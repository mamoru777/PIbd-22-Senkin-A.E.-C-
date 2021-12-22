using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    public class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }


        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            // Прописать логику для добавления
            if (parkingStages.ContainsKey(name)) return;
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }
        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            // Прописать логику для удаления

            if (parkingStages.ContainsKey(name)) parkingStages.Remove(name);
            else return;
        }
        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public Parking<Vehicle> this[string ind]
        {
            // Продумать логику для индексатора
            get
            {
                if (parkingStages.ContainsKey(ind)) return parkingStages[ind];
                else return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter file = new StreamWriter(filename, false, Encoding.Default))
            {
                file.WriteLine("ParkingCollection");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    file.WriteLine("Parking" + separator + level.Key);
                    ITransport mashina = null;
                    for (int i = 0; (mashina = level.Value.GetNext(i)) != null; i++)
                    {
                        if (mashina != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (mashina.GetType().Name == "Gusmashina")

                            {
                                file.Write("Gusmashina" + separator);
                            }

                            if (mashina.GetType().Name == "Kran")

                            {
                                file.Write("Kran" + separator);
                            }

                            //Записываемые параметры
                            file.WriteLine(mashina);
                        }
                    }
                }
            }
            return true;
        }
        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader file = new StreamReader(filename, Encoding.Default))
            {


                if (file.ReadLine().Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FormatException("Неверный формат файла");
                }
                Vehicle mashina = null;
                string key = string.Empty;
                string line ;
                for (int i = 1; (line = file.ReadLine()) != null; i++)
                {
                    //идем по считанным записям
                    if (line.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Contains(separator))
                    {
                        if (line.Contains("Gusmashina"))
                    {
                            mashina = new Gusmashina(line.Split(separator)[1]);
                        }
                        else if (line.Contains("Kran"))
                        {
                            mashina = new Kran(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + mashina;
                        if (!result)
                        {
                            throw new OverflowException("Не удалось загрузить автомобиль на парковку");
                        }
                    }
                   
                }
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    public class Gusmashina : Vehicle, IEquatable<Gusmashina>
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        protected readonly int kranWidth = 60;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        protected readonly int kranHeight = 80;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// /// <summary>
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char separator = ';';
        public Gusmashina(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Gusmashina(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }
        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected Gusmashina(int maxSpeed, float weight, Color mainColor, int carWidth, int
        carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.kranWidth = carWidth;
            this.kranHeight = carHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {

                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - kranWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    // Продумать логику
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    // Продумать логику
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - kranHeight)
                    {
                        _startPosY += step;
                    }
                    break;

            }
        }
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            Brush br;
            br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX + 60, _startPosY + 40, 30, 30);
            g.FillRectangle(br, _startPosX + 10, _startPosY + 70, 80, 30);


            br = new SolidBrush(MainColor);
            g.DrawEllipse(pen, _startPosX, _startPosY + 100, 110, 25);
            g.FillEllipse(br, _startPosX + 7, _startPosY + 105, 15, 15);
            g.FillEllipse(br, _startPosX + 25, _startPosY + 108, 15, 15);
            g.FillEllipse(br, _startPosX + 45, _startPosY + 110, 15, 15);
            g.FillEllipse(br, _startPosX + 65, _startPosY + 108, 15, 15);
            g.FillEllipse(br, _startPosX + 83, _startPosY + 106, 15, 15);
            g.FillEllipse(br, _startPosX + 39, _startPosY + 102, 8, 8);
            g.FillEllipse(br, _startPosX + 57, _startPosY + 102, 8, 8);
        }
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса Car
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Gusmashina other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Gusmashina carObj))
            {
                return false;       
            }
            else
            {
                return Equals(carObj);
            }
        }
    }
}

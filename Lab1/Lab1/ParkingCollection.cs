﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        
    }
}

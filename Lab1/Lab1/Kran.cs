﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    public class Kran : Gusmashina, IEquatable<Kran>
    {

        public Color DopColor { private set; get; }
        public Color DopColor2 { private set; get; }
        public bool Krann { private set; get; } // Кран (дополнительная картинка)
        public bool Gusenica { private set; get; } // Гусеница
        public bool Korpus { private set; get; } // Корпус крана
        public bool Okna { private set; get; } // Окна в корпусе (дополнительная картинка)


        public Kran(int maxSpeed, float weight, Color mainColor, Color dopColor, Color dopColor2, bool krann, bool okna):
            base(maxSpeed, weight, mainColor, 100, 120)
        {
            DopColor = dopColor;
            DopColor2 = dopColor2;
            Krann = krann;
            Okna = okna;
        }

        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public Kran(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                DopColor2 = Color.FromName(strs[4]);
                Krann = Convert.ToBoolean(strs[5]);
                Okna = Convert.ToBoolean(strs[6]);
            }
        }

        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br;
            br = new SolidBrush(MainColor);
            base.DrawTransport(g);

            if (Krann)
            {
                br = new SolidBrush(DopColor);
                g.FillRectangle(br, _startPosX + 30, _startPosY, 10, 70);
                g.FillRectangle(br, _startPosX - 5, _startPosY - 10, 50, 10);
                g.FillRectangle(br, _startPosX + 3, _startPosY, 1, 30);
                g.FillRectangle(br, _startPosX - 5, _startPosY + 30, 20, 5);
                g.FillRectangle(br, _startPosX + 10, _startPosY + 35, 5, 20);
                g.FillRectangle(br, _startPosX - 5, _startPosY + 50, 20, 5);
            }

            if (Okna)
            {
                br = new SolidBrush(DopColor2);
                g.FillEllipse(br, _startPosX + 65, _startPosY + 45, 20, 20);
                g.FillEllipse(br, _startPosX + 15, _startPosY + 75, 20, 20);
                g.FillEllipse(br, _startPosX + 40, _startPosY + 75, 20, 20);
                g.FillEllipse(br, _startPosX + 65, _startPosY + 75, 20, 20);
            }
        }
        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        
        public void SetDopColor2(Color color)
        {
            DopColor2 = color;
        }
        public override string ToString()
        {
            return
            $"{base.ToString()}{separator}{DopColor.Name}{separator}{DopColor2.Name}{separator}{Krann}{separator}{Okna}{ separator}";
        }
        /// <summary>
        /// Метод интерфейса IEquatable для класса SportCar
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Kran other)
        {
            // Реализовать метод сравнения для дочернего класса
            if (!Equals((Gusmashina)other))
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (DopColor2 != other.DopColor2)
            {
                return false;
            }
            if (Krann != other.Krann)
            {
                return false;
            }
            if (Okna != other.Okna)
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
            if (!(obj is Kran carObj))
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

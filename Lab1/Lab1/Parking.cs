using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    public class Parking<T> where T : class, ITransport   
    {
        /// <summary>
        /// Массив объектов, которые храним
        /// </summary>
        private readonly T[] _places;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;
        /// <summary>
        /// Размер парковочного места (ширина)
        /// </summary>l97 
        private readonly int _placeSizeWidth = 130;
        /// <summary>
        /// Размер парковочного места (высота)
        /// </summary>
        private readonly int _placeSizeHeight = 180;

        private readonly int w;

        private readonly int h;

/// <summary>
/// Конструктор
/// </summary>
/// <param name="picWidth">Рамзер парковки - ширина</param>
/// <param name="picHeight">Рамзер парковки - высота</param>
    public Parking(int picWidth, int picHeight)
        {
            int width = picWidth / _placeSizeWidth;
            int height = picHeight / _placeSizeHeight;
            w = width;
            h = height;
            _places = new T[width * height];
            pictureWidth = picWidth;
            pictureHeight = picHeight;
        }
        /// <summary>
        /// Перегрузка оператора сложения
        /// Логика действия: на парковку добавляется автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="car">Добавляемый автомобиль</param>
        /// <returns></returns>
        public static int operator + (Parking<T> p, T kran)
        {
            // Прописать логику для сложения
            for (int i = 0; i < p._places.Length; i++)
            {
                if (p._places[i] == null)
                {
                    p._places[i] = kran;
                    return i;
                }
            }
            return -1;      
            
        }
        /// <summary>
        /// Перегрузка оператора вычитания
        /// Логика действия: с парковки забираем автомобиль
        /// </summary>
        /// <param name="p">Парковка</param>
        /// <param name="index">Индекс места, с которого пытаемся извлечь объект</param>
            /// <returns></returns>
        public static T operator -(Parking<T> p, int index)
        {
            if (index >= 0 && index < p._places.Length)
            {
                var kran = p._places[index];
                p._places[index] = null;
                return kran;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            int flagw = 0;
            int flagh = 0;
            int widthpos;
            int heightpos;
            DrawMarking(g);
            for (int i = 0; i < _places.Length; i++)
            {

                if (flagw < w)
                {
                    widthpos = flagw * _placeSizeWidth;
                    heightpos = flagh * _placeSizeHeight;
                    flagw++;
                }
                else 
                {
                    flagw = 0;
                    flagh++;
                    widthpos = flagw * _placeSizeWidth;
                    heightpos = flagh * _placeSizeHeight;
                    flagw++;
                }   

                _places[i]?.SetPosition(15 + widthpos, 50 + heightpos, pictureWidth, pictureHeight);
                _places[i]?.DrawTransport(g);
            }
        }
        /// <summary>
        /// Метод отрисовки разметки парковочных мест
        /// </summary>
        /// <param name="g"></param>
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
        
            {
                for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
                {//линия рамзетки места
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i *
                    _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth,
                (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
            }
        }
    }
}

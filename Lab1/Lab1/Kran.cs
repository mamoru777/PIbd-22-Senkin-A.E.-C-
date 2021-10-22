using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    class Kran
    {
        private float _startPosX;
        private float _startPosY;
        private int _pictureWidth;
        private int _pictureHeight;

        private readonly int kranWidth = 100;
        private readonly int kranHeight = 120;

        public int MaxSpeed { private set; get; }
        public float Weight { private set; get; }
        public Color MainColor { private set; get; }
        public Color DopColor { private set; get; }
        public Color DopColor2 { private set; get; }
        public bool Krann { private set; get; } // Кран (дополнительная картинка)
        public bool Gusenica { private set; get; } // Гусеница
        public bool Korpus { private set; get; } // Корпус крана
        public bool Okna { private set; get; } // Окна в корпусе (дополнительная картинка)


        public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor, Color dopColor2, bool krann, bool okna)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            DopColor2 = dopColor2;
            Krann = krann;
            Okna = okna;
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureHeight = height;
            _pictureWidth = width;
        }

        public void MoveTransport(Direction direction)
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
                    // Продумать логику
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    // Продумать логику
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
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

        public void DrawKran(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush br;
            br = new SolidBrush(MainColor);
            g.FillRectangle(br, _startPosX + 60, _startPosY + 40, 30, 30);
            g.FillRectangle(br, _startPosX + 10, _startPosY + 70, 80, 30);


            br = new SolidBrush(Color.Black);
            g.DrawEllipse(pen, _startPosX, _startPosY + 100, 110, 25);
            g.FillEllipse(br, _startPosX + 7, _startPosY + 105, 15, 15);
            g.FillEllipse(br, _startPosX + 25, _startPosY + 108, 15, 15);
            g.FillEllipse(br, _startPosX + 45, _startPosY + 110, 15, 15);
            g.FillEllipse(br, _startPosX + 65, _startPosY + 108, 15, 15);
            g.FillEllipse(br, _startPosX + 83, _startPosY + 106, 15, 15);
            g.FillEllipse(br, _startPosX + 39, _startPosY + 102, 8, 8);
            g.FillEllipse(br, _startPosX + 57, _startPosY + 102, 8, 8);

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
    }
}

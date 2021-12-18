using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Formkran : Form
    {
        private ITransport kran;
        public Formkran()
        {
            InitializeComponent();
        }

        public void SetKran(ITransport kran)
        {
            this.kran = kran;
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxkran.Width, pictureBoxkran.Height);
            Graphics gr = Graphics.FromImage(bmp);
            kran.DrawTransport(gr);
            pictureBoxkran.Image = bmp;
        }

        private void buttonCreateGusmashina_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            kran = new Gusmashina(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black);
            kran.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxkran.Width,
            pictureBoxkran.Height);
            //Color.Brown, Color.Cyan, true, true); kran.SetPosition(rnd.Next(10, 100),
            //rnd.Next(10, 100), pictureBoxkran.Width, pictureBoxkran.Height);
            Draw();
        }
        private void buttonCreateKran_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            kran = new Kran(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Black, Color.Brown, Color.Cyan, true, true);
            kran.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxkran.Width,
            pictureBoxkran.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    kran.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    kran.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    kran.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    kran.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

    }
}

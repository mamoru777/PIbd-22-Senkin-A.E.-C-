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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly Parking<Gusmashina> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Gusmashina>(pictureBoxParking.Width,
            pictureBoxParking.Height);
            Draw();
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetGusmashina_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var gusmashina = new Gusmashina(100, 1000, dialog.Color);
            if (parking + gusmashina >= 0)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
            
        }
        /// <summary>
        /// Обработка нажатия кнопки "Припарковать гоночный автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetKran_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    ColorDialog dialogDop2 = new ColorDialog();
                    if (dialogDop2.ShowDialog() == DialogResult.OK)
                    {
                        var kran = new Kran(100, 1000, dialog.Color, dialogDop.Color, dialogDop2.Color,
true, true);
                        if (parking + kran >= 0)
                        {
                            Draw();
                        }
                        else
                        {

                            MessageBox.Show("Парковка переполнена");
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeKran_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var kran = parking - Convert.ToInt32(maskedTextBox1.Text);
                if (kran != null)
                {
                    Formkran form = new Formkran();
                    form.SetKran(kran);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }
}

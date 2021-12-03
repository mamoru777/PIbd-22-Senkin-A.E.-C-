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
    public partial class FormKranConfig : Form
    {
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        Vehicle Transport = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event Action<Vehicle> eventAddKran;
        public FormKranConfig()
        {
            InitializeComponent();
            //привязать panelColor_MouseDown к панелям с цветами
            panelWhite.MouseDown += panelColor_MouseDown;
            panelAqua.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelBrown.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawTransport()
        {
            if (Transport != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxKran.Width, pictureBoxKran.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Transport.SetPosition(5, 5, pictureBoxKran.Width, pictureBoxKran.Height);
                Transport.DrawTransport(gr);
                pictureBoxKran.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddKran == null)
            {
                eventAddKran = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddKran += ev;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelGusmashina_MouseDown(object sender, MouseEventArgs e)
        {
            labelGusmashina.DoDragDrop(labelGusmashina.Name, DragDropEffects.Move |
            DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelKran_MouseDown(object sender, MouseEventArgs e)
        {
            labelKran.DoDragDrop(labelKran.Name, DragDropEffects.Move |
            DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTransport_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /*/// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTransport_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный автомобиль":
                    Transport = new Gusmashina(100, 500, Color.Black);
                    break;
                case "Гоночный автомобиль":
                    Transport = new Kran(100, 500, Color.Black, Color.Black, Color.Blue, true,
                    true);
                    break;
            }
            DrawTransoprt();
        }*/
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTransport_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "labelGusmashina":
                    Transport = new Gusmashina((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Black);
                    break;
                case "labelKran":
                    Transport = new Kran((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, Color.Aqua, checkBoxKran.Checked, checkBoxSideOkna.Checked);
                    break;
            }
            DrawTransport();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            // Прописать логику вызова dragDrop для панелей, используя sender
            //DoDragDrop(Control.DefaultBackColor, DragDropEffects.Move | DragDropEffects.Copy);
            if (Transport != null)
            {
                (sender as Panel).DoDragDrop((sender as Panel).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
            }
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {

            // Прописать логику проверки приходящего значения на тип Color
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены базового цвета
            Transport.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawTransport();
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены дополнительного цвета, если объект является объектом дочернего класса
            if (Transport is Kran)
            {
                (Transport as Kran).SetDopColor((Color)e.Data.GetData(typeof(Color)));
            }
            DrawTransport();
        }

        private void labelDopColor2_DragDrop(object sender, DragEventArgs e)
        {
            // Прописать логику смены дополнительного цвета, если объект является объектом дочернего класса
            if (Transport is Kran)
            {
                (Transport as Kran).SetDopColor2((Color)e.Data.GetData(typeof(Color)));
            }
            DrawTransport();
        }

        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddKran?.Invoke(Transport);
            Close();
        }

    }
}

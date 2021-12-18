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
        private readonly ParkingCollection parkingCollection;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
        }
        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >=
            listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index <
            listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }
        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            if (listBoxParkings.SelectedIndex > -1)
            {
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
            }
            pictureBoxParking.Image = bmp;

        }
        /// Обработка нажатия кнопки "Добавить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Удалить парковку"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelParking_Click(object sender, EventArgs e)
                {
                    if (listBoxParkings.SelectedIndex > -1)
                    {
                        if (MessageBox.Show($"Удалить парковку  { listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());

                            ReloadLevels();
                        }
                        Draw();
                    }
                }
        
        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeKran_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBox1.Text != "")
            {
                var kran = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox1.Text);
                if (kran != null)
                {
                    Formkran form = new Formkran();
                    form.SetKran(kran);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        /// <summary>
        /// Метод обработки выбора элемента на listBoxLevels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {   
            Draw();
        }

        /// <summary>
        /// Обработка нажатия кнопки "Добавить автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetKran_Click(object sender, EventArgs e)
        {
            var formKranConfig = new FormKranConfig();
            formKranConfig.AddEvent(AddKran);
            formKranConfig.Show();
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="car"></param>
        private void AddKran(Vehicle kran)
        {
            if (kran != null && listBoxParkings.SelectedIndex > -1)
            {
                if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + kran)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }

    }
}

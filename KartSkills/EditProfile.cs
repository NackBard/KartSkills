using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class EditProfile : Form
    {
        string img = "";
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public EditProfile()
        {
            InitializeComponent();
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            TimerLabel.Text = $"До начала события осталось {different.Days} дней, {different.Hours} часов, {different.Minutes} минут и {different.Seconds} секунд.";
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файлы JPG (*.jpg)|*.jpg|Файлы PNG (*.png)|*.png|Все файлы (*.*)|*.*";
            dialog.Title = "Выбрать фотографию";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                img = dialog.FileName.ToString();
                pictureBoxPhoto.ImageLocation = img;
                textBoxPhoto.Text = dialog.FileName;
            }
        }

        private void buttoLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MenuRacers menu = new MenuRacers();
            menu.Show();
            Close();
        }

        private void buttonSaveProfile_Click(object sender, EventArgs e)
        {
            MenuRacers menu = new MenuRacers();
            menu.Show();
            Close();
        }
    }
}

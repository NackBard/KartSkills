using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class MainMenu : Form
    {
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public MainMenu()
        {
            InitializeComponent();
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            TimerLabel.Text = $"До начала события осталось {different.Days} дней, {different.Hours} часов, {different.Minutes} минут и {different.Seconds} секунд.";
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            buttonLogin login = new buttonLogin();
            login.Show();
        }

        private void pictureBoxInfo_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }

        private void pictureBoxMoney_Click(object sender, EventArgs e)
        {
            SponsorRacer spon = new SponsorRacer();
            spon.Show();
        }

        private void pictureBoxRacer_Click(object sender, EventArgs e)
        {
            NewRacer racer = new NewRacer();
            racer.Show();
        }
    }
}

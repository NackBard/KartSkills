using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class MenuRacers : Form
    {
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public MenuRacers()
        {
            InitializeComponent();
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            TimerLabel.Text = $"До начала события осталось {different.Days} дней, {different.Hours} часов, {different.Minutes} минут и {different.Seconds} секунд.";
        }

        private void buttoLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegRacer_Click(object sender, EventArgs e)
        {
            RegRace race = new RegRace();
            race.Show();
            Close();
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile edit = new EditProfile();
            edit.Show();
            Close();
        }

        private void buttonContacts_Click(object sender, EventArgs e)
        {
            panelContacts.Visible = true;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            panelContacts.Visible = false;
        }

        private void buttonMyResults_Click(object sender, EventArgs e)
        {
            MyResults result = new MyResults();
            result.Show();
            Close();
        }

        private void buttonMySponsor_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class Information : Form
    {
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public Information()
        {
            InitializeComponent();
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            TimerLabel.Text = $"До начала события осталось {different.Days} дней, {different.Hours} часов, {different.Minutes} минут и {different.Seconds} секунд.";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoKartSkills info = new InfoKartSkills();
            info.Show();
            Close();
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            MyResults result = new MyResults();
            result.Show();
            Close();
        }

        private void buttonOrganizations_Click(object sender, EventArgs e)
        {
            ListOrganizations list = new ListOrganizations();
            list.Show();
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class Invs : Form
    {
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public Invs()
        {
            InitializeComponent();
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            TimerLabel.Text = $"До начала события осталось {different.Days} дней, {different.Hours} часов, {different.Minutes} минут и {different.Seconds} секунд.";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Invs_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdmissions_Click(object sender, EventArgs e)
        {
            AdmissionInv inv = new AdmissionInv();
            inv.Show();
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuAdmin menu = new MenuAdmin();
            menu.Show();
            Close();
        }
    }
}

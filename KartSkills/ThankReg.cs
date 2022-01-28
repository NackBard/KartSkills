﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class ThankReg : Form
    {
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public ThankReg()
        {
            InitializeComponent();
        }

        private void TimerStart_Tick(object sender, EventArgs e)
        {
            TimeSpan different = DateOfStart.Subtract(DateTime.Now);
            TimerLabel.Text = $"До начала события осталось {different.Days} дней, {different.Hours} часов, {different.Minutes} минут и {different.Seconds} секунд.";
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttoLogOut_Click(object sender, EventArgs e)
        {
            MenuRacers menu = new MenuRacers();
            menu.Show();
            Close();
        }
    }
}

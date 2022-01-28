using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class SponsorRacer : Form
    {
        DateTime DateOfStart = new DateTime(2022, 11, 24, 6, 0, 0);
        public SponsorRacer()
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || comboBoxRacer.SelectedValue == null || textBoxCard.Text == "" || maskedTextBoxNumberCard.MaskCompleted == false || maskedTextBoxDay.MaskCompleted == false || maskedTextBoxYear.MaskCompleted == false || maskedTextBoxCVC.MaskCompleted == false)
            {
                MessageBox.Show("Не верно заполнены поля");
            }
            else
            {
                int month = Int32.Parse(maskedTextBoxDay.Text);
                int year = Int32.Parse(maskedTextBoxYear.Text);
                if (month <= 12 && month > 0 && year > 2020)
                {
                    SponsorComplete sponsor = new SponsorComplete();
                    sponsor.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Не верно заполнены поля");
                }
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            float pay = Int32.Parse(textBoxCost.Text);
            textBoxCost.Text = (pay + 10f).ToString();
            labelMoney.Text = $"${textBoxCost.Text}";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            float pay = Single.Parse(textBoxCost.Text);
            if (pay > 0)
            {
                if ((pay - 10f) < 0)
                {
                    textBoxCost.Text = "0";
                }
                else
                {
                    textBoxCost.Text = (pay - 10f).ToString();
                }
            }
            labelMoney.Text = $"${textBoxCost.Text}";
        }

        private void textBoxCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCost.Text == "")
                {
                    textBoxCost.Text = "0";
                }
                else
                {
                    long pay = long.Parse(textBoxCost.Text);
                    if (pay < 0)
                    {
                        textBoxCost.Text = "0";
                    }
                    else
                    {
                        labelMoney.Text = $"${textBoxCost.Text}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

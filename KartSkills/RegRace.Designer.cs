
namespace KartSkills
{
    partial class RegRace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.dataGridTimer = new System.Windows.Forms.DataGridView();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelKartName = new System.Windows.Forms.Label();
            this.dataKartName = new System.Windows.Forms.DataGridView();
            this.buttoLogOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox25km = new System.Windows.Forms.CheckBox();
            this.checkBox4km = new System.Windows.Forms.CheckBox();
            this.checkBox65km = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonVariantA = new System.Windows.Forms.RadioButton();
            this.radioButtonVariantB = new System.Windows.Forms.RadioButton();
            this.radioButtonVariantC = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(124, 388);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(160, 29);
            this.textBoxDateOfBirth.TabIndex = 115;
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(124, 423);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(160, 30);
            this.comboBoxCountry.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(63, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 22);
            this.label8.TabIndex = 109;
            this.label8.Text = "Детали спонсорства";
            // 
            // TimerStart
            // 
            this.TimerStart.Enabled = true;
            this.TimerStart.Interval = 1000;
            this.TimerStart.Tick += new System.EventHandler(this.TimerStart_Tick);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Location = new System.Drawing.Point(195, 473);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 39);
            this.buttonCancel.TabIndex = 101;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReg.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonReg.Location = new System.Drawing.Point(36, 473);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(153, 39);
            this.buttonReg.TabIndex = 100;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(113, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 96;
            this.label6.Text = "Вид гонки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(315, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 94;
            this.label1.Text = "Регистрация на гонку";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBack.Location = new System.Drawing.Point(44, 42);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 45);
            this.buttonBack.TabIndex = 93;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimerLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.Location = new System.Drawing.Point(143, 530);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(61, 22);
            this.TimerLabel.TabIndex = 92;
            this.TimerLabel.Text = "label3";
            // 
            // dataGridTimer
            // 
            this.dataGridTimer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridTimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTimer.Location = new System.Drawing.Point(-3, 520);
            this.dataGridTimer.Name = "dataGridTimer";
            this.dataGridTimer.RowTemplate.Height = 25;
            this.dataGridTimer.Size = new System.Drawing.Size(891, 43);
            this.dataGridTimer.TabIndex = 91;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelCity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(285, 84);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(321, 24);
            this.labelCity.TabIndex = 90;
            this.labelCity.Text = "Москва, Россия 20 июня 2017";
            // 
            // labelKartName
            // 
            this.labelKartName.AutoSize = true;
            this.labelKartName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelKartName.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelKartName.Location = new System.Drawing.Point(301, 25);
            this.labelKartName.Name = "labelKartName";
            this.labelKartName.Size = new System.Drawing.Size(294, 44);
            this.labelKartName.TabIndex = 89;
            this.labelKartName.Text = "Kart Skills 2017";
            // 
            // dataKartName
            // 
            this.dataKartName.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataKartName.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataKartName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKartName.Location = new System.Drawing.Point(-3, -3);
            this.dataKartName.Name = "dataKartName";
            this.dataKartName.RowTemplate.Height = 25;
            this.dataKartName.Size = new System.Drawing.Size(891, 130);
            this.dataKartName.TabIndex = 88;
            // 
            // buttoLogOut
            // 
            this.buttoLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.buttoLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttoLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttoLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoLogOut.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttoLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttoLogOut.Location = new System.Drawing.Point(719, 42);
            this.buttoLogOut.Name = "buttoLogOut";
            this.buttoLogOut.Size = new System.Drawing.Size(122, 45);
            this.buttoLogOut.TabIndex = 117;
            this.buttoLogOut.Text = "Logout";
            this.buttoLogOut.UseVisualStyleBackColor = false;
            this.buttoLogOut.Click += new System.EventHandler(this.buttoLogOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(571, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 22);
            this.label2.TabIndex = 118;
            this.label2.Text = "Варианты комплектов";
            // 
            // checkBox25km
            // 
            this.checkBox25km.AutoSize = true;
            this.checkBox25km.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox25km.Location = new System.Drawing.Point(72, 246);
            this.checkBox25km.Name = "checkBox25km";
            this.checkBox25km.Size = new System.Drawing.Size(184, 26);
            this.checkBox25km.TabIndex = 119;
            this.checkBox25km.Text = "Заезд 2,5 км($25)";
            this.checkBox25km.UseVisualStyleBackColor = true;
            // 
            // checkBox4km
            // 
            this.checkBox4km.AutoSize = true;
            this.checkBox4km.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox4km.Location = new System.Drawing.Point(72, 278);
            this.checkBox4km.Name = "checkBox4km";
            this.checkBox4km.Size = new System.Drawing.Size(168, 26);
            this.checkBox4km.TabIndex = 120;
            this.checkBox4km.Text = "Заезд 4 км($40)";
            this.checkBox4km.UseVisualStyleBackColor = true;
            // 
            // checkBox65km
            // 
            this.checkBox65km.AutoSize = true;
            this.checkBox65km.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox65km.Location = new System.Drawing.Point(72, 310);
            this.checkBox65km.Name = "checkBox65km";
            this.checkBox65km.Size = new System.Drawing.Size(184, 26);
            this.checkBox65km.TabIndex = 121;
            this.checkBox65km.Text = "Заезд 6,5 км($65)";
            this.checkBox65km.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 122;
            this.label3.Text = "Взнос:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 123;
            this.label4.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(657, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 56);
            this.label5.TabIndex = 124;
            this.label5.Text = "120";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(600, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 56);
            this.label7.TabIndex = 125;
            this.label7.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(559, 392);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 22);
            this.label9.TabIndex = 126;
            this.label9.Text = "Регистрационный взнос";
            // 
            // radioButtonVariantA
            // 
            this.radioButtonVariantA.AutoSize = true;
            this.radioButtonVariantA.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonVariantA.Location = new System.Drawing.Point(531, 232);
            this.radioButtonVariantA.Name = "radioButtonVariantA";
            this.radioButtonVariantA.Size = new System.Drawing.Size(299, 48);
            this.radioButtonVariantA.TabIndex = 127;
            this.radioButtonVariantA.TabStop = true;
            this.radioButtonVariantA.Text = "Вариант A ($0) Номер пилота +\r\nбраслет\r\n";
            this.radioButtonVariantA.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariantB
            // 
            this.radioButtonVariantB.AutoSize = true;
            this.radioButtonVariantB.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonVariantB.Location = new System.Drawing.Point(531, 282);
            this.radioButtonVariantB.Name = "radioButtonVariantB";
            this.radioButtonVariantB.Size = new System.Drawing.Size(315, 48);
            this.radioButtonVariantB.TabIndex = 128;
            this.radioButtonVariantB.TabStop = true;
            this.radioButtonVariantB.Text = "Вариант A ($30) Номер пилота + \r\nШлем + Браслет";
            this.radioButtonVariantB.UseVisualStyleBackColor = true;
            // 
            // radioButtonVariantC
            // 
            this.radioButtonVariantC.AutoSize = true;
            this.radioButtonVariantC.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonVariantC.Location = new System.Drawing.Point(531, 336);
            this.radioButtonVariantC.Name = "radioButtonVariantC";
            this.radioButtonVariantC.Size = new System.Drawing.Size(310, 48);
            this.radioButtonVariantC.TabIndex = 129;
            this.radioButtonVariantC.TabStop = true;
            this.radioButtonVariantC.Text = "Вариант A ($50) Номер пилота +\r\nЭкипировка + Браслет";
            this.radioButtonVariantC.UseVisualStyleBackColor = true;
            // 
            // RegRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.radioButtonVariantC);
            this.Controls.Add(this.radioButtonVariantB);
            this.Controls.Add(this.radioButtonVariantA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox65km);
            this.Controls.Add(this.checkBox4km);
            this.Controls.Add(this.checkBox25km);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttoLogOut);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.dataGridTimer);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelKartName);
            this.Controls.Add(this.dataKartName);
            this.Name = "RegRace";
            this.Text = "RegRace";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer TimerStart;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.DataGridView dataGridTimer;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelKartName;
        private System.Windows.Forms.DataGridView dataKartName;
        private System.Windows.Forms.Button buttoLogOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox25km;
        private System.Windows.Forms.CheckBox checkBox4km;
        private System.Windows.Forms.CheckBox checkBox65km;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonVariantA;
        private System.Windows.Forms.RadioButton radioButtonVariantB;
        private System.Windows.Forms.RadioButton radioButtonVariantC;
    }
}
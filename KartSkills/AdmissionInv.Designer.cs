
namespace KartSkills
{
    partial class AdmissionInv
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.dataGridTimer = new System.Windows.Forms.DataGridView();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelKartName = new System.Windows.Forms.Label();
            this.dataKartName = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(431, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 38);
            this.label9.TabIndex = 144;
            this.label9.Text = "Поступление";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(242, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 38);
            this.label8.TabIndex = 143;
            this.label8.Text = "Наименование";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TimerStart
            // 
            this.TimerStart.Enabled = true;
            this.TimerStart.Interval = 1000;
            this.TimerStart.Tick += new System.EventHandler(this.TimerStart_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(295, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 29);
            this.label1.TabIndex = 133;
            this.label1.Text = "Поступление инвентаря";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave.Location = new System.Drawing.Point(286, 423);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(147, 38);
            this.buttonSave.TabIndex = 135;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimerLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.Location = new System.Drawing.Point(143, 530);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(61, 22);
            this.TimerLabel.TabIndex = 132;
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
            this.dataGridTimer.TabIndex = 131;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelCity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(285, 84);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(321, 24);
            this.labelCity.TabIndex = 130;
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
            this.labelKartName.TabIndex = 129;
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
            this.dataKartName.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(431, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 38);
            this.label2.TabIndex = 186;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(242, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 38);
            this.label3.TabIndex = 185;
            this.label3.Text = "Номер гонщика";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(431, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 38);
            this.label4.TabIndex = 188;
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(242, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 38);
            this.label5.TabIndex = 187;
            this.label5.Text = "Браслет";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(431, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 38);
            this.label6.TabIndex = 190;
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(242, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 38);
            this.label7.TabIndex = 189;
            this.label7.Text = "Шлем";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(431, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 38);
            this.label10.TabIndex = 192;
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(242, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 38);
            this.label11.TabIndex = 191;
            this.label11.Text = "Экипировка";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Location = new System.Drawing.Point(454, 423);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 38);
            this.buttonCancel.TabIndex = 193;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // AdmissionInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.dataGridTimer);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelKartName);
            this.Controls.Add(this.dataKartName);
            this.Name = "AdmissionInv";
            this.Text = "AdmissionInv";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer TimerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.DataGridView dataGridTimer;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelKartName;
        private System.Windows.Forms.DataGridView dataKartName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonCancel;
    }
}

namespace KartSkills
{
    partial class SponsorComplete
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.dataGridTimer = new System.Windows.Forms.DataGridView();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelKartName = new System.Windows.Forms.Label();
            this.dataKartName = new System.Windows.Forms.DataGridView();
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.labelFund = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelRacer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBack.Location = new System.Drawing.Point(376, 442);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(122, 45);
            this.buttonBack.TabIndex = 25;
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
            this.TimerLabel.TabIndex = 24;
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
            this.dataGridTimer.TabIndex = 23;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelCity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(285, 84);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(321, 24);
            this.labelCity.TabIndex = 22;
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
            this.labelKartName.TabIndex = 21;
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
            this.dataKartName.TabIndex = 20;
            // 
            // TimerStart
            // 
            this.TimerStart.Enabled = true;
            this.TimerStart.Interval = 1000;
            this.TimerStart.Tick += new System.EventHandler(this.TimerStart_Tick);
            // 
            // labelFund
            // 
            this.labelFund.AutoSize = true;
            this.labelFund.BackColor = System.Drawing.SystemColors.Control;
            this.labelFund.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFund.Location = new System.Drawing.Point(362, 287);
            this.labelFund.Name = "labelFund";
            this.labelFund.Size = new System.Drawing.Size(158, 29);
            this.labelFund.TabIndex = 34;
            this.labelFund.Text = "Фонд Собак";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BackColor = System.Drawing.SystemColors.Control;
            this.labelCost.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCost.Location = new System.Drawing.Point(371, 342);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(140, 75);
            this.labelCost.TabIndex = 33;
            this.labelCost.Text = "$50";
            // 
            // labelRacer
            // 
            this.labelRacer.AutoSize = true;
            this.labelRacer.BackColor = System.Drawing.SystemColors.Control;
            this.labelRacer.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRacer.Location = new System.Drawing.Point(254, 216);
            this.labelRacer.Name = "labelRacer";
            this.labelRacer.Size = new System.Drawing.Size(389, 32);
            this.labelRacer.TabIndex = 36;
            this.labelRacer.Text = "Иван Прудов(204) из Russia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(222, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Спасибо за спонсорскую поддержку!";
            // 
            // SponsorComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRacer);
            this.Controls.Add(this.labelFund);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.dataGridTimer);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelKartName);
            this.Controls.Add(this.dataKartName);
            this.Name = "SponsorComplete";
            this.Text = "SponsorComplete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.DataGridView dataGridTimer;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelKartName;
        private System.Windows.Forms.DataGridView dataKartName;
        private System.Windows.Forms.Timer TimerStart;
        private System.Windows.Forms.Label labelFund;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelRacer;
        private System.Windows.Forms.Label label2;
    }
}
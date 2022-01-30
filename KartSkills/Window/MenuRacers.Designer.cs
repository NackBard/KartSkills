
namespace KartSkills
{
    partial class MenuRacers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuRacers));
            this.dataGridTimer = new System.Windows.Forms.DataGridView();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelKartName = new System.Windows.Forms.Label();
            this.dataKartName = new System.Windows.Forms.DataGridView();
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegRacer = new System.Windows.Forms.Button();
            this.buttonMySponsor = new System.Windows.Forms.Button();
            this.buttonMyResults = new System.Windows.Forms.Button();
            this.buttonContacts = new System.Windows.Forms.Button();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.buttoLogOut = new System.Windows.Forms.Button();
            this.panelContacts = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNumverPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).BeginInit();
            this.panelContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(350, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Меню гонщика";
            // 
            // buttonRegRacer
            // 
            this.buttonRegRacer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRegRacer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonRegRacer.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRegRacer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegRacer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRegRacer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegRacer.Location = new System.Drawing.Point(79, 190);
            this.buttonRegRacer.Name = "buttonRegRacer";
            this.buttonRegRacer.Size = new System.Drawing.Size(286, 92);
            this.buttonRegRacer.TabIndex = 28;
            this.buttonRegRacer.Text = "Регистрация на гонку";
            this.buttonRegRacer.UseVisualStyleBackColor = false;
            this.buttonRegRacer.Click += new System.EventHandler(this.buttonRegRacer_Click);
            // 
            // buttonMySponsor
            // 
            this.buttonMySponsor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonMySponsor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMySponsor.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMySponsor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMySponsor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMySponsor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMySponsor.Location = new System.Drawing.Point(534, 288);
            this.buttonMySponsor.Name = "buttonMySponsor";
            this.buttonMySponsor.Size = new System.Drawing.Size(286, 92);
            this.buttonMySponsor.TabIndex = 29;
            this.buttonMySponsor.Text = "Мой спонсор";
            this.buttonMySponsor.UseVisualStyleBackColor = false;
            this.buttonMySponsor.Click += new System.EventHandler(this.buttonMySponsor_Click);
            // 
            // buttonMyResults
            // 
            this.buttonMyResults.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonMyResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMyResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonMyResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMyResults.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMyResults.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMyResults.Location = new System.Drawing.Point(534, 190);
            this.buttonMyResults.Name = "buttonMyResults";
            this.buttonMyResults.Size = new System.Drawing.Size(286, 92);
            this.buttonMyResults.TabIndex = 30;
            this.buttonMyResults.Text = "Мои результаты";
            this.buttonMyResults.UseVisualStyleBackColor = false;
            this.buttonMyResults.Click += new System.EventHandler(this.buttonMyResults_Click);
            // 
            // buttonContacts
            // 
            this.buttonContacts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonContacts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonContacts.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContacts.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonContacts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonContacts.Location = new System.Drawing.Point(79, 386);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new System.Drawing.Size(286, 92);
            this.buttonContacts.TabIndex = 31;
            this.buttonContacts.Text = "Контакты";
            this.buttonContacts.UseVisualStyleBackColor = false;
            this.buttonContacts.Click += new System.EventHandler(this.buttonContacts_Click);
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonEditProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEditProfile.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProfile.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEditProfile.Location = new System.Drawing.Point(79, 288);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(286, 92);
            this.buttonEditProfile.TabIndex = 32;
            this.buttonEditProfile.Text = "Редактирование профиля";
            this.buttonEditProfile.UseVisualStyleBackColor = false;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // buttoLogOut
            // 
            this.buttoLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.buttoLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttoLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttoLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoLogOut.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttoLogOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttoLogOut.Location = new System.Drawing.Point(721, 42);
            this.buttoLogOut.Name = "buttoLogOut";
            this.buttoLogOut.Size = new System.Drawing.Size(122, 45);
            this.buttoLogOut.TabIndex = 46;
            this.buttoLogOut.Text = "Logout";
            this.buttoLogOut.UseVisualStyleBackColor = false;
            this.buttoLogOut.Click += new System.EventHandler(this.buttoLogOut_Click);
            // 
            // panelContacts
            // 
            this.panelContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContacts.Controls.Add(this.pictureBoxClose);
            this.panelContacts.Controls.Add(this.labelEmail);
            this.panelContacts.Controls.Add(this.labelNumverPhone);
            this.panelContacts.Controls.Add(this.label4);
            this.panelContacts.Controls.Add(this.label3);
            this.panelContacts.Controls.Add(this.label2);
            this.panelContacts.Location = new System.Drawing.Point(183, 214);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(521, 276);
            this.panelContacts.TabIndex = 47;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(482, 3);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(34, 35);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 53;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.SystemColors.Control;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(164, 168);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(196, 27);
            this.labelEmail.TabIndex = 52;
            this.labelEmail.Text = "dada@yandex.ru";
            // 
            // labelNumverPhone
            // 
            this.labelNumverPhone.AutoSize = true;
            this.labelNumverPhone.BackColor = System.Drawing.SystemColors.Control;
            this.labelNumverPhone.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumverPhone.Location = new System.Drawing.Point(206, 126);
            this.labelNumverPhone.Name = "labelNumverPhone";
            this.labelNumverPhone.Size = new System.Drawing.Size(197, 27);
            this.labelNumverPhone.TabIndex = 51;
            this.labelNumverPhone.Text = "+7 999 999 99 99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "Телефон:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(196, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Контакты";
            // 
            // TimerLabel
            // 
            this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimerLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TimerLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLabel.Location = new System.Drawing.Point(12, 530);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(860, 22);
            this.TimerLabel.TabIndex = 48;
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuRacers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.panelContacts);
            this.Controls.Add(this.buttoLogOut);
            this.Controls.Add(this.buttonEditProfile);
            this.Controls.Add(this.buttonContacts);
            this.Controls.Add(this.buttonMyResults);
            this.Controls.Add(this.buttonMySponsor);
            this.Controls.Add(this.buttonRegRacer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridTimer);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelKartName);
            this.Controls.Add(this.dataKartName);
            this.Name = "MenuRacers";
            this.Text = "MenuRacers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).EndInit();
            this.panelContacts.ResumeLayout(false);
            this.panelContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridTimer;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelKartName;
        private System.Windows.Forms.DataGridView dataKartName;
        private System.Windows.Forms.Timer TimerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegRacer;
        private System.Windows.Forms.Button buttonMySponsor;
        private System.Windows.Forms.Button buttonMyResults;
        private System.Windows.Forms.Button buttonContacts;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Button buttoLogOut;
        private System.Windows.Forms.Panel panelContacts;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNumverPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label TimerLabel;
    }
}
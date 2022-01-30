
namespace KartSkills
{
    partial class MenuAdmin
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
            this.TimerStart = new System.Windows.Forms.Timer(this.components);
            this.buttonOrganizationsList = new System.Windows.Forms.Button();
            this.buttonVolunteers = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonListUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridTimer = new System.Windows.Forms.DataGridView();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelKartName = new System.Windows.Forms.Label();
            this.dataKartName = new System.Windows.Forms.DataGridView();
            this.buttoLogOut = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerStart
            // 
            this.TimerStart.Enabled = true;
            this.TimerStart.Interval = 1000;
            this.TimerStart.Tick += new System.EventHandler(this.TimerStart_Tick);
            // 
            // buttonOrganizationsList
            // 
            this.buttonOrganizationsList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonOrganizationsList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonOrganizationsList.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOrganizationsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrganizationsList.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOrganizationsList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOrganizationsList.Location = new System.Drawing.Point(79, 288);
            this.buttonOrganizationsList.Name = "buttonOrganizationsList";
            this.buttonOrganizationsList.Size = new System.Drawing.Size(286, 92);
            this.buttonOrganizationsList.TabIndex = 44;
            this.buttonOrganizationsList.Text = "Благотворительные организации";
            this.buttonOrganizationsList.UseVisualStyleBackColor = false;
            // 
            // buttonVolunteers
            // 
            this.buttonVolunteers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonVolunteers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonVolunteers.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonVolunteers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolunteers.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVolunteers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonVolunteers.Location = new System.Drawing.Point(534, 190);
            this.buttonVolunteers.Name = "buttonVolunteers";
            this.buttonVolunteers.Size = new System.Drawing.Size(286, 92);
            this.buttonVolunteers.TabIndex = 42;
            this.buttonVolunteers.Text = "Волонтеры";
            this.buttonVolunteers.UseVisualStyleBackColor = false;
            // 
            // buttonInventory
            // 
            this.buttonInventory.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonInventory.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventory.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonInventory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonInventory.Location = new System.Drawing.Point(534, 288);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(286, 92);
            this.buttonInventory.TabIndex = 41;
            this.buttonInventory.Text = "Инвентарь";
            this.buttonInventory.UseVisualStyleBackColor = false;
            this.buttonInventory.Click += new System.EventHandler(this.buttonInventory_Click);
            // 
            // buttonListUser
            // 
            this.buttonListUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonListUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonListUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonListUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListUser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonListUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonListUser.Location = new System.Drawing.Point(79, 190);
            this.buttonListUser.Name = "buttonListUser";
            this.buttonListUser.Size = new System.Drawing.Size(286, 92);
            this.buttonListUser.TabIndex = 40;
            this.buttonListUser.Text = "Пользователи";
            this.buttonListUser.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(350, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Меню гонщика";
            // 
            // dataGridTimer
            // 
            this.dataGridTimer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridTimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTimer.Location = new System.Drawing.Point(-3, 520);
            this.dataGridTimer.Name = "dataGridTimer";
            this.dataGridTimer.RowTemplate.Height = 25;
            this.dataGridTimer.Size = new System.Drawing.Size(891, 43);
            this.dataGridTimer.TabIndex = 36;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelCity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(285, 84);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(321, 24);
            this.labelCity.TabIndex = 35;
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
            this.labelKartName.TabIndex = 34;
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
            this.dataKartName.TabIndex = 33;
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
            this.buttoLogOut.TabIndex = 45;
            this.buttoLogOut.Text = "Logout";
            this.buttoLogOut.UseVisualStyleBackColor = false;
            this.buttoLogOut.Click += new System.EventHandler(this.buttoLogOut_Click);
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
            this.TimerLabel.TabIndex = 46;
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.buttoLogOut);
            this.Controls.Add(this.buttonOrganizationsList);
            this.Controls.Add(this.buttonVolunteers);
            this.Controls.Add(this.buttonInventory);
            this.Controls.Add(this.buttonListUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridTimer);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelKartName);
            this.Controls.Add(this.dataKartName);
            this.Name = "MenuAdmin";
            this.Text = "MenuAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKartName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerStart;
        private System.Windows.Forms.Button buttonOrganizationsList;
        private System.Windows.Forms.Button buttonVolunteers;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonListUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridTimer;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelKartName;
        private System.Windows.Forms.DataGridView dataKartName;
        private System.Windows.Forms.Button buttoLogOut;
        private System.Windows.Forms.Label TimerLabel;
    }
}

namespace KartSkills
{
    partial class OrganizationInfo
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxFund = new System.Windows.Forms.PictureBox();
            this.labelNameFund = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFund)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFund
            // 
            this.pictureBoxFund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFund.Location = new System.Drawing.Point(9, 7);
            this.pictureBoxFund.Name = "pictureBoxFund";
            this.pictureBoxFund.Size = new System.Drawing.Size(149, 147);
            this.pictureBoxFund.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFund.TabIndex = 9;
            this.pictureBoxFund.TabStop = false;
            // 
            // labelNameFund
            // 
            this.labelNameFund.AutoSize = true;
            this.labelNameFund.BackColor = System.Drawing.SystemColors.Control;
            this.labelNameFund.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNameFund.Location = new System.Drawing.Point(164, 21);
            this.labelNameFund.Name = "labelNameFund";
            this.labelNameFund.Size = new System.Drawing.Size(25, 22);
            this.labelNameFund.TabIndex = 32;
            this.labelNameFund.Text = "...";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDescription.Location = new System.Drawing.Point(164, 55);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(313, 99);
            this.textBoxDescription.TabIndex = 33;
            // 
            // OrganizationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelNameFund);
            this.Controls.Add(this.pictureBoxFund);
            this.Name = "OrganizationInfo";
            this.Size = new System.Drawing.Size(492, 165);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFund;
        private System.Windows.Forms.Label labelNameFund;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}

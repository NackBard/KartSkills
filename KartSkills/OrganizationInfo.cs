using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartSkills
{
    public partial class OrganizationInfo : UserControl
    {
        public OrganizationInfo()
        {
            InitializeComponent();
        }

        private string _message;
        private string _title;
        private string _icon;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; labelNameFund.Text = value; }
        }

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; textBoxDescription.Text = value; }
        }
        [Category("Custom Props")]
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBoxFund.ImageLocation = value; }
        }
    }
}

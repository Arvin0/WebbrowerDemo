using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebbrowerDemo
{
    public partial class VteDetailsForm : Form
    {
        public VteDetailsForm()
        {
            InitializeComponent();
        }

        private void VteDetailsLoad(object sender, EventArgs e)
        {
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            var url = "Data/details-test.html";
            this.webBrowser_detials.Url = new Uri(basePath + url);
            this.panel_details.Show();
        }
    }
}

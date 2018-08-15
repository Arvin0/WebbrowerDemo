using System;

namespace IntegratedPlugin.Form
{
    public partial class VteDetailsForm : System.Windows.Forms.Form
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

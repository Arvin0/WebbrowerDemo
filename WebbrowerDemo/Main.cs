using System;
using System.Windows.Forms;

namespace WebbrowerDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MainLoad(object sender, EventArgs e)
        {
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            var url = "Data/main-test.html";
            this.webBrowser_vteshow.Url = new Uri(basePath + url);
            this.pane_vteMain.Hide();

            RegisterEvent_CloseVteMain();
        }

        /// <summary>
        /// 显示AI检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AiCheckClick(object sender, EventArgs e)
        {
            if (this.pane_vteMain.Visible)
            {
                this.pane_vteMain.Hide();
            }
            else
            {
                this.pane_vteMain.Show();
            }
        }

        private void RegisterEvent_CloseVteMain()
        {
            HtmlDocument htmlDoc = this.webBrowser_vteshow.Document;
            HtmlElement btnElement = htmlDoc.All["closevtemain"];
            if (btnElement != null)
            {
                btnElement.AttachEventHandler("onclick", new EventHandler(AiCheckClick));
            }
        }
        
    }
}

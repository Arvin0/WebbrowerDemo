using IntegratedPlugin.Entry;
using IntegratedPlugin.Model;
using System;
using System.Windows.Forms;

namespace WebbrowerDemo
{
    public partial class MainForm : Form
    {
        private MainPageManagement _mainPageHandle;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainLoad(object sender, EventArgs e)
        {
            _mainPageHandle = new MainPageManagement(webBrowser_vteshow);
            this.pane_vteMain.Show();
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

        private void webBrowser_vteshow_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            _mainPageHandle.BrowerDocumentCompleted(new PatientModel()
            {
                Num = 123,
                Name = "Tom"
            });
            _mainPageHandle.SetCallBack(CallBack_ReceiveDataFromPage);
        }

        /// <summary>
        /// 回调函数，获取页面传递的数据
        /// 根据不同的数据类型，完成不同操作
        /// </summary>
        /// <param name="data"></param>
        public void CallBack_ReceiveDataFromPage(DataTransferModel data)
        {
            this.rtBox_aishow.Text = data.Data;
        }
    }
}

using System;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace WebbrowerDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainLoad(object sender, EventArgs e)
        {
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            var url = "Data/main-test.html";
            this.webBrowser_vteshow.Url = new Uri(basePath + url);
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
            // 注册事件

            HtmlDocument htmlDoc = this.webBrowser_vteshow.Document;
            HtmlElement btnshowDataInForm = htmlDoc.All["showDataInForm"];
            if (btnshowDataInForm != null)
            {
                // 点击页面按钮，在Form中显示数据
                //btnElement.Click += new HtmlElementEventHandler(TransferDataToForm);
                btnshowDataInForm.AttachEventHandler("onclick", new EventHandler(ShowDataInForm));
            }

            HtmlElement btnshowDetailsForm = htmlDoc.All["showDetailsForm"];
            if (btnshowDetailsForm != null)
            {
                // 点击页面按钮，弹出新的form窗体
                btnshowDetailsForm.AttachEventHandler("onclick", new EventHandler(ShowDetailsForm));
            }

            HtmlElement btnshowTransferDataInForm = htmlDoc.All["showTransferDataInForm"];
            if (btnshowTransferDataInForm != null)
            {
                // 点击页面按钮，传输数据到Form
                btnshowTransferDataInForm.AttachEventHandler("onclick", new EventHandler(TransferDataToFormParam));
            }

            TransferDataToForm();
        }

        private void ShowDataInForm(object sender, EventArgs e)
        {
            this.rtBox_aishow.Text = "从webbrower获取数据";
        }

        private void TransferDataToForm()
        {
            var resultNoReturnData = this.webBrowser_vteshow.Document.InvokeScript("showDataFromForm", new object[] { "病人Tom" });
            var resultWithData = this.webBrowser_vteshow.Document.InvokeScript("doAdd", new object[] { 1, 2 });
            var showData = "从form调用页面中js执行成功，js函数名称：showDataFromForm， doAdd。 doAdd结果：" + resultWithData.ToString();
            this.rtBox_aishow.Text = showData;
        }

        private void TransferDataToFormParam(object sender, EventArgs e)
        {
            var result = this.webBrowser_vteshow.Document.InvokeScript("transferDataToForm");
            this.rtBox_aishow.Text = result.ToString();
        }

        private void ShowDetailsForm(object sender, EventArgs e)
        {
            (new VteDetailsForm()).Show();
        }
    }
}

using IntegratedPlugin.Common;
using IntegratedPlugin.Interaction;
using IntegratedPlugin.Model;
using System;
using System.Windows.Forms;
using IntegratedPlugin.Config;

namespace IntegratedPlugin.UI
{
    public partial class VteMain : Form
    {
        private readonly PatientModel _patient;

        public VteMain(PatientModel patient)
        {
            _patient = patient;
            InitializeComponent();
        }

        private void MainLoad(object sender, EventArgs e)
        {
            Initialize();
        }

        #region 回调集成项目方法，传递数据

        private DataTransfer _transferDataToIntegratedSystem = null;

        public void SetCallBack(DataTransfer callBack)
        {
            _transferDataToIntegratedSystem = callBack;
        }

        #endregion

        private void Initialize()
        {
            // 设置webbrower 页面数据
            this.webBrowser_vteshow.Url = new Uri(ConfigHelp.GetPathBaseRootPath("Main"));
        }

        private void WebBrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 注册相关事件
            RegisterEvents();

            // 将病人信息传到页面
            TransferPatientInfoToUi();
        }

        /// <summary>
        /// 注册页面事件
        /// </summary>
        private void RegisterEvents()
        {
            // 注册事件
            var htmlDoc = this.webBrowser_vteshow.Document;

            // 点击页面按钮，弹出新的form窗体
            var btnshowDetailsForm = htmlDoc.All["showDetailsForm"];
            if (btnshowDetailsForm != null)
            {
                btnshowDetailsForm.AttachEventHandler("onclick", new EventHandler(ShowDetailsForm));
            }

            // 点击页面按钮，传输数据到集成项目
            var btnshowTransferDataInForm = htmlDoc.All["showTransferDataInForm"];
            if (btnshowTransferDataInForm != null)
            {
                btnshowTransferDataInForm.AttachEventHandler("onclick", new EventHandler(TransferDataToForm));
            }
        }

        /// <summary>
        /// 根据不同请求，显示不同页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowDetailsForm(object sender, EventArgs e)
        {
            string formName = "VteDetailsForm";
            var form = FormManagement.GetForm(formName);
            if (form == null)
            {
                form = new VteDetailsForm();
                FormManagement.AddForm(formName, form);
            }
            else
            {
                form.TopMost = true;
            }


            form.Show();
        }

        /// <summary>
        /// 传输页面信息到Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransferDataToForm(object sender, EventArgs e)
        {
            var result = this.webBrowser_vteshow.Document.InvokeScript("transferDataToForm");
            _transferDataToIntegratedSystem(new DataTransferModel()
            {
                Data = result.ToString(),
                Type = 123
            });
        }

        /// <summary>
        /// 传递病人信息到页面
        /// </summary>
        /// <param name="patient"></param>
        private void TransferPatientInfoToUi()
        {
            var resultNoReturnData =
                webBrowser_vteshow.Document.InvokeScript("showDataFromForm", new object[] {_patient.Name});
        }

        private void VteMainFormClosing(object sender, FormClosingEventArgs e)
        {
            FormManagement.CloseAllForm();
        }
    }
}

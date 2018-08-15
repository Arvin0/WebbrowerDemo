using System;
using System.Windows.Forms;
using IntegratedPlugin.Form;
using IntegratedPlugin.Model;

namespace IntegratedPlugin.Entry
{
    public class MainPageManagement
    {
        private readonly WebBrowser _webBrowser;

        public MainPageManagement(WebBrowser webBrowser)
        {
            _webBrowser = webBrowser;
            Initialize();
        }

        #region 回调集成项目方法，传递数据

        private DataTransfer _transferDataToMain = null;

        public void SetCallBack(DataTransfer callBack)
        {
            _transferDataToMain = callBack;
        }

        #endregion

        private void Initialize()
        {
            // 设置webbrower 页面数据
            var basePath = System.AppDomain.CurrentDomain.BaseDirectory;
            var url = "Data/main-test.html";
            this._webBrowser.Url = new Uri(basePath + url);
        }

        public void BrowerDocumentCompleted(PatientModel patient)
        {
            // 注册相关事件
            RegisterEvents();

            // 将病人信息传到页面
            TransferPatientInfoToUi(patient);
        }

        /// <summary>
        /// 注册页面事件
        /// </summary>
        private void RegisterEvents()
        {
            // 注册事件
            var htmlDoc = this._webBrowser.Document;

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
            (new VteDetailsForm()).Show();
        }

        /// <summary>
        /// 传输页面信息到Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransferDataToForm(object sender, EventArgs e)
        {
            var result = _webBrowser.Document.InvokeScript("transferDataToForm");
            _transferDataToMain(new DataTransferModel()
            {
                Data = result.ToString(),
                Type = 123
            });
        }

        /// <summary>
        /// 传递病人信息到页面
        /// </summary>
        /// <param name="patient"></param>
        private void TransferPatientInfoToUi(PatientModel patient)
        {
            var resultNoReturnData = _webBrowser.Document.InvokeScript("showDataFromForm", new object[] { patient.Name });
        }
    }

    /// <summary>
    /// 数据传输
    /// </summary>
    /// <param name="data"></param>
    public delegate void DataTransfer(DataTransferModel data);
}

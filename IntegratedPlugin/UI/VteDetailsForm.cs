using IntegratedPlugin.Common;
using System;
using System.Windows.Forms;
using IntegratedPlugin.Config;

namespace IntegratedPlugin.UI
{
    public partial class VteDetailsForm : System.Windows.Forms.Form
    {
        public VteDetailsForm()
        {
            InitializeComponent();
        }

        private void VteDetailsLoad(object sender, EventArgs e)
        {
            this.webBrowser_detials.Url = new Uri(ConfigHelp.GetPathBaseRootPath("Detail"));
        }

        private void VteDetailsFormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            FormManagement.RemoveForm(this.Name);
        }

        private void webBrowser_detials_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // 注册事件
            var htmlDoc = this.webBrowser_detials.Document;

            // 点击页面按钮，弹出新的form窗体
            var btnshowDetailsForm = htmlDoc.All["ptitle"];
            if (btnshowDetailsForm != null)
            {
                btnshowDetailsForm.MouseDown += new HtmlElementEventHandler(MyMouseDown);
                btnshowDetailsForm.MouseUp += new HtmlElementEventHandler(MyMouseUp);
                btnshowDetailsForm.MouseMove += new HtmlElementEventHandler(MyMouseMove);
                btnshowDetailsForm.MouseLeave += new HtmlElementEventHandler(MyMouseLeave);
            }
        }

        #region 窗体可移动控制

        private bool _beginMove = false; //初始化
        private int _currentXPosition; // 当前X坐标
        private int _currentYPosition; // 当前Y坐标

        /// <summary>
        /// 鼠标按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyMouseDown(object sender, HtmlElementEventArgs e)
        {

            if (e.MouseButtonsPressed == MouseButtons.Left)
            {
                _beginMove = true;
                _currentXPosition = MousePosition.X; //鼠标的x坐标为当前窗体左上角x坐标
                _currentYPosition = MousePosition.Y; //鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        /// <summary>
        /// 鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyMouseMove(object sender, HtmlElementEventArgs e)
        {
            if (_beginMove)
            {
                this.Left += MousePosition.X - _currentXPosition; //根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - _currentYPosition; //根据鼠标的y坐标窗体的顶部，即Y坐标
                _currentXPosition = MousePosition.X;
                _currentYPosition = MousePosition.Y;
            }
        }

        /// <summary>
        /// 鼠标放下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyMouseUp(object sender, HtmlElementEventArgs e)
        {
            if (e.MouseButtonsPressed == MouseButtons.Left)
            {
                ResetMousePosition();
            }
        }

        /// <summary>
        /// 鼠标离开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyMouseLeave(object sender, HtmlElementEventArgs e)
        {
            ResetMousePosition();
        }

        /// <summary>
        /// 重置鼠标状态
        /// </summary>
        private void ResetMousePosition()
        {
            //设置初始状态
            _currentXPosition = 0;
            _currentYPosition = 0;
            _beginMove = false;
        }

        #endregion
    }
}

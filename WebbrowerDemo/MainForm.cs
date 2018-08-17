using IntegratedPlugin.Interaction;
using IntegratedPlugin.Model;
using System;
using System.Windows.Forms;

namespace WebbrowerDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 显示AI检测
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AiCheckClick(object sender, EventArgs e)
        {
            new Entrance().Start(new PatientModel()
            {
                Num = 123,
                Name = "Tom"
            }, CallBack_ReceiveDataFromPage);
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

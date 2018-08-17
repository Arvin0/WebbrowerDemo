using IntegratedPlugin.Model;
using IntegratedPlugin.UI;

namespace IntegratedPlugin.Interaction
{
    /// <summary>
    /// VTE卫士入口
    /// </summary>
    public class Entrance
    {
        /// <summary>
        /// VTE卫士启动窗口
        /// </summary>
        /// <param name="patient"></param>
        /// <param name="callBack"></param>
        public void Start(PatientModel patient, DataTransfer callBack)
        {
            var vteMain = new VteMain(patient);

            vteMain.SetCallBack(callBack);

            vteMain.Show();
        }
    }
}

namespace IntegratedPlugin.Model
{
    /// <summary>
    /// 插件与集成项目数据传输模型
    /// </summary>
    public class DataTransferModel
    {
        /// <summary>
        /// 数据类型
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// 数据
        /// </summary>
        public string Data { get; set; }
    }
}

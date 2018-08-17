using System;
using System.Configuration;
using System.IO;

namespace IntegratedPlugin.Config
{
    /// <summary>
    /// 配置操作类
    /// </summary>
    public static class ConfigHelp
    {
        /// <summary>
        /// 项目路径
        /// </summary>
        public static string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// 配置文件名称
        /// </summary>
        public static string ConfigurationFileName = "MySettings.config";

        /// <summary>
        /// 配置文件路径
        /// </summary>
        private static string ConfigurationFilePath = Path.Combine(BaseDirectory, ConfigurationFileName);

        /// <summary>
        /// 自定义配置
        /// </summary>
        private static Configuration _configuration;

        /// <summary>
        /// 获取配置文件值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSettingsValue(string key)
        {
            return GetConfiguratoin().AppSettings.Settings[key].Value;
        }

        /// <summary>
        /// 获取配置文件值
        /// </summary>
        /// <typeparam name="T">需求值类型</typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetAppSettingsValue<T>(string key)
        {
            object value = GetConfiguratoin().AppSettings.Settings[key].Value;
            return (T)value;
        }

        /// <summary>
        /// 基于项目运行路径，获取文件的绝对路径
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetPathBaseRootPath(string key)
        {
            return Path.Combine(BaseDirectory, GetAppSettingsValue(key));
        }

        /// <summary>
        /// 配置文件初始化
        /// </summary>
        private static Configuration GetConfiguratoin()
        {
            if (_configuration == null)
            {
                ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
                fileMap.ExeConfigFilename = ConfigurationFilePath;
                _configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            }

            return _configuration;
        }
    }
}

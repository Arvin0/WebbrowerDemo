using System;
using System.Collections.Concurrent;
using System.Windows.Forms;

namespace IntegratedPlugin.Common
{
    /// <summary>
    /// 管理当前打开的Form
    /// </summary>
    internal static class FormManagement
    {
        /// <summary>
        /// 所有已经打开Form的缓存
        /// </summary>
        private static readonly ConcurrentDictionary<string, Form> FormCache = new ConcurrentDictionary<string, Form>();

        /// <summary>
        /// 获取缓存中的Form
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static Form GetForm(string name)
        {
            if (FormCache.TryGetValue(name, out var form))
            {
                return form;
            }

            return null;
        }

        /// <summary>
        /// 添加新的Form
        /// 如果Form已经存在，则更新Form; 否则，直接添加新的Form
        /// </summary>
        /// <param name="name">Form 名称</param>
        /// <param name="form">Form 实例</param>
        /// <returns></returns>
        internal static bool AddForm(string name, Form form)
        {
            if (form == null)
            {
                return false;
            }

            if (GetForm(name) != null)
            {
                FormCache[name] = form;
                return true;
            }

            return FormCache.TryAdd(name, form);
        }

        /// <summary>
        /// 从缓存中移除Form
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        internal static bool RemoveForm(string name)
        {
            if (GetForm(name) != null)
            {
                return FormCache.TryRemove(name, out var form);
            }

            return true;
        }

        /// <summary>
        /// 关闭所有打开的窗体
        /// </summary>
        internal static void CloseAllForm()
        {
            foreach (var key in FormCache.Keys)
            {
                try
                {
                    var form = GetForm(key);
                    form?.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    // Log
                }
            }

            FormCache.Clear();
        }
    }
}

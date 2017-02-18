using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Optional;

namespace WordLTUIAu
{
    class PluginLoader
    {
        public static Option<ICollection<UIAutomationPlugin>> loadPlugins(String path)
        {
            string[] dllFileNames = null;

            if (Directory.Exists(path))
            {
                dllFileNames = Directory.GetFiles(path, "*.dll");
            }

            return Option.None<ICollection<UIAutomationPlugin>>();
        }
    }
}

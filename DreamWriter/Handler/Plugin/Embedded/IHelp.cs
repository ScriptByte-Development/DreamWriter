using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DreamWriter.EditorWndw;

namespace DreamWriter.Handler.Plugin.Embedded
{
    public class IHelp : IPlugin
    {
        public void Go(string parameters)
        {
            foreach (IPlugin plugin in PluginLoader.Plugins)
            {
                MessageBox.Show($"{plugin.Name}, {plugin.Explanation}", "Plugin Loader");
            }
        }

        public string Name
        {
            get
            {
                return "Help";
            }
        }

        public string Explanation
        {
            get
            {
                return "This plugin shows all loaded plugins and their explanations";
            }
        }
    }
}

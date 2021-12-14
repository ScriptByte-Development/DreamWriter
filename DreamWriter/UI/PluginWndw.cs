using DreamWriter.Handler.Plugin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DreamWriter.EditorWndw;

namespace DreamWriter.UI
{
    public partial class PluginWndw : Form
    {
        public PluginWndw()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PluginWndw_Load(object sender, EventArgs e)
        {
            try
            {
                PluginLoader.StartPluginLoader(); //starts the plugin loader
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void pluginTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                while (true)
                {
                    try
                    {
                        //let the user fill in an plugin name
                        string line = pluginTxtBox.Text;
                        string name = line.Split(new char[] { ' ' }).FirstOrDefault();
                        IPlugin plugin = PluginLoader.Plugins.Where(p => p.Name == name).FirstOrDefault();
                        if (plugin != null)
                        {
                            //If the plugin is found, execute it
                            string parameters = line.Replace(string.Format("{0} ", name), string.Empty);
                            plugin.Go(parameters);
                        }
                        else
                        {
                            MessageBox.Show($"No plugin found with the name {name}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error occured trying to execute a plugin. Error: {ex.Message}", Application.ProductName);
                    }
                }
            }
        }
    }
}

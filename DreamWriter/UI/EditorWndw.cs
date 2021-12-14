using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CockCs; //my library i made, has alot of functions i use prewrittern so i dont have to waste time rewriting it
using DreamWriter.Handler;
using DreamWriter.Handler.Plugin;
using DreamWriter.UI;
using static DreamWriter.Handler.ColorTable;


namespace DreamWriter
{
    public partial class EditorWndw : Form
    {

        public EditorWndw()
        {
            InitializeComponent();
            LoadMenuStripColor();
        }

        private void EditorWndw_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            CodeEditor.Text = "";
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Text File|*.txt|Any File|*.*";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(of.FileName);
                    CodeEditor.Text = sr.ReadToEnd();
                    sr.Close();
                    this.Text = of.FileName;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter(this.Text);
                sw.Write(CodeEditor.Text);
                sw.Close();
            }
            catch
            {

            }
        }

        private void LoadMenuStripColor()
        {
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
            foreach (ToolStripMenuItem m in menuStrip.Items.OfType<ToolStripMenuItem>())
            ApplyMenuColorRecursive(m);
        }

        public static void ApplyMenuColorRecursive(ToolStripMenuItem Item)
        {
            if (Item.DropDownItems.Count > 0)
            {
                foreach (ToolStripMenuItem m in Item.DropDownItems.OfType<ToolStripMenuItem>())
                    ApplyMenuColorRecursive(m);
            }
            Item.ForeColor = Color.White;
            Item.Margin = new Padding(0, 1, 0, 1);
        }

        private void pluginsBtn_Click(object sender, EventArgs e)
        {
            var form = new PluginWndw();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void CodeEditor_Load(object sender, EventArgs e)
        {

        }

        public interface IPlugin
        {
            string Name { get; }
            string Explanation { get; }
            void Go (string parameters);
        }
    }
}

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

namespace DreamWriter
{
    public partial class EditorWndw : Form
    {
        WebClient wc = new WebClient();
        private string defPath = Application.StartupPath + "//Monaco//";

        public EditorWndw()
        {
            InitializeComponent();
        }

        private void EditorWndw_Load(object sender, EventArgs e)
        {
            LoadEditor();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadEditor()
        {
            WebClient wc = new WebClient();
            try
            {
                CodeEditor.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
                CodeEditor.Document.InvokeScript("SetTheme", new string[]
                {
                   "Dark"
                });
                addBase();
                addMath();
                addGlobalNS();
                addGlobalV();
                addGlobalF();
                CodeEditor.Document.InvokeScript("SetText", new object[]
                {
                 ""
                });
            }
            catch (Exception ex)
            {

            }
        }


        private void addIntel(string label, string kind, string detail, string insertText)
        {
            string text = "\"" + label + "\"";
            string text2 = "\"" + kind + "\"";
            string text3 = "\"" + detail + "\"";
            string text4 = "\"" + insertText + "\"";
            CodeEditor.Document.InvokeScript("AddIntellisense", new object[]
            {
                label,
                kind,
                detail,
                insertText
            });
        }

        private void addGlobalF()
        {
            string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
            foreach (string text in array)
            {
                bool flag = text.Contains(':');
                if (flag)
                {
                    this.addIntel(text, "Function", text, text.Substring(1));
                }
                else
                {
                    this.addIntel(text, "Function", text, text);
                }
            }
        }

        private void addGlobalV()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
            {
                this.addIntel(text, "Variable", text, text);
            }
        }

        private void addGlobalNS()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
            {
                this.addIntel(text, "Class", text, text);
            }
        }

        private void addMath()
        {
            foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
            {
                this.addIntel(text, "Method", text, text);
            }
        }

        private void addBase()
        {
            foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
            {
                this.addIntel(text, "Keyword", text, text);
            }
        }

    }
}

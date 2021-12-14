namespace DreamWriter
{
    partial class EditorWndw
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorWndw));
            this.dragCtrl = new Siticone.UI.WinForms.SiticoneDragControl();
            this.topPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.exitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.closeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.CodeEditor = new FastColoredTextBoxNS.FastColoredTextBox();
            this.pluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // dragCtrl
            // 
            this.dragCtrl.TargetControl = this.topPnl;
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.topPnl.Controls.Add(this.pictureBox1);
            this.topPnl.Controls.Add(this.minimizeBtn);
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Controls.Add(this.menuStrip);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.ForeColor = System.Drawing.Color.Transparent;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(867, 32);
            this.topPnl.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 24);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.BorderRadius = 4;
            this.minimizeBtn.BorderThickness = 2;
            this.minimizeBtn.CheckedState.Parent = this.minimizeBtn;
            this.minimizeBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.CustomImages.Parent = this.minimizeBtn;
            this.minimizeBtn.FillColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.HoveredState.Parent = this.minimizeBtn;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.minimizeBtn.Location = new System.Drawing.Point(768, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.PressedColor = System.Drawing.Color.White;
            this.minimizeBtn.ShadowDecoration.Parent = this.minimizeBtn;
            this.minimizeBtn.Size = new System.Drawing.Size(45, 27);
            this.minimizeBtn.TabIndex = 27;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.BorderRadius = 4;
            this.exitBtn.BorderThickness = 2;
            this.exitBtn.CheckedState.Parent = this.exitBtn;
            this.exitBtn.CustomBorderColor = System.Drawing.Color.Transparent;
            this.exitBtn.CustomImages.Parent = this.exitBtn;
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Sitka Text", 11.25F);
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.HoveredState.Parent = this.exitBtn;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageSize = new System.Drawing.Size(12, 12);
            this.exitBtn.Location = new System.Drawing.Point(819, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.PressedColor = System.Drawing.Color.White;
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(45, 27);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStrip,
            this.pluginsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(35, 3);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(211, 24);
            this.menuStrip.TabIndex = 28;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileStrip
            // 
            this.fileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBtn,
            this.openBtn,
            this.saveBtn,
            this.closeBtn});
            this.fileStrip.ForeColor = System.Drawing.Color.White;
            this.fileStrip.Name = "fileStrip";
            this.fileStrip.Size = new System.Drawing.Size(37, 20);
            this.fileStrip.Text = "File";
            // 
            // newBtn
            // 
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(103, 22);
            this.newBtn.Text = "New";
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(103, 22);
            this.openBtn.Text = "Open";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(103, 22);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(103, 22);
            this.closeBtn.Text = "Close";
            // 
            // CodeEditor
            // 
            this.CodeEditor.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.CodeEditor.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:" +
    "]*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.CodeEditor.AutoScrollMinSize = new System.Drawing.Size(35, 14);
            this.CodeEditor.BackBrush = null;
            this.CodeEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CodeEditor.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.CodeEditor.CaretColor = System.Drawing.Color.White;
            this.CodeEditor.ChangedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CodeEditor.CharHeight = 14;
            this.CodeEditor.CharWidth = 8;
            this.CodeEditor.CurrentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CodeEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CodeEditor.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeEditor.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.CodeEditor.ForeColor = System.Drawing.Color.White;
            this.CodeEditor.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CodeEditor.IsReplaceMode = false;
            this.CodeEditor.Language = FastColoredTextBoxNS.Language.CSharp;
            this.CodeEditor.LeftBracket = '(';
            this.CodeEditor.LeftBracket2 = '{';
            this.CodeEditor.LineNumberColor = System.Drawing.Color.Gray;
            this.CodeEditor.Location = new System.Drawing.Point(0, 32);
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.PaddingBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CodeEditor.Paddings = new System.Windows.Forms.Padding(0);
            this.CodeEditor.RightBracket = ')';
            this.CodeEditor.RightBracket2 = '}';
            this.CodeEditor.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CodeEditor.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("CodeEditor.ServiceColors")));
            this.CodeEditor.ServiceLinesColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CodeEditor.Size = new System.Drawing.Size(867, 569);
            this.CodeEditor.TabIndex = 1;
            this.CodeEditor.Text = "a";
            this.CodeEditor.TextAreaBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.CodeEditor.Zoom = 100;
            this.CodeEditor.Load += new System.EventHandler(this.CodeEditor_Load);
            // 
            // pluginsToolStripMenuItem
            // 
            this.pluginsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pluginsBtn});
            this.pluginsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            this.pluginsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.pluginsToolStripMenuItem.Text = "Tools";
            // 
            // pluginsBtn
            // 
            this.pluginsBtn.Name = "pluginsBtn";
            this.pluginsBtn.Size = new System.Drawing.Size(180, 22);
            this.pluginsBtn.Text = "Plugins";
            this.pluginsBtn.Click += new System.EventHandler(this.pluginsBtn_Click);
            // 
            // EditorWndw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(867, 601);
            this.Controls.Add(this.CodeEditor);
            this.Controls.Add(this.topPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "EditorWndw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DreamWriter";
            this.Load += new System.EventHandler(this.EditorWndw_Load);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneDragControl dragCtrl;
        private System.Windows.Forms.Panel topPnl;
        public Siticone.UI.WinForms.SiticoneButton exitBtn;
        public Siticone.UI.WinForms.SiticoneButton minimizeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileStrip;
        private System.Windows.Forms.ToolStripMenuItem newBtn;
        private System.Windows.Forms.ToolStripMenuItem openBtn;
        private System.Windows.Forms.ToolStripMenuItem saveBtn;
        private System.Windows.Forms.ToolStripMenuItem closeBtn;
        private FastColoredTextBoxNS.FastColoredTextBox CodeEditor;
        private System.Windows.Forms.ToolStripMenuItem pluginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pluginsBtn;
    }
}


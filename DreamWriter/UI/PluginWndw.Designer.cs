namespace DreamWriter.UI
{
    partial class PluginWndw
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginWndw));
            this.topPnl = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minimizeBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.exitBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.pluginTxtBox = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.topPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.topPnl.Controls.Add(this.pictureBox1);
            this.topPnl.Controls.Add(this.minimizeBtn);
            this.topPnl.Controls.Add(this.exitBtn);
            this.topPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPnl.ForeColor = System.Drawing.Color.Transparent;
            this.topPnl.Location = new System.Drawing.Point(0, 0);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(329, 32);
            this.topPnl.TabIndex = 1;
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
            this.minimizeBtn.Location = new System.Drawing.Point(230, 2);
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
            this.exitBtn.Location = new System.Drawing.Point(281, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.PressedColor = System.Drawing.Color.White;
            this.exitBtn.ShadowDecoration.Parent = this.exitBtn;
            this.exitBtn.Size = new System.Drawing.Size(45, 27);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // pluginTxtBox
            // 
            this.pluginTxtBox.Animated = false;
            this.pluginTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pluginTxtBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pluginTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pluginTxtBox.DefaultText = "";
            this.pluginTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pluginTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pluginTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pluginTxtBox.DisabledState.Parent = this.pluginTxtBox;
            this.pluginTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pluginTxtBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pluginTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pluginTxtBox.FocusedState.Parent = this.pluginTxtBox;
            this.pluginTxtBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.pluginTxtBox.ForeColor = System.Drawing.Color.White;
            this.pluginTxtBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pluginTxtBox.HoveredState.Parent = this.pluginTxtBox;
            this.pluginTxtBox.Location = new System.Drawing.Point(75, 100);
            this.pluginTxtBox.Name = "pluginTxtBox";
            this.pluginTxtBox.PasswordChar = '\0';
            this.pluginTxtBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.pluginTxtBox.PlaceholderText = "plugin";
            this.pluginTxtBox.SelectedText = "";
            this.pluginTxtBox.ShadowDecoration.Parent = this.pluginTxtBox;
            this.pluginTxtBox.Size = new System.Drawing.Size(200, 36);
            this.pluginTxtBox.TabIndex = 7;
            this.pluginTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pluginTxtBox_KeyDown);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.topPnl;
            // 
            // PluginWndw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(329, 230);
            this.Controls.Add(this.pluginTxtBox);
            this.Controls.Add(this.topPnl);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PluginWndw";
            this.Text = "PluginWndw";
            this.Load += new System.EventHandler(this.PluginWndw_Load);
            this.topPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Siticone.UI.WinForms.SiticoneButton minimizeBtn;
        public Siticone.UI.WinForms.SiticoneButton exitBtn;
        private Siticone.UI.WinForms.SiticoneTextBox pluginTxtBox;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}
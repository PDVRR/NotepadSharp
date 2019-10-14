namespace NotepadSharp
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.textContentFld = new System.Windows.Forms.TextBox();
            this.symbolCountLbl = new System.Windows.Forms.Label();
            this.newFileMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.linesCountLbl = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(968, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuBtn,
            this.openFileMenuBtn,
            this.saveFileMenuBtn,
            this.saveAsFileMenuBtn,
            this.exitMenuBtn});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileMenuBtn
            // 
            this.openFileMenuBtn.Name = "openFileMenuBtn";
            this.openFileMenuBtn.Size = new System.Drawing.Size(180, 22);
            this.openFileMenuBtn.Text = "Open";
            this.openFileMenuBtn.Click += new System.EventHandler(this.openFileMenuBtn_Click);
            // 
            // saveFileMenuBtn
            // 
            this.saveFileMenuBtn.Enabled = false;
            this.saveFileMenuBtn.Name = "saveFileMenuBtn";
            this.saveFileMenuBtn.Size = new System.Drawing.Size(180, 22);
            this.saveFileMenuBtn.Text = "Save";
            this.saveFileMenuBtn.Click += new System.EventHandler(this.saveFileMenuBtn_Click);
            // 
            // saveAsFileMenuBtn
            // 
            this.saveAsFileMenuBtn.Name = "saveAsFileMenuBtn";
            this.saveAsFileMenuBtn.Size = new System.Drawing.Size(180, 22);
            this.saveAsFileMenuBtn.Text = "Save as";
            this.saveAsFileMenuBtn.Click += new System.EventHandler(this.saveAsFileMenuBtn_Click);
            // 
            // textContentFld
            // 
            this.textContentFld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textContentFld.Location = new System.Drawing.Point(12, 27);
            this.textContentFld.Multiline = true;
            this.textContentFld.Name = "textContentFld";
            this.textContentFld.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textContentFld.Size = new System.Drawing.Size(944, 456);
            this.textContentFld.TabIndex = 1;
            this.textContentFld.TextChanged += new System.EventHandler(this.textContentFld_TextChanged);
            // 
            // symbolCountLbl
            // 
            this.symbolCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.symbolCountLbl.AutoSize = true;
            this.symbolCountLbl.Location = new System.Drawing.Point(12, 486);
            this.symbolCountLbl.Name = "symbolCountLbl";
            this.symbolCountLbl.Size = new System.Drawing.Size(74, 13);
            this.symbolCountLbl.TabIndex = 2;
            this.symbolCountLbl.Text = "Symbol count:";
            // 
            // newFileMenuBtn
            // 
            this.newFileMenuBtn.Name = "newFileMenuBtn";
            this.newFileMenuBtn.Size = new System.Drawing.Size(180, 22);
            this.newFileMenuBtn.Text = "New";
            this.newFileMenuBtn.Click += new System.EventHandler(this.newFileMenuBtn_Click);
            // 
            // exitMenuBtn
            // 
            this.exitMenuBtn.Name = "exitMenuBtn";
            this.exitMenuBtn.Size = new System.Drawing.Size(180, 22);
            this.exitMenuBtn.Text = "Exit";
            this.exitMenuBtn.Click += new System.EventHandler(this.exitMenuBtn_Click);
            // 
            // linesCountLbl
            // 
            this.linesCountLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linesCountLbl.AutoSize = true;
            this.linesCountLbl.Location = new System.Drawing.Point(845, 486);
            this.linesCountLbl.Name = "linesCountLbl";
            this.linesCountLbl.Size = new System.Drawing.Size(74, 13);
            this.linesCountLbl.TabIndex = 3;
            this.linesCountLbl.Text = "Lines count: 1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 507);
            this.Controls.Add(this.linesCountLbl);
            this.Controls.Add(this.symbolCountLbl);
            this.Controls.Add(this.textContentFld);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "NotepadSharp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuBtn;
        private System.Windows.Forms.TextBox textContentFld;
        private System.Windows.Forms.Label symbolCountLbl;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem exitMenuBtn;
        private System.Windows.Forms.Label linesCountLbl;
    }
}


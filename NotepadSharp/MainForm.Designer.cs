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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldWrapMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.textContentFld = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.symbolCountLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linesCountTextLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.linesCountLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.White;
            this.mainMenuStrip.GripMargin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
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
            this.toolStripSeparator1,
            this.exitMenuBtn});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileMenuBtn
            // 
            this.newFileMenuBtn.Name = "newFileMenuBtn";
            this.newFileMenuBtn.Size = new System.Drawing.Size(112, 22);
            this.newFileMenuBtn.Text = "New";
            this.newFileMenuBtn.Click += new System.EventHandler(this.newFileMenuBtn_Click);
            // 
            // openFileMenuBtn
            // 
            this.openFileMenuBtn.Name = "openFileMenuBtn";
            this.openFileMenuBtn.Size = new System.Drawing.Size(112, 22);
            this.openFileMenuBtn.Text = "Open";
            this.openFileMenuBtn.Click += new System.EventHandler(this.openFileMenuBtn_Click);
            // 
            // saveFileMenuBtn
            // 
            this.saveFileMenuBtn.Enabled = false;
            this.saveFileMenuBtn.Name = "saveFileMenuBtn";
            this.saveFileMenuBtn.Size = new System.Drawing.Size(112, 22);
            this.saveFileMenuBtn.Text = "Save";
            this.saveFileMenuBtn.Click += new System.EventHandler(this.saveFileMenuBtn_Click);
            // 
            // saveAsFileMenuBtn
            // 
            this.saveAsFileMenuBtn.Name = "saveAsFileMenuBtn";
            this.saveAsFileMenuBtn.Size = new System.Drawing.Size(112, 22);
            this.saveAsFileMenuBtn.Text = "Save as";
            this.saveAsFileMenuBtn.Click += new System.EventHandler(this.saveAsFileMenuBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitMenuBtn
            // 
            this.exitMenuBtn.Name = "exitMenuBtn";
            this.exitMenuBtn.Size = new System.Drawing.Size(112, 22);
            this.exitMenuBtn.Text = "Exit";
            this.exitMenuBtn.Click += new System.EventHandler(this.exitMenuBtn_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutMenuBtn,
            this.copyMenuBtn,
            this.pasteMenuBtn,
            this.deleteMenuBtn});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutMenuBtn
            // 
            this.cutMenuBtn.Name = "cutMenuBtn";
            this.cutMenuBtn.Size = new System.Drawing.Size(107, 22);
            this.cutMenuBtn.Text = "Cut";
            this.cutMenuBtn.Click += new System.EventHandler(this.cutMenuBtn_Click);
            // 
            // copyMenuBtn
            // 
            this.copyMenuBtn.Name = "copyMenuBtn";
            this.copyMenuBtn.Size = new System.Drawing.Size(107, 22);
            this.copyMenuBtn.Text = "Copy";
            this.copyMenuBtn.Click += new System.EventHandler(this.copyMenuBtn_Click);
            // 
            // pasteMenuBtn
            // 
            this.pasteMenuBtn.Name = "pasteMenuBtn";
            this.pasteMenuBtn.Size = new System.Drawing.Size(107, 22);
            this.pasteMenuBtn.Text = "Paste";
            this.pasteMenuBtn.Click += new System.EventHandler(this.pasteMenuBtn_Click);
            // 
            // deleteMenuBtn
            // 
            this.deleteMenuBtn.Name = "deleteMenuBtn";
            this.deleteMenuBtn.Size = new System.Drawing.Size(107, 22);
            this.deleteMenuBtn.Text = "Delete";
            this.deleteMenuBtn.Click += new System.EventHandler(this.deleteMenuBtn_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.worldWrapMenuBtn,
            this.fontMenuBtn});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // worldWrapMenuBtn
            // 
            this.worldWrapMenuBtn.Checked = true;
            this.worldWrapMenuBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.worldWrapMenuBtn.Name = "worldWrapMenuBtn";
            this.worldWrapMenuBtn.Size = new System.Drawing.Size(180, 22);
            this.worldWrapMenuBtn.Text = "Word Wrap";
            this.worldWrapMenuBtn.Click += new System.EventHandler(this.worldWrapMenuBtn_Click);
            // 
            // fontMenuBtn
            // 
            this.fontMenuBtn.Name = "fontMenuBtn";
            this.fontMenuBtn.Size = new System.Drawing.Size(180, 22);
            this.fontMenuBtn.Text = "Font";
            this.fontMenuBtn.Click += new System.EventHandler(this.fontMenuBtn_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarMenuBtn});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statusBarMenuBtn
            // 
            this.statusBarMenuBtn.Checked = true;
            this.statusBarMenuBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarMenuBtn.Name = "statusBarMenuBtn";
            this.statusBarMenuBtn.Size = new System.Drawing.Size(126, 22);
            this.statusBarMenuBtn.Text = "Status Bar";
            this.statusBarMenuBtn.Click += new System.EventHandler(this.statusBarMenuBtn_Click);
            // 
            // textContentFld
            // 
            this.textContentFld.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textContentFld.BackColor = System.Drawing.Color.White;
            this.textContentFld.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textContentFld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.textContentFld.Location = new System.Drawing.Point(0, 27);
            this.textContentFld.Multiline = true;
            this.textContentFld.Name = "textContentFld";
            this.textContentFld.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textContentFld.Size = new System.Drawing.Size(968, 455);
            this.textContentFld.TabIndex = 1;
            this.textContentFld.TextChanged += new System.EventHandler(this.textContentFld_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.White;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.symbolCountLbl,
            this.toolStripStatusLabel2,
            this.linesCountTextLbl,
            this.linesCountLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 485);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(968, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel1.Text = "Symbol count:";
            // 
            // symbolCountLbl
            // 
            this.symbolCountLbl.Name = "symbolCountLbl";
            this.symbolCountLbl.Size = new System.Drawing.Size(13, 17);
            this.symbolCountLbl.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // linesCountTextLbl
            // 
            this.linesCountTextLbl.Name = "linesCountTextLbl";
            this.linesCountTextLbl.Size = new System.Drawing.Size(71, 17);
            this.linesCountTextLbl.Text = "Lines count:";
            // 
            // linesCountLbl
            // 
            this.linesCountLbl.Name = "linesCountLbl";
            this.linesCountLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linesCountLbl.Size = new System.Drawing.Size(13, 17);
            this.linesCountLbl.Text = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 507);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textContentFld);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "NotepadSharp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuBtn;
        private System.Windows.Forms.TextBox textContentFld;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem exitMenuBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldWrapMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem copyMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuBtn;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel symbolCountLbl;
        private System.Windows.Forms.ToolStripStatusLabel linesCountTextLbl;
        private System.Windows.Forms.ToolStripStatusLabel linesCountLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem fontMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarMenuBtn;
    }
}


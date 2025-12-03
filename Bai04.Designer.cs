namespace Bai04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textSpace = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.openDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.exitDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newFile = new System.Windows.Forms.ToolStripButton();
            this.saveFile = new System.Windows.Forms.ToolStripButton();
            this.fontCombobox = new System.Windows.Forms.ToolStripComboBox();
            this.fontSizeCombobox = new System.Windows.Forms.ToolStripComboBox();
            this.bold = new System.Windows.Forms.ToolStripButton();
            this.italic = new System.Windows.Forms.ToolStripButton();
            this.underline = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSpace
            // 
            this.textSpace.Location = new System.Drawing.Point(0, 81);
            this.textSpace.Name = "textSpace";
            this.textSpace.Size = new System.Drawing.Size(1355, 855);
            this.textSpace.TabIndex = 0;
            this.textSpace.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.formatMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1355, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDocument,
            this.openDocument,
            this.saveDocument,
            this.exitDocument});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // newDocument
            // 
            this.newDocument.Image = ((System.Drawing.Image)(resources.GetObject("newDocument.Image")));
            this.newDocument.Name = "newDocument";
            this.newDocument.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newDocument.Size = new System.Drawing.Size(349, 34);
            this.newDocument.Text = "Tạo văn bản mới";
            this.newDocument.Click += new System.EventHandler(this.newDocument_Click);
            // 
            // openDocument
            // 
            this.openDocument.Image = ((System.Drawing.Image)(resources.GetObject("openDocument.Image")));
            this.openDocument.Name = "openDocument";
            this.openDocument.Size = new System.Drawing.Size(349, 34);
            this.openDocument.Text = "Mở tập tin";
            this.openDocument.Click += new System.EventHandler(this.openDocument_Click);
            // 
            // saveDocument
            // 
            this.saveDocument.Image = ((System.Drawing.Image)(resources.GetObject("saveDocument.Image")));
            this.saveDocument.Name = "saveDocument";
            this.saveDocument.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveDocument.Size = new System.Drawing.Size(349, 34);
            this.saveDocument.Text = "Lưu nội dung văn bản";
            this.saveDocument.Click += new System.EventHandler(this.saveDocument_Click);
            // 
            // exitDocument
            // 
            this.exitDocument.Name = "exitDocument";
            this.exitDocument.Size = new System.Drawing.Size(349, 34);
            this.exitDocument.Text = "Thoát";
            this.exitDocument.Click += new System.EventHandler(this.exitDocument_Click);
            // 
            // formatMenu
            // 
            this.formatMenu.Name = "formatMenu";
            this.formatMenu.Size = new System.Drawing.Size(111, 32);
            this.formatMenu.Text = "Định dạng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFile,
            this.saveFile,
            this.fontCombobox,
            this.fontSizeCombobox,
            this.bold,
            this.italic,
            this.underline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1355, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newFile
            // 
            this.newFile.BackColor = System.Drawing.Color.White;
            this.newFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newFile.Image = ((System.Drawing.Image)(resources.GetObject("newFile.Image")));
            this.newFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(34, 33);
            this.newFile.Text = "toolStripButton1";
            this.newFile.Click += new System.EventHandler(this.newFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.BackColor = System.Drawing.Color.White;
            this.saveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFile.Image = ((System.Drawing.Image)(resources.GetObject("saveFile.Image")));
            this.saveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(34, 33);
            this.saveFile.Text = "toolStripButton2";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // fontCombobox
            // 
            this.fontCombobox.Name = "fontCombobox";
            this.fontCombobox.Size = new System.Drawing.Size(121, 38);
            this.fontCombobox.Click += new System.EventHandler(this.fontCombobox_Click);
            // 
            // fontSizeCombobox
            // 
            this.fontSizeCombobox.Name = "fontSizeCombobox";
            this.fontSizeCombobox.Size = new System.Drawing.Size(121, 38);
            this.fontSizeCombobox.Click += new System.EventHandler(this.fontSizeCombobox_Click);
            // 
            // bold
            // 
            this.bold.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bold.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.bold.Image = ((System.Drawing.Image)(resources.GetObject("bold.Image")));
            this.bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(34, 33);
            this.bold.Text = "toolStripButton1";
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // italic
            // 
            this.italic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italic.Image = ((System.Drawing.Image)(resources.GetObject("italic.Image")));
            this.italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(34, 33);
            this.italic.Text = "toolStripButton1";
            this.italic.Click += new System.EventHandler(this.italic_Click);
            // 
            // underline
            // 
            this.underline.BackColor = System.Drawing.SystemColors.ControlDark;
            this.underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underline.Image = ((System.Drawing.Image)(resources.GetObject("underline.Image")));
            this.underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(34, 33);
            this.underline.Text = "toolStripButton1";
            this.underline.Click += new System.EventHandler(this.underline_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 746);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textSpace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Soạn thảo văn bản";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textSpace;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDocument;
        private System.Windows.Forms.ToolStripMenuItem openDocument;
        private System.Windows.Forms.ToolStripMenuItem saveDocument;
        private System.Windows.Forms.ToolStripMenuItem exitDocument;
        private System.Windows.Forms.ToolStripMenuItem formatMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newFile;
        private System.Windows.Forms.ToolStripButton saveFile;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripComboBox fontCombobox;
        private System.Windows.Forms.ToolStripComboBox fontSizeCombobox;
        private System.Windows.Forms.ToolStripButton bold;
        private System.Windows.Forms.ToolStripButton italic;
        private System.Windows.Forms.ToolStripButton underline;
    }
}


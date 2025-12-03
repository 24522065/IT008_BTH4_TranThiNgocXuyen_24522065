namespace Bai05
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNew_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.studentInfoList = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNew_Menu,
            this.exit_Menu});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // addNew_Menu
            // 
            this.addNew_Menu.Name = "addNew_Menu";
            this.addNew_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNew_Menu.Size = new System.Drawing.Size(258, 34);
            this.addNew_Menu.Text = "Thêm Mới";
            this.addNew_Menu.Click += new System.EventHandler(this.addNew_Menu_Click);
            // 
            // exit_Menu
            // 
            this.exit_Menu.Name = "exit_Menu";
            this.exit_Menu.Size = new System.Drawing.Size(258, 34);
            this.exit_Menu.Text = "Thoát";
            this.exit_Menu.Click += new System.EventHandler(this.exit_Menu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNew,
            this.toolStripLabel1,
            this.searchBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1382, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addNew
            // 
            this.addNew.Image = ((System.Drawing.Image)(resources.GetObject("addNew.Image")));
            this.addNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(120, 29);
            this.addNew.Text = "Thêm mới";
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(160, 29);
            this.toolStripLabel1.Text = "Tìm Kiếm Theo Tên";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(150, 34);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // studentInfoList
            // 
            this.studentInfoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInfoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colID,
            this.colName,
            this.colApartment,
            this.colScore});
            this.studentInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentInfoList.Location = new System.Drawing.Point(0, 67);
            this.studentInfoList.Name = "studentInfoList";
            this.studentInfoList.RowHeadersWidth = 62;
            this.studentInfoList.RowTemplate.Height = 28;
            this.studentInfoList.Size = new System.Drawing.Size(1382, 743);
            this.studentInfoList.TabIndex = 2;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 8;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 150;
            // 
            // colID
            // 
            this.colID.HeaderText = "Mã Số SV";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 150;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên Sinh Viên";
            this.colName.MinimumWidth = 8;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colApartment
            // 
            this.colApartment.HeaderText = "Khoa";
            this.colApartment.MinimumWidth = 8;
            this.colApartment.Name = "colApartment";
            this.colApartment.ReadOnly = true;
            this.colApartment.Width = 150;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "Điểm TB";
            this.colScore.MinimumWidth = 8;
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 810);
            this.Controls.Add(this.studentInfoList);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNew_Menu;
        private System.Windows.Forms.ToolStripMenuItem exit_Menu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addNew;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.DataGridView studentInfoList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
    }
}


namespace Bai06
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startLocation = new System.Windows.Forms.TextBox();
            this.endLocation = new System.Windows.Forms.TextBox();
            this.startLocation_Button = new System.Windows.Forms.Button();
            this.endLocation_Button = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.copyButton);
            this.groupBox1.Controls.Add(this.endLocation_Button);
            this.groupBox1.Controls.Add(this.startLocation_Button);
            this.groupBox1.Controls.Add(this.endLocation);
            this.groupBox1.Controls.Add(this.startLocation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(39, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao chép tập tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường Dẫn Thư Mục Nguồn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đường Dẫn Thư Mục Đích";
            // 
            // startLocation
            // 
            this.startLocation.Location = new System.Drawing.Point(271, 36);
            this.startLocation.Name = "startLocation";
            this.startLocation.ReadOnly = true;
            this.startLocation.Size = new System.Drawing.Size(245, 26);
            this.startLocation.TabIndex = 2;
            // 
            // endLocation
            // 
            this.endLocation.Location = new System.Drawing.Point(271, 85);
            this.endLocation.Name = "endLocation";
            this.endLocation.ReadOnly = true;
            this.endLocation.Size = new System.Drawing.Size(245, 26);
            this.endLocation.TabIndex = 3;
            // 
            // startLocation_Button
            // 
            this.startLocation_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.startLocation_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startLocation_Button.Location = new System.Drawing.Point(549, 38);
            this.startLocation_Button.Name = "startLocation_Button";
            this.startLocation_Button.Size = new System.Drawing.Size(48, 24);
            this.startLocation_Button.TabIndex = 4;
            this.startLocation_Button.Text = "...";
            this.startLocation_Button.UseVisualStyleBackColor = false;
            this.startLocation_Button.Click += new System.EventHandler(this.startLocation_Button_Click);
            // 
            // endLocation_Button
            // 
            this.endLocation_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.endLocation_Button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.endLocation_Button.Location = new System.Drawing.Point(549, 91);
            this.endLocation_Button.Name = "endLocation_Button";
            this.endLocation_Button.Size = new System.Drawing.Size(48, 24);
            this.endLocation_Button.TabIndex = 5;
            this.endLocation_Button.Text = "...";
            this.endLocation_Button.UseVisualStyleBackColor = false;
            this.endLocation_Button.Click += new System.EventHandler(this.endLocation_Button_Click);
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.copyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.copyButton.Location = new System.Drawing.Point(157, 151);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(156, 37);
            this.copyButton.TabIndex = 6;
            this.copyButton.Text = "Sao Chép";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox2.Location = new System.Drawing.Point(39, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Green;
            this.progressBar.Location = new System.Drawing.Point(16, 38);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(622, 30);
            this.progressBar.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(135, 25);
            this.statusLabel.Text = "Đang sao chép:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sao Chép Tập Tin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button endLocation_Button;
        private System.Windows.Forms.Button startLocation_Button;
        private System.Windows.Forms.TextBox endLocation;
        private System.Windows.Forms.TextBox startLocation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Timer timer;
    }
}


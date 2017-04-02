namespace Take_a_Break_v2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.h_lbl = new System.Windows.Forms.Label();
            this.m_lbl = new System.Windows.Forms.Label();
            this.h2_lbl = new System.Windows.Forms.Label();
            this.m2_lbl = new System.Windows.Forms.Label();
            this.s2_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.s_lbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.finish_btn = new System.Windows.Forms.Button();
            this.alarm_img = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Take a Break v2";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time passed using the computer:";
            // 
            // h_lbl
            // 
            this.h_lbl.AutoSize = true;
            this.h_lbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.h_lbl.Location = new System.Drawing.Point(119, 43);
            this.h_lbl.Name = "h_lbl";
            this.h_lbl.Size = new System.Drawing.Size(49, 59);
            this.h_lbl.TabIndex = 1;
            this.h_lbl.Text = "0";
            // 
            // m_lbl
            // 
            this.m_lbl.AutoSize = true;
            this.m_lbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_lbl.Location = new System.Drawing.Point(225, 43);
            this.m_lbl.Name = "m_lbl";
            this.m_lbl.Size = new System.Drawing.Size(49, 59);
            this.m_lbl.TabIndex = 2;
            this.m_lbl.Text = "0";
            // 
            // h2_lbl
            // 
            this.h2_lbl.AutoSize = true;
            this.h2_lbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.h2_lbl.Location = new System.Drawing.Point(81, 43);
            this.h2_lbl.Name = "h2_lbl";
            this.h2_lbl.Size = new System.Drawing.Size(49, 59);
            this.h2_lbl.TabIndex = 3;
            this.h2_lbl.Text = "0";
            // 
            // m2_lbl
            // 
            this.m2_lbl.AutoSize = true;
            this.m2_lbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m2_lbl.Location = new System.Drawing.Point(187, 43);
            this.m2_lbl.Name = "m2_lbl";
            this.m2_lbl.Size = new System.Drawing.Size(49, 59);
            this.m2_lbl.TabIndex = 4;
            this.m2_lbl.Text = "0";
            // 
            // s2_lbl
            // 
            this.s2_lbl.AutoSize = true;
            this.s2_lbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.s2_lbl.Location = new System.Drawing.Point(287, 43);
            this.s2_lbl.Name = "s2_lbl";
            this.s2_lbl.Size = new System.Drawing.Size(49, 59);
            this.s2_lbl.TabIndex = 6;
            this.s2_lbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(160, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 59);
            this.label2.TabIndex = 7;
            this.label2.Tag = "";
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(259, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 59);
            this.label3.TabIndex = 8;
            this.label3.Tag = "";
            this.label3.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // s_lbl
            // 
            this.s_lbl.AutoSize = true;
            this.s_lbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.s_lbl.Location = new System.Drawing.Point(326, 43);
            this.s_lbl.Name = "s_lbl";
            this.s_lbl.Size = new System.Drawing.Size(49, 59);
            this.s_lbl.TabIndex = 5;
            this.s_lbl.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(419, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // finish_btn
            // 
            this.finish_btn.Location = new System.Drawing.Point(12, 135);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(419, 56);
            this.finish_btn.TabIndex = 12;
            this.finish_btn.Text = "Finish Break";
            this.finish_btn.UseVisualStyleBackColor = true;
            // 
            // alarm_img
            // 
            this.alarm_img.Image = global::Take_a_Break_v2.Properties.Resources.Zootopia_Party_Alert_emoticon;
            this.alarm_img.Location = new System.Drawing.Point(16, 43);
            this.alarm_img.Name = "alarm_img";
            this.alarm_img.Size = new System.Drawing.Size(59, 56);
            this.alarm_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alarm_img.TabIndex = 13;
            this.alarm_img.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Take_a_Break_v2.Properties.Resources.navigation_icon;
            this.pictureBox2.Location = new System.Drawing.Point(415, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Take_a_Break_v2.Properties.Resources.settings_icon;
            this.pictureBox1.Location = new System.Drawing.Point(415, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 203);
            this.Controls.Add(this.alarm_img);
            this.Controls.Add(this.finish_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s2_lbl);
            this.Controls.Add(this.s_lbl);
            this.Controls.Add(this.m2_lbl);
            this.Controls.Add(this.h2_lbl);
            this.Controls.Add(this.m_lbl);
            this.Controls.Add(this.h_lbl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 242);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 152);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take a Break v2 - Yuval Gal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alarm_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label h_lbl;
        private System.Windows.Forms.Label m_lbl;
        private System.Windows.Forms.Label h2_lbl;
        private System.Windows.Forms.Label m2_lbl;
        private System.Windows.Forms.Label s2_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label s_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button finish_btn;
        private System.Windows.Forms.PictureBox alarm_img;
    }
}
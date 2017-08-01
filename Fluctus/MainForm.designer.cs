namespace Fluctus
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
            this.aFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.counter = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.finish_btn = new System.Windows.Forms.Button();
            this.breaktime_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sep_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prog = new System.Windows.Forms.Timer(this.components);
            this.reverseprog = new System.Windows.Forms.Timer(this.components);
            this.time_lbl = new System.Windows.Forms.Label();
            this.adder = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.alarm_img = new System.Windows.Forms.PictureBox();
            this.skip_btn = new System.Windows.Forms.Button();
            this.gamemodechecker = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_img)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Fluctus";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aFKToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 136);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Fluctus.Properties.Resources.open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::Fluctus.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aFKToolStripMenuItem
            // 
            this.aFKToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.aFKToolStripMenuItem.CheckOnClick = true;
            this.aFKToolStripMenuItem.Image = global::Fluctus.Properties.Resources.off;
            this.aFKToolStripMenuItem.Name = "aFKToolStripMenuItem";
            this.aFKToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aFKToolStripMenuItem.Text = "AFK";
            this.aFKToolStripMenuItem.CheckedChanged += new System.EventHandler(this.aFKToolStripMenuItem_CheckedChanged);
            this.aFKToolStripMenuItem.Click += new System.EventHandler(this.aFKToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Fluctus.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Fluctus.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // counter
            // 
            this.counter.Enabled = true;
            this.counter.Interval = 1000;
            this.counter.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.finish_btn.Font = new System.Drawing.Font("Calibri Light", 15.75F);
            this.finish_btn.Location = new System.Drawing.Point(12, 135);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(335, 56);
            this.finish_btn.TabIndex = 12;
            this.finish_btn.Text = "Finish Break";
            this.finish_btn.UseVisualStyleBackColor = true;
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            // 
            // breaktime_lbl
            // 
            this.breaktime_lbl.AutoSize = true;
            this.breaktime_lbl.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.breaktime_lbl.Location = new System.Drawing.Point(68, 42);
            this.breaktime_lbl.Name = "breaktime_lbl";
            this.breaktime_lbl.Size = new System.Drawing.Size(49, 59);
            this.breaktime_lbl.TabIndex = 14;
            this.breaktime_lbl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14.25F);
            this.label2.Location = new System.Drawing.Point(205, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 46);
            this.label2.TabIndex = 15;
            this.label2.Tag = "";
            this.label2.Text = "Have a break for one minute,\r\n walk around you\'r workspace";
            // 
            // sep_lbl
            // 
            this.sep_lbl.AutoSize = true;
            this.sep_lbl.Location = new System.Drawing.Point(-2, 38);
            this.sep_lbl.Name = "sep_lbl";
            this.sep_lbl.Size = new System.Drawing.Size(496, 13);
            this.sep_lbl.TabIndex = 16;
            this.sep_lbl.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------------------------------" +
    "--";
            this.sep_lbl.Click += new System.EventHandler(this.sep_lbl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 30F);
            this.label3.Location = new System.Drawing.Point(277, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 49);
            this.label3.TabIndex = 17;
            this.label3.Text = "0";
            this.label3.Visible = false;
            // 
            // prog
            // 
            this.prog.Interval = 1000;
            this.prog.Tick += new System.EventHandler(this.prog_Tick);
            // 
            // reverseprog
            // 
            this.reverseprog.Tick += new System.EventHandler(this.reverseprog_Tick);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Calibri", 50F);
            this.time_lbl.Location = new System.Drawing.Point(184, 24);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(69, 82);
            this.time_lbl.TabIndex = 18;
            this.time_lbl.Text = "0";
            this.time_lbl.Visible = false;
            // 
            // adder
            // 
            this.adder.Tick += new System.EventHandler(this.adder_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 42);
            this.label4.TabIndex = 19;
            this.label4.Text = "oh";
            this.label4.Visible = false;
            // 
            // alarm_img
            // 
            this.alarm_img.Image = global::Fluctus.Properties.Resources.red;
            this.alarm_img.Location = new System.Drawing.Point(16, 43);
            this.alarm_img.Name = "alarm_img";
            this.alarm_img.Size = new System.Drawing.Size(59, 56);
            this.alarm_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alarm_img.TabIndex = 13;
            this.alarm_img.TabStop = false;
            // 
            // skip_btn
            // 
            this.skip_btn.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.skip_btn.Location = new System.Drawing.Point(354, 135);
            this.skip_btn.Name = "skip_btn";
            this.skip_btn.Size = new System.Drawing.Size(77, 56);
            this.skip_btn.TabIndex = 20;
            this.skip_btn.Text = "Skip";
            this.skip_btn.UseVisualStyleBackColor = true;
            this.skip_btn.Click += new System.EventHandler(this.skip_btn_Click);
            // 
            // gamemodechecker
            // 
            this.gamemodechecker.Interval = 1000;
            this.gamemodechecker.Tick += new System.EventHandler(this.gamemodechecker_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 203);
            this.Controls.Add(this.skip_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sep_lbl);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.alarm_img);
            this.Controls.Add(this.breaktime_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finish_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 242);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 152);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fluctus";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alarm_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer counter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button finish_btn;
        private System.Windows.Forms.PictureBox alarm_img;
        private System.Windows.Forms.Label breaktime_lbl;
        private System.Windows.Forms.Label sep_lbl;
        private System.Windows.Forms.Timer prog;
        private System.Windows.Forms.Timer reverseprog;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer adder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem aFKToolStripMenuItem;
        private System.Windows.Forms.Button skip_btn;
        private System.Windows.Forms.Timer gamemodechecker;
    }
}
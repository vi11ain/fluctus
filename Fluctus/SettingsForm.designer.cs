namespace Fluctus
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.update = new System.Windows.Forms.PictureBox();
            this.hebrew = new System.Windows.Forms.PictureBox();
            this.english = new System.Windows.Forms.PictureBox();
            this.forceontop = new System.Windows.Forms.CheckBox();
            this.forcecenter = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.note2enable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.note30enable = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.sleepmodeenable = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.savelistbtn = new System.Windows.Forms.Button();
            this.processlist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gamemodeenable = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hebrew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.english)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 263);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox3);
            this.tabPage2.Controls.Add(this.radioButton3);
            this.tabPage2.Controls.Add(this.richTextBox4);
            this.tabPage2.Controls.Add(this.radioButton4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 237);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alert Style";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.richTextBox3.Location = new System.Drawing.Point(3, 114);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(783, 67);
            this.richTextBox3.TabIndex = 7;
            this.richTextBox3.Text = "A relexing notification sound that goes on when you face a break.";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioButton3.Location = new System.Drawing.Point(3, 92);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(783, 22);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Notification Style";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // richTextBox4
            // 
            this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.richTextBox4.Location = new System.Drawing.Point(3, 25);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(783, 67);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "Sound will not play while break is starting.";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioButton4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.radioButton4.Location = new System.Drawing.Point(3, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(783, 22);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "No Sound";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 237);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Other";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.407407F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.59259F));
            this.tableLayoutPanel2.Controls.Add(this.update, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.hebrew, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.english, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.forceontop, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.forcecenter, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(783, 231);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // update
            // 
            this.update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.update.Image = global::Fluctus.Properties.Resources.update;
            this.update.Location = new System.Drawing.Point(3, 59);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(51, 23);
            this.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.update.TabIndex = 21;
            this.update.TabStop = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // hebrew
            // 
            this.hebrew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hebrew.Image = global::Fluctus.Properties.Resources.hebrew;
            this.hebrew.Location = new System.Drawing.Point(3, 3);
            this.hebrew.Name = "hebrew";
            this.hebrew.Size = new System.Drawing.Size(51, 22);
            this.hebrew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hebrew.TabIndex = 19;
            this.hebrew.TabStop = false;
            this.hebrew.Click += new System.EventHandler(this.hebrew_Click);
            // 
            // english
            // 
            this.english.Dock = System.Windows.Forms.DockStyle.Fill;
            this.english.Image = global::Fluctus.Properties.Resources.english;
            this.english.Location = new System.Drawing.Point(3, 31);
            this.english.Name = "english";
            this.english.Size = new System.Drawing.Size(51, 22);
            this.english.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.english.TabIndex = 20;
            this.english.TabStop = false;
            this.english.Click += new System.EventHandler(this.english_Click);
            // 
            // forceontop
            // 
            this.forceontop.AutoSize = true;
            this.forceontop.Location = new System.Drawing.Point(60, 3);
            this.forceontop.Name = "forceontop";
            this.forceontop.Size = new System.Drawing.Size(154, 17);
            this.forceontop.TabIndex = 18;
            this.forceontop.Text = "Force on-top while in break";
            this.forceontop.UseVisualStyleBackColor = true;
            this.forceontop.CheckedChanged += new System.EventHandler(this.forceontop_CheckedChanged);
            // 
            // forcecenter
            // 
            this.forcecenter.AutoSize = true;
            this.forcecenter.Location = new System.Drawing.Point(60, 31);
            this.forcecenter.Name = "forcecenter";
            this.forcecenter.Size = new System.Drawing.Size(154, 17);
            this.forcecenter.TabIndex = 25;
            this.forcecenter.Text = "Force center while in break";
            this.forcecenter.UseVisualStyleBackColor = true;
            this.forcecenter.CheckedChanged += new System.EventHandler(this.forcecenter_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(789, 237);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Notes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.note2enable, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.note30enable, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.619048F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.38095F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 231);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // note2enable
            // 
            this.note2enable.AutoSize = true;
            this.note2enable.Dock = System.Windows.Forms.DockStyle.Top;
            this.note2enable.Location = new System.Drawing.Point(394, 213);
            this.note2enable.Name = "note2enable";
            this.note2enable.Size = new System.Drawing.Size(386, 15);
            this.note2enable.TabIndex = 13;
            this.note2enable.Text = "Enabled?";
            this.note2enable.UseVisualStyleBackColor = true;
            this.note2enable.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(394, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Note every 2 hours break:";
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(394, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(386, 188);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Note every 30 minutes break:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 188);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // note30enable
            // 
            this.note30enable.AutoSize = true;
            this.note30enable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note30enable.Location = new System.Drawing.Point(3, 213);
            this.note30enable.Name = "note30enable";
            this.note30enable.Size = new System.Drawing.Size(385, 15);
            this.note30enable.TabIndex = 15;
            this.note30enable.Text = "Enabled?";
            this.note30enable.UseVisualStyleBackColor = true;
            this.note30enable.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.richTextBox5);
            this.tabPage5.Controls.Add(this.sleepmodeenable);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(789, 237);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sleep Mode";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBox5
            // 
            this.richTextBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox5.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.richTextBox5.Location = new System.Drawing.Point(3, 25);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(783, 68);
            this.richTextBox5.TabIndex = 15;
            this.richTextBox5.Text = "Every time you hop above a set time an alert will rise asking you to save you\'r w" +
    "ork, after you saved it the computer will shut down and if you will try to turn " +
    "it on it will shutdown again";
            // 
            // sleepmodeenable
            // 
            this.sleepmodeenable.AutoSize = true;
            this.sleepmodeenable.Dock = System.Windows.Forms.DockStyle.Top;
            this.sleepmodeenable.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.sleepmodeenable.Location = new System.Drawing.Point(3, 3);
            this.sleepmodeenable.Name = "sleepmodeenable";
            this.sleepmodeenable.Size = new System.Drawing.Size(783, 22);
            this.sleepmodeenable.TabIndex = 17;
            this.sleepmodeenable.Text = "Enabled?";
            this.sleepmodeenable.UseVisualStyleBackColor = true;
            this.sleepmodeenable.CheckedChanged += new System.EventHandler(this.sleepmodeenable_CheckedChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.savelistbtn);
            this.tabPage6.Controls.Add(this.processlist);
            this.tabPage6.Controls.Add(this.label1);
            this.tabPage6.Controls.Add(this.richTextBox1);
            this.tabPage6.Controls.Add(this.gamemodeenable);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(789, 237);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Game Mode";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // savelistbtn
            // 
            this.savelistbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.savelistbtn.Location = new System.Drawing.Point(3, 214);
            this.savelistbtn.Name = "savelistbtn";
            this.savelistbtn.Size = new System.Drawing.Size(783, 23);
            this.savelistbtn.TabIndex = 22;
            this.savelistbtn.Text = "Save list";
            this.savelistbtn.UseVisualStyleBackColor = true;
            this.savelistbtn.Click += new System.EventHandler(this.savelistbtn_Click);
            // 
            // processlist
            // 
            this.processlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.processlist.Location = new System.Drawing.Point(3, 106);
            this.processlist.Multiline = true;
            this.processlist.Name = "processlist";
            this.processlist.Size = new System.Drawing.Size(783, 108);
            this.processlist.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "List of games\' process name to look out for: (Seperate each process with a new li" +
    "ne)";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.richTextBox1.Location = new System.Drawing.Point(3, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(783, 68);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "Checks if games are running or not, if they do then Fluctus will automatically se" +
    "t it self to AFK and you will not receive notifications about breaks till you fi" +
    "nish gaming.";
            // 
            // gamemodeenable
            // 
            this.gamemodeenable.AutoSize = true;
            this.gamemodeenable.Dock = System.Windows.Forms.DockStyle.Top;
            this.gamemodeenable.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.gamemodeenable.Location = new System.Drawing.Point(3, 3);
            this.gamemodeenable.Name = "gamemodeenable";
            this.gamemodeenable.Size = new System.Drawing.Size(783, 22);
            this.gamemodeenable.TabIndex = 18;
            this.gamemodeenable.Text = "Enabled?";
            this.gamemodeenable.UseVisualStyleBackColor = true;
            this.gamemodeenable.CheckedChanged += new System.EventHandler(this.gamemodeenable_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(797, 263);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hebrew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.english)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox note2enable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox note30enable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox update;
        private System.Windows.Forms.CheckBox forceontop;
        private System.Windows.Forms.PictureBox hebrew;
        private System.Windows.Forms.PictureBox english;
        private System.Windows.Forms.CheckBox forcecenter;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.CheckBox sleepmodeenable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox gamemodeenable;
        private System.Windows.Forms.Button savelistbtn;
        private System.Windows.Forms.TextBox processlist;
    }
}
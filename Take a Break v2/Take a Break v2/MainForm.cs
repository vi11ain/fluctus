using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Take_a_Break_v2
{
    public partial class MainForm : Form
    {
        Stopwatch timer = new Stopwatch();
        Stopwatch break_Timer = new Stopwatch();
        Stopwatch var_Change;
        public static bool settings_Menu = true;
        public static bool settings_Alert = true;
        public static bool settings_Break = true;
        bool in_Break = false;
        public MainForm()
        {

            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void break_Check()
        {
            if (settings_Break)
            {
                //if (m2_lbl.Text == "0" && m_lbl.Text == "0" && h_lbl.Text != "0")
                if (s2_lbl.Text == "0" && s_lbl.Text == "0" && m_lbl.Text != "0")
                {
                    in_Break = true;
                    break_Refresh();
                    timer.Stop();
                    var_Change = break_Timer;
                    break_Timer.Start();
                }
            }else
            {
                
            }
        }

        private void break_Refresh()
        {
            Size startsize;
            if (!in_Break)
            {
                startsize = new Size(459, 152);
            }
            else
            {
                startsize = new Size(459, 242);
            }

            this.Size = startsize;
            this.MaximumSize = startsize;
            this.MinimumSize = startsize;
            progressBar1.Visible = in_Break;
            finish_btn.Visible = in_Break;
            alarm_img.Visible = in_Break;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var_Change = timer;
            timer.Start();
            break_Refresh();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s_lbl.Text = Convert.ToString((var_Change.Elapsed.Seconds) % 10);
            s2_lbl.Text = Convert.ToString((var_Change.Elapsed.Seconds) / 10);
            m_lbl.Text = Convert.ToString((var_Change.Elapsed.Minutes) % 10);
            m2_lbl.Text = Convert.ToString((var_Change.Elapsed.Minutes) / 10);
            h_lbl.Text = Convert.ToString((var_Change.Elapsed.Hours) % 10);
            h2_lbl.Text = Convert.ToString((var_Change.Elapsed.Hours) / 10);
            break_Check();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Visible = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Visible = true;
        }
    }
}

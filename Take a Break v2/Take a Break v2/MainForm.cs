using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using Take_a_Break_v2.Properties;
using Microsoft.Win32;
using System.Threading;
namespace Take_a_Break_v2
{
    public partial class MainForm : Form
    {
        Stopwatch timer = new Stopwatch();
        Stopwatch break_timer = new Stopwatch();
        TimeSpan onemin = new TimeSpan(0, 1, 0);
        TimeSpan tenmin = new TimeSpan(0, 10, 0);
        TimeSpan changeme = new TimeSpan(9, 9, 9);
        System.IO.Stream str;
        string m30;
        string m1;
        string displayme;
        public static bool refresh_lang4me = false;
        public static bool settings_Alert = true;
        bool in_Break = false;
        bool break_Type;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue("Take a Break v2", Application.ExecutablePath.ToString());
            timer.Start();
            break_Refresh();
            lang_Refresh();
            sep_lbl.AutoSize = false;
            sep_lbl.Height = 2;
            sep_lbl.BorderStyle = BorderStyle.Fixed3D;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
        }

        private void lang_Refresh()
        {
            this.Text = Settings.Default.Main_Title;
            label1.Text = Settings.Default.LabelText;
            m30 = Settings.Default.Message30;
            m1 = Settings.Default.Message1;
            finish_btn.Text = Settings.Default.ButtonText;
            openToolStripMenuItem.Text = Settings.Default.Open;
            aboutToolStripMenuItem.Text = Settings.Default.About;
            settingsToolStripMenuItem.Text = Settings.Default.Settings_contex;
            exitToolStripMenuItem.Text = Settings.Default.Exit;
            if (Settings.Default.Sound == "alarm")
            {
                str = Properties.Resources.Red_Alert_Alarm_Sound_Effect;
            }else
            {
                str = Properties.Resources.arpeggio;
            }
        }

        private void break_Refresh()
        {
            Size startsize;
            Font startfont;
            Point timelocation;
            if (!in_Break)
            {
                startsize = new Size(459, 140);
                startfont = time2_lbl.Font;
                timelocation = time2_lbl.Location;
            }
            else
            {
                startsize = new Size(459, 242);
                startfont = label3.Font;
                timelocation = label3.Location;
                if (!this.ShowInTaskbar)
                {
                    this.ShowInTaskbar = true;
                    this.WindowState = FormWindowState.Normal;
                }
            }

            this.Size = startsize;
            this.MaximumSize = startsize;
            this.MinimumSize = startsize;
            time_lbl.Font = startfont;
            time_lbl.Location = timelocation;
            time_lbl.Visible = true;
            sep_lbl.Visible = in_Break;
            label2.Text = displayme;
            label2.Visible = in_Break;
            this.ControlBox = !in_Break;
            breaktime_lbl.Visible = in_Break;
            progressBar1.Visible = in_Break;
            finish_btn.Visible = in_Break;
            alarm_img.Visible = in_Break;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.Visible||!this.ShowInTaskbar)
            {
                this.WindowState = FormWindowState.Normal;
                this.ShowInTaskbar = true;
                this.Show();
            }else
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (refresh_lang4me)
            {
                lang_Refresh();
                refresh_lang4me = false;
            }
            if (this.Visible == true)
            {
                if (in_Break)
                {
                    breaktime_lbl.Text = (changeme.ToString("mm\\:ss"));
                    if (break_Type)
                        changeme = onemin - break_timer.Elapsed;
                    else
                        changeme = tenmin - break_timer.Elapsed;
                }
                time_lbl.Text = (timer.Elapsed.ToString("hh\\:mm"));
            }
            if (timer.Elapsed.Minutes == 30 && progressBar1.Value == 0)
            {
                in_Break = true;
                break_Type = true;
                progressBar1.Maximum = 600;
                displayme = m30;
                break_Refresh();
                timer.Stop();
                break_timer.Start();
                prog.Start();
                this.Show();
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if (timer.Elapsed.Hours != 0 && timer.Elapsed.Hours % 2 != 0 && timer.Elapsed.Minutes == 0 && progressBar1.Value == 0)
            {
                in_Break = true;
                break_Type = true;
                progressBar1.Maximum = 600;
                displayme = m30;
                break_Refresh();
                timer.Stop();
                break_timer.Start();
                prog.Start();
                this.Show();
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if (timer.Elapsed.Hours != 0 && timer.Elapsed.Hours % 2 == 0 && timer.Elapsed.Minutes == 0 && progressBar1.Value == 0)
            {
                in_Break = true;
                break_Type = false;
                progressBar1.Maximum = 600;
                displayme = m1;
                break_Refresh();
                timer.Stop();
                break_timer.Start();
                prog.Start();
                this.Show();
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            //if (changeme.Minutes == 0 && changeme.Seconds == 0)
            //{
            if (in_Break)
            {
                if (progressBar1.Value == 600)
                    break_timer.Stop();
            }
            //}
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.Visible = true;
        }

        private void finish_btn_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value == 600)
            {
                in_Break = false;
                break_Refresh();
                timer.Start();
                break_timer.Stop();
                break_timer.Reset();
                reverseprog.Start();
            }
        }

        private void prog_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 600)
            {
                if (break_Type)
                {
                    progressBar1.Value += 10;
                }
                else
                {
                    progressBar1.Value += 1;
                }
            }
            else
            {
                prog.Stop();
            }
        }

        private void reverseprog_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
                progressBar1.Value -= 10;
            else
            {
                reverseprog.Stop();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }

        private void sep_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}

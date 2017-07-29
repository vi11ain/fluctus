using System.Globalization;
using System.Resources;
using Fluctus.Properties;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Fluctus
{
    public partial class SettingsForm : Form
    {
        public Action yourAction { get; set; }
        string update_Check;
        string update_No;
        string update_Yes;
        string update_Title;
        

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (!Settings.Default.isprocesslistset)
            {
                Settings.Default.processlist = new List<string>();
                Settings.Default.isprocesslistset = true;
                Settings.Default.Save();
            }
            refresh_Lang();
        }

        private void refresh_Lang()
        {
            this.Text = MainForm.res_man.GetString("contextSettings", MainForm.cul);
            tabPage2.Text = MainForm.res_man.GetString("TabName2", MainForm.cul);
            tabPage3.Text = MainForm.res_man.GetString("TabName3", MainForm.cul);
            //checkBox2.Text = MainForm.res_man.GetString("Mode2", MainForm.cul);
            //richTextBox1.Text = MainForm.res_man.GetString("Mode2d", MainForm.cul);
            radioButton4.Text = MainForm.res_man.GetString("Alert1", MainForm.cul);
            richTextBox4.Text = MainForm.res_man.GetString("Alert1d", MainForm.cul);
            radioButton3.Text = MainForm.res_man.GetString("Alert2", MainForm.cul);
            richTextBox3.Text = MainForm.res_man.GetString("Alert2d", MainForm.cul);
            update_Check = MainForm.res_man.GetString("updateCheck", MainForm.cul);
            update_No = MainForm.res_man.GetString("updateNo", MainForm.cul);
            update_Yes = MainForm.res_man.GetString("updateYes", MainForm.cul);
            update_Title = MainForm.res_man.GetString("updateTitle", MainForm.cul);
            if (Settings.Default.Sound == "alarm")
            {
                radioButton4.Select();
            }
            else
            {
                radioButton3.Select();
            }
            forceontop.Checked = Settings.Default.forceontop;
            forcecenter.Checked = Settings.Default.forcecenter;
            //powersaving.Checked = Settings.Default.savepower;
            note30enable.Checked = Settings.Default.note30;
            note2enable.Checked = Settings.Default.note2;
            textBox1.Text = Settings.Default.note30msg;
            textBox2.Text = Settings.Default.note2msg;
            gamemodeenable.Checked = Settings.Default.gamemode;
            processlist.Text = string.Join(Environment.NewLine, Settings.Default.processlist.ToArray());
        }

        private void english_Click(object sender, EventArgs e)
        {
            MainForm.cul = new CultureInfo("en");
            Settings.Default.lang = "en";
            Settings.Default.Save();
            refresh_Lang();
            yourAction?.Invoke();
        }

        private void update_Click(object sender, EventArgs e)
        {
            MessageBox.Show(update_Check, update_Title);
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load("https://github.com/jugges/Take-a-Break-v2/releases");
            var xpath = "/html[1]/body[1]/div[4]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/ul[1]/li[1]/a[1]/span[1]";
            var span = doc.DocumentNode.SelectSingleNode(xpath);
            var title = span.InnerText;
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;
            //MessageBox.Show(version);
            if (title == version)
            {
                MessageBox.Show(update_No, update_Title);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(update_Yes, update_Title, MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dialogResult)
                {
                    System.Diagnostics.Process.Start("https://github.com/jugges/Take-a-Break-v2/releases");
                }
            }
        }

        private void hebrew_Click(object sender, EventArgs e)
        {
            MainForm.cul = new CultureInfo("he");
            Settings.Default.lang = "he";
            Settings.Default.Save();
            refresh_Lang();
            yourAction?.Invoke();
        }

        private void forceontop_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.forceontop = forceontop.Checked;
            Settings.Default.Save();
            //yourAction?.Invoke();
        }

        private void powersaving_CheckedChanged(object sender, EventArgs e)
        {
            //Settings.Default.savepower = powersaving.Checked;
            //Settings.Default.Save();
            //yourAction?.Invoke();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.note30 = note30enable.Checked;
            Settings.Default.Save();
            //yourAction?.Invoke();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.note2 = note2enable.Checked;
            Settings.Default.Save();
            //yourAction?.Invoke();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.note2msg = textBox2.Text;
            Settings.Default.Save();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.note30msg = textBox1.Text;
            Settings.Default.Save();
        }

        private void forcecenter_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.forcecenter = forcecenter.Checked;
            Settings.Default.Save();
            //yourAction?.Invoke();
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            Settings.Default.Sound = "nosound";
            Settings.Default.Save();
            yourAction?.Invoke();
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            Settings.Default.Sound = "relax";
            Settings.Default.Save();
            yourAction?.Invoke();
        }

        private void savelistbtn_Click(object sender, EventArgs e)
        {
            if (!processlist.Text.Equals(""))
            {
                foreach (var myString in processlist.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    Settings.Default.processlist = new List<string>();
                    Settings.Default.processlist.Add(myString);
                    Settings.Default.Save();
                    //yourAction?.Invoke();
                }
            }
            else
            {
                gamemodeenable.Checked = false;
                Settings.Default.gamemode = false;
                yourAction?.Invoke();
            }
        }

        private void gamemodeenable_CheckedChanged(object sender, EventArgs e)
        {
            if (gamemodeenable.Checked)
            {
                if (Settings.Default.processlist.Count != 0)
                {
                    Settings.Default.gamemode = gamemodeenable.Checked;
                    Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Hi hi hi! You need to have a list of processes to look out for before enabling game mode! create a list and then hit the save button.");
                    gamemodeenable.Checked = false;
                }
            }
            else
            {
                Settings.Default.gamemode = false;
            }
            yourAction?.Invoke();
        }

        private void sleepmodeenable_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Take_a_Break_v2.Properties;

namespace Take_a_Break_v2
{
    public partial class SettingsForm : Form
    {

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            refresh_Lang();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void refresh_Lang()
        {
            this.Text = Settings.Default.Settings_Title;
            label1.Text = Settings.Default.TabName1;
            groupBox1.Text = Settings.Default.TabName1;
            label2.Text = Settings.Default.TabName2;
            groupBox2.Text = Settings.Default.TabName2;
            checkBox1.Text = Settings.Default.Mode1;
            richTextBox2.Text = Settings.Default.Mode1d;
            checkBox2.Text = Settings.Default.Mode2;
            richTextBox1.Text = Settings.Default.Mode2d;
            radioButton4.Text = Settings.Default.Alert1;
            richTextBox4.Text = Settings.Default.Alert1d;
            radioButton3.Text = Settings.Default.Alert2;
            richTextBox3.Text = Settings.Default.Alert2d;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Settings.Default.Main_Title = "Take a Break v2 - Yuval Gal";
            Settings.Default.Message30 = "Have a break for one minute,\rwalk around you'r workspace";
            Settings.Default.Alert1 = "Alarm Style";
            Settings.Default.Alert1d = "A repetitive alarm sound that goes on till you end you'r break.";
            Settings.Default.Alert2 = "Notification Style";
            Settings.Default.Alert2d = "A relexing notification sound that goes on when you face a break.";
            Settings.Default.ButtonText = "Finish Break";
            Settings.Default.LabelText = "Time passed using the computer:";
            Settings.Default.Message1 = "Have a break for 10 minutes";
            Settings.Default.Mode1 = "Sleep Mode";
            Settings.Default.Mode1d = "Every time you hop above 12:00 pm an alert will rise asking you to save you'r work, after you saved it the computer will shut down and if you will try to turn it on it will shutdown again";
            Settings.Default.Mode2 = "Gaming Mode";
            Settings.Default.Mode2d = "Showing the breaks above the video game's full screen in the left upper corner to let you know that you should take a break after this match.";
            Settings.Default.Settings_Title = "Settings";
            Settings.Default.TabName1 = "Modes";
            Settings.Default.TabName2 = "Alert Types";
            Settings.Default.Open = "Open";
            Settings.Default.Settings_contex = "Settings";
            Settings.Default.About = "About";
            Settings.Default.Exit = "Exit";
            Settings.Default.Save();
            refresh_Lang();
            MainForm.refresh_lang4me=true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Settings.Default.Main_Title = "קח הפסקה 2 - יובל גל";
            Settings.Default.Message30 = "קח הפסקה לדקה,\rהתהלך בסביבתך";
            Settings.Default.Alert1 = "סגנון אזעקה";
            Settings.Default.Alert1d = "אזעקה שחוזרת על עצמה עד שתסיים את ההפסקה שלך.";
            Settings.Default.Alert2 = "סגנון התרעה";
            Settings.Default.Alert2d = "צליל התרעה מרגיע שמופעל כשאתה מתחיל את ההפסקה.";
            Settings.Default.ButtonText = "סיים הפסקה";
            Settings.Default.LabelText = "זמן שעבר בשימוש במחשב:";
            Settings.Default.Message1 = "קח הפסקה ל10 דקות";
            Settings.Default.Mode1 = "מצב שינה";
            Settings.Default.Mode1d = "Every time you hop above 12:00 pm an alert will rise asking you to save you'r work, after you saved it the computer will shut down and if you will try to turn it on it will shutdown again";
            Settings.Default.Mode2 = "מצב משחק";
            Settings.Default.Mode2d = "Showing the breaks above the video game's full screen in the left upper corner to let you know that you should take a break after this match.";
            Settings.Default.Settings_Title = "הגדרות";
            Settings.Default.TabName1 = "מצבים";
            Settings.Default.TabName2 = "סוגי התרעות";
            Settings.Default.Open = "פתח";
            Settings.Default.Settings_contex = "הגדרות";
            Settings.Default.About = "לגבי";
            Settings.Default.Exit = "יציאה";
            Settings.Default.Save();
            refresh_Lang();
            MainForm.refresh_lang4me = true;
        }
    }
}

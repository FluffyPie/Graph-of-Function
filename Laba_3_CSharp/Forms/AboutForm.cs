using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_3_CSharp.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            
            if (Properties.Settings.Default.Language == "Russian")
                CloseButton.Text = "Закрыть";
            else
                CloseButton.Text = "Close";
            if (Properties.Settings.Default.Theme == "Dark")
                SetDarkTheme();
            if (Properties.Settings.Default.Theme == "Custom")
                SetCustomTheme();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void SetDarkTheme()
        {
            TopPanel.BackColor = Color.FromArgb(32, 34, 37);
            this.BackColor = Color.FromArgb(54, 57, 63);
            MainLabel.ForeColor = Color.Transparent;
            MainLabel.ForeColor = Color.White;
            CloseButton.BackColor = Color.FromArgb(32, 34, 37);
            CloseButton.ForeColor = Color.White;
        }
        void SetCustomTheme()
        {
            TopPanel.BackColor = Properties.Settings.Default.TopPanelColor;
            this.BackColor = Properties.Settings.Default.MainWindowColor;
            MainLabel.ForeColor = Properties.Settings.Default.TextColor; ;
            CloseButton.BackColor = Properties.Settings.Default.ButtonColor; ;
            CloseButton.ForeColor = Properties.Settings.Default.TextColor;
        }
    }
}

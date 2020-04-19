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
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
            CustomTopPanel.BackColor = Properties.Settings.Default.TopPanelColor;
            CustomMainWindow.BackColor = Properties.Settings.Default.MainWindowColor;
            if (Properties.Settings.Default.Language == "Russian")
                LanguageComboBox.SelectedIndex = 0;
            else
                LanguageComboBox.SelectedIndex = 1;
            if (Properties.Settings.Default.TooltipActive == "Yes")
                TooltipSettings.Checked = true;
            else
                TooltipSettings.Checked = false;
            if (Properties.Settings.Default.Theme == "Light")
                LightThemeRadioButton.Checked = true;
            else if (Properties.Settings.Default.Theme == "Dark")
            {
                DarkThemeRadioButton.Checked = true;
                //SetDarkTheme();
            }
            else 
            {
                CustomThemeRadioButton.Checked = true;
                //SetCustomTheme();
            }

        }

        void SetLightTheme()
        {
            

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            if (Properties.Settings.Default.Language == "Russian")
                LanguageComboBox.SelectedIndex = 0;
            else
                LanguageComboBox.SelectedIndex = 1;
            if (Properties.Settings.Default.TooltipActive == "Yes")
                TooltipSettings.Checked = true;
            else
                TooltipSettings.Checked = false;
            if (Properties.Settings.Default.Theme == "Dark")
                DarkThemeRadioButton.Checked = true;
            else if (Properties.Settings.Default.Theme == "Light")
                LightThemeRadioButton.Checked = true;
            else
                CustomThemeRadioButton.Checked = true;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void TooltipChanged(object sender, EventArgs e)
        {
            if (TooltipSettings.Checked == true)
                Properties.Settings.Default.TooltipActive = "Yes";
            else
                Properties.Settings.Default.TooltipActive = "No";
        }

        private void LanguageChanged(object sender, EventArgs e)
        {
            if (LanguageComboBox.SelectedIndex == 0)
                Properties.Settings.Default.Language = "Russian";
            else
                Properties.Settings.Default.Language = "English";
        }

        private void ThemeChangedDark(object sender, EventArgs e)
        {
            if (DarkThemeRadioButton.Checked == true)
                Properties.Settings.Default.Theme = "Dark";
            else if (LightThemeRadioButton.Checked == true)
                Properties.Settings.Default.Theme = "Light";
            else
                Properties.Settings.Default.Theme = "Custom";
        }

        private void LightChanged(object sender, EventArgs e)
        {
            if (DarkThemeRadioButton.Checked == true)
                Properties.Settings.Default.Theme = "Dark";
            else if (LightThemeRadioButton.Checked == true)
                Properties.Settings.Default.Theme = "Light";
            else
                Properties.Settings.Default.Theme = "Custom";
        }

        private void CustomThemeChanged(object sender, EventArgs e)
        {
            if (DarkThemeRadioButton.Checked == true)
                Properties.Settings.Default.Theme = "Dark";
            else if (LightThemeRadioButton.Checked == true)
                Properties.Settings.Default.Theme = "Light";
            else
                Properties.Settings.Default.Theme = "Custom";
        }
        Forms.CustomThemeForm SetCustomTheme = new Forms.CustomThemeForm();
        private void ShowSetCustomColor_Click(object sender, EventArgs e)
        {
            SetCustomTheme.ShowDialog();
        }
    }

}

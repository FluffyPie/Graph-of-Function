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
                SetDarkTheme();
            }
            else 
            {
                CustomThemeRadioButton.Checked = true;
                SetCustomTheme();
            }
            if (Properties.Settings.Default.Language == "Russian")
                SetRussianLanguage();
        }
        
        void SetDarkTheme()
        { 
            this.TopPanel.BackColor = Color.FromArgb(32, 34, 37);
            this.BackColor = Color.FromArgb(54, 57, 63);
            this.LanguageLabel.ForeColor = Color.White;
            this.ThemeLabel.ForeColor = Color.White;
            this.DarkThemeRadioButton.ForeColor = Color.White;
            this.LightThemeRadioButton.ForeColor = Color.White;
            this.CustomThemeRadioButton.ForeColor = Color.White;
            this.ShowSetCustomColor.ForeColor = Color.White;
            this.ShowSetCustomColor.BackColor = Color.FromArgb(32, 34, 37);
            this.TooltipLabel.ForeColor = Color.White;
            this.TooltipSettings.ForeColor = Color.White;
            this.CancelButton.ForeColor = Color.White;
            this.CancelButton.BackColor = Color.FromArgb(32, 34, 37);
            this.SaveButton.ForeColor = Color.White;
            this.SaveButton.BackColor = Color.FromArgb(32, 34, 37);
        }
        void SetCustomTheme()
        {
            this.TopPanel.BackColor = Properties.Settings.Default.TopPanelColor;
            this.BackColor = Properties.Settings.Default.MainWindowColor;
            this.LanguageLabel.ForeColor = Properties.Settings.Default.TextColor;
            this.ThemeLabel.ForeColor = Properties.Settings.Default.TextColor;
            this.DarkThemeRadioButton.ForeColor = Properties.Settings.Default.TextColor;
            this.LightThemeRadioButton.ForeColor = Properties.Settings.Default.TextColor;
            this.CustomThemeRadioButton.ForeColor = Properties.Settings.Default.TextColor;
            this.ShowSetCustomColor.ForeColor = Properties.Settings.Default.TextColor;
            this.ShowSetCustomColor.BackColor = Properties.Settings.Default.ButtonColor;
            this.TooltipLabel.ForeColor = Properties.Settings.Default.TextColor;
            this.TooltipSettings.ForeColor = Properties.Settings.Default.TextColor;
            this.CancelButton.ForeColor = Properties.Settings.Default.TextColor;
            this.CancelButton.BackColor = Properties.Settings.Default.ButtonColor;
            this.SaveButton.ForeColor = Properties.Settings.Default.TextColor;
            this.SaveButton.BackColor = Properties.Settings.Default.ButtonColor;

        }
        void SetRussianLanguage()
        {
            this.LanguageLabel.Text = "Выберите язык";
            this.CustomThemeRadioButton.Text = "Кастомная тема";
            this.LightThemeRadioButton.Text = "Светлая тема";
            this.DarkThemeRadioButton.Text = "Темная тема";
            this.ShowSetCustomColor.Text = "Настроить свои цвета";
            this.TooltipLabel.Text = "Всплывающие подсказки";
            if (TooltipSettings.Checked == true)
                this.TooltipSettings.Text = "Активны";
            else
                this.TooltipSettings.Text = "Не активны";
            this.ThemeLabel.Text = "Выберите тему";
            this.CancelButton.Text = "Отменить";
            this.SaveButton.Text = "Сохранить";

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
            if (LanguageComboBox.SelectedIndex == 0)
                MessageBox.Show("Для применения выбранных настроек требуется перезапуск программы", "Внимание");
            if (LanguageComboBox.SelectedIndex == 1)
                MessageBox.Show("You must restart the app to apply the settings", "Warning");
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void TooltipChanged(object sender, EventArgs e)
        {
            if (TooltipSettings.Checked == true)
                Properties.Settings.Default.TooltipActive = "Yes";
            else
                Properties.Settings.Default.TooltipActive = "No";
            if (TooltipSettings.Checked == true)
                if (Properties.Settings.Default.Language == "Russian")
                    this.TooltipSettings.Text = "Активны";
                else
                    this.TooltipSettings.Text = "Active";
            else
                if (Properties.Settings.Default.Language == "Russian")
                    this.TooltipSettings.Text = "Не активны";
                else
                    this.TooltipSettings.Text = "Deactive";
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

        Forms.CustomThemeForm CustomTheme = new Forms.CustomThemeForm();
        private void ShowSetCustomColor_Click(object sender, EventArgs e)
        {
            CustomTheme.ShowDialog();
        }
    }

}

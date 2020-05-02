namespace Laba_3_CSharp.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.LightThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.DarkThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CustomMainWindow = new System.Windows.Forms.PictureBox();
            this.CustomTopPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ShowSetCustomColor = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CustomThemeRadioButton = new System.Windows.Forms.RadioButton();
            this.TooltipSettings = new System.Windows.Forms.CheckBox();
            this.ThemeLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LanguageComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.TooltipLabel = new System.Windows.Forms.Label();
            this.CancelButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SaveButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.DragControlMainWindow = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.DragControlTopPanel = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomMainWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LightThemeRadioButton
            // 
            this.LightThemeRadioButton.AutoSize = true;
            this.LightThemeRadioButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LightThemeRadioButton.Location = new System.Drawing.Point(173, 117);
            this.LightThemeRadioButton.Name = "LightThemeRadioButton";
            this.LightThemeRadioButton.Size = new System.Drawing.Size(84, 17);
            this.LightThemeRadioButton.TabIndex = 3;
            this.LightThemeRadioButton.Text = "Light Theme";
            this.LightThemeRadioButton.UseVisualStyleBackColor = true;
            this.LightThemeRadioButton.CheckedChanged += new System.EventHandler(this.LightChanged);
            // 
            // DarkThemeRadioButton
            // 
            this.DarkThemeRadioButton.AutoSize = true;
            this.DarkThemeRadioButton.Checked = true;
            this.DarkThemeRadioButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DarkThemeRadioButton.Location = new System.Drawing.Point(45, 117);
            this.DarkThemeRadioButton.Name = "DarkThemeRadioButton";
            this.DarkThemeRadioButton.Size = new System.Drawing.Size(84, 17);
            this.DarkThemeRadioButton.TabIndex = 2;
            this.DarkThemeRadioButton.TabStop = true;
            this.DarkThemeRadioButton.Text = "Dark Theme";
            this.DarkThemeRadioButton.UseVisualStyleBackColor = true;
            this.DarkThemeRadioButton.CheckedChanged += new System.EventHandler(this.ThemeChangedDark);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(164, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CustomMainWindow);
            this.panel1.Controls.Add(this.CustomTopPanel);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.ShowSetCustomColor);
            this.panel1.Controls.Add(this.CustomThemeRadioButton);
            this.panel1.Controls.Add(this.LightThemeRadioButton);
            this.panel1.Controls.Add(this.DarkThemeRadioButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(54, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 180);
            this.panel1.TabIndex = 20;
            // 
            // CustomMainWindow
            // 
            this.CustomMainWindow.Location = new System.Drawing.Point(320, 55);
            this.CustomMainWindow.Name = "CustomMainWindow";
            this.CustomMainWindow.Size = new System.Drawing.Size(54, 41);
            this.CustomMainWindow.TabIndex = 23;
            this.CustomMainWindow.TabStop = false;
            // 
            // CustomTopPanel
            // 
            this.CustomTopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.CustomTopPanel.Location = new System.Drawing.Point(302, 34);
            this.CustomTopPanel.Name = "CustomTopPanel";
            this.CustomTopPanel.Size = new System.Drawing.Size(60, 40);
            this.CustomTopPanel.TabIndex = 7;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(292, 21);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(94, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // ShowSetCustomColor
            // 
            this.ShowSetCustomColor.AnimationHoverSpeed = 0.07F;
            this.ShowSetCustomColor.AnimationSpeed = 0.03F;
            this.ShowSetCustomColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowSetCustomColor.BaseColor = System.Drawing.Color.Transparent;
            this.ShowSetCustomColor.BorderColor = System.Drawing.Color.Black;
            this.ShowSetCustomColor.CheckedBaseColor = System.Drawing.Color.Gray;
            this.ShowSetCustomColor.CheckedBorderColor = System.Drawing.Color.Black;
            this.ShowSetCustomColor.CheckedForeColor = System.Drawing.Color.Black;
            this.ShowSetCustomColor.CheckedImage = null;
            this.ShowSetCustomColor.CheckedLineColor = System.Drawing.Color.DimGray;
            this.ShowSetCustomColor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ShowSetCustomColor.FocusedColor = System.Drawing.Color.Empty;
            this.ShowSetCustomColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ShowSetCustomColor.ForeColor = System.Drawing.Color.Black;
            this.ShowSetCustomColor.Image = null;
            this.ShowSetCustomColor.ImageSize = new System.Drawing.Size(20, 20);
            this.ShowSetCustomColor.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ShowSetCustomColor.Location = new System.Drawing.Point(151, 140);
            this.ShowSetCustomColor.Name = "ShowSetCustomColor";
            this.ShowSetCustomColor.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.ShowSetCustomColor.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ShowSetCustomColor.OnHoverForeColor = System.Drawing.Color.White;
            this.ShowSetCustomColor.OnHoverImage = null;
            this.ShowSetCustomColor.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.ShowSetCustomColor.OnPressedColor = System.Drawing.Color.Black;
            this.ShowSetCustomColor.Size = new System.Drawing.Size(123, 34);
            this.ShowSetCustomColor.TabIndex = 5;
            this.ShowSetCustomColor.Text = "Set Custom Colors";
            this.ShowSetCustomColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShowSetCustomColor.Click += new System.EventHandler(this.ShowSetCustomColor_Click);
            // 
            // CustomThemeRadioButton
            // 
            this.CustomThemeRadioButton.AutoSize = true;
            this.CustomThemeRadioButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CustomThemeRadioButton.Location = new System.Drawing.Point(292, 117);
            this.CustomThemeRadioButton.Name = "CustomThemeRadioButton";
            this.CustomThemeRadioButton.Size = new System.Drawing.Size(96, 17);
            this.CustomThemeRadioButton.TabIndex = 4;
            this.CustomThemeRadioButton.Text = "Custom Theme";
            this.CustomThemeRadioButton.UseVisualStyleBackColor = true;
            this.CustomThemeRadioButton.CheckedChanged += new System.EventHandler(this.CustomThemeChanged);
            // 
            // TooltipSettings
            // 
            this.TooltipSettings.Checked = true;
            this.TooltipSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TooltipSettings.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TooltipSettings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TooltipSettings.Location = new System.Drawing.Point(218, 393);
            this.TooltipSettings.Name = "TooltipSettings";
            this.TooltipSettings.Size = new System.Drawing.Size(229, 36);
            this.TooltipSettings.TabIndex = 19;
            this.TooltipSettings.Text = "Active";
            this.TooltipSettings.UseVisualStyleBackColor = true;
            this.TooltipSettings.CheckedChanged += new System.EventHandler(this.TooltipChanged);
            // 
            // ThemeLabel
            // 
            this.ThemeLabel.AutoSize = true;
            this.ThemeLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThemeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ThemeLabel.Location = new System.Drawing.Point(146, 130);
            this.ThemeLabel.Name = "ThemeLabel";
            this.ThemeLabel.Size = new System.Drawing.Size(241, 21);
            this.ThemeLabel.TabIndex = 16;
            this.ThemeLabel.Text = "Choose a color scheme";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(514, 31);
            this.TopPanel.TabIndex = 13;
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.BackColor = System.Drawing.Color.Transparent;
            this.LanguageComboBox.BaseColor = System.Drawing.Color.White;
            this.LanguageComboBox.BorderColor = System.Drawing.Color.Silver;
            this.LanguageComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.LanguageComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LanguageComboBox.ForeColor = System.Drawing.Color.Black;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Items.AddRange(new object[] {
            "Русский",
            "English"});
            this.LanguageComboBox.Location = new System.Drawing.Point(171, 81);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LanguageComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.LanguageComboBox.Size = new System.Drawing.Size(194, 26);
            this.LanguageComboBox.TabIndex = 15;
            this.LanguageComboBox.SelectedValueChanged += new System.EventHandler(this.LanguageChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.BackColor = System.Drawing.Color.Transparent;
            this.LanguageLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LanguageLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LanguageLabel.Location = new System.Drawing.Point(178, 47);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(175, 21);
            this.LanguageLabel.TabIndex = 14;
            this.LanguageLabel.Text = "Choose Language";
            // 
            // TooltipLabel
            // 
            this.TooltipLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TooltipLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TooltipLabel.Location = new System.Drawing.Point(118, 369);
            this.TooltipLabel.Name = "TooltipLabel";
            this.TooltipLabel.Size = new System.Drawing.Size(283, 21);
            this.TooltipLabel.TabIndex = 17;
            this.TooltipLabel.Text = "Tooltips";
            this.TooltipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelButton
            // 
            this.CancelButton.AnimationHoverSpeed = 0.07F;
            this.CancelButton.AnimationSpeed = 0.03F;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.BaseColor = System.Drawing.Color.Transparent;
            this.CancelButton.BorderColor = System.Drawing.Color.Black;
            this.CancelButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CancelButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CancelButton.CheckedForeColor = System.Drawing.Color.White;
            this.CancelButton.CheckedImage = null;
            this.CancelButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CancelButton.FocusedColor = System.Drawing.Color.Empty;
            this.CancelButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Image = null;
            this.CancelButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CancelButton.LineColor = System.Drawing.Color.Transparent;
            this.CancelButton.Location = new System.Drawing.Point(70, 440);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.CancelButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelButton.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.CancelButton.OnHoverImage = null;
            this.CancelButton.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.CancelButton.OnPressedColor = System.Drawing.Color.Black;
            this.CancelButton.Size = new System.Drawing.Size(123, 42);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AnimationHoverSpeed = 0.07F;
            this.SaveButton.AnimationSpeed = 0.03F;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BaseColor = System.Drawing.Color.Transparent;
            this.SaveButton.BorderColor = System.Drawing.Color.Black;
            this.SaveButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SaveButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SaveButton.CheckedForeColor = System.Drawing.Color.White;
            this.SaveButton.CheckedImage = null;
            this.SaveButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveButton.FocusedColor = System.Drawing.Color.Empty;
            this.SaveButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Image = null;
            this.SaveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SaveButton.LineColor = System.Drawing.Color.Transparent;
            this.SaveButton.Location = new System.Drawing.Point(324, 440);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SaveButton.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.SaveButton.OnHoverImage = null;
            this.SaveButton.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.SaveButton.OnPressedColor = System.Drawing.Color.Black;
            this.SaveButton.Size = new System.Drawing.Size(123, 42);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DragControlMainWindow
            // 
            this.DragControlMainWindow.TargetControl = this;
            // 
            // DragControlTopPanel
            // 
            this.DragControlTopPanel.TargetControl = this.TopPanel;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 509);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TooltipSettings);
            this.Controls.Add(this.ThemeLabel);
            this.Controls.Add(this.LanguageComboBox);
            this.Controls.Add(this.LanguageLabel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.TooltipLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomMainWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

     
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton LightThemeRadioButton;
        private System.Windows.Forms.RadioButton DarkThemeRadioButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox TooltipSettings;
        private System.Windows.Forms.Label ThemeLabel;
        private Guna.UI.WinForms.GunaComboBox LanguageComboBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TooltipLabel;
        private System.Windows.Forms.RadioButton CustomThemeRadioButton;
        private Guna.UI.WinForms.GunaAdvenceButton CancelButton;
        private Guna.UI.WinForms.GunaAdvenceButton SaveButton;
        private Guna.UI.WinForms.GunaAdvenceButton ShowSetCustomColor;
        private System.Windows.Forms.Panel CustomTopPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox CustomMainWindow;
        private Guna.UI.WinForms.GunaDragControl DragControlMainWindow;
        private Guna.UI.WinForms.GunaDragControl DragControlTopPanel;
    }
}
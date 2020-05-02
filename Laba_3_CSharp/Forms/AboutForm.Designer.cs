namespace Laba_3_CSharp.Forms
{
    partial class AboutForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MainLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TopPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.MainPanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Silver;
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(452, 44);
            this.TopPanel.TabIndex = 21;
            // 
            // MainLabel
            // 
            this.MainLabel.BackColor = System.Drawing.Color.Transparent;
            this.MainLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainLabel.Location = new System.Drawing.Point(69, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(319, 341);
            this.MainLabel.TabIndex = 23;
            this.MainLabel.Text = "Лабораторная работа №3\r\nЗнакомство с WinForms\r\nНаписать программу для построения " +
    "графика Циклоиды\r\nСтудент группы 484\r\nКлюев Богдан Сергеевич\r\n2020 год";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(-3, -13);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TopPanelDragControl
            // 
            this.TopPanelDragControl.TargetControl = this.TopPanel;
            // 
            // MainPanelDragControl
            // 
            this.MainPanelDragControl.TargetControl = this;
            // 
            // CloseButton
            // 
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BaseColor = System.Drawing.Color.Transparent;
            this.CloseButton.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedBaseColor = System.Drawing.SystemColors.GrayText;
            this.CloseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CloseButton.CheckedImage = null;
            this.CloseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Image = null;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.Location = new System.Drawing.Point(138, 298);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Size = new System.Drawing.Size(180, 42);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 369);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private Guna.UI.WinForms.GunaDragControl TopPanelDragControl;
        private Guna.UI.WinForms.GunaDragControl MainPanelDragControl;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
    }
}
namespace Laba_3_CSharp.Forms
{
    partial class CustomThemeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainWindow = new Guna.UI.WinForms.GunaElipse(this.components);
            this.CustomThemeMainWindow = new System.Windows.Forms.Panel();
            this.CustomWindowTopPanel = new System.Windows.Forms.Panel();
            this.CustomThemeButton = new System.Windows.Forms.Button();
            this.CustomThemeLabel = new System.Windows.Forms.Label();
            this.MainChartWindow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainWindowPanel = new System.Windows.Forms.Panel();
            this.TopPanelColorButton = new System.Windows.Forms.Button();
            this.TextColorButton = new System.Windows.Forms.Button();
            this.GraphOneColorButton = new System.Windows.Forms.Button();
            this.GraphTwoColorButton = new System.Windows.Forms.Button();
            this.GraphThreeColorButton = new System.Windows.Forms.Button();
            this.GraphFourColorButton = new System.Windows.Forms.Button();
            this.ButtonColorButton = new System.Windows.Forms.Button();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.DragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.FifthGraphColorButton = new System.Windows.Forms.Button();
            this.MainWindowColorButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CustomThemeMainWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChartWindow)).BeginInit();
            this.MainWindowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindow
            // 
            this.MainWindow.TargetControl = this;
            // 
            // CustomThemeMainWindow
            // 
            this.CustomThemeMainWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomThemeMainWindow.Controls.Add(this.MainChartWindow);
            this.CustomThemeMainWindow.Controls.Add(this.CustomThemeLabel);
            this.CustomThemeMainWindow.Controls.Add(this.CustomThemeButton);
            this.CustomThemeMainWindow.Controls.Add(this.CustomWindowTopPanel);
            this.CustomThemeMainWindow.Location = new System.Drawing.Point(11, 67);
            this.CustomThemeMainWindow.Name = "CustomThemeMainWindow";
            this.CustomThemeMainWindow.Size = new System.Drawing.Size(267, 366);
            this.CustomThemeMainWindow.TabIndex = 0;
            // 
            // CustomWindowTopPanel
            // 
            this.CustomWindowTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomWindowTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomWindowTopPanel.Location = new System.Drawing.Point(0, 0);
            this.CustomWindowTopPanel.Name = "CustomWindowTopPanel";
            this.CustomWindowTopPanel.Size = new System.Drawing.Size(265, 54);
            this.CustomWindowTopPanel.TabIndex = 1;
            // 
            // CustomThemeButton
            // 
            this.CustomThemeButton.Location = new System.Drawing.Point(34, 309);
            this.CustomThemeButton.Name = "CustomThemeButton";
            this.CustomThemeButton.Size = new System.Drawing.Size(202, 40);
            this.CustomThemeButton.TabIndex = 2;
            this.CustomThemeButton.Text = "Button";
            this.CustomThemeButton.UseVisualStyleBackColor = true;
            // 
            // CustomThemeLabel
            // 
            this.CustomThemeLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomThemeLabel.Location = new System.Drawing.Point(60, 69);
            this.CustomThemeLabel.Name = "CustomThemeLabel";
            this.CustomThemeLabel.Size = new System.Drawing.Size(166, 23);
            this.CustomThemeLabel.TabIndex = 3;
            this.CustomThemeLabel.Text = "This is a text";
            // 
            // MainChartWindow
            // 
            this.MainChartWindow.BackColor = System.Drawing.Color.Transparent;
            this.MainChartWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.Name = "ChartArea";
            this.MainChartWindow.ChartAreas.Add(chartArea1);
            this.MainChartWindow.Location = new System.Drawing.Point(3, 98);
            this.MainChartWindow.Name = "MainChartWindow";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend2";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series3.MarkerBorderWidth = 5;
            series3.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Fuchsia;
            series4.Name = "Series4";
            series5.ChartArea = "ChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series5.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series5.MarkerSize = 7;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Series5";
            this.MainChartWindow.Series.Add(series1);
            this.MainChartWindow.Series.Add(series2);
            this.MainChartWindow.Series.Add(series3);
            this.MainChartWindow.Series.Add(series4);
            this.MainChartWindow.Series.Add(series5);
            this.MainChartWindow.Size = new System.Drawing.Size(261, 205);
            this.MainChartWindow.TabIndex = 4;
            this.MainChartWindow.Text = "Chart";
            // 
            // MainWindowPanel
            // 
            this.MainWindowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainWindowPanel.Controls.Add(this.SaveButton);
            this.MainWindowPanel.Controls.Add(this.CancelButton);
            this.MainWindowPanel.Controls.Add(this.MainWindowColorButton);
            this.MainWindowPanel.Controls.Add(this.FifthGraphColorButton);
            this.MainWindowPanel.Controls.Add(this.ButtonColorButton);
            this.MainWindowPanel.Controls.Add(this.GraphFourColorButton);
            this.MainWindowPanel.Controls.Add(this.GraphThreeColorButton);
            this.MainWindowPanel.Controls.Add(this.GraphTwoColorButton);
            this.MainWindowPanel.Controls.Add(this.GraphOneColorButton);
            this.MainWindowPanel.Controls.Add(this.TextColorButton);
            this.MainWindowPanel.Controls.Add(this.TopPanelColorButton);
            this.MainWindowPanel.Controls.Add(this.CustomThemeMainWindow);
            this.MainWindowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowPanel.Location = new System.Drawing.Point(0, 0);
            this.MainWindowPanel.Name = "MainWindowPanel";
            this.MainWindowPanel.Size = new System.Drawing.Size(476, 528);
            this.MainWindowPanel.TabIndex = 1;
            // 
            // TopPanelColorButton
            // 
            this.TopPanelColorButton.Location = new System.Drawing.Point(289, 84);
            this.TopPanelColorButton.Name = "TopPanelColorButton";
            this.TopPanelColorButton.Size = new System.Drawing.Size(174, 20);
            this.TopPanelColorButton.TabIndex = 3;
            this.TopPanelColorButton.Text = "Top Panel Color";
            this.TopPanelColorButton.UseVisualStyleBackColor = true;
            this.TopPanelColorButton.Click += new System.EventHandler(this.TopPanelColorButton_Click);
            // 
            // TextColorButton
            // 
            this.TextColorButton.Location = new System.Drawing.Point(289, 136);
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new System.Drawing.Size(174, 20);
            this.TextColorButton.TabIndex = 4;
            this.TextColorButton.Text = "Text Color";
            this.TextColorButton.UseVisualStyleBackColor = true;
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // GraphOneColorButton
            // 
            this.GraphOneColorButton.Location = new System.Drawing.Point(289, 210);
            this.GraphOneColorButton.Name = "GraphOneColorButton";
            this.GraphOneColorButton.Size = new System.Drawing.Size(174, 20);
            this.GraphOneColorButton.TabIndex = 5;
            this.GraphOneColorButton.Text = "First Graph Color";
            this.GraphOneColorButton.UseVisualStyleBackColor = true;
            this.GraphOneColorButton.Click += new System.EventHandler(this.GraphOneColorButton_Click);
            // 
            // GraphTwoColorButton
            // 
            this.GraphTwoColorButton.Location = new System.Drawing.Point(289, 236);
            this.GraphTwoColorButton.Name = "GraphTwoColorButton";
            this.GraphTwoColorButton.Size = new System.Drawing.Size(174, 20);
            this.GraphTwoColorButton.TabIndex = 6;
            this.GraphTwoColorButton.Text = "Second Graph Color";
            this.GraphTwoColorButton.UseVisualStyleBackColor = true;
            this.GraphTwoColorButton.Click += new System.EventHandler(this.GraphTwoColorButton_Click);
            // 
            // GraphThreeColorButton
            // 
            this.GraphThreeColorButton.Location = new System.Drawing.Point(289, 262);
            this.GraphThreeColorButton.Name = "GraphThreeColorButton";
            this.GraphThreeColorButton.Size = new System.Drawing.Size(174, 20);
            this.GraphThreeColorButton.TabIndex = 7;
            this.GraphThreeColorButton.Text = "Third Graph Color";
            this.GraphThreeColorButton.UseVisualStyleBackColor = true;
            this.GraphThreeColorButton.Click += new System.EventHandler(this.GraphThreeColorButton_Click);
            // 
            // GraphFourColorButton
            // 
            this.GraphFourColorButton.Location = new System.Drawing.Point(289, 288);
            this.GraphFourColorButton.Name = "GraphFourColorButton";
            this.GraphFourColorButton.Size = new System.Drawing.Size(174, 20);
            this.GraphFourColorButton.TabIndex = 8;
            this.GraphFourColorButton.Text = "Fourth Graph Color";
            this.GraphFourColorButton.UseVisualStyleBackColor = true;
            this.GraphFourColorButton.Click += new System.EventHandler(this.GraphFourColorButton_Click);
            // 
            // ButtonColorButton
            // 
            this.ButtonColorButton.Location = new System.Drawing.Point(289, 387);
            this.ButtonColorButton.Name = "ButtonColorButton";
            this.ButtonColorButton.Size = new System.Drawing.Size(174, 20);
            this.ButtonColorButton.TabIndex = 9;
            this.ButtonColorButton.Text = "Button Color";
            this.ButtonColorButton.UseVisualStyleBackColor = true;
            this.ButtonColorButton.Click += new System.EventHandler(this.ButtonColorButton_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.MainWindowPanel;
            // 
            // FifthGraphColorButton
            // 
            this.FifthGraphColorButton.Location = new System.Drawing.Point(289, 314);
            this.FifthGraphColorButton.Name = "FifthGraphColorButton";
            this.FifthGraphColorButton.Size = new System.Drawing.Size(174, 20);
            this.FifthGraphColorButton.TabIndex = 10;
            this.FifthGraphColorButton.Text = "Fifth Graph Color";
            this.FifthGraphColorButton.UseVisualStyleBackColor = true;
            this.FifthGraphColorButton.Click += new System.EventHandler(this.FifthGraphColorButton_Click);
            // 
            // MainWindowColorButton
            // 
            this.MainWindowColorButton.Location = new System.Drawing.Point(289, 175);
            this.MainWindowColorButton.Name = "MainWindowColorButton";
            this.MainWindowColorButton.Size = new System.Drawing.Size(174, 20);
            this.MainWindowColorButton.TabIndex = 11;
            this.MainWindowColorButton.Text = "Main Window Color";
            this.MainWindowColorButton.UseVisualStyleBackColor = true;
            this.MainWindowColorButton.Click += new System.EventHandler(this.MainWindowColorButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(57, 459);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(147, 47);
            this.CancelButton.TabIndex = 12;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(266, 459);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(147, 47);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save and Close";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CustomThemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 528);
            this.Controls.Add(this.MainWindowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomThemeForm";
            this.Text = "CustomThemeForm";
            this.CustomThemeMainWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChartWindow)).EndInit();
            this.MainWindowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse MainWindow;
        private System.Windows.Forms.Panel CustomThemeMainWindow;
        private System.Windows.Forms.Label CustomThemeLabel;
        private System.Windows.Forms.Button CustomThemeButton;
        private System.Windows.Forms.Panel CustomWindowTopPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChartWindow;
        private System.Windows.Forms.Panel MainWindowPanel;
        private System.Windows.Forms.Button ButtonColorButton;
        private System.Windows.Forms.Button GraphFourColorButton;
        private System.Windows.Forms.Button GraphThreeColorButton;
        private System.Windows.Forms.Button GraphTwoColorButton;
        private System.Windows.Forms.Button GraphOneColorButton;
        private System.Windows.Forms.Button TextColorButton;
        private System.Windows.Forms.Button TopPanelColorButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private Guna.UI.WinForms.GunaDragControl DragControl;
        private System.Windows.Forms.Button FifthGraphColorButton;
        private System.Windows.Forms.Button MainWindowColorButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}
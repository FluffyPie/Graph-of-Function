namespace Laba_3_CSharp.Forms
{
    partial class MainForm
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
            this.MainChartWindow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RadiusUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.XRightUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.XLeftUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.LeftXLabel = new System.Windows.Forms.Label();
            this.RightXLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.TableButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainChartWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRightUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XLeftUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainChartWindow
            // 
            this.MainChartWindow.BackColor = System.Drawing.Color.Transparent;
            this.MainChartWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea1.Name = "ChartArea";
            this.MainChartWindow.ChartAreas.Add(chartArea1);
            this.MainChartWindow.Location = new System.Drawing.Point(-7, 39);
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
            this.MainChartWindow.Size = new System.Drawing.Size(630, 470);
            this.MainChartWindow.TabIndex = 0;
            this.MainChartWindow.Text = "Chart";
            // 
            // RadiusUpDownValue
            // 
            this.RadiusUpDownValue.DecimalPlaces = 2;
            this.RadiusUpDownValue.Location = new System.Drawing.Point(629, 196);
            this.RadiusUpDownValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RadiusUpDownValue.Name = "RadiusUpDownValue";
            this.RadiusUpDownValue.Size = new System.Drawing.Size(97, 20);
            this.RadiusUpDownValue.TabIndex = 4;
            this.RadiusUpDownValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RadiusUpDownValue.ValueChanged += new System.EventHandler(this.RadiusValueChanged);
            // 
            // XRightUpDownValue
            // 
            this.XRightUpDownValue.DecimalPlaces = 2;
            this.XRightUpDownValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.XRightUpDownValue.Location = new System.Drawing.Point(629, 143);
            this.XRightUpDownValue.Name = "XRightUpDownValue";
            this.XRightUpDownValue.Size = new System.Drawing.Size(97, 20);
            this.XRightUpDownValue.TabIndex = 5;
            this.XRightUpDownValue.ValueChanged += new System.EventHandler(this.RightXValueChanged);
            // 
            // XLeftUpDownValue
            // 
            this.XLeftUpDownValue.DecimalPlaces = 2;
            this.XLeftUpDownValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.XLeftUpDownValue.Location = new System.Drawing.Point(629, 94);
            this.XLeftUpDownValue.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.XLeftUpDownValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.XLeftUpDownValue.Name = "XLeftUpDownValue";
            this.XLeftUpDownValue.Size = new System.Drawing.Size(97, 20);
            this.XLeftUpDownValue.TabIndex = 6;
            this.XLeftUpDownValue.ValueChanged += new System.EventHandler(this.LeftXValueChanged);
            // 
            // LeftXLabel
            // 
            this.LeftXLabel.AutoSize = true;
            this.LeftXLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeftXLabel.Location = new System.Drawing.Point(607, 75);
            this.LeftXLabel.Name = "LeftXLabel";
            this.LeftXLabel.Size = new System.Drawing.Size(136, 16);
            this.LeftXLabel.TabIndex = 7;
            this.LeftXLabel.Text = "Left border of X";
            // 
            // RightXLabel
            // 
            this.RightXLabel.AutoSize = true;
            this.RightXLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RightXLabel.Location = new System.Drawing.Point(607, 124);
            this.RightXLabel.Name = "RightXLabel";
            this.RightXLabel.Size = new System.Drawing.Size(144, 16);
            this.RightXLabel.TabIndex = 8;
            this.RightXLabel.Text = "Right border of X";
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadiusLabel.Location = new System.Drawing.Point(608, 177);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(128, 16);
            this.RadiusLabel.TabIndex = 10;
            this.RadiusLabel.Text = "Value of Radius";
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepLabel.Location = new System.Drawing.Point(629, 229);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(80, 16);
            this.StepLabel.TabIndex = 12;
            this.StepLabel.Text = "Step of X";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(629, 248);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 25;
            this.gunaElipse1.TargetControl = this;
            // 
            // TableButton
            // 
            this.TableButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableButton.Location = new System.Drawing.Point(610, 419);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(141, 45);
            this.TableButton.TabIndex = 13;
            this.TableButton.Text = "button1";
            this.TableButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 508);
            this.Controls.Add(this.TableButton);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.RightXLabel);
            this.Controls.Add(this.LeftXLabel);
            this.Controls.Add(this.XLeftUpDownValue);
            this.Controls.Add(this.XRightUpDownValue);
            this.Controls.Add(this.RadiusUpDownValue);
            this.Controls.Add(this.MainChartWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.MainChartWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRightUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XLeftUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChartWindow;
        private System.Windows.Forms.NumericUpDown XRightUpDownValue;
        private System.Windows.Forms.NumericUpDown RadiusUpDownValue;
        private System.Windows.Forms.NumericUpDown XLeftUpDownValue;

        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.Label RightXLabel;
        private System.Windows.Forms.Label LeftXLabel;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Button TableButton;
    }
}
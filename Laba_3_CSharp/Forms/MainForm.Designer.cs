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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainChartWindow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RadiusUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.XRightUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.XLeftUpDownValue = new System.Windows.Forms.NumericUpDown();
            this.LeftXLabel = new System.Windows.Forms.Label();
            this.RightXLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            this.StepXUpDown = new System.Windows.Forms.NumericUpDown();
            this.MainWindowForm = new Guna.UI.WinForms.GunaElipse(this.components);
            this.TableButton = new System.Windows.Forms.Button();
            this.HideTableButton = new System.Windows.Forms.Button();
            this.DragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.TableOfValues = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.PanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainChartWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRightUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XLeftUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfValues)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainChartWindow
            // 
            this.MainChartWindow.BackColor = System.Drawing.Color.Transparent;
            this.MainChartWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea2.Name = "ChartArea";
            this.MainChartWindow.ChartAreas.Add(chartArea2);
            this.MainChartWindow.Location = new System.Drawing.Point(-16, 39);
            this.MainChartWindow.Name = "MainChartWindow";
            series6.ChartArea = "ChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend2";
            series6.Name = "Series1";
            series7.ChartArea = "ChartArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Name = "Series2";
            series8.ChartArea = "ChartArea";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series8.MarkerBorderWidth = 5;
            series8.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series8.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series8.Name = "Series3";
            series9.ChartArea = "ChartArea";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Name = "Series4";
            series10.ChartArea = "ChartArea";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series10.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series10.MarkerSize = 7;
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series10.Name = "Series5";
            this.MainChartWindow.Series.Add(series6);
            this.MainChartWindow.Series.Add(series7);
            this.MainChartWindow.Series.Add(series8);
            this.MainChartWindow.Series.Add(series9);
            this.MainChartWindow.Series.Add(series10);
            this.MainChartWindow.Size = new System.Drawing.Size(630, 470);
            this.MainChartWindow.TabIndex = 0;
            this.MainChartWindow.Text = "Chart";
            // 
            // RadiusUpDownValue
            // 
            this.RadiusUpDownValue.DecimalPlaces = 2;
            this.RadiusUpDownValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
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
            // StepXUpDown
            // 
            this.StepXUpDown.DecimalPlaces = 2;
            this.StepXUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StepXUpDown.Location = new System.Drawing.Point(629, 248);
            this.StepXUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StepXUpDown.Name = "StepXUpDown";
            this.StepXUpDown.Size = new System.Drawing.Size(97, 20);
            this.StepXUpDown.TabIndex = 11;
            this.StepXUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StepXUpDown.ValueChanged += new System.EventHandler(this.StepValuesChanged);
            // 
            // MainWindowForm
            // 
            this.MainWindowForm.Radius = 25;
            this.MainWindowForm.TargetControl = this;
            // 
            // TableButton
            // 
            this.TableButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TableButton.Location = new System.Drawing.Point(611, 421);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(141, 45);
            this.TableButton.TabIndex = 13;
            this.TableButton.Text = "Show the Table of Values";
            this.TableButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TableButton.UseVisualStyleBackColor = true;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // HideTableButton
            // 
            this.HideTableButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideTableButton.Location = new System.Drawing.Point(611, 421);
            this.HideTableButton.Name = "HideTableButton";
            this.HideTableButton.Size = new System.Drawing.Size(141, 45);
            this.HideTableButton.TabIndex = 14;
            this.HideTableButton.Text = "Hide the Table of Values";
            this.HideTableButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HideTableButton.UseVisualStyleBackColor = true;
            this.HideTableButton.Visible = false;
            this.HideTableButton.Click += new System.EventHandler(this.HideTableButton_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // TableOfValues
            // 
            this.TableOfValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableOfValues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.TableOfValues.Location = new System.Drawing.Point(12, 515);
            this.TableOfValues.Name = "TableOfValues";
            this.TableOfValues.ReadOnly = true;
            this.TableOfValues.RowTemplate.DefaultCellStyle.Format = "N2";
            this.TableOfValues.RowTemplate.DefaultCellStyle.NullValue = null;
            this.TableOfValues.Size = new System.Drawing.Size(745, 273);
            this.TableOfValues.TabIndex = 2;
            // 
            // ColumnX
            // 
            this.ColumnX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnX.HeaderText = "Value X";
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            // 
            // ColumnY
            // 
            this.ColumnY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnY.HeaderText = "Value Y";
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            this.ColumnY.ToolTipText = "Value of Y";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(611, 289);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(146, 90);
            this.ErrorLabel.TabIndex = 15;
            this.ErrorLabel.Text = "At these coordinates, the graph degenerates into a point!";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.TopPanel.Controls.Add(this.SettingsButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(769, 48);
            this.TopPanel.TabIndex = 16;
            // 
            // SettingsButton
            // 
            this.SettingsButton.AnimationHoverSpeed = 0.07F;
            this.SettingsButton.AnimationSpeed = 0.03F;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BaseColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BorderColor = System.Drawing.Color.Black;
            this.SettingsButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.SettingsButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.SettingsButton.CheckedForeColor = System.Drawing.Color.White;
            this.SettingsButton.CheckedImage = null;
            this.SettingsButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.SettingsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsButton.FocusedColor = System.Drawing.Color.Empty;
            this.SettingsButton.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.ForeColor = System.Drawing.Color.Black;
            this.SettingsButton.Image = null;
            this.SettingsButton.ImageSize = new System.Drawing.Size(20, 20);
            this.SettingsButton.LineColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Location = new System.Drawing.Point(24, 6);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.SettingsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.SettingsButton.OnHoverForeColor = System.Drawing.Color.DimGray;
            this.SettingsButton.OnHoverImage = null;
            this.SettingsButton.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.SettingsButton.OnPressedColor = System.Drawing.Color.Black;
            this.SettingsButton.Size = new System.Drawing.Size(116, 42);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // PanelDragControl
            // 
            this.PanelDragControl.TargetControl = this.TopPanel;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 800);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.TableOfValues);
            this.Controls.Add(this.HideTableButton);
            this.Controls.Add(this.TableButton);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.StepXUpDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.StepXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfValues)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MainChartWindow;
        private System.Windows.Forms.NumericUpDown XRightUpDownValue;
        private System.Windows.Forms.NumericUpDown RadiusUpDownValue;
        private System.Windows.Forms.NumericUpDown XLeftUpDownValue;

        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.NumericUpDown StepXUpDown;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.Label RightXLabel;
        private System.Windows.Forms.Label LeftXLabel;
        private Guna.UI.WinForms.GunaElipse MainWindowForm;
        private System.Windows.Forms.Button TableButton;
        private System.Windows.Forms.Button HideTableButton;
        private Guna.UI.WinForms.GunaDragControl DragControl;
        private System.Windows.Forms.DataGridView TableOfValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI.WinForms.GunaDragControl PanelDragControl;
        private Guna.UI.WinForms.GunaAdvenceButton SettingsButton;
    }
}
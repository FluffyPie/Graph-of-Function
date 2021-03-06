﻿namespace Laba_3_CSharp.Forms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.PanelDragControl = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFromFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GraphFormulaLabel = new System.Windows.Forms.Label();
            this.ParametricLabel = new System.Windows.Forms.Label();
            this.CloseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.CollapseButton = new Guna.UI.WinForms.GunaAdvenceButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainChartWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRightUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XLeftUpDownValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfValues)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainChartWindow
            // 
            this.MainChartWindow.BackColor = System.Drawing.Color.Transparent;
            this.MainChartWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea";
            this.MainChartWindow.ChartAreas.Add(chartArea3);
            this.MainChartWindow.Location = new System.Drawing.Point(15, 75);
            this.MainChartWindow.Name = "MainChartWindow";
            series11.ChartArea = "ChartArea";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend2";
            series11.Name = "Series1";
            series12.ChartArea = "ChartArea";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Series2";
            series13.ChartArea = "ChartArea";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series13.MarkerBorderWidth = 5;
            series13.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series13.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series13.Name = "Series3";
            series14.ChartArea = "ChartArea";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.Name = "Series4";
            series15.ChartArea = "ChartArea";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series15.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series15.MarkerSize = 7;
            series15.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series15.Name = "Series5";
            this.MainChartWindow.Series.Add(series11);
            this.MainChartWindow.Series.Add(series12);
            this.MainChartWindow.Series.Add(series13);
            this.MainChartWindow.Series.Add(series14);
            this.MainChartWindow.Series.Add(series15);
            this.MainChartWindow.Size = new System.Drawing.Size(589, 434);
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
            this.LeftXLabel.MouseEnter += new System.EventHandler(this.LeftBorderMouseEnter);
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
            this.RightXLabel.MouseEnter += new System.EventHandler(this.RightMouseEnter);
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
            this.RadiusLabel.MouseEnter += new System.EventHandler(this.RadiusMosueEnter);
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
            this.StepLabel.MouseEnter += new System.EventHandler(this.StepMouseEnter);
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
            this.TableButton.Location = new System.Drawing.Point(610, 393);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(141, 45);
            this.TableButton.TabIndex = 13;
            this.TableButton.Text = "Show the Table of Values";
            this.TableButton.UseVisualStyleBackColor = true;
            this.TableButton.Click += new System.EventHandler(this.TableButton_Click);
            // 
            // HideTableButton
            // 
            this.HideTableButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideTableButton.Location = new System.Drawing.Point(610, 393);
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
            this.TableOfValues.Size = new System.Drawing.Size(745, 221);
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
            // PanelDragControl
            // 
            this.PanelDragControl.TargetControl = this.MenuStrip;
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(230)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(769, 29);
            this.MenuStrip.TabIndex = 16;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToFileButton,
            this.OpenFromFile,
            this.SettingsButton,
            this.AboutButton});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 25);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveToFileButton
            // 
            this.SaveToFileButton.Name = "SaveToFileButton";
            this.SaveToFileButton.Size = new System.Drawing.Size(234, 26);
            this.SaveToFileButton.Text = "Save to File";
            this.SaveToFileButton.Click += new System.EventHandler(this.SaveToFileButton_Click);
            // 
            // OpenFromFile
            // 
            this.OpenFromFile.Name = "OpenFromFile";
            this.OpenFromFile.Size = new System.Drawing.Size(234, 26);
            this.OpenFromFile.Text = "Open from File";
            this.OpenFromFile.Click += new System.EventHandler(this.OpenFromFile_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(234, 26);
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(234, 26);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // GraphFormulaLabel
            // 
            this.GraphFormulaLabel.AutoSize = true;
            this.GraphFormulaLabel.BackColor = System.Drawing.Color.Transparent;
            this.GraphFormulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphFormulaLabel.Location = new System.Drawing.Point(396, 42);
            this.GraphFormulaLabel.Name = "GraphFormulaLabel";
            this.GraphFormulaLabel.Size = new System.Drawing.Size(99, 40);
            this.GraphFormulaLabel.TabIndex = 17;
            this.GraphFormulaLabel.Text = "x = rt – r sin t;\r\ny = r – r cos t.";
            // 
            // ParametricLabel
            // 
            this.ParametricLabel.AutoSize = true;
            this.ParametricLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametricLabel.Location = new System.Drawing.Point(149, 52);
            this.ParametricLabel.Name = "ParametricLabel";
            this.ParametricLabel.Size = new System.Drawing.Size(241, 20);
            this.ParametricLabel.TabIndex = 18;
            this.ParametricLabel.Text = "Parametric equation of the graph";
            // 
            // CloseButton
            // 
            this.CloseButton.AnimationHoverSpeed = 0.07F;
            this.CloseButton.AnimationSpeed = 0.03F;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BaseColor = System.Drawing.Color.Red;
            this.CloseButton.BorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CloseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CloseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CloseButton.CheckedImage = null;
            this.CloseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = null;
            this.CloseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CloseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.Location = new System.Drawing.Point(729, 7);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CloseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CloseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CloseButton.OnHoverImage = null;
            this.CloseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CloseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CloseButton.Radius = 10;
            this.CloseButton.Size = new System.Drawing.Size(18, 17);
            this.CloseButton.TabIndex = 19;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CollapseButton
            // 
            this.CollapseButton.AnimationHoverSpeed = 0.07F;
            this.CollapseButton.AnimationSpeed = 0.03F;
            this.CollapseButton.BackColor = System.Drawing.Color.Transparent;
            this.CollapseButton.BaseColor = System.Drawing.Color.Gold;
            this.CollapseButton.BorderColor = System.Drawing.Color.Black;
            this.CollapseButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.CollapseButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.CollapseButton.CheckedForeColor = System.Drawing.Color.White;
            this.CollapseButton.CheckedImage = null;
            this.CollapseButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.CollapseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CollapseButton.FocusedColor = System.Drawing.Color.Empty;
            this.CollapseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CollapseButton.ForeColor = System.Drawing.Color.Transparent;
            this.CollapseButton.Image = null;
            this.CollapseButton.ImageSize = new System.Drawing.Size(20, 20);
            this.CollapseButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CollapseButton.Location = new System.Drawing.Point(705, 7);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.CollapseButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CollapseButton.OnHoverForeColor = System.Drawing.Color.White;
            this.CollapseButton.OnHoverImage = null;
            this.CollapseButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.CollapseButton.OnPressedColor = System.Drawing.Color.Black;
            this.CollapseButton.Radius = 10;
            this.CollapseButton.Size = new System.Drawing.Size(18, 17);
            this.CollapseButton.TabIndex = 20;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 800);
            this.Controls.Add(this.CollapseButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ParametricLabel);
            this.Controls.Add(this.GraphFormulaLabel);
            this.Controls.Add(this.MenuStrip);
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
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.MainChartWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadiusUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRightUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XLeftUpDownValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableOfValues)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
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
        private Guna.UI.WinForms.GunaDragControl PanelDragControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToFileButton;
        private System.Windows.Forms.ToolStripMenuItem OpenFromFile;
        private System.Windows.Forms.ToolStripMenuItem SettingsButton;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label GraphFormulaLabel;
        private System.Windows.Forms.Label ParametricLabel;
        private Guna.UI.WinForms.GunaAdvenceButton CloseButton;
        private Guna.UI.WinForms.GunaAdvenceButton CollapseButton;
    }
}
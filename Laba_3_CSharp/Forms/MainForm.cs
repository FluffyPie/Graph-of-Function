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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Height = 500;
            double Radius = Convert.ToDouble(RadiusUpDownValue.Value);
            MainChartWindow.ChartAreas[0].AxisX.ScaleView.Size = Radius * 5.5;
            MainChartWindow.ChartAreas[0].AxisY.ScaleView.Size = Radius * 4;
            MainChartWindow.ChartAreas[0].AxisX.LabelStyle.Format = "0.0";
            MainChartWindow.ChartAreas[0].AxisY.LabelStyle.Format = "0.0";
            DrawAGraph();
            
        }

        Code.Calculations Calculations = new Code.Calculations();
        Forms.Settings SettingsForm = new Forms.Settings();
        private void DrawAGraph()
        {
            MainChartWindow.Series[0].Points.Clear();
            MainChartWindow.Series[1].Points.Clear();
            MainChartWindow.Series[2].Points.Clear();
            MainChartWindow.Series[3].Points.Clear();
            MainChartWindow.Series[4].Points.Clear();
            double Radius = Convert.ToDouble(RadiusUpDownValue.Value);
            double XRight = Convert.ToDouble(XRightUpDownValue.Value);
            double XLeft = Convert.ToDouble(XLeftUpDownValue.Value);
            if (XLeft == XRight)
                ErrorLabel.Visible = true;
            else
                ErrorLabel.Visible = false;
            MainChartWindow.ChartAreas[0].AxisX.ScaleView.Size = Radius*5.5;
            MainChartWindow.ChartAreas[0].AxisY.ScaleView.Size = Radius*4;
            {
                for (double t = XLeft; t < XRight; t += 0.1)
                {
                    MainChartWindow.Series[0].Points.AddXY(Calculations.AxisXCalculation(t, Radius), Calculations.AxisYCalculation(t, Radius));
                }
                for (double t = 0; t < 2 * Math.PI; t += 0.1)
                {
                    MainChartWindow.Series[1].Points.AddXY(Radius * (XLeft + Math.Cos(t)), Radius * (Math.Sin(t) + 1));
                }
                MainChartWindow.Series[2].Points.AddXY(Radius * (XLeft - Math.Sin(XLeft)), Radius * (1 - Math.Cos(XLeft)));
                for (double t = 0; t < 2 * Math.PI; t += 0.1)
                {
                    MainChartWindow.Series[3].Points.AddXY(Radius * (XRight + Math.Cos(t)), Radius * (Math.Sin(t) + 1));
                }
                MainChartWindow.Series[4].Points.AddXY(Radius * (XRight - Math.Sin(XRight)), Radius * (1 - Math.Cos(XRight)));
            }
        }

        private void RadiusValueChanged(object sender, EventArgs e)
        {
            DrawAGraph();
            if (HideTableButton.Visible == true)
            {
                TableOfValues.Rows.Clear();
                CreateTable();
            }
        }

        private void LeftXValueChanged(object sender, EventArgs e)
        {
            double Radius = Convert.ToDouble(RadiusUpDownValue.Value);
            double XLeft = Convert.ToDouble(XLeftUpDownValue.Value);
            MainChartWindow.ChartAreas[0].AxisX.ScaleView.Scroll(XLeft-Radius*10000);
            DrawAGraph();
            if (HideTableButton.Visible == true)
            {
                TableOfValues.Rows.Clear();
                CreateTable();
            }
        }

        private void RightXValueChanged(object sender, EventArgs e)
        {
            double Radius = Convert.ToDouble(RadiusUpDownValue.Value);
            double XRight= Convert.ToDouble(XRightUpDownValue.Value);
            MainChartWindow.ChartAreas[0].AxisX.ScaleView.Scroll(XRight+Radius*10000);
            DrawAGraph();
            if (HideTableButton.Visible == true)
            {
                TableOfValues.Rows.Clear();
                CreateTable();
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            this.Height = 800;
            TableButton.Visible = false;
            HideTableButton.Visible = true;
            if (HideTableButton.Visible == true)
            CreateTable();
            
            
        }

        private void HideTableButton_Click(object sender, EventArgs e)
        {
            this.Height = 500;
            TableButton.Visible = true;
            HideTableButton.Visible = false;
        }
        private void CreateTable()
        {
            
            double Radius = Convert.ToDouble(RadiusUpDownValue.Value);
            double XRight = Convert.ToDouble(XRightUpDownValue.Value);
            double XLeft = Convert.ToDouble(XLeftUpDownValue.Value);
            double XStep = Convert.ToDouble(StepXUpDown.Value);
            for (double i = XLeft; i<=XRight; i += XStep)
            {
                TableOfValues.Rows.Add(Calculations.AxisXCalculation(i, Radius), Calculations.AxisYCalculation(i, Radius));
            }
        }

        private void StepValuesChanged(object sender, EventArgs e)
        {
            if (HideTableButton.Visible == true)
            {
                TableOfValues.Rows.Clear();
                CreateTable();
            }     
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm.ShowDialog();
        }
    }  
}

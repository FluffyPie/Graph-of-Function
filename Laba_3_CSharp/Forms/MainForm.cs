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
           
            double Radius = Convert.ToDouble(RadiusUpDownValue.Value);
            MainChartWindow.ChartAreas[0].AxisX.ScaleView.Size = Radius * 5.5;
            MainChartWindow.ChartAreas[0].AxisY.ScaleView.Size = Radius * 4;
            DrawAGraph();
            
        }

        Code.Calculations Calculations = new Code.Calculations();
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
        }

        private void LeftXValueChanged(object sender, EventArgs e)
        {
            double Radius = Convert.ToDouble(RadiusUpDownValue.Value);
            double XLeft = Convert.ToDouble(XLeftUpDownValue.Value);
            MainChartWindow.ChartAreas[0].AxisX.ScaleView.Scroll(XLeft-Radius*10);
            DrawAGraph();
        }

        private void RightXValueChanged(object sender, EventArgs e)
        {
            double Radius = Convert.ToDouble(RadiusUpDownValue.Value);
            double XRight= Convert.ToDouble(XRightUpDownValue.Value);
            MainChartWindow.ChartAreas[0].AxisX.ScaleView.Scroll(XRight+Radius*10);
            DrawAGraph();
        }
    }  
}

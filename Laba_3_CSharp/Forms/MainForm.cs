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
     
            MainChartWindow.ChartAreas[0].CursorX.IsUserEnabled = true;
            MainChartWindow.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            MainChartWindow.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            MainChartWindow.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            trackBar1.Maximum = 10000;
            
           
        }
        Code.Calculations Calculations = new Code.Calculations();
        
        private void ValueChanged(object sender, EventArgs e)
        {

            MainChartWindow.Series[0].Points.Clear();
            MainChartWindow.Series[1].Points.Clear();
            MainChartWindow.Series[2].Points.Clear();
            double Radius = 1;
            double x = Convert.ToDouble(trackBar1.Value)/1000;
            for (double t = 0; t < x; t += 0.1)
            {
                MainChartWindow.Series[0].Points.AddXY(Calculations.AxisXCalculation(t, Radius), Calculations.AxisYCalculation(t, Radius));
            }
            for (double t = 0; t < 2 * Math.PI; t += 0.1)
            {
                MainChartWindow.Series[1].Points.AddXY(x + Math.Cos(t), Math.Sin(t) + 1);
            }
            MainChartWindow.Series[2].Points.AddXY(x - Math.Sin(x), 1 - Math.Cos(x));
           
        }
    }
}

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
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 50);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.Enabled = true;
            for (int i = 0; i < 50; i++)
                chart1.Series[0].Points.AddXY(i, Math.Sin(i));
        }
    }
}

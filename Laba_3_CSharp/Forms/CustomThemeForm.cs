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
    public partial class CustomThemeForm : Form
    {
        public CustomThemeForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Theme == "Dark")
                SetDarkColor();
            else if ((Properties.Settings.Default.Theme == "Custom"))
                SetCustomColor();
            Code.Calculations Calculations = new Code.Calculations();
            double Radius = 1;
            double XLeft = 0;
            double XRight = 5;
            MainChartWindow.ChartAreas[0].AxisX.ScaleView.Size = Radius*4;
            MainChartWindow.ChartAreas[0].AxisY.ScaleView.Size = Radius*2.5;
            this.MainChartWindow.ChartAreas[0].AxisX.LabelStyle.Format = "0";
            this.MainChartWindow.ChartAreas[0].AxisY.LabelStyle.Format = "0";
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
        public IEnumerable<Control> GetSelfAndChildrenRecursive(Control Parent)
        {
            List<Control> Controls = new List<Control>();

            foreach (Control Child in Parent.Controls)
            {
                Controls.AddRange(GetSelfAndChildrenRecursive(Child));
            }

            Controls.Add(Parent);
            return Controls;

        }
        private void TopPanelColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TopPanelColor = ColorDialog.Color;
                CustomWindowTopPanel.BackColor = ColorDialog.Color;
            }
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TextColor = ColorDialog.Color;
                CustomThemeLabel.ForeColor = ColorDialog.Color;
                MainChartWindow.ChartAreas[0].AxisX.LabelStyle.ForeColor = ColorDialog.Color;
                MainChartWindow.ChartAreas[0].AxisY.LabelStyle.ForeColor = ColorDialog.Color;
                CustomThemeButton.ForeColor = ColorDialog.Color;
            }
        }

        private void MainWindowColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.MainWindowColor = ColorDialog.Color;
                CustomThemeMainWindow.BackColor = ColorDialog.Color;
            }
        }
        private void GraphOneColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FirstGraphColor = ColorDialog.Color;
                MainChartWindow.Series[0].Color = ColorDialog.Color;
            }
        }

        private void GraphTwoColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.SecondGraphColor = ColorDialog.Color;
                MainChartWindow.Series[1].Color = ColorDialog.Color;
            }
        }

        private void GraphThreeColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ThirdGraphColor = ColorDialog.Color;
                MainChartWindow.Series[2].MarkerBorderColor = ColorDialog.Color;
                MainChartWindow.Series[2].MarkerColor = ColorDialog.Color;
            }
        }

        private void GraphFourColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FourthGraphColor = ColorDialog.Color;
                MainChartWindow.Series[3].Color = ColorDialog.Color;
            }
        }

        private void FifthGraphColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FifthGraphColor = ColorDialog.Color;
                MainChartWindow.Series[4].MarkerColor = ColorDialog.Color;
                MainChartWindow.Series[4].MarkerBorderColor = ColorDialog.Color;
            }
        }

        private void ButtonColorButton_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ButtonColor = ColorDialog.Color;
                CustomThemeButton.BackColor = ColorDialog.Color;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
            
        }
        private void SetDarkColor()
        {
            GetSelfAndChildrenRecursive(this).OfType<Button>().ToList()
                  .ForEach(button => button.BackColor = Color.FromArgb(32, 34, 37));
            GetSelfAndChildrenRecursive(this).OfType<Button>().ToList()
                  .ForEach(button => button.ForeColor = Color.White);

        }
        private void SetCustomColor()
        {
            GetSelfAndChildrenRecursive(this).OfType<Button>().ToList()
                  .ForEach(button => button.BackColor = Properties.Settings.Default.ButtonColor);
            GetSelfAndChildrenRecursive(this).OfType<Button>().ToList()
                  .ForEach(button => button.ForeColor = Properties.Settings.Default.TextColor);
        }
        private void SetRussianLanguage()
        {
            
        }
        
    }
}

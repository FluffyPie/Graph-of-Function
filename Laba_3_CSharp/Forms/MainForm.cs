using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (Properties.Settings.Default.Theme == "Dark")
                SetDarkColor();
            else if ((Properties.Settings.Default.Theme == "Custom"))
                SetCustomColor();
            if (Properties.Settings.Default.Language == "Russian")
                SetRussianLanguage();
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
        Forms.AboutForm AboutForm = new Forms.AboutForm();
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
            ErrorLabel.Text = String.Empty;
            ErrorLabel.ForeColor = Color.Red;
            if (XLeftUpDownValue.Value == 0 || XRightUpDownValue.Value == 0)
            {
                if (Properties.Settings.Default.Language == "Russian")
                    ErrorLabel.Text = "При этих параметрах график вырождается в точку!";
                else
                    ErrorLabel.Text = "At these coordinates, the graph degenerates into a point!";
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
            ErrorLabel.Text = String.Empty;
            ErrorLabel.ForeColor = Color.Red;
            if (XLeftUpDownValue.Value == 0 || XRightUpDownValue.Value == 0)
            {
                if (Properties.Settings.Default.Language == "Russian")
                    ErrorLabel.Text = "При этих параметрах график вырождается в точку!";
                else
                    ErrorLabel.Text = "At these coordinates, the graph degenerates into a point!";
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
            ErrorLabel.Text = String.Empty;
            ErrorLabel.ForeColor = Color.Red;
            if (XLeftUpDownValue.Value == 0 || XRightUpDownValue.Value == 0)
            {
                if (Properties.Settings.Default.Language == "Russian")
                    ErrorLabel.Text = "При этих параметрах график вырождается в точку!";
                else
                    ErrorLabel.Text = "At these coordinates, the graph degenerates into a point!";
            }
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            this.Height = 800;
            TableButton.Visible = false;
            HideTableButton.Visible = true;
            if (HideTableButton.Visible == true)
            CreateTable();
            ErrorLabel.Text = String.Empty;
            ErrorLabel.ForeColor = Color.Red;
            if (XLeftUpDownValue.Value == 0 || XRightUpDownValue.Value == 0)
            {
                if (Properties.Settings.Default.Language == "Russian")
                    ErrorLabel.Text = "При этих параметрах график вырождается в точку!";
                else
                    ErrorLabel.Text = "At these coordinates, the graph degenerates into a point!";
            }

        }

        private void HideTableButton_Click(object sender, EventArgs e)
        {
            this.Height = 500;
            TableButton.Visible = true;
            HideTableButton.Visible = false;
            ErrorLabel.Text = String.Empty;
            ErrorLabel.ForeColor = Color.Red;
            if (XLeftUpDownValue.Value == 0 || XRightUpDownValue.Value == 0)
            {
                if (Properties.Settings.Default.Language == "Russian")
                    ErrorLabel.Text = "При этих параметрах график вырождается в точку!";
                else
                    ErrorLabel.Text = "At these coordinates, the graph degenerates into a point!";
            }
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
            ErrorLabel.Text = String.Empty;
            ErrorLabel.ForeColor = Color.Red;
            if (XLeftUpDownValue.Value == 0 || XRightUpDownValue.Value == 0)
            {
                if (Properties.Settings.Default.Language == "Russian")
                    ErrorLabel.Text = "При этих параметрах график вырождается в точку!";
                else
                    ErrorLabel.Text = "At these coordinates, the graph degenerates into a point!";
            }

        }

        void SetDarkColor()
        {
            MenuStrip.BackColor = Color.FromArgb(32, 34, 37);
            MenuStrip.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(54, 57, 63);
            LeftXLabel.ForeColor = Color.White;
            RightXLabel.ForeColor = Color.White;
            RadiusLabel.ForeColor = Color.White;
            StepLabel.ForeColor = Color.White;
            TableButton.ForeColor = Color.White;
            HideTableButton.ForeColor = Color.White;
            TableButton.BackColor = Color.FromArgb(32, 34, 37);
            HideTableButton.BackColor = Color.FromArgb(32, 34, 37);
            MainChartWindow.ChartAreas[0].BackColor = Color.FromArgb(32, 34, 37);
            MainChartWindow.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            MainChartWindow.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            TableOfValues.BackgroundColor = Color.FromArgb(54, 57, 63);
            SaveToFileButton.BackColor = Color.FromArgb(32, 34, 37);
            SaveToFileButton.ForeColor = Color.White;
            OpenFromFile.BackColor = Color.FromArgb(32, 34, 37);
            OpenFromFile.ForeColor = Color.White;
            AboutButton.BackColor = Color.FromArgb(32, 34, 37);
            AboutButton.ForeColor = Color.White;
            SettingsButton.BackColor = Color.FromArgb(32, 34, 37);
            SettingsButton.ForeColor = Color.White;
            ParametricLabel.ForeColor = Color.White;
            GraphFormulaLabel.ForeColor = Color.White;
        }
        void SetCustomColor()
        {
            MenuStrip.BackColor = Properties.Settings.Default.TopPanelColor;
            MenuStrip.ForeColor = Properties.Settings.Default.TextColor;
            this.BackColor = Properties.Settings.Default.MainWindowColor;
            LeftXLabel.ForeColor = Properties.Settings.Default.TextColor;
            RightXLabel.ForeColor = Properties.Settings.Default.TextColor;
            RadiusLabel.ForeColor = Properties.Settings.Default.TextColor;
            StepLabel.ForeColor = Properties.Settings.Default.TextColor;
            TableButton.ForeColor = Properties.Settings.Default.TextColor;
            HideTableButton.ForeColor = Properties.Settings.Default.TextColor;
            TableButton.BackColor = Properties.Settings.Default.TopPanelColor;
            HideTableButton.BackColor = Properties.Settings.Default.ButtonColor;
            MainChartWindow.ChartAreas[0].BackColor = Properties.Settings.Default.MainWindowColor;
            MainChartWindow.ChartAreas[0].AxisX.LabelStyle.ForeColor = Properties.Settings.Default.TextColor;
            MainChartWindow.ChartAreas[0].AxisY.LabelStyle.ForeColor = Properties.Settings.Default.TextColor; ;
            TableOfValues.BackgroundColor = Properties.Settings.Default.MainWindowColor;
            SaveToFileButton.BackColor = Properties.Settings.Default.TopPanelColor;
            SaveToFileButton.ForeColor = Properties.Settings.Default.TextColor;
            OpenFromFile.BackColor = Properties.Settings.Default.TopPanelColor;
            OpenFromFile.ForeColor = Properties.Settings.Default.TextColor;
            AboutButton.BackColor = Properties.Settings.Default.TopPanelColor;
            AboutButton.ForeColor = Properties.Settings.Default.TextColor;
            SettingsButton.BackColor =  Properties.Settings.Default.TopPanelColor;
            SettingsButton.ForeColor = Properties.Settings.Default.TextColor;
            MainChartWindow.Series[0].MarkerColor = Properties.Settings.Default.FirstGraphColor;
            MainChartWindow.Series[0].MarkerBorderColor = Properties.Settings.Default.FirstGraphColor;
            MainChartWindow.Series[1].MarkerColor = Properties.Settings.Default.SecondGraphColor;
            MainChartWindow.Series[1].MarkerBorderColor = Properties.Settings.Default.SecondGraphColor;
            MainChartWindow.Series[2].MarkerColor = Properties.Settings.Default.ThirdGraphColor;
            MainChartWindow.Series[2].MarkerBorderColor = Properties.Settings.Default.ThirdGraphColor;
            MainChartWindow.Series[3].MarkerColor = Properties.Settings.Default.FourthGraphColor;
            MainChartWindow.Series[3].MarkerBorderColor = Properties.Settings.Default.FourthGraphColor;
            MainChartWindow.Series[4].MarkerColor = Properties.Settings.Default.FifthGraphColor;
            MainChartWindow.Series[4].MarkerBorderColor = Properties.Settings.Default.FifthGraphColor;
            ParametricLabel.ForeColor = Properties.Settings.Default.TextColor;
            GraphFormulaLabel.ForeColor = Properties.Settings.Default.TextColor;
        }
        void SetRussianLanguage()
        {
            ErrorLabel.Text = "При этих параметрах график вырождается в точку!";
            SaveToFileButton.Text = "Сохранить в файл";
            OpenFromFile.Text = "Открыть из файла";
            AboutButton.Text = "О программе...";
            fileToolStripMenuItem.Text = "Файл";
            SettingsButton.Text = "Настройки";
            TableOfValues.Columns[0].HeaderText = "Значение X";
            TableOfValues.Columns[1].HeaderText = "Значение Y";
            LeftXLabel.Text = "Левая граница Х";
            RightXLabel.Text = "Правая граница Х";
            RadiusLabel.Text = "Радиус окружности";
            StepLabel.Text = "Шаг Х";
            HideTableButton.Text = "Спрятать таблицу значений";
            TableButton.Text = "Таблица значений";
            ParametricLabel.Text = "Параметрическое уравнение";

        }

        //private void exitbutton_click(object sender, eventargs e)
        //{
        //    application.exit();
        //}

        //private void collapsebutton_click(object sender, eventargs e)
        //{
        //    this.windowstate = formwindowstate.minimized;
        //}

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm.ShowDialog();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm.ShowDialog();
        }

        private void SaveToFileButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog.DefaultExt = "txt";
            SaveFileDialog.Filter =
            "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            SaveFileDialog.FileName = "Function Parameters";
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Stream = new StreamWriter(SaveFileDialog.FileName);
                Stream.WriteLine(XLeftUpDownValue.Value);
                Stream.WriteLine(XRightUpDownValue.Value);
                Stream.WriteLine(RadiusUpDownValue.Value);
                Stream.WriteLine(StepXUpDown.Value);
                Stream.Close();
                ErrorLabel.ForeColor = Color.Green;
                if (Properties.Settings.Default.Language == "Russian")
                    ErrorLabel.Text = "Файл успешно сохранен";
                else
                    ErrorLabel.Text = "File Saved Succesfully";

            }
            else
            {
                ErrorLabel.ForeColor = Color.Red;
                if (Properties.Settings.Default.Language == "Russian")
                    ErrorLabel.Text = "Файл не был сохранен";
                else
                    ErrorLabel.Text = "Failed to save file";
            }
        }

        private void OpenFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog.DefaultExt = "txt";
            OpenFileDialog.Filter =
            "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            OpenFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            OpenFileDialog.FileName = "Function Parameters";
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string Filename = OpenFileDialog.FileName;
                try
                {
                    StreamReader Stream = new StreamReader(Filename);
                    XLeftUpDownValue.Value = Convert.ToDecimal(Stream.ReadLine());
                    XRightUpDownValue.Value = Convert.ToDecimal(Stream.ReadLine());
                    RadiusUpDownValue.Value = Convert.ToDecimal(Stream.ReadLine());
                    StepXUpDown.Value = Convert.ToDecimal(Stream.ReadLine());                 
                    Stream.Close();
                   
                }
                catch
                {
                    ErrorLabel.ForeColor = Color.Red;
                    if (Properties.Settings.Default.Language == "Russian")
                        ErrorLabel.Text = "Не удалось считать данные";
                    else
                        ErrorLabel.Text = "Unable to read file";
                }

            }
            else
            {
                ErrorLabel.ForeColor = Color.Red;
                if (Properties.Settings.Default.Language == "Russian")
                    ErrorLabel.Text = "Не удалось открыть файл";
                else
                    ErrorLabel.Text = "Unable to open file";
            }
        }

     

        private void LeftBorderMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(LeftXLabel, "Левая граница Х в диапазоне от -100 до 0");
                else
                    ToolTipPopup.SetToolTip(LeftXLabel, "Left border of X in the range from -100 to 0");
            }
        }

        private void RightMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(RightXLabel, "Правая граница Х в диапазоне от 0 до 100");
                else
                    ToolTipPopup.SetToolTip(RightXLabel, "Right border of X in the range from 0 to 100");
            }
        }

        private void RadiusMosueEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(RadiusLabel, "Радиус окружности, рисующей циклоиду, в диапазоне от 0 до 100");
                else
                    ToolTipPopup.SetToolTip(RadiusLabel, "Radius of the circle drawing the cycloid, in the range from 0 to 100");
            }
        }

        private void StepMouseEnter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.TooltipActive == "Yes")
            {
                ToolTip ToolTipPopup = new ToolTip();
                if (Properties.Settings.Default.Language == "Russian")
                    ToolTipPopup.SetToolTip(StepLabel, "Значение шага, определяющего диапазон в таблице значений Х и Y");
                else
                    ToolTipPopup.SetToolTip(StepLabel, "The value of the step that defines the range in the table of X and Y values");
            }
        }
    }  
}

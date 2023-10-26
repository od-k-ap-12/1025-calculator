using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1025_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Operand1 = "";
        string Operand2 = "";
        string Operator = "";
        bool OperatorActive = false;
        public MainWindow()
        {
            InitializeComponent();
        }
         private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "1";
            if (OperatorActive) Operand2 += "1";
            else Operand1 += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "2";
            if (OperatorActive) Operand2 += "2";
            else Operand1 += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "3";
            if (OperatorActive) Operand2 += "3";
            else Operand1 += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "6";
            if (OperatorActive) Operand2 += "6";
            else Operand1 += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "5";
            if (OperatorActive) Operand2 += "5";
            else Operand1 += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "4";
            if (OperatorActive) Operand2 += "4";
            else Operand1 += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "7";
            if (OperatorActive) Operand2 += "7";
            else Operand1 += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "8";
            if (OperatorActive) Operand2 += "8";
            else Operand1 += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "9";
            if (OperatorActive) Operand2 += "9";
            else Operand1 += "9";
        }
        private void buttonMult_Click(object sender, EventArgs e)
        {
            if (Operand2 == "") Operator = "*";
            OperatorActive = true;
            textBoxResult.Text += "*";
            if (Operand2 != "")
            {
                textBoxPrevResult.Text = Convert.ToString(Result());
                Operand1 = textBoxPrevResult.Text;
                Operand2 = "";
                textBoxResult.Text = textBoxPrevResult.Text;
            }

        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (Operand2 == "") Operator = "+";
            OperatorActive = true;
            textBoxResult.Text += "+";
            if (Operand2 != "")
            {
                textBoxPrevResult.Text = Convert.ToString(Result());
                Operand1 = textBoxPrevResult.Text;
                Operand2 = "";
                textBoxResult.Text = textBoxPrevResult.Text;
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            textBoxPrevResult.Text = Result();
            Operand1 = textBoxPrevResult.Text;
            Operand2 = "";
            textBoxResult.Text = textBoxPrevResult.Text;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (Operand2 == "") Operator = "-";
            OperatorActive = true;
            textBoxResult.Text += "-";
            if (Operand2 != "")
            {
                textBoxPrevResult.Text = Convert.ToString(Result());
                Operand1 = textBoxPrevResult.Text;
                Operand2 = "";
                textBoxResult.Text = textBoxPrevResult.Text;
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (Operand2 == "") Operator = "/";
            OperatorActive = true;
            textBoxResult.Text += "/";
            if (Operand2 != "")
            {
                textBoxPrevResult.Text = Convert.ToString(Result());
                Operand1 = textBoxPrevResult.Text;
                Operand2 = "";
                textBoxResult.Text = textBoxPrevResult.Text;
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBoxResult.Text += "0";
            if (OperatorActive) Operand2 += "0";
            else Operand1 += "0";
        }
        private void buttonCE_Click(object sender, EventArgs e)
        {
            Operand2 = "";
            textBoxResult.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Operand1 = "";
            Operand2 = "";
            Operator = "";
            OperatorActive = false;
            textBoxResult.Text = "";
            textBoxPrevResult.Text = "";
        }

        private string Result()
        {
                if (Operator == "*")
                {
                Operand1=Operand1.Replace(',', '.');
                Operand2=Operand2.Replace(',', '.');
                return Convert.ToString(double.Parse(Operand1, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) * (double.Parse(Operand2, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)));
                }
                else if (Operator == "/")
                {
                    if (Operand2 == "0")
                    {
                        return "Error";
                    }
                    else
                    {
                    Operand1 = Operand1.Replace(',', '.');
                    Operand2 = Operand2.Replace(',', '.');
                    return Convert.ToString(double.Parse(Operand1, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) / (double.Parse(Operand2, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)));
                    }
                }
                else if (Operator == "+")
                {
                Operand1 = Operand1.Replace(',', '.');
                Operand2 = Operand2.Replace(',', '.');
                return Convert.ToString(double.Parse(Operand1, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) + (double.Parse(Operand2, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)));
                }
                else if (Operator == "-")
                {
                Operand1 = Operand1.Replace(',', '.');
                Operand2 = Operand2.Replace(',', '.');
                return Convert.ToString(double.Parse(Operand1, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture) - (double.Parse(Operand2, NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, CultureInfo.InvariantCulture)));
                }
            
            return "";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {

            if (Operand1 == "")
            {
                Operand1 += "0,";
                textBoxResult.Text += "0,";
            }
            else if (Operand2 == "" && Operand1 != "" && (OperatorActive))
            {
                Operand2 += "0,";
                textBoxResult.Text += "0,";
            }
            else if (Operand2 != "" && Operand1 != "" && (OperatorActive))
            {
                Operand2 += ",";
                textBoxResult.Text += ",";
            }
            else
            {
                Operand1 += ",";
                textBoxResult.Text += ",";
            }

        }
        private void buttonArrow_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text == "")
            {
                return;
            }
            else
            {
                if (OperatorActive)
                {
                    if (textBoxResult.Text[textBoxResult.Text.Length - 1] == Operator[0])
                    {
                        textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1);
                    }
                    else
                    {
                        Operand2 = Operand2.Remove(Operand2.Length - 1);
                        textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1);
                    }
                }
                else
                {
                    Operand1 = Operand1.Remove(Operand1.Length - 1);
                    textBoxResult.Text = textBoxResult.Text.Remove(textBoxResult.Text.Length - 1);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
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
using Calculator.Classes;

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public enum SelectedOperator
        {
            Addition,
            Subraction,
            Multiplication,
            Division
        }

        double lastNumber;

        SelectedOperator selectedOperator;    

        public MainWindow()
        {
            InitializeComponent();
            acButton.Click += AcButton_Click;
            percentButton.Click += PercentButton_Click;
            
        }

        private void NegateButton_Click(object sender, RoutedEventArgs e)
        {
            
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * (-1);
                resultLabel.Content = lastNumber.ToString();
            }
        }

        int opnumber = 1;
        int opselection = 0;
        int opcontinue = 0;

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            Button currentButton = (Button)sender;

            if(resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = currentButton.Content;
                opnumber = 0;
            }
            else if (opnumber == 1)
            {
                resultLabel.Content = currentButton.Content;
                opnumber = 0;
            }
            else
            {
                resultLabel.Content = $"{resultLabel.Content}{currentButton.Content}";
            }
        }
        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            if (opcontinue == 0)
            {
                double lastNumber2 = lastNumber;

                if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
                {
                    resultLabel.Content = lastNumber;
                }

                if (sender == addButton)
                {
                    selectedOperator = SelectedOperator.Addition;
                    resultLabel2.Content = lastNumber + " +";

                }
                if (sender == subButton)
                {
                    selectedOperator = SelectedOperator.Subraction;
                    resultLabel2.Content = lastNumber + " -";

                }
                if (sender == mulButton)
                {
                    selectedOperator = SelectedOperator.Multiplication;
                    resultLabel2.Content = lastNumber + " *";

                }
                if (sender == divButton)
                {
                    selectedOperator = SelectedOperator.Division;
                    resultLabel2.Content = lastNumber + " /";
                }
                opnumber = 1;
                opselection = 1;
                opcontinue = 1;
            }
            else if (opcontinue == 1)
            {
                double newNumber;
                double result = 0;
                if (double.TryParse(resultLabel.Content.ToString(), out newNumber))
                {
                    switch (selectedOperator)
                    {
                        case SelectedOperator.Addition:
                            result = SimpleMath.Add(lastNumber, newNumber);
                            viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                            break;

                        case SelectedOperator.Subraction:
                            result = SimpleMath.Sub(lastNumber, newNumber);
                            viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                            break;

                        case SelectedOperator.Multiplication:
                            result = SimpleMath.Mul(lastNumber, newNumber);
                            viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                            break;

                        case SelectedOperator.Division:
                            if(newNumber == 0)
                            {
                                result = SimpleMath.Div(lastNumber, newNumber);
                                result = 0;
                                viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                                break;
                            }
                            else
                            {
                                result = SimpleMath.Div(lastNumber, newNumber);
                                viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                                break;
                            }
                    }
                    if(result == 0)
                    {
                        lastNumber = 0;
                    }
                    else
                    {
                        lastNumber = result;
                    }

                    if (sender == addButton)
                    {
                        selectedOperator = SelectedOperator.Addition;
                        resultLabel2.Content = lastNumber + " +";

                    }
                    if (sender == subButton)
                    {
                        selectedOperator = SelectedOperator.Subraction;
                        resultLabel2.Content = lastNumber + " -";

                    }
                    if (sender == mulButton)
                    {
                        selectedOperator = SelectedOperator.Multiplication;
                        resultLabel2.Content = lastNumber + " *";

                    }
                    if (sender == divButton)
                    {
                        selectedOperator = SelectedOperator.Division;
                        resultLabel2.Content = lastNumber + " /";
                    }
                    opnumber = 1;
                    opselection = 1;
                    resultLabel.Content = result.ToString();
                }
            }
        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
            resultLabel2.Content = "";
            opnumber = 1;
            opselection = 0;
            opcontinue = 0;
        }

        private void PercentButton_Click(object sender, RoutedEventArgs e)
        {
            double lastNumber;
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * 0.1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            if(!resultLabel.Content.ToString().Contains("."))
            {
                resultLabel.Content = $"{resultLabel.Content}.";
            }   
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            double result = 0;
            if(double.TryParse(resultLabel.Content.ToString(), out newNumber))
            {
                if (opselection == 0)
                {
                    if(resultLabel2.Content == null)
                    {
                        resultLabel2.Content = "";
                    }
                    else
                    {
                        resultLabel2.Content = resultLabel2.Content.ToString();
                    }
                    
                }
                else
                {
                    switch (selectedOperator)
                    {
                        case SelectedOperator.Addition:
                            result = SimpleMath.Add(lastNumber, newNumber);
                            viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                            resultLabel2.Content = resultLabel2.Content.ToString() + " " + newNumber + " = ";
                            break;

                        case SelectedOperator.Subraction:
                            result = SimpleMath.Sub(lastNumber, newNumber);
                            viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                            resultLabel2.Content = resultLabel2.Content.ToString() + " " + newNumber + " = ";
                            break;

                        case SelectedOperator.Multiplication:
                            result = SimpleMath.Mul(lastNumber, newNumber);
                            viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                            resultLabel2.Content = resultLabel2.Content.ToString() + " " + newNumber + " = ";
                            break;

                        case SelectedOperator.Division:
                            if (newNumber == 0)
                            {
                                result = SimpleMath.Div(lastNumber, newNumber);
                                result = 0;
                                viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                                resultLabel2.Content = resultLabel2.Content.ToString() + " " + newNumber + " = ";
                                break;
                            }
                            else
                            {
                                result = SimpleMath.Div(lastNumber, newNumber);
                                viewtable.Items.Insert(0, resultLabel2.Content.ToString() + " " + newNumber + " = " + result.ToString());
                                resultLabel2.Content = resultLabel2.Content.ToString() + " " + newNumber + " = ";
                                break;
                            }
                    }
                    resultLabel.Content = result.ToString();
                    opselection = 0;
                    opcontinue = 0;
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender == DeleteButton)
            {
                if(resultLabel.Content.ToString().Length != 1)
                {
                    resultLabel.Content = resultLabel.Content.ToString().Substring(0, resultLabel.Content.ToString().Length - 1);
                }
                else
                {
                    resultLabel.Content = "0";
                }
            }
        }

        private void SqrtButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender == SqrtButton)
            {
                if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
                {
                    lastNumber = Math.Sqrt(lastNumber);
                    resultLabel.Content = lastNumber.ToString();
                }
            }
        }
        private void XXButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * lastNumber;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void XinverseButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = 1 / lastNumber;
                resultLabel.Content = lastNumber.ToString();
            }
        }
    }
}
 
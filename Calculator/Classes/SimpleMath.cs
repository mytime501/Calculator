using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator.Classes
{
    class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Sub(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Mul(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Div(double n1, double n2)
        {
            if(n2 == 0)
            {
                MessageBox.Show("0으로 나눌 수 없습니다.", "잘못된 연산", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return n1 / n2;
        }
    }
}

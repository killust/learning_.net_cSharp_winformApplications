using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int CalculateDelegate(int num);
namespace coreConsoleApp
{
    internal class DelegateExample
    {
        static int number = 100;
        public static int Add(int num)
        {
            number += num;
            return number;
        }
        public static int Mul(int num)
        {
            number *= num;
            return number;
        }
        public static int getNumber()
        {
            return number;
        }
    }
}

























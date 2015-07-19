using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class MathOperations
    {
        public int addit(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }

        public int subit(int num1, int num2)
        {
            int diff = num1 - num2;
            return diff;
        }

        public int mulit(int num1, int num2)
        {
            int prod = num1 * num2;
            return prod;
        }

        public int divit(int num1, int num2)
        {
            int modul = num1 / num2;
            return modul;
        }
    }
}

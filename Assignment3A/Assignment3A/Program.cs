using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3A
{
    class Program
    {
        static void Main(string[] args)
        {        
            Info newinfo = new Info();
            newinfo.DispInfo();

            int firstOperand = PromptforInteger();
            int secondOperand = PromptforInteger();

            MathOperation mo = new MathOperation();
            mo.FirstOperand = firstOperand;
            mo.SecondOperand = secondOperand;
                       
            int newadd = mo.AddOperation();
            Console.WriteLine("The sum of the two numbers is: " + newadd);
            Console.ReadLine();
                        
            int newsub = mo.SubtractOperation();
            Console.WriteLine("The difference between the two numbers is: " + newsub);
            Console.ReadLine();
                    
            int newmul = mo.MultiplyOperation();
            Console.WriteLine("The product of the two numbers is: " + newmul);
            Console.ReadLine();
                        
            float newmod = mo.DivisionOperation();
            Console.WriteLine("The modulous of the two numbers is: " + newmod);
            Console.ReadLine();
        }
        
        static int PromptforInteger()
        {
            Console.Write("Enter an Integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }        
    }
}

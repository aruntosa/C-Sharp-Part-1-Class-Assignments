using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class MathOperationsUI
    {

        public void DisplayMenu()
        {
            Console.WriteLine("1) Add Operation");
            Console.WriteLine("2) Subtract Operation");
            Console.WriteLine("3) Multiply Operation");
            Console.WriteLine("4) Divide Operation");
            Console.WriteLine("5) Exit");
            Console.WriteLine();
            Console.ReadLine();
        }

        public char PromptForChoice()
        {
            string inValue;
            Console.WriteLine("Enter the choice: ");
            inValue = Console.ReadLine();
            char intChoice = Convert.ToChar(inValue);
            return intChoice;
        }
        
        public void ProcessMenu()
        {
            int num1 = PromptforInteger();
            int num2 = PromptforInteger();

            char intChoice = PromptForChoice();

            if (intChoice == 1)
            {
                MathOperations newMathadd = new MathOperations();
                int newadd = newMathadd.addit(num1, num2);
                Console.WriteLine("The sum of the two numbers is: " + newadd);
                Console.ReadLine();
            }

            else if (intChoice == 2)
            {

                MathOperations newMathsub = new MathOperations();
                int newsub = newMathsub.subit(num1, num2);
                Console.WriteLine("The difference between the two numbers is: " + newsub);
                Console.ReadLine();
            }

            else if (intChoice == 3)
            {
                MathOperations newMathmul = new MathOperations();
                int newmul = newMathmul.mulit(num1, num2);
                Console.WriteLine("The product of the two numbers is: " + newmul);
                Console.ReadLine();
            }

            else if (intChoice == 4)
            {
                MathOperations newMathdiv = new MathOperations();
                int newmod = newMathdiv.divit(num1, num2);
                Console.WriteLine("The modulous of the two numbers is: " + newmod);
                Console.ReadLine();
            }
        }
        
        static int PromptforInteger()
        {
            Console.Write("Enter an Integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
    
    }
}

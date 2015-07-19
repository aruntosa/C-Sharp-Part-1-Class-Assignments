using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    class FormattedOutput
    {
            public void PromptForLetter()
             {
                Console.Write("Enter letter1 :");
                char letter1 = (char)Console.Read();
                Console.ReadLine();
                Console.Write("You entered :" + letter1);
                Console.ReadLine();

                string outputblock = String.Format("{0} \t {1} \t {2} \t {3} \t {4}", letter1, Convert.ToString(letter1, 16), Convert.ToString(letter1, 10), Convert.ToString(letter1, 8), Convert.ToString(letter1, 2));
                Console.Write(outputblock);
                Console.ReadLine();


                Console.Write("Enter letter2 :");
                char letter2 = (char)Console.Read();
                Console.ReadLine();
                Console.Write("You entered :" + letter2);
                Console.ReadLine();

                string outputblock1 = String.Format("{0} \t {1} \t {2} \t {3} \t {4}", letter2, Convert.ToString(letter2, 16), Convert.ToString(letter2, 10), Convert.ToString(letter2, 8), Convert.ToString(letter2, 2));
                Console.Write(outputblock1);
                Console.ReadLine();

                Console.Write("Enter letter3 :");
                char letter3 = (char)Console.Read();
                Console.ReadLine();
                Console.Write("You entered :" + letter3);
                Console.ReadLine();

                string outputblock3 = String.Format("{0} \t {1} \t {2} \t {3} \t {4}", letter3, Convert.ToString(letter3, 16), Convert.ToString(letter3, 10), Convert.ToString(letter3, 8), Convert.ToString(letter3, 2));
                Console.Write(outputblock3);
                Console.ReadLine();

                Console.Write("Enter letter4 :");
                char letter4 = (char)Console.Read();
                Console.ReadLine();
                Console.Write("You entered :" + letter4);
                Console.ReadLine();

                string outputblock4 = String.Format("{0} \t {1} \t {2} \t {3} \t {4}", letter4, Convert.ToString(letter4, 16), Convert.ToString(letter4, 10), Convert.ToString(letter4, 8), Convert.ToString(letter4, 2));
                Console.Write(outputblock4);
                Console.ReadLine();

                Console.Write("Enter letter5 :");
                char letter5 = (char)Console.Read();
                Console.ReadLine();
                Console.Write("You entered :" + letter5);
                Console.ReadLine();

                string outputblock5 = String.Format("{0} \t {1} \t {2} \t {3} \t {4}", letter5, Convert.ToString(letter5, 16), Convert.ToString(letter5, 10), Convert.ToString(letter5, 8), Convert.ToString(letter5, 2));
                Console.Write(outputblock5);
                Console.ReadLine();
            }
        
        


       

    }  
        
}

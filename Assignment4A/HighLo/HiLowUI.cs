using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLo
{
   
        public class HiLowUI
        {
            int input;
            string userVal;
            HiLow newob = new HiLow();            
            
            public void Play()
            {
                Welcome();                          
                int newgoal = newob.CreateGoal();
                for (int i = 0; i < 100; i++)
                {
                    newob.Compare();
                }
            }

            public void PlayGame()
            {
                Console.WriteLine("");
                Console.WriteLine("Do you want to play y/n ?: ");
                string userValue = Console.ReadLine();
                if (userValue == "y")
                    Play();
                else
                    Environment.Exit(0);
            }

            public string Menu()
            {                
                Console.WriteLine("");
                Console.WriteLine("1) Easy");
                Console.WriteLine("");
                Console.WriteLine("2) Medium");
                Console.WriteLine("");
                Console.WriteLine("3) Difficult");
                Console.WriteLine("");
                Console.WriteLine("Please choose the difficulty level : ");
                Console.WriteLine("");
                userVal = (Console.ReadLine());
                return userVal;
            }

            public int PromptforInteger()
            {
                Console.WriteLine("");
                Console.Write("Enter a number : ");
                input = Convert.ToInt32(Console.ReadLine());                
                return input;
            }

            public void Welcome()
            {
                Console.WriteLine(""); 
                Console.WriteLine("******************************");
                Console.WriteLine("** THE ULTIMATE HI LOW GAME **");
                Console.WriteLine("** Try to guess the number ***");
                Console.WriteLine("******************************");
                Console.WriteLine("");
            }            
        }
    }


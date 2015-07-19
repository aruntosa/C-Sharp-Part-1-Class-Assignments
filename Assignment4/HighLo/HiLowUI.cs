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
            HiLow newob = new HiLow();
            
            public void Play()
            {
                Welcome();
                newob.CreateGoal();
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
                string userVal = Console.ReadLine();
                if (userVal == "y")
                    Play();
                else
                    Environment.Exit(0);
            }

            public int PromptforInteger()
            {
                Console.WriteLine("");
                Console.Write("Enter a number between 1 and 100: ");
                input = Convert.ToInt32(Console.ReadLine());
                return input;
            }

            public void Welcome()
            {
                Console.WriteLine(""); 
                Console.WriteLine("******************************");
                Console.WriteLine("** THE ULTIMATE HI LOW GAME **");
                Console.WriteLine("** Try to geuess the number **");
                Console.WriteLine("******************************");
                Console.WriteLine("");
            }
        }

    }


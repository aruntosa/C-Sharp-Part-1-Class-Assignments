using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLo
{
    class HiLow
    {
        private int goal;
        public int num;
        private string result;
        
        public HiLow()
        {
            goal = 0;
            num = 0;
            result = "";
        }
        
        public int Goal
        {
            get
            {
                return goal;
            }
            set
            {
                goal = value;
            }
        }

        public string Result
        {
            get
            {
                return result;
            }
            set
            {
                if (num < 1)
                {
                    result = "Invalid entry";
                }
                else if (num > 100)
                {
                    result = "Invalid entry";
                }
                else 
                    result = value;
                
            }
        }

        public void Compare()
        {
            HiLowUI newobj = new HiLowUI();
            num = newobj.PromptforInteger();

            if (num > 100)
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Entry, Please enter a number between 1 and 100 only");
                Console.WriteLine("");
            }
            else if (num < 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Entry, Please enter a number between 1 and 100 only");
                Console.WriteLine("");
            }
            else
            {

                if (num == Goal)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Display Result : Correct");
                    Console.WriteLine("");
                    newobj.PlayGame();
                }

                else if (num > Goal)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Display Result : Too High");
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Display Result : Too Low");
                    Console.WriteLine("");
                }
            }
        } 
                
        public int CreateGoal()
        {
            System.Random r = new Random(); //instantiate the random class
            Goal = r.Next(1, 100); //declaring variable for the random number;
            return Goal;
        }
    }
}




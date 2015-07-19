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

        public int CreateGoal()
        { 
            HiLowUI newobj = new HiLowUI();
            string level = newobj.Menu();

            switch (level)
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a number between 1 and 10");
                    CreateGoalEasy();
                    break;
                case "2":
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a number between 1 and 50");
                    CreateGoalMedium();
                    break;
                case "3":
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a number between 1 and 100");
                    CreateGoalDifficult();
                    break;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a valid input : 1, 2 or 3");
                    break;
            }
            return Goal;
        }

        public int CreateGoalEasy()
        {
            
            System.Random r = new Random(); 
            Goal = r.Next(1, 10);
            return Goal;
        }

        public int CreateGoalMedium()
        {
            System.Random rr = new Random();
            Goal = rr.Next(11, 50);
            return Goal;
        }

        public int CreateGoalDifficult()
        {            
            System.Random rrr = new Random();
            Goal = rrr.Next(51, 100);
            return Goal;
        }
    }
}
    





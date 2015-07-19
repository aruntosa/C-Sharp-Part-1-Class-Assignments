using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello_KK
{
    class Program
    {
        static void Main()
        {
            DisplayInfo();
            Console.ReadLine();
        }
        static void DisplayInfo()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Arun Kumar Kanakasabai");
            Console.WriteLine("Introduction to Object Oriented Programming, ITDEV 110");
            Console.WriteLine("Matthew");
            Console.WriteLine("Assignment 1A - Compile on Command line");
            Console.WriteLine("Date: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("*******************************************");
        }
    }
}

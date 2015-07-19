using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Info newinfo = new Info();
            newinfo.DispInfo();

            MathOperationsUI moui = new MathOperationsUI();
            moui.DisplayMenu();
            moui.ProcessMenu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLo
{
    class Program
    {
        static void Main(string[] args)
        {
            Info newInfo = new Info();
            newInfo.DispInfo();

            HiLowUI newobj = new HiLowUI();
            newobj.PlayGame();
        }
    }
}

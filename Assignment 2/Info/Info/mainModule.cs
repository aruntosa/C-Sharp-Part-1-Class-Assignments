using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    class mainModule
    {
        static void Main(string[] args)
        {
            Info newinfo = new Info();
            newinfo.DispInfo("Assignment");

            FormattedOutput newfo = new FormattedOutput();
            newfo.PromptForLetter();
        }
    }
}

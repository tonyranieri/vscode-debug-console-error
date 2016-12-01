using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VSCodeIssue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var spinner = new ConsoleSpinner();

            Console.WriteLine("This will work on command line, fail in VS Code Debug Console");
            while(true)
            {
                spinner.Turn();
            }
        }
    }
}

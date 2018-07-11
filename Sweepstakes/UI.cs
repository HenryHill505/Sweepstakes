using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class UI
    {
        public string PromptForSweepstakesManager()
        {
            Console.WriteLine("Would you like to organize your sweepstakes into a stack or a queue?");
            return Console.ReadLine();
        }
    }
}

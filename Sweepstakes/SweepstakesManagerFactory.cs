using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesManagerFactory
    {
        public ISweepstakesManager CreateSweepstakesManager(string sweepstakesManager)
        {
            switch (sweepstakesManager)
            {
                case "Queue":
                    return new SweepstakesQueueManager();
                case "Stack":
                    return new SweepstakesStackManager();
                default:
                    Console.WriteLine("Entered invalid sweepstakes manager type. Enter Stack or Queue");
                    return CreateSweepstakesManager(Console.ReadLine());
            }
        }
    }
}

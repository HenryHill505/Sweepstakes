using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class SweepstakesManagerFactory
    {
        static public ISweepstakesManager CreateSweepstakesManager(string sweepstakesManager)
        {
            switch (sweepstakesManager.ToLower())
            {
                case "queue":
                    return new SweepstakesQueueManager();
                case "stack":
                    return new SweepstakesStackManager();
                default:
                    Console.WriteLine("Entered invalid sweepstakes manager type. Enter stack or queue");
                    return CreateSweepstakesManager(Console.ReadLine());
            }
        }
    }
}

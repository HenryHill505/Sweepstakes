using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();

        public int Count
        {
            get
            {
                return sweepstakesQueue.Count;
            }
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.First();
        }
    }
}

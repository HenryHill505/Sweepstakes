﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface ISweepstakesManager
    {
        void EndSweepstakes();
        void InsertSweepstakes(Sweepstakes sweepstakes);
        Sweepstakes GetSweepstakes();
        int Count
        {
            get;
        }
    }
}

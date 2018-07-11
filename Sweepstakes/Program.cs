using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationMaster app = new ApplicationMaster(new MarketingFirm(SweepstakesManagerFactory.CreateSweepstakesManager(UI.PromptForSweepstakesManager())));
        }
    }
}

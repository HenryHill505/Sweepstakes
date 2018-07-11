using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class ApplicationMaster
    {
        MarketingFirm firm;
       public ApplicationMaster(MarketingFirm firm)
        {
            this.firm = firm;
        }

        public void ManageSweepStakes()
        {
            switch (UI.PromptForSweepstakesManagementChoice())
            {
                case "1":
                    break;
                case "2":
                    break;
                default:
                    break;
            }
        }
    }
}

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

        public void ManageAllSweepStakes()
        {
            switch (UI.PromptForSweepstakesManagementChoice())
            {
                case "1":
                    ManageCurrentSweepStakes();
                    break;
                case "2":
                    firm.sweepstakesManager.InsertSweepstakes(new Sweepstakes(UI.PromptForSweepstakesName()));
                    break;
                default:
                    break;
            }
        }

        
    }
}

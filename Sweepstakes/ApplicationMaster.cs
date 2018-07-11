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

        public void ManageAllSweepstakes()
        {
            switch (UI.PromptForAllSweepstakesManagementChoice())
            {
                case "1":
                    ManageCurrentSweepstakes(firm);
                    break;
                case "2":
                    firm.sweepstakesManager.InsertSweepstakes(new Sweepstakes(UI.PromptForSweepstakesName()));
                    break;
                default:
                    break;
            }
        }

        public void ManageCurrentSweepstakes(MarketingFirm firm)
        {
            switch (UI.PromptForCurrentSweepstakesManagementChoice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
            }
        }
    }
}

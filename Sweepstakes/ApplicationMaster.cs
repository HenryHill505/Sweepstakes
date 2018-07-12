using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class ApplicationMaster
    {
        MarketingFirm firm;
        SmtpClient smtp;
       public ApplicationMaster(SmtpClient smtp, MarketingFirm firm)
        {
            this.firm = firm;
            this.smtp = smtp;
        }

        public void ManageAllSweepstakes()
        {
            if (firm.sweepstakesManager.Count > 0)
            {
                Console.WriteLine($"Current Sweepstakes: {firm.sweepstakesManager.GetSweepstakes().name}");
            }
            switch (UI.PromptForAllSweepstakesManagementChoice())
            {
                case "1":
                    if (firm.sweepstakesManager.Count > 0)
                    {
                        ManageCurrentSweepstakes(firm);
                    }
                    else
                    {
                        Console.WriteLine("There are currently no sweepstakes. Please create a sweepstakes");
                    }
                    break;
                case "2":
                    firm.sweepstakesManager.InsertSweepstakes(new Sweepstakes(UI.PromptForSweepstakesName()));
                    break;
                default:
                    break;
            }
            Console.Clear();
            ManageAllSweepstakes();
        }

        public void ManageCurrentSweepstakes(MarketingFirm firm)
        {
            Sweepstakes sweepstakes = firm.sweepstakesManager.GetSweepstakes();
            switch (UI.PromptForCurrentSweepstakesManagementChoice())
            {
                case "1":
                    //Register New Contestant
                    {
                        Contestant contestant = new Contestant();
                        contestant.firstName = UI.PromptForContestantFirstName();
                        contestant.lastName = UI.PromptForContestantLastName();
                        contestant.emailAddress = UI.PromptForContestantEmail();
                        sweepstakes.RegisterContestant(contestant);
                    }
                    break;
                case "2":
                    //Display Contestant Info
                    foreach (Contestant contestant in sweepstakes.contestants.Values)
                    {
                        sweepstakes.PrintContestantInfo(contestant);
                    }
                    break;
                case "3":
                    // Pick Winner
                    Console.WriteLine(sweepstakes.PickWinner(smtp) + " is the winner.");
                    Console.ReadLine();
                    firm.sweepstakesManager.EndSweepstakes();
                    break;
                default:
                    break;
            }
        }
    }
}

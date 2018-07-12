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
            Console.Clear();
            PrintCurrentSweepstakes();
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
                        Console.ReadLine();
                    }
                    break;
                case "2":
                    firm.sweepstakesManager.InsertSweepstakes(new Sweepstakes(UI.PromptForSweepstakesName()));
                    break;
                default:
                    break;
            }
            ManageAllSweepstakes();
        }

        public void ManageCurrentSweepstakes(MarketingFirm firm)
        {
            Console.Clear();
            Sweepstakes sweepstakes = firm.sweepstakesManager.GetSweepstakes();
            Console.WriteLine(sweepstakes.name);
            switch (UI.PromptForCurrentSweepstakesManagementChoice())
            {
                case "1":
                    RegisterContestant(sweepstakes);
                    ManageCurrentSweepstakes(firm);
                    break;
                case "2":
                    PrintRegisteredContestants(sweepstakes);
                    ManageCurrentSweepstakes(firm);
                    break;
                case "3":
                    Console.WriteLine(sweepstakes.PickWinner(smtp) + " is the winner.");
                    Console.ReadLine();
                    firm.sweepstakesManager.EndSweepstakes();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid entry. Enter a number corresponding to an option");
                    Console.ReadLine();
                    ManageCurrentSweepstakes(firm);
                    break;
            }
        }

        public void PrintCurrentSweepstakes()
        {
            if (firm.sweepstakesManager.Count > 0)
            {
                Console.WriteLine($"Current Sweepstakes: {firm.sweepstakesManager.GetSweepstakes().name}");
            }
        }

        public void PrintRegisteredContestants(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Registered Contestants");
            foreach (Contestant contestant in sweepstakes.contestants.Values)
            {
                sweepstakes.PrintContestantInfo(contestant);
            }
            Console.ReadLine();
        }
        
        public void RegisterContestant(Sweepstakes sweepstakes)
        {
            Contestant contestant = new Contestant();
            contestant.firstName = UI.PromptForContestantFirstName();
            contestant.lastName = UI.PromptForContestantLastName();
            contestant.emailAddress = UI.PromptForContestantEmail();
            sweepstakes.RegisterContestant(contestant);
        }
    }
}

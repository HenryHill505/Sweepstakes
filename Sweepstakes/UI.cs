using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UI
    {
        public static string PromptForContestantFirstName()
        {
            Console.WriteLine("Enter the contestant's first name:");
            return Console.ReadLine();
        }
        
        public static string PromptForContestantLastName()
        {
            Console.WriteLine("Enter the contestant's last name:");
            return Console.ReadLine();
        }

        public static string PromptForContestantEmail()
        {
            Console.WriteLine("Enter the contestant's email address:");
            return Console.ReadLine();
        }

        public static string PromptForSweepstakesManager()
        {
            Console.WriteLine("Would you like to organize your sweepstakes into a stack or a queue?");
            return Console.ReadLine();
        }

        public static string PromptForSweepstakesName()
        {
            Console.WriteLine("Enter a name for this sweepstakes");
            return Console.ReadLine();
        }

        public static string PromptForAllSweepstakesManagementChoice()
        {
            Console.WriteLine("1. Manage Current Sweepstakes\n2. Create New Sweepstakes");
            return Console.ReadLine();
        }

        public static string PromptForCurrentSweepstakesManagementChoice()
        {
            Console.Clear();
            Console.WriteLine("1. Register New Contestant\n2. DisplayContestantInfo\n3. Pick Winner\n4. Back");
            return Console.ReadLine();
        }
    }
}

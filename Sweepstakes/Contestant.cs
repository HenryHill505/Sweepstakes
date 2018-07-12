using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public void Notify(int winnerNumber, string winnerName)
        {
            if (winnerNumber == registrationNumber)
            {
                Console.WriteLine($"Congratulations, {winnerName}. You won the sweepstakes!");
            }
            else
            {
                Console.WriteLine($"{firstName} {lastName}, you did not win the sweepstakes. {winnerName} won, not you. Better luck next time!");
            }
        }
    }
}

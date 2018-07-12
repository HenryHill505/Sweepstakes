using System;
using System.Net;
using System.Net.Mail;
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

        public void Notify(SmtpClient smtp, int winnerNumber, string winnerName)
        {
            if (winnerNumber == registrationNumber)
            {
                smtp.Send("Smtptest505@gmail.com", emailAddress, "Sweepstakes results", $"Congratulations, {winnerName}. You won the sweepstakes!");
            }
            else
            {
                smtp.Send("Smtptest505@gmail.com", emailAddress, "Sweepstakes results", $"{firstName} {lastName}, you did not win the sweepstakes. {winnerName} won, not you. Better luck next time!");
            }
        }
    }
}

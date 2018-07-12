using System;
using System.Net;
using System.Net.Mail;
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
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential credentials = new NetworkCredential("Smtptest505", "Testpassword505");
            smtp.Credentials = credentials;
            smtp.EnableSsl = true;

            ApplicationMaster app = new ApplicationMaster(smtp, new MarketingFirm(SweepstakesManagerFactory.CreateSweepstakesManager(UI.PromptForSweepstakesManager())));
            app.ManageAllSweepstakes();
        }
    }
}

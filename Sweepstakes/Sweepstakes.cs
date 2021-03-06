﻿using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        public string name;
        public Dictionary<int, Contestant> contestants;
        public Random randomizer;

        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant >();
            randomizer = new Random();
        }

        public string PickWinner(SmtpClient smtp)
        {
            int contestantCount = contestants.Count;
            int winnerRegistrationNumber = randomizer.Next(1, contestantCount + 1);
            string winnerName = $"{contestants[winnerRegistrationNumber].firstName} {contestants[winnerRegistrationNumber].lastName}";
            NotifyContestants(smtp, winnerRegistrationNumber, winnerName);
            return winnerName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.registrationNumber} {contestant.firstName} {contestant.lastName} {contestant.emailAddress}");
        }

        public void NotifyContestants(SmtpClient smtp, int winnerNumber, string winnerName)
        {
            foreach(Contestant contestant in contestants.Values)
            {
                contestant.Notify(smtp, winnerNumber, winnerName);
            }
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = contestants.Count + 1;
            contestants.Add(contestant.registrationNumber, contestant);
        }
    }
}

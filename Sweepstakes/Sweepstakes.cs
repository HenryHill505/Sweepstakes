using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        string name;
        Dictionary<int, Contestant> contestants;
        Random randomizer;

        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant >();
            randomizer = new Random();
        }

        public string PickWinner()
        {
            int contestantCount = contestants.Count;
            int winnerRegistrationNumber = randomizer.Next(1, contestantCount + 1);
            string winnerName = $"{contestants[winnerRegistrationNumber].firstName} {contestants[winnerRegistrationNumber].lastName}";
            return winnerName;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }
    }
}

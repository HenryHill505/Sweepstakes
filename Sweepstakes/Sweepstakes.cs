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

        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant >();
        }

        public string PickWinner()
        {

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

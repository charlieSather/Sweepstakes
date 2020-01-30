using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Sweepstakes
    {
        Dictionary<int,Contestant> contestants;
        string name;
        string Name
        {
            get { return name; }
        }

        public Sweepstakes(string name )
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {

        }

        public Contestant PickWinner()
        {
            return new Contestant();
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}

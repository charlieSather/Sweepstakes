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
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            Random rand = new Random();

            List<int> keys = new List<int>();
            keys.AddRange(contestants.Keys);

            return contestants[keys[rand.Next(0, keys.Count)]];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.FirstName} {contestant.LastName},Email: {contestant.EmailAddress}, #{contestant.RegistrationNumber}");
        }
    }
}

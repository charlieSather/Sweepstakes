using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        string name;
        public string Name
        {
            get { return name; }
        }

        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
            contestant.AssignRegistrationNumber(contestants.Count);
        }

        public Contestant PickWinner()
        {
            Random rand = new Random();
            return contestants[rand.Next(0, contestants.Count)];
        }

        public void NotifyContestants(string winner)
        {
            foreach (Contestant contestant in contestants.Values)
            {
                contestant.Notify(winner);
                contestant.Email(winner, name);
            }
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.FirstName} {contestant.LastName},Email: {contestant.EmailAddress}, #{contestant.RegistrationNumber}");
        }

    }
}

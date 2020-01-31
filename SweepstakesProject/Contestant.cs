using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Contestant : INotify
    {
        string firstname;
        public string FirstName { get { return firstname; } }

        string lastname;
        public string LastName { get { return lastname; } }

        string emailAddress;
        public string EmailAddress { get { return lastname; } }

        int registrationNumber;
        public int RegistrationNumber { get { return registrationNumber; } }

        public Contestant(string FirstName,string LastName, string EmailAddress, int RegistrationNumber)
        {
            this.firstname = FirstName;
            this.lastname = LastName;
            this.emailAddress = EmailAddress;
            this.registrationNumber = RegistrationNumber;
        }

        public void Notify(string winner)
        {
            if (winner == registrationNumber.ToString())
            {
                Console.WriteLine("Congratulations {0} {1} you have won!!)", FirstName, LastName);
            }
            else
            {
                Console.WriteLine("Oh No!! You lost :(");
            }
        }
    }
}

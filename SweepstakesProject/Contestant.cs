using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace SweepstakesProject
{
    public class Contestant : INotify
    {
        string firstname;
        public string FirstName { get { return firstname; } }

        string lastname;
        public string LastName { get { return lastname; } }

        string emailAddress;
        public string EmailAddress { get { return emailAddress; } }

        int registrationNumber;
        public int RegistrationNumber { get { return registrationNumber; } }

        public Contestant(string FirstName, string LastName, string EmailAddress)
        {
            this.firstname = FirstName;
            this.lastname = LastName;
            this.emailAddress = EmailAddress;
        }

        public void Notify(Contestant winner)
        {
            if (winner.RegistrationNumber == registrationNumber)
            {
                Console.WriteLine("Congratulations {0} {1} you have won!!)", FirstName, LastName);
            }
            else
            {
                Console.WriteLine("Oh No!! You lost {0} {1} :(", FirstName, LastName);
            }
        }

        public void Email(Contestant winner, string sweepstakes)
        {
            try
            {
                var message = new MimeMessage();

                message.From.Add(new MailboxAddress($"ChuckMan", $"cmangia12@gmail.com"));
                message.To.Add(new MailboxAddress($"{FirstName} {LastName}", $"{EmailAddress}"));

                message.Subject = ("Sweepstakes Results");

                message.Body = new TextPart("plain")
                {
                    Text = $@"Dear {FirstName} {LastName},
We are pleased to announce that {winner.FirstName} {winner.LastName} has won this year's {sweepstakes} sweepstakes!!!"
                };

                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                    string[] splitAt = EmailAddress.Split('@');
                    string[] splitWebsite = splitAt[1].Split('.');

                    client.Connect($"smtp.{splitWebsite[0]}.{splitWebsite[1]}", 587, false);

                    client.Authenticate("cmangia12@gmail.com", "ChuckMan!2121:");

                    client.Send(message);
                    client.Disconnect(true);
                };
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
            
        }

        public void AssignRegistrationNumber(int regNumber)
        {
            registrationNumber = regNumber;
        }
    }
}

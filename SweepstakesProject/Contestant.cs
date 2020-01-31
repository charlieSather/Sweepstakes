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
    class Contestant : INotify
    {
        string firstname;
        public string FirstName { get { return firstname; } }

        string lastname;
        public string LastName { get { return lastname; } }

        string emailAddress;
        public string EmailAddress { get { return emailAddress; } }

        int registrationNumber;
        public int RegistrationNumber { get { return registrationNumber; } }

        //public Contestant(string FirstName,string LastName, string EmailAddress, int RegistrationNumber)
        //{
        //    this.firstname = FirstName;
        //    this.lastname = LastName;
        //    this.emailAddress = EmailAddress;
        //    this.registrationNumber = RegistrationNumber;
        //}

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
        public void Email(string winner, string sweepstakes)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress($"ChuckMan", $"cmangia12@gmail.com"));
            message.To.Add(new MailboxAddress($"{FirstName} {LastName}", $"{EmailAddress}"));

            message.Subject = ("Sweepstakes Results");

            message.Body = new TextPart("plain")
            {
                Text = $@"Dear {FirstName} {LastName},
We are pleased to announce that {winner} has won this year's {sweepstakes} sweepstakes!!!"
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                string[] splitAt = EmailAddress.Split('@');
                string[] splitWebsite = splitAt[1].Split('.');

                client.Connect($"smtp.{splitWebsite[0]}.{splitWebsite[1]}", 587, false);

                client.Authenticate("cmangia12@gmail.com", "ChuckMan!2121:");
                //ignore authentication for now

                client.Send(message);
                client.Disconnect(true);
            };

        }
    }
}

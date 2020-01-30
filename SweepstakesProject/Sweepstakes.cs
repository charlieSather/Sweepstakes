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
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        string name;
        string Name
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
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            Random rand = new Random();

            List<int> keys = new List<int>();
            keys.AddRange(contestants.Keys);

            Contestant winner = contestants[keys[rand.Next(0, keys.Count)]];

            var message = new MimeMessage();

            message.From.Add(new MailboxAddress($"{name}", $"{name}@yahoo.com"));
            message.To.Add(new MailboxAddress($"{winner.FirstName} {winner.LastName}", $"{winner.EmailAddress}"));
            message.Subject = ("Winner winner chicken dinner");

            message.Body = new TextPart("plain")
            {
                Text = $@"Dear {winner.FirstName} {winner.LastName},
We are pleased to announce that you have won this year's {name} sweepstakes. Congratulations!!!"
            };

            //using (var client = new SmtpClient())
            //{
            //    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

            //    client.Connect("")
            //}












                return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"{contestant.FirstName} {contestant.LastName},Email: {contestant.EmailAddress}, #{contestant.RegistrationNumber}");
        }
    }
}

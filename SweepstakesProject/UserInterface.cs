using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SweepstakesProject
{
    public static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            switch (prompt)
            {
                case ("First"):
                    Console.WriteLine("Enter first name:");
                    break;
                case ("Last"):
                    Console.WriteLine("Enter last name:");
                    break;
                case ("Email"):
                    Console.WriteLine("Enter email address:");
                    break;
                case ("Number"):
                    Console.WriteLine("Enter registration Number:");
                    break;
                case ("Sweepstake"):
                    Console.WriteLine("Enter name for sweepstake");
                    break;                    
            }
            string input = Console.ReadLine();
            return input;
        }

        public static (string, string, string, int) GetContestantInfo()
        {
            string firstName = GetName("first");
            string lastName = GetName("last");
            string email = GetEmail(new Regex(@"^\w+@\w+(.com)$"));
            int registrationNumber = GetRegistrationNumber(new Regex(@"^\d{1-3}$"));

            return (firstName, lastName, email, registrationNumber);
        }

        private static string GetName(string type)
        {
            Console.WriteLine($"Please enter your {type} name");
            string input = Console.ReadLine();
            switch (input)
            {
                case (""):
                    return GetName(type);
                default:
                    return input;
            }
        }
        private static string GetEmail(Regex reg)
        {
            Console.WriteLine($"Please enter your email Address");
            string input = Console.ReadLine();
            if (reg.IsMatch(input))
            {
                return input;
            }
            else
            {
                return GetEmail(reg);
            }
        }
        private static int GetRegistrationNumber(Regex reg)
        {
            Console.WriteLine($"Please enter your email Address");
            string input = Console.ReadLine();
            if (reg.IsMatch(input))
            {
                return Int32.Parse(input);
            }
            else
            {
                return GetRegistrationNumber(reg);
            }
        }

        public static string GetMarketingFirm()
        {
            Console.WriteLine("Choose manager type:\n1: Stack\n2:Queue");
            switch (Console.ReadLine().ToLower())
            {
                case ("1"):
                    return "stack";
                case ("2"):
                    return "queue";
                default:
                    return GetMarketingFirm();
            }
        }
    }
}

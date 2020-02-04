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

        public static (string, string, string) GetContestantInfo()
        {
            string firstName = GetName("first");
            string lastName = GetName("last");
            string email = GetEmail(new Regex(@"^\w+@\w+(.com)$"));

            return (firstName, lastName, email);
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
        
        public static string GetMarketingFirm()
        {
            Console.WriteLine("Choose manager type:\n1: Stack\n2: Queue");
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

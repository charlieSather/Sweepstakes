using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class UserInterface
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
            }
            string input = Console.ReadLine();
            return input;
        }
    }
}

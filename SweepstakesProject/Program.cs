using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation sim = new Simulation();
            sim.CreateMarketingFirmWithManager();


            Contestant Charlie = new Contestant("Charlie", "S", "charliesather18@gmail.com", 1);
            Charlie.Email("David S", "Grand");

        }
    }
}

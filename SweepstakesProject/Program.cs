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

            //Sweepstakes sweepstakes = new Sweepstakes("Grand");

            //sweepstakes.RegisterContestant(new Contestant("Charlie", "Sather", "halo@uwm.edu"));
            //sweepstakes.RegisterContestant(new Contestant("Dave", "Steinhafel", "dman@gmail.com"));
            //sweepstakes.RegisterContestant(new Contestant("Sprite", "M", "sodaCrusher@gmail.com"));
            //sweepstakes.RegisterContestant(new Contestant("Cole", "K", "policeNeverLose@gmail.com"));
            

            //foreach (Contestant contestant in sweepstakes.getDict().Values)
            //{
            //    sweepstakes.PrintContestantInfo(contestant);
            //}

            //Console.WriteLine("\n");

            //sweepstakes.NotifyContestants(sweepstakes.PickWinner());

            //Console.ReadLine();



        }
    }
}

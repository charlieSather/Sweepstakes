using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class Simulation
    {
        MarketingFirm mf;
        public void CreateMarketingFirmWithManager()
        {
            string manager = UserInterface.GetUserInputFor("Manager");

            switch (manager.ToLower())
            {
                case ("stack"):
                    mf = new MarketingFirm(new SweepstakesStackManager());
                    break;
                case ("queue"):
                    mf = new MarketingFirm(new SweepstakesQueueManager());
                    break;
            }
        }
    }
}

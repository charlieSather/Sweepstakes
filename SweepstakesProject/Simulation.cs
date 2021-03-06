﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Simulation
    {
        MarketingFirm mf;
        public void CreateMarketingFirmWithManager()
        {
            switch (UserInterface.GetMarketingFirm())
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

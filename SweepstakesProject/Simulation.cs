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
            mf = UserInterface.GetMarketingFirm();
        }
    }
}

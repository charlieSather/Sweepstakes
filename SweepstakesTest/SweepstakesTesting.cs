using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SweepstakesProject;

namespace SweepstakesTest
{
    [TestClass]
    public class SweepstakesTesting
    {
        [TestMethod]
        public void PickWinner_TestPickkingWinner()
        {


            
        }

        [TestMethod]
        public void RegisterContestant_AddThreeContestantsWithStack()
        {
            MarketingFirm mf = new MarketingFirm(new SweepstakesStackManager());

            Sweepstakes sweepstakes = new Sweepstakes("Grand");

            sweepstakes.RegisterContestant(new Contestant("Charlie", "S", "halo1@yahoo.com", 1));
            sweepstakes.RegisterContestant(new Contestant("Craig", "S","halo2@yahoo.com", 2));
            sweepstakes.RegisterContestant(new Contestant("Chris", "S", "halo3@yahoo.com", 3));

            mf._manager.InsertSweepstakes(sweepstakes);

            Sweepstakes sweepstakes2 = new Sweepstakes("Grand2");
            mf._manager.InsertSweepstakes(sweepstakes2);


            mf._manager.GetSweepstakes();

            Assert.AreEqual("Grand", mf._manager.GetSweepstakes().Name);
        }

        [TestMethod]
        public void RegisterContestant_AddThreeContestantsWithQueue()
        {
            MarketingFirm mf = new MarketingFirm(new SweepstakesQueueManager());

            Sweepstakes sweepstakes = new Sweepstakes("Grand");

            sweepstakes.RegisterContestant(new Contestant("Charlie", "S", "halo1@yahoo.com", 1));
            sweepstakes.RegisterContestant(new Contestant("Craig", "S", "halo2@yahoo.com", 2));
            sweepstakes.RegisterContestant(new Contestant("Chris", "S", "halo3@yahoo.com", 3));

            mf._manager.InsertSweepstakes(sweepstakes);

            Sweepstakes sweepstakes2 = new Sweepstakes("Grand2");
            mf._manager.InsertSweepstakes(sweepstakes2);



            Assert.AreEqual("Grand",mf._manager.GetSweepstakes().Name) ;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    interface INotify
    {
        void Notify(Contestant winner);
        void Email(Contestant winner, string sweepstakes);
    }
}

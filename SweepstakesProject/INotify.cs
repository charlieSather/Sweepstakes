﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    interface INotify
    {
        void Notify(string winner);
        void Email(string winner, string sweepstakes);
    }
}

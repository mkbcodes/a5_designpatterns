﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    public interface IObserver
    {
        void Update(decimal currentBidPrice);
    }

}
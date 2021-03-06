﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    public abstract class Price
    {
        abstract public int GetPriceCode();

        abstract public double GetCharge(int daysRented);

        public virtual int GetFrequentPoints(int daysRented)
        {
            return 1;
        }
    }
}

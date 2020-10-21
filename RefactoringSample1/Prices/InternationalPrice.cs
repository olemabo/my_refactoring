﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    class InternationalPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.INTERNATIONAL;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 4;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    public class ChildrenPrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.CHILDRENS;
        }

        public override double GetCharge(int daysRented)
        {
            double thisAmount = 1.5;
            if (daysRented > 3)
            {
                thisAmount += (daysRented - 3) * 1.5;
            }
            return thisAmount;
        }


    }
}

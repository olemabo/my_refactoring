using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    class NewRealeasePrice : Price
    {
        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }

        public override double GetCharge(int daysRented)
        {
            return daysRented * 3;
        }

        public override int GetFrequentPoints(int daysRented)
        {
            var frequentRenterPoints = 1;
            if (daysRented > 1)
                frequentRenterPoints++;
            return frequentRenterPoints;
        }
    }
}

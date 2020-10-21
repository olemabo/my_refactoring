using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
	public class Rental
	{
		private Movie _movie;
		private int _daysRented;

		public Rental(Movie movie, int daysRented)
		{
			_movie = movie;
			_daysRented = daysRented;
		}
		public int GetDaysRented()
		{
			return _daysRented;
		}
		public Movie GetMovie()
		{
			return _movie;
		}
               
       
        public static double GetCharge(Rental rental)
        {
            int daysRented = rental.GetDaysRented();
            double thisAmount = rental.GetMovie().GetCharge(daysRented);
            return thisAmount;
        }



        public static int GetFrequentPoints(Rental rental)
        {
            // more lines than necessary, just to make things more clear in the beginning 
            int daysRented = rental.GetDaysRented();
            int frequentPoints = rental.GetMovie().GetFrequentPoints(daysRented);
            return frequentPoints;
        }

    }
}

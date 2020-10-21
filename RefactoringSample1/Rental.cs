using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
	public class Rental
	{
		private Movie _movie;
		private int _daysRented;

		/// <summary>
		/// Rental constructor initilizing a movie object and the number of days rented
		/// </summary>
		/// <param name="movie">Movie: movie object</param>
		/// <param name="daysRented">int: days a movie has been rented</param>
		public Rental(Movie movie, int daysRented)
		{
			_movie = movie;
			_daysRented = daysRented;
		}

		/// <summary>
		/// Get function giving the number of days a movie has been rented
		/// </summary>
		/// <returns>int: the number of days a movie has been rented</returns>
		public int GetDaysRented()
		{
			return _daysRented;
		}

		/// <summary>
		/// Get function giving the Movie object
		/// </summary>
		/// <returns>Movie: the given Movie object corresponding to the rental</returns>
		public Movie GetMovie()
		{
			return _movie;
		}
               
        /// <summary>
		/// Get the total charge of the renting object
		/// </summary>
		/// <param name="rental">Rental: rental object</param>
		/// <returns>double: amount of charge for the given rental</returns>
        public static double GetCharge(Rental rental)
        {
            int daysRented = rental.GetDaysRented();
            double thisAmount = rental.GetMovie().GetCharge(daysRented);
            return thisAmount;
        }


		/// <summary>
		/// Get the total frequent points of the renting object
		/// </summary>
		/// <param name="rental">Rental: rental object</param>
		/// <returns>int: amount of frequent points for the given rental</returns>
		public static int GetFrequentPoints(Rental rental)
        {
            // more lines than necessary, just to make things more clear in the beginning 
            int daysRented = rental.GetDaysRented();
            int frequentPoints = rental.GetMovie().GetFrequentPoints(daysRented);
            return frequentPoints;
        }

    }
}

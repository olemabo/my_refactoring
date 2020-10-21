using System;

namespace RefactoringSample1
{
	public class Movie
	{
		public const int CHILDRENS = 2;
		public const int REGULAR = 0;
		public const int NEW_RELEASE = 1;
		public const int INTERNATIONAL = 3;


		private string _title;
		private Price _price;

		/// <summary>
		/// Constructor initilizing a movie object with correct movie name and price object
		/// corresponding to the given price code. 
		/// </summary>
		/// <param name="title">string: title of movie</param>
		/// <param name="priceCode">int: price code of movie</param>
		public Movie(string title, int priceCode)
		{
			_title = title;
			SetPriceCode(priceCode);
		}

		/// <summary>
		/// Set the _price object to a correct price object based on the price code.
		/// A switch statement will sett the matching price code to correct price object
		/// if it finds one, otherwise it will be set to the default object (RegularPrice()). 
		/// </summary>
		/// <param name="PriceCode">int: the price code of the movie</param>
		public void SetPriceCode(int PriceCode)
        {
			_price = PriceCode switch
			{
				CHILDRENS => new ChildrenPrice(),
				NEW_RELEASE => new NewRealeasePrice(),
				INTERNATIONAL => new InternationalPrice(),
				_ => new RegularPrice(),
			};
        }

		/// <summary>
		/// Get the price code associated with a movie object 
		/// </summary>
		/// <returns>int: price code</returns>
		public int GetPriceCode()
		{
			return _price.GetPriceCode();
		}

		/// <summary>
		/// Get the charge of renting a movie which is calculated based on the number of days rented
		/// </summary>
		/// <param name="daysRented">Number of days which a film has been rented</param>
		/// <returns>double: The charge of renting a movie for daysRented number of days</returns>
		public double GetCharge(int daysRented)
        {
			return _price.GetCharge(daysRented);
        }

		/// <summary>
		/// Get number of frequent points which is calculated based on the number of days rented
		/// </summary>
		/// <param name="daysRented">Number of days which a film has been rented</param>
		/// <returns>the number of frequent points</returns>
		public int GetFrequentPoints(int daysRented)
		{
			return _price.GetFrequentPoints(daysRented);
		}

		/// <summary>
		/// Get the title of the movie from the movie class
		/// </summary>
		/// <returns>string: title of the movie</returns>
		public string GetTitle()
		{
			return _title;
		}
	}
}

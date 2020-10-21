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
		//private int _priceCode;

		public Movie(string title, int priceCode)
		{
			_title = title;
			SetPriceCode(priceCode);
			//_priceCode = priceCode;
		}

		public void SetPriceCode(int PriceCode)
        {
			// return price 
			_price = PriceCode switch
			{
				CHILDRENS => new ChildrenPrice(),
				NEW_RELEASE => new NewRealeasePrice(),
				INTERNATIONAL => new InternationalPrice(),
				_ => new RegularPrice(),
			};
        }

		public int GetPriceCode()
		{
			return _price.GetPriceCode();
		}

		public double GetCharge(int daysRented)
        {
			return _price.GetCharge(daysRented);
        }

		public int GetFrequentPoints(int daysRented)
		{
			return _price.GetFrequentPoints(daysRented);
		}

		//public static void SetPriceCode(int arg)
		//{
		//	_priceCode = arg;
		//}

		public string GetTitle()
		{
			return _title;
		}
	}
}

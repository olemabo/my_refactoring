using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
	/// <summary>
	/// The Customer class will be a class containing information about the rental behaviour of a costumer.   
	/// </summary>
	public class Customer
	{
		private string _name;
		private List<Rental> _rentals = new List<Rental>();
		/// <summary>
		/// constructor initializing the name of the costumer
		/// </summary>
		/// <param name="name">the string name of the costumer</param>
		public Customer(string name)
		{
			_name = name;
		}

		/// <summary>
		/// Add a rental to the _rentals list.
		/// </summary>
		/// <param name="rent">Rental: renting object</param>
		public void AddRental(Rental rent)
		{
			_rentals.Add(rent);
		}

		/// <summary>
		/// Get the name of the customer
		/// </summary>
		/// <returns>string: the name of the customer</returns>
		public string GetName()
		{
			return _name;
		}

		/// <summary>
		/// Get the total charge associated with a renting object
		/// </summary>
		/// <returns>double: total charge of renting</returns>
		public double GetTotalCharge()
		{
			double result = 0;

			// add charge for each rental 
			foreach (Rental rental in _rentals)
			{
				result += Rental.GetCharge(rental);
			}

			return result;
		}

		/// <summary>
		/// Get the total frequent points associated with a renting object
		/// </summary>
		/// <returns>double: total number of frequent points of renting</returns>
		public int GetFrequentPoints()
		{
			int result = 0;

			// add frequent points for each rental 
			foreach (Rental rental in _rentals)
			{
				result += Rental.GetFrequentPoints(rental);
			}

			return result;
		}

		// Statement and Html statement are very similar, so maybe they could be connected somehow.
		// however, it seems more clean to separate them at the moment. 


		/// <summary>
		/// Function creating a string statement of the rental record
		/// </summary>
		/// <returns>string: a rental record</returns>
		public string Statement()
		{
			var result = $"Rental Record for {GetName()}\n";

			foreach (Rental rental in _rentals) 
			{ 
				//show figures for this rental
				result += $"\t{rental.GetMovie().GetTitle()}\t{Rental.GetCharge(rental)}\n";
            }

            //add footer lines
            result += $"Amount owed is {GetTotalCharge()}\n";
			result += $"You earned {GetFrequentPoints()} frequent renter points";
			return result;
		}

		/// <summary>
		/// Function creating a string statement of the rental record in html
		/// </summary>
		/// <returns>string: a rental record in html</returns>
		public string HtmlStatement()
		{
			var result = $"<h1>Rental Record for {GetName()}</h1>";

			foreach (Rental rental in _rentals)
			{
				//show figures for this rental
				result += $"<p>{rental.GetMovie().GetTitle()}\t{Rental.GetCharge(rental)}</p>";
			}

			//add footer lines
			result += $"<p>Amount owed is {GetTotalCharge()}</p>";
			result += $"<p>ou earned {GetFrequentPoints()} frequent renter points</p>";
			return result;
		}
	}
}

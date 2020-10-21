using System;
using Xunit;
using System.Collections.Generic;

namespace RefactoringSample1.Tests
{
	public class CustomerTest
	{
		private static List<Movie> _movies = new List<Movie>
			{
				new Movie("The Lion King", Movie.CHILDRENS),
				new Movie("Joker", Movie.NEW_RELEASE),
				new Movie("Avengers: Endgame", Movie.REGULAR),
				new Movie("Parasite", Movie.INTERNATIONAL)
			};

		// Strongly typed test with memberdata
		[Theory]
		[MemberData(nameof(RentalTestData))]
		public void CanCreateStatement(Rental rental1, Rental rental2, double totalAmt, int freqPoints)
		{
			var customer = new Customer("Jane Doe");
			customer.AddRental(rental1);
			customer.AddRental(rental2);
			var statement = customer.Statement();
			var htmlStatement = customer.HtmlStatement();
			var totalAmount = customer.GetTotalCharge();
			var frequentRenterPoints = customer.GetFrequentPoints();
			Assert.Equal(totalAmount, totalAmt);
			Assert.Equal(frequentRenterPoints, freqPoints);
			// just added a small check to see if the html statement is different from the normal statement
			Assert.NotEqual(statement, htmlStatement);
		}

		// Method to return rental data that is strongly typed while you add testdata
		public static TheoryData<Rental, Rental, double, int> RentalTestData()
		{
			return new TheoryData<Rental, Rental, double, int> {
				{ new Rental(_movies[0], 4), new Rental(_movies[1], 2), 9, 3 },
				{ new Rental(_movies[2], 2), new Rental(_movies[0], 3), 3.5, 2 },
				{ new Rental(_movies[1], 2), new Rental(_movies[2], 3), 9.5, 3 },
				{ new Rental(_movies[1], 4), new Rental(_movies[1], 3), 21, 4 },
				{ new Rental(_movies[0], 5), new Rental(_movies[1], 2), 10.5, 3 },
				{ new Rental(_movies[3], 2), new Rental(_movies[2], 3), 11.5, 2 },
				{ new Rental(_movies[3], 4), new Rental(_movies[3], 3), 28, 2 }
			};
		}
	}
}
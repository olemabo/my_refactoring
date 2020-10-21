using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace RefactoringSample1.Tests
{
    public class MovieTest
    {
		public static TheoryData<Movie, int> MovieTestData()
		{
			return new TheoryData<Movie, int> {
				{ new Movie("The Lion King", Movie.CHILDRENS), 2 },
				{ new Movie("Joker", Movie.NEW_RELEASE), 1 },
				{ new Movie("Avengers: Endgame", Movie.REGULAR), 0 },
				{ new Movie("Parasite", Movie.INTERNATIONAL), 3 }
			};
		}

		// Strongly typed test with memberdata
		[Theory]
		[MemberData(nameof(MovieTestData))]
		public void TestMovieObjects(Movie movie, int priceCode)
		{
			var getPriceCode = movie.GetPriceCode();
			Assert.Equal(getPriceCode, priceCode);
		}
	}
}

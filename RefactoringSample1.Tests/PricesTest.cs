using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace RefactoringSample1.Tests
{
	// dont need this test, but I added it anyway just for learning 
    public class PricesTest
    {
		public static TheoryData<Price, int, int> PriceTestData()
		{
			return new TheoryData<Price, int, int> {
				{ new NewRealeasePrice(), 2, 2},
				{ new NewRealeasePrice(), 1, 1},
				{ new RegularPrice(), 1, 1},
				{ new InternationalPrice(), 1, 1},
				{ new ChildrenPrice(), 1, 1}
			};
		}

		[Theory]
		[MemberData(nameof(PriceTestData))]
		public void TestPriceObjects(Price price, int daysRented, int frequentPoints)
		{
			var getFrequentPoints = price.GetFrequentPoints(daysRented);
			Assert.Equal(getFrequentPoints, frequentPoints);
		}
	}
}

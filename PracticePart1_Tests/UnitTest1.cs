using Xunit;
using PracticePart1;

namespace PracticePart1_Tests
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(-1, -1)] // Group these together. Negatives first.
		[InlineData(-2, -1)]
		[InlineData(0, 0)]
		[InlineData(1, 1)] // Group these together: Positives
		[InlineData(2, 1)]
		[InlineData(265728, 1)]
		[InlineData(-4539873, -1)]
		public void Test1(int value, int expected)
		{
			int actual = Coupon.GetSign(value);
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(5.0, 0.0)]
		[InlineData(9.99, 0.0)]
		[InlineData(10.00, 2.0)]
		[InlineData(19.99, 2.0)]
		[InlineData(20.0, 3.0)]
		[InlineData(20.01, 3.0)]
		[InlineData(100.0, 3.0)]
		public void TestCalcCoupon(decimal value, decimal expected)
		{
			decimal actual = Coupon.CalculateCoupon(value);
			Assert.Equal(expected, actual);
		}
	}
}

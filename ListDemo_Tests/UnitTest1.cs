using Xunit;
using ListDemo;
using System.Collections.Generic;

namespace ListDemo_Tests
{
	public class UnitTest1
	{
		[Fact]
		public void TestRemoveLargest1()
		{
			List<int> values = new List<int>() { 5, 20, 6, 3 };
			List<int> actual = MyLists.RemoveLargest(values);

			List<int> expected = new List<int>() { 5, 6, 3 };
			Assert.Equal(expected, actual);
		}

		// What to test?
		// A basic one { 5, 20, 6, 3} -> { 5, 6, 3 }
		// Double greatest { 5, 20, 6, 20, 3 } -> { 5, 6, 20, 3 }
		// Empty list: { } -> { }
		// All the same: { 5, 5, 5, 5 } -> { 5, 5, 5 }
		// Only one: { 5 } -> { }
		[Theory]
		[InlineData(   new int[] {5,20,6,3} ,      new int[] {5,6,3}           )]
		[InlineData(   new int[] {5,20,6,20,3}  ,  new int[] {5,6,20,3}        )]
		[InlineData(   new int[] { },              new int[] { }               )]
		[InlineData(   new int[] { 5,5,5,5 },      new int[] { 5,5,5 }         )]
		[InlineData(   new int[] { 5 },            new int[] { }               )]
		public void TestRemoveLarget2(int[] valuesarray, int[] expectedarray)
		{
			List<int> values = new List<int>(valuesarray);
			List<int> expected = new List<int>(expectedarray);

			List<int> actual = MyLists.RemoveLargest(values);
			Assert.Equal(expected, actual);
		}
	}
}
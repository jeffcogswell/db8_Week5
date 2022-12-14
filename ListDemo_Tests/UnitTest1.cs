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

		// Just for demonstration purposes, let's try out Assert.Contains
		[Fact]
		public void TestContainsDemo()
		{
			List<int> mylist = new List<int>() { 5, 20, 6, 3 };
			List<int> result = MyLists.RemoveLargest(mylist);

			// Let's make sure 3 is still in the list
			// What not to do, even though it feels like they should work:
			//      Assert.True(result.Contains(3));
			//      Assert.Equal(true, result.Contains(3));
			// Because the list holds integers <int>, the contains will also need <int>
			// The first parameter is what we expect to see in the list.
			// The second parameter is the list we're looking in.
			Assert.Contains<int>(3, result);
		}

	}
}
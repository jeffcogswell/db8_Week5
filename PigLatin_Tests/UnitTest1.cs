using Xunit;
using PigLatin;

namespace PigLatin_Tests
{
	public class UnitTest1
	{
		[Fact]
		public void TestIsVowelA()
		{
			bool actual = Translator.IsVowel('a');
			Assert.True(actual);
		}
		[Fact]
		public void TestIsVowelE()
		{
			bool actual = Translator.IsVowel('e');
			Assert.True(actual);
		}
		[Fact]
		public void TestIsVowelI()
		{
			bool actual = Translator.IsVowel('i');
			Assert.True(actual);
		}
		[Fact]
		public void TestIsVowelO()
		{
			bool actual = Translator.IsVowel('o');
			Assert.True(actual);
		}
		[Fact]
		public void TestIsVowelU()
		{
			bool actual = Translator.IsVowel('u');
			Assert.True(actual);
		}
		[Fact]
		public void TestIsVowelS()
		{
			bool actual = Translator.IsVowel('s');
			Assert.False(actual);
		}
		[Fact]
		public void TestIsVowelZ()
		{
			bool actual = Translator.IsVowel('z');
			Assert.False(actual);
		}
	}
}

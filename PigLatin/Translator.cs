using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatin
{
	// Change internal to public
	public class Translator
	{
		// returns true if it’s a vowel, false if it’s a consonant
		public static bool IsVowel(char ch)
		{
			if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static bool StartsWithVowel(string word)
		{
			return true;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcApp
{
	public class Calculator
	{
		public int Number { get; set; }
		public Calculator(int _Number)
		{
			Number = _Number;
		}

		public int FindFactorial()
		{
			// To find a factorial

			// Start with the number

			int result = Number;

			// Count down from one less than the number,
			// and multiply each time.
			for (int next = Number - 1; next >= 1; next--)
			{
				result = result * next;
			}

			return result;
		}

		public List<int> FindFactors()
		{
			List<int> result = new List<int>();
			return result;
		}
	}
}

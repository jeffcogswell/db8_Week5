using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
	public class CashRegister
	{
		// One function: Takes a list of products
		// and calculates the grand total price.

		public static decimal GrandTotal(List<Product> prods)
		{
			decimal total = 0.0m;
			foreach (Product prod in prods)
			{
				total += prod.Price;
			}
			return total;
		}

		// Second function: Takes a list of products
		// and calculates the sales tax. (Say 6% or
		// whatever you like.)
	}
}

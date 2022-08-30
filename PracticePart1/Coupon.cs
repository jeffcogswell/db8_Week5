﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePart1
{
	public class Coupon
	{
		public static int GetSign(int num)
		{
			if (num < 0)
			{
				return -1;
			}
			else if (num > 0)
			{
				return 1;
			}
			return 0;

			/* This would be wrong but 
			 * we might not actually catch it!
			if (num == -2)
			{
				return -1;
			}
			else if (num == -1)
			{
				return -1;
			}
			else if (num == 0)
			{
				return 0;
			}
			else if (num == 1)
			{
				return 1;
			}
			else if (num == 2)
			{
				return 1;
			}
			else
			{
				return 0;
			}
			*/
		}

		public static bool isRangeVersion1(int num)
		{
			return false;
		}

		public static bool isRangeVersion2(int num)
		{
			return false;
		}

		public static decimal CalculateCoupon(decimal purchase)
		{
			if (purchase < 10)
			{
				return 0.0m;
			}
			else if (purchase <= 19.99m)
			{
				return 2.0m;
			}
			else
			{
				return 3.0m;
			}
		}
	}
}

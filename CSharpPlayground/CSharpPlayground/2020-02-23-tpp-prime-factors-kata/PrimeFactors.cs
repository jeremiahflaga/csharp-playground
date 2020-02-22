using System;
using System.Collections.Generic;

namespace CSharpPlayground._2020_02_23_tpp_prime_factors_kata
{
	internal class PrimeFactors
	{
		internal static IEnumerable<int> Generate(int n)
		{
			var primeFactors = new List<int>();
			int divisor = 2;
			while (n > 1)
			{
				while (n % divisor == 0)
				{
					primeFactors.Add(divisor);
					n /= divisor;
				}
				divisor++;
			}

			return primeFactors;
		}
	}
}
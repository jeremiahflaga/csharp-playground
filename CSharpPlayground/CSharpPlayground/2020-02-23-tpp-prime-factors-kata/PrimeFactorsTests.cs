using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CSharpPlayground._2020_02_23_tpp_prime_factors_kata
{
	public class PrimeFactorsTests
	{
		[Fact]
		public void prime_factors_tests()
		{
			Assert.Equal(new List<int>(), PrimeFactors.Generate(1));
			Assert.Equal(new List<int>() { 2 }, PrimeFactors.Generate(2));
			Assert.Equal(new List<int>() { 3 }, PrimeFactors.Generate(3));
			Assert.Equal(new List<int>() { 2, 2 }, PrimeFactors.Generate(4));
			Assert.Equal(new List<int>() { 5 }, PrimeFactors.Generate(5));
			Assert.Equal(new List<int>() { 2, 3 }, PrimeFactors.Generate(6));
			Assert.Equal(new List<int>() { 7 }, PrimeFactors.Generate(7));
			Assert.Equal(new List<int>() { 2, 2, 2 }, PrimeFactors.Generate(8));
			Assert.Equal(new List<int>() { 3, 3 }, PrimeFactors.Generate(9));
			Assert.Equal(new List<int>() { 2, 5 }, PrimeFactors.Generate(10));
			Assert.Equal(new List<int>() { 2, 2, 2, 3, 3, 5, 7, 11, 13 }, 
								PrimeFactors.Generate(2*2*2*3*3*5*7*11*13));
		}
	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorKata
{
	[TestClass]
	public class UnitTest1
	{
		Calculator _calc = new Calculator();

		[TestMethod]
		public void StringEmptyReturnZero()
		{
			AssertSum(0, "");
		}

		[TestMethod]
		public void StringReturnNumber()
		{
			AssertSum(1, "1");
		}

		[TestMethod]
		public void StringSequenceReturnSum()
		{
			AssertSum(3, "1,2");
		}

		[TestMethod]
		public void StringSequence2ReturnSum()
		{
			AssertSum(6, "1,2,3");
		}

		private void AssertSum(int expected, string actual)
		{
			Assert.AreEqual(expected, _calc.Add(actual));
		}
	}
}

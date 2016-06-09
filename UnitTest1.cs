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
		public void StringSequenceOfTwoNumbersReturnSum()
		{
			AssertSum(3, "1,2");
		}

		[TestMethod]
		public void StringSequenceOfNNumbersReturnSum()
		{
			AssertSum(6, "1,2,3");
			AssertSum(50, "10,20,1,1,1,1,1,1,1,1,1,1,5,5");
		}

		[TestMethod]
		public void StringSecquenceWithNewLineSeparatorReturnSum()
		{
			AssertSum(6, "1\n2,3");
		}

		[TestMethod]
		[ExpectedException(typeof(Exception), "Missing number")]
		public void StringSequenceWithoutANumber()
		{
			AssertSum(1, "1,\n");
			AssertSum(10, "1,2,\n,3,\n,4");
		}

		private void AssertSum(int expected, string actual)
		{
			Assert.AreEqual(expected, _calc.Add(actual));
		}
	}
}

using System;

namespace CalculatorKata
{
	internal class Calculator
	{
		public Calculator()
		{
		}

		public int Add(string entryText)
		{
			if (string.IsNullOrEmpty(entryText))
				return 0;
			return SplitAndSumNumbers(entryText);
		}

		private static int SplitAndSumNumbers(string text)
		{
			var retval = 0;
			string[] numbers = text.Split(',');
			foreach (string number in numbers)
				retval += Int32.Parse(number);
			return retval;
		}
	}
}
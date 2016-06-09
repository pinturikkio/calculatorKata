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
			if (entryText.Contains(",\n"))
				throw new Exception("Missing number");
			return SplitAndSumNumbers(entryText);
		}

		private static int SplitAndSumNumbers(string text)
		{
			var retval = 0;
			char[] separators = new char[] {
				',',
				'\n'
			};
			string[] numbers = text.Split(separators);
			foreach (string number in numbers)
				retval += Int32.Parse(number);
			return retval;
		}
	}
}
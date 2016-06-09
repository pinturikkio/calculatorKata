using System;

namespace CalculatorKata
{
	internal class Calculator
	{
		public static Parser __parser { get; private set; }

		public Calculator()
		{
			__parser = new Parser();
		}

		public int Add(string entryText)
		{
			if (string.IsNullOrEmpty(entryText))
				return 0;
			if (entryText.Contains(",\n"))
				throw new Exception("Missing number");
			if (entryText.Contains("//;\n"))
			{
				__parser.AddSeparator(';');
				entryText.Remove(0,4);
			}
			return SplitAndSumNumbers(entryText);
		}

		private static int SplitAndSumNumbers(string text)
		{
			var retval = 0;
			var numbers = __parser.SplitAndParseString(text);
			foreach (int number in numbers)
				retval += number;
			return retval;
		}
	}
}
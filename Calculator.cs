using System;

namespace CalculatorKata
{
	internal class Calculator
	{
		public Calculator()
		{
		}

		public int Add(string v)
		{
			if (string.IsNullOrEmpty(v))
				return 0;
			var retval = 0;
			string[] numbers = v.Split(',');
			foreach (string number in numbers)
				retval += Int32.Parse(number);
			return retval;
		}
	}
}
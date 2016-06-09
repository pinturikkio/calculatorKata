using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorKata
{
	internal class Parser
	{
		private List<char> _separators = new List<char>();

		public Parser()
		{
			_separators.Add('\n');
			_separators.Add(',');
		}

		public void AddSeparator(char separator)
		{
			_separators.ToList().Add(separator);
		}

		public string[] SplitString(string text)
		{
			return text.Split(_separators.ToArray());
		}

		public int[] ParseArrayString(string[] array)
		{
			List<int> retval = new List<int>();
			foreach (string item in array)
				retval.Add(Int32.Parse(item));
			return retval.ToArray();
		}

		public int[] SplitAndParseString(string text)
		{
			return ParseArrayString(SplitString(text));
		}

	}
}

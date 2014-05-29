using KATA.RomanNumeral.Domain.Enum;
using KATA.RomanNumeral.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KATA.RomanNumeral.Domain.Service
{
	public class ArabicToRomanDomainService : IArabicToRomanDomainService
	{

		public string GetRomanValue(int input)
		{
			string result = string.Empty;
			
			if (input > 3000 || input < 1)
			{
				throw new IndexOutOfRangeException();
			}

			if (input <= 3 && input > 1)
			{
				for (int i = 1; i <= input; i++)
				{
					result += GetRomanStandard(1);
				}

				return result;
			}

			return GetRomanStandard(input);
		}

		private string GetRomanStandard(int input)
		{
			return ((RomanConstant)input).ToString();
		}

	}
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KATA.RomanNumeral.Application.Interface;
using KATA.RomanNumeral.Application.Service;
using KATA.RomanNumeral.Domain.Interface;
using KATA.RomanNumeral.Domain.Service;

namespace KATA.RomanNumeral.UnitTests
{
	[TestClass]
	public class ArabicToRomanTests
	{
		IArabicToRomanApplicationService arabicToRomanApplicationService;

		[TestInitialize]
		public void TestInitializer()
		{
			IArabicToRomanDomainService arabicToRomanDomainService = new ArabicToRomanDomainService();
			arabicToRomanApplicationService = new ArabicToRomanApplicationService(arabicToRomanDomainService);
		}

		# region RomanStandardTest
		[TestMethod]
		public void test_arabic_roman_for_1_digit_I()
		{
			//Input
			var input = 1;
			var expectedOutput = "I";
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);
			//Expected value
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void test_arabic_roman_for_1_digit_V()
		{
			//Input
			var input = 5;
			var expectedOutput = "V";
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);
			//Expected value
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void test_arabic_roman_for_1_digit_X()
		{
			//Input
			var input = 10;
			var expectedOutput = "X";
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);
			//Expected value
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void test_arabic_roman_for_1_digit_L()
		{
			//Input
			var input = 50;
			var expectedOutput = "L";
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);
			//Expected value
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void test_arabic_roman_for_1_digit_C()
		{
			//Input
			var input = 100;
			var expectedOutput = "C";
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);
			//Expected value
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void test_arabic_roman_for_1_digit_D()
		{
			//Input
			var input = 500;
			var expectedOutput = "D";
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);
			//Expected value
			Assert.AreEqual(expectedOutput, result);
		}

		[TestMethod]
		public void test_arabic_roman_for_1_digit_M()
		{
			//Input
			var input = 1000;
			var expectedOutput = "M";
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);
			//Expected value
			Assert.AreEqual(expectedOutput, result);
		}

		#endregion

		# region RangeValidationTest
		[TestMethod]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void test_value_greater_than_3000()
		{
			//Input
			var input = 3001;
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);

		}

		[TestMethod]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void test_value_lesser_than_1()
		{
			//Input
			var input = 0;
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);

		}

		#endregion

		#region RomanNonStandards
		[TestMethod]
		public void test_arabic_roman_for_single_digit()
		{
			//Input
			var input = 2;
			var expectedOutput = "II";
			//Method call
			var result = arabicToRomanApplicationService.GetRomanValue(input);
			//Expected value
			Assert.AreEqual(expectedOutput, result);
		}

		//[TestMethod]
		//public void test_arabic_roman_for_single_digit_four()
		//{
		//	//Input
		//	var input = 4;
		//	var expectedOutput = "IV";
		//	//Method call
		//	var result = arabicToRomanApplicationService.GetRomanValue(input);
		//	//Expected value
		//	Assert.AreEqual(expectedOutput, result);
		//}

		#endregion
	}
}

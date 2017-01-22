using System;
namespace CalculatorDroid_MVVMCross
{
	public class Calculator:ICalculatorService
	{
		public Calculator()
		{
		}

		public double Add(int firstNumber, int secondNumber)
		{
			return firstNumber + secondNumber;
		}
	}
}

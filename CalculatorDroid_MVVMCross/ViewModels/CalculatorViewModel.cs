using System;
using MvvmCross.Core.ViewModels;

namespace CalculatorDroid_MVVMCross
{
	public class CalculatorViewModel:MvxViewModel
	{
		ICalculatorService _calculatorService;
		public CalculatorViewModel(ICalculatorService calculatorService)
		{
			_calculatorService = calculatorService;
		}

		public override void Start()
		{
			FirstNumber = 0;
			SecondNumber = 0;
			Recalculate();
			base.Start();
		}

		int _firstNumber;
		public int FirstNumber
		{
			get { return _firstNumber; }
			set { _firstNumber = value; RaisePropertyChanged(() => FirstNumber);Recalculate(); }
		}
		int _secondNumber;
		public int SecondNumber
		{
			get { return _secondNumber; }
			set { _secondNumber = value; RaisePropertyChanged(() => SecondNumber); Recalculate();}
		}
		int _result;
		public int Result
		{
			get { return _result; }
			set { _result = value; RaisePropertyChanged(() => Result); }
		}

		void Recalculate()
		{
			Result = FirstNumber + SecondNumber;
		}
	}
}

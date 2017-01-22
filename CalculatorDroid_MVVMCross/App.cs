using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace CalculatorDroid_MVVMCross
{
	public class App:MvxApplication
	{
		public App()
		{
			Mvx.RegisterType<ICalculatorService, Calculator>();
			Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<CalculatorViewModel>());

		}
	}
}

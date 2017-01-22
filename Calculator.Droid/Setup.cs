using System;
using Android.Content;
using CalculatorDroid_MVVMCross;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace Calculator.Droid
{
	public class Setup:MvxAndroidSetup
	{
		public Setup(Context applicationContext)
			: base(applicationContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new App();
		}
	}
}

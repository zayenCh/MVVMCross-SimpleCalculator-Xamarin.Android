
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Droid.Views;

namespace Calculator.Droid
{
	[Activity(Label = "Calculator", MainLauncher=true)]
	public class Calculator : MvxActivity 
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
		}
		protected override void OnViewModelSet()
		{
			SetContentView(Resource.Layout.CalculatorLayout);
		}
	}
}

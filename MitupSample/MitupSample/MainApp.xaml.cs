using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MitupSample
{
	public partial class MainApp : Application
	{
		public MainApp()
		{
			MainPage = new NavigationPage(new Page1Binding());
		}
	}
}

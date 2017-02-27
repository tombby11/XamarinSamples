using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MitupSample
{
	public partial class Page1 : ContentPage
	{
		private int count = 0;
		public Page1()
		{
			InitializeComponent();
			navButton.IsEnabled = toggleSwitch.IsToggled;
		}

		private void AddClicks(object sender, EventArgs e)
		{
			count++;
			label.Text = $"{count} Clicks!";
		}

		private async void GoToPage2(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Page2());
		}

		private void Switch_OnToggled(object sender, ToggledEventArgs e)
		{
			navButton.IsEnabled = e.Value;

		}
	}
}

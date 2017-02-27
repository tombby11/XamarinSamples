using System;
using System.ComponentModel;

namespace MitupSample.ViewModels
{
	public class Page1ViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public event EventHandler NavigationToPage2;

		int _count;
		public Page1ViewModel()
		{
			WelcomeMessage = "Hello World";
			_count = 0;
		}
		private string _welcomeMessage;



		public string WelcomeMessage
		{
			get
			{
				return _welcomeMessage;
			}

			set
			{
				_welcomeMessage = value;
				OnPropertyChanged(nameof(WelcomeMessage)); 
			}
		}

		public System.Windows.Input.ICommand AddClickCommand
		{
			get
			{
				return new Xamarin.Forms.Command(() =>
				{
					WelcomeMessage = $"{++_count} Clicks";
				}

				);
			}
		}

		public System.Windows.Input.ICommand GoToPage2
		{
			get
			{
				return new Xamarin.Forms.Command(() =>
				{
					NavigationToPage2?.Invoke(this,null);
				}

				);
			}
		}


		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs (propertyName)); 
		}

	}
}
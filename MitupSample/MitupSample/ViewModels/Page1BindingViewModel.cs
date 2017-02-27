using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace MitupSample
{
	public class Page1BindingViewModel:INotifyPropertyChanged
	{
		private int _counter = 0;


		public event EventHandler Next;
		public Page1BindingViewModel()
		{
			MessageShown = "Welcome from Page1ViewModel";
			NextCommand = new Command(GoNext, GoNextCanExecute);
			AddClicksCommand = new Command(AddClicks);
		}

		private bool _canNavigate;
		public bool CanNavigate
		{
			get { return _canNavigate; }
			set
			{
				if (value == _canNavigate) return;
				_canNavigate = value;
				OnPropertyChanged(nameof(CanNavigate));
				NextCommand.ChangeCanExecute();
			}
		}

		private string _messageShown;
		public string MessageShown
		{
			get { return _messageShown; }
			set
			{
				_messageShown = value;
				OnPropertyChanged(nameof(MessageShown));
			}
		}

		public Command AddClicksCommand { get; }

		public Command NextCommand { get; }

		private void AddClicks()
		{
			MessageShown = $"{++_counter} clicks";
		}
		private bool GoNextCanExecute(object arg)
		{
			return CanNavigate;
		}

		private void GoNext(object obj)
		{
			Next?.Invoke(this, null);
		}


		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName )
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

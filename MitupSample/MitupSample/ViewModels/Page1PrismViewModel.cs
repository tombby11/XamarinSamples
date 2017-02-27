using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace MitupSample.ViewModels
{
	public class Page1PrismViewModel : BindableBase
	{
		private int _counter;
		public Page1PrismViewModel(INavigationService navigationService)
		{
			MessageShown = "Welcome from Prism Content Page 1 ViewModel";
			NextCommand = new DelegateCommand(async () => await navigationService.NavigateAsync("Page2")).ObservesCanExecute((p) => IsEnabled);
			AddClicksCommand = new DelegateCommand(() => MessageShown = $"{++_counter} clicks");
		}

		public DelegateCommand NextCommand { get; }
		public DelegateCommand AddClicksCommand { get; }
		private bool _isEnabled;
		public bool IsEnabled
		{
			get { return _isEnabled; }
			set
			{
				SetProperty(ref _isEnabled, value);
			}
		}
		private string _messageShown;
		public string MessageShown
		{
			get { return _messageShown; }
			set
			{
				SetProperty(ref _messageShown, value);
			}
		}
	}
}

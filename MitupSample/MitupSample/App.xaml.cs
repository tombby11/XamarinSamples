using Prism.Unity;
using MitupSample.Views;
using Xamarin.Forms;

namespace MitupSample
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("NavigationPage/Page1Prism/Page2");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<NavigationPage>();
			Container.RegisterTypeForNavigation<Page1Prism>();
			Container.RegisterTypeForNavigation<Page2>();
		}
	}
}


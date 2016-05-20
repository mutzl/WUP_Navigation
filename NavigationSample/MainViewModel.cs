namespace NavigationSample
{
	using System;

	using GalaSoft.MvvmLight;
	using GalaSoft.MvvmLight.Views;

	public class MainViewModel : ViewModelBase
	{
		private readonly NavigationService navigationService;

		public MainViewModel()
		{
			navigationService = new NavigationService();
			navigationService.Configure("SecondPage", typeof(Page2));

		}
		public void NavigateToPage2()
		{
			navigationService.NavigateTo("SecondPage");
		}

		public void NavigateBack()
		{
			navigationService.GoBack();
		}
	}
}

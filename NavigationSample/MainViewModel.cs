namespace NavigationSample
{
	using System;

	using GalaSoft.MvvmLight;
	using GalaSoft.MvvmLight.Views;

	public class MainViewModel : ViewModelBase
	{
		private readonly NavigationService NavigationService;

		public MainViewModel()
		{
			NavigationService = new NavigationService();
			NavigationService.Configure("SecondPage", typeof(Page2));
			NavigationService.Configure("ThirdPage", typeof(Page2));
			NavigationService.Configure("MainPage", typeof(MainPage));
		}
		public void NavigateToPage2()
		{
			NavigationService.NavigateTo("SecondPage");
		}

		public void NavigateBack()
		{
			NavigationService.GoBack();
		}
	}
}

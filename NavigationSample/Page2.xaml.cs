using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace NavigationSample
{
	using System.ComponentModel;

	using Windows.ApplicationModel.Background;

	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Page2 : Page
	{
		private int counter = 0;
		public Page2()
		{
			this.InitializeComponent();

			((App)App.Current).OnBackRequested += (sender, args) =>
				{
					counter++;
					args.Handled = (counter < 3);
					Bindings.Update();
				};
		}



		public string DemoString { get; set; } = "Hello new Page";

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			if (e.Parameter == null) return;
			
			DemoString = (string)e.Parameter;

			Bindings.Update();
		}
	}
}

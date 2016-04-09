using System;

using Xamarin.Forms;

namespace Style
{
	public class App : Application
	{
		public App ()
		{
			//MainPage = new NavigationPage (new NoStylePage());
			//MainPage = new NavigationPage (new ImplicitStylePage());
			//MainPage = new NavigationPage (new ExplicitStyleCSharp());
			//MainPage = new NavigationPage (new ImplicitStyleXaml());
			MainPage = new NavigationPage (new ImplicitStyleCSharp());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}


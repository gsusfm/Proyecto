using System;

using Xamarin.Forms;

namespace AnalisisT
{
	public class App : Application
	{

        public static object Assets { get; internal set; }
        public static bool IsUserLoggedIn { get; set; }
        public App ()
		{
            MainPage = new NavigationPage(new TodoList());
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


using Realms;
using Xamarin.Forms;

namespace RealmTodo
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage());
		}

		static App()
		{
			var realmConfig = new RealmConfiguration { ShouldDeleteIfMigrationNeeded = true };
			Realm = Realm.GetInstance(realmConfig);
		}

		public static Realm Realm;

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

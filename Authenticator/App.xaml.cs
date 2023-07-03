using Authenticator.Views.Home;

namespace Authenticator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		MainPage = new AppShell();


		//Home routes
        Routing.RegisterRoute(nameof(AccountDetailsPage), typeof(AccountDetailsPage));
    }
}

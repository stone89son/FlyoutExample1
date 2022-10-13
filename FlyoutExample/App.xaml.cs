namespace FlyoutExample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new AppShell();
        //MainPage = new FlyoutPageDemo();
        MainPage = new NavigationPage(new FirstPage());
    }
}

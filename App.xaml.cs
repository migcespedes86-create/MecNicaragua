using Microsoft.Maui.Controls;

namespace MecNicaMauiLogin;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MainPage());
    }
}

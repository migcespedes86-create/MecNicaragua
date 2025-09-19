using Microsoft.Maui.Controls;

namespace MecNicaMauiLogin;

public partial class MainPage : ContentPage
{
    private const string LoginUrl = "https://mecnicaragua.org/Sys/login";

    public MainPage()
    {
        InitializeComponent();
        LoginWebView.Source = LoginUrl;
    }

    void OnReloadClicked(object sender, EventArgs e)
    {
        LoginWebView.Reload();
    }

    void OnNavigating(object sender, WebNavigatingEventArgs e)
    {
        LoadingOverlay.IsVisible = true;
    }

    void OnNavigated(object sender, WebNavigatedEventArgs e)
    {
        LoadingOverlay.IsVisible = false;
        if (e.Result != WebNavigationResult.Success)
        {
            DisplayAlert("Error", "No se pudo cargar la página.", "OK");
        }
    }

    protected override bool OnBackButtonPressed()
    {
        if (LoginWebView.CanGoBack)
        {
            LoginWebView.GoBack();
            return true; // consumimos el back
        }
        return base.OnBackButtonPressed();
    }
}

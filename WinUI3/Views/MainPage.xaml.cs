using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using WinUI3.ViewModels;

namespace WinUI3.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private async void OnMainPageLoade(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        await PDFView.EnsureCoreWebView2Async();
        PDFView.CoreWebView2.SetVirtualHostNameToFolderMapping("pspdfkit", "C:\\Users\\smeth\\Desktop\\ToDelete\\WinUI3\\WinUI3\\sdk", CoreWebView2HostResourceAccessKind.Allow);

        PDFView.CoreWebView2.Navigate(
          "http://pspdfkit/index.html");
    }
}

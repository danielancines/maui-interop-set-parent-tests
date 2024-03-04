using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using Windows.Win32;
using Windows.Win32.Foundation;

namespace Maui.SetParentIssues;

public partial class MainPage : ContentPage
{
    private MyWindow _window;

    public MainPage()
    {
        InitializeComponent();
    }

    private void CloseWindowButton_Clicked(object sender, EventArgs e)
    {
        if (this._window != null)
            Application.Current.CloseWindow(this._window);
    }

    private void OpenButton_Clicked(object sender, EventArgs e)
    {
        this._window = new MyWindow(new ContentPage()
        {
            Background = Colors.Gray
        });

        Application.Current.OpenWindow(this._window);
    }
}

public class MyWindow : Window
{
    public MyWindow(Page page) : base(page)
    {

    }
}

public class MyWindowHandler : WindowHandler
{
    private HWND _mainWindowHandle;
    private HWND _childWindowHandle;

    protected override void ConnectHandler(Microsoft.UI.Xaml.Window platformView)
    {
        base.ConnectHandler(platformView);
        this._mainWindowHandle = new HWND((Application.Current.MainPage.Window.Handler.PlatformView as MauiWinUIWindow).GetWindowHandle());
        this._childWindowHandle = new HWND(this.PlatformView.GetWindowHandle());

        PInvoke.SetParent(this._childWindowHandle, this._mainWindowHandle);
    }

    protected override void DisconnectHandler(Microsoft.UI.Xaml.Window platformView)
    {
        var result = PInvoke.SetParent(this._childWindowHandle, Windows.Win32.Foundation.HWND.Null);

        base.DisconnectHandler(platformView);
    }
}

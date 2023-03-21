using MAUISampleDemo.View.Navigation;

namespace MAUISampleDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(NavPage1), typeof(NavPage1));
    }
}

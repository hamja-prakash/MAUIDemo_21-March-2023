namespace MAUISampleDemo.View.LazyView;

public partial class LazyViewDemo : ContentPage
{
	public LazyViewDemo()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LazyActiviation.LoadViewAsync();
    }

    async void LoadLazyView_Clicked(object sender, EventArgs e)
    {
        await LazyUserAction.LoadViewAsync();
    }
}
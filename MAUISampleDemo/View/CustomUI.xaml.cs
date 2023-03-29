namespace MAUISampleDemo.View;

public partial class CustomUI : ContentPage
{
    bool isFirstTime = true;
    public CustomUI()
	{
		InitializeComponent();
	}

    private void btnLike_Clicked(object sender, EventArgs e)
    {
        if (isFirstTime)
        {
            btnLike.BackgroundColor = Colors.DeepPink;
            btnLike.BorderColor = Colors.Transparent;
            btnLike.TextColor = Colors.White;
            isFirstTime = false;
        }
        else
        {
            btnLike.BackgroundColor = Colors.White;
            btnLike.BorderColor = Colors.Silver;
            btnLike.TextColor = Colors.Black;
            isFirstTime = true;
        }
    }
}
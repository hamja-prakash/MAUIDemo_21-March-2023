namespace MAUISampleDemo.View.Validations;

public partial class ValidationMainPage : ContentPage
{
	public ValidationMainPage()
	{
		InitializeComponent();
	}

    private void FrmValidation1_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmValidation1, new ValidationRulesDemo());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmValidation2_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmValidation2, new Validation2());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void FrmValidation3_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            NavigationPage(FrmValidation3, new Validation3());
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    #region [ Methods ]
    public async void NavigationPage(Frame frame, Page page)
    {
        try
        {
            await frame.ScaleTo(0.9, 100, Easing.Linear);
            await frame.ScaleTo(1.0, 100, Easing.Linear);
            await Navigation.PushAsync(page);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
    #endregion

    
}
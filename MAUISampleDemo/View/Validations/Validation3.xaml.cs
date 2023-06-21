using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View.Validations;

public partial class Validation3 : ContentPage
{
    Validation3ViewModel Validation3ViewModel;
	public Validation3()
	{
        Validation3ViewModel = new Validation3ViewModel();
        this.BindingContext = Validation3ViewModel;
        InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var isValid = Validation3ViewModel.Validate();

        if (isValid)
        {
            DisplayAlert(":)", "This form is valid", "OK");
        }
        else
        {
            DisplayAlert(":(", "This form is not valid", "OK");
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        // Test clear all 1
        Validation3ViewModel.LastName.Value = null;
        Validation3ViewModel.Email.Value = null;
        Validation3ViewModel.Name.Value = null;
    }
}
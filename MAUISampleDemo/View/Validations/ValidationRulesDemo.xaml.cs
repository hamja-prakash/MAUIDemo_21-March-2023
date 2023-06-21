using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View.Validations;

public partial class ValidationRulesDemo : ContentPage
{
    ValidationRulesViewModel validationRulesViewModel;
    public ValidationRulesDemo()
    {
        InitializeComponent();
        validationRulesViewModel = new ValidationRulesViewModel();
        this.BindingContext = validationRulesViewModel;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var isValid = validationRulesViewModel.Validate();

        if (isValid)
        {
            DisplayAlert(":)", "This form is valid", "OK");
        }
        else
        {
            DisplayAlert(":(", "This form is not valid", "OK");
        }
    }

    private void nameEntry_Unfocused(object sender, FocusEventArgs e)
    {
        validationRulesViewModel.Name.Validate();
    }

    private void lastnameEntry_Unfocused(object sender, FocusEventArgs e)
    {
        validationRulesViewModel.LastName.Validate();
    }

    private void emailEntry_Unfocused(object sender, FocusEventArgs e)
    {
        validationRulesViewModel.Email.Validate();
    }
}
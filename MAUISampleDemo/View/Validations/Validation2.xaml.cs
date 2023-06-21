using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View.Validations;

public partial class Validation2 : ContentPage
{
    Validation2ViewModel _context;

    public Validation2()
	{
		InitializeComponent();
        _context = new Validation2ViewModel();
        BindingContext = _context;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var isValid = _context.Validate();

        if (isValid)
        {
            DisplayAlert(":)", "This form is valid", "OK");
        }
        else
        {
            DisplayAlert(":(", $"This form is not valid. {_context.User.Error}", "OK");
        }
    }
}
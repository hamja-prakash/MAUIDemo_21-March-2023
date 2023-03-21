namespace MAUISampleDemo.View;

public partial class NullCoalescingDemo : ContentPage
{
	public NullCoalescingDemo()
	{
		InitializeComponent();
	}

    private void btnOutput_Clicked(object sender, EventArgs e)
    {
		try
		{
			Customer customer = new Customer();
			customer.Name = "Test";
			var name = customer?.Name?.Length ?? -1; // It firstly check is customer is null and if yes then it returns -1, same for Name field and it both are exist then return the specific length value.
			LblResult.Text = name.ToString();
        }
		catch (Exception ex)
		{
			App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
		}
    }

    private void btnVMOutput_Clicked(object sender, EventArgs e)
    {
		try
		{
			var vm = new CustomerViewModel();
			LblVMResult.Text = vm.customer2.Name.ToString();
			vm.IsCustomerNull();
        }
        catch (Exception ex)
        {
            App.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
        }
    }
}

public class Customer
{
    public string Name { get; set; }
}

public class CustomerViewModel
{
	Customer customer1;
	public Customer customer2
	{
		get
		{
			return customer1 ??= new Customer { Name = "Data" }; // If = not available it returns the null object but if we add = the it returns the specifi value.
		}
	}
    public void IsCustomerNull()
    {
        if (customer1 == null)
            App.Current.MainPage.DisplayAlert("Error", "It is Null", "Ok");
		else
            App.Current.MainPage.DisplayAlert("Error", "It is Not Null", "Ok");
    }

}



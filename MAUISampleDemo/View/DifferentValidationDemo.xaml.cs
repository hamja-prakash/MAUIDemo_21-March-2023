using System.Diagnostics.SymbolStore;
using System.Threading.Tasks;

namespace MAUISampleDemo.View;

public partial class DifferentValidationDemo : ContentPage
{
    public string imgcheck = "iconcheck.png";
    public string imguncheck = "iconuncheck.png";

    public DifferentValidationDemo()
	{
		InitializeComponent();
	}

    private void BtnCheckValidation_Clicked(object sender, EventArgs e)
    {
		try
		{
            if(Validation())
            {
                txtValue.Text = JustNumberFormat(txtValue.Text);
                var isvalidEmail = ValidateEmail(txtEmail.Text);
                if (isvalidEmail)
                    imgcheckemail.Source = imgcheck;
                else
                    imgcheckemail.Source = imguncheck;
            }
        }
		catch (Exception ex)
		{
			var err = ex.Message;
		}
    }

    public static string JustNumberFormat(string value)
    {
        return string.Join("", value.ToCharArray().Where(Char.IsDigit));
    }

    public static bool ValidateEmail(string value)
    {
        if (!(value is string valueAsString))
        {
            return false;
        }
        // only return true if there is only 1 '@' character
        // and it is neither the first nor the last character
        int index = valueAsString.IndexOf('@');
        return
            index > 0 &&
            index != valueAsString.Length - 1 &&
            index == valueAsString.LastIndexOf('@')? true:false;
    }

    public static async Task RunSafe(Task task, Action<Exception> onError = null, CancellationToken token = default(CancellationToken))
    {
        Exception exception = null;
        try
        {
            if (!token.IsCancellationRequested)
            {
                await Task.Run(() => {
                    task.Start();
                    task.Wait();
                });
            }
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("Task Cancelled");
        }
        catch (AggregateException e)
        {
            var ex = e.InnerException;
            while (ex.InnerException != null)
                ex = ex.InnerException;
            exception = ex;
        }
        catch (Exception e)
        {
            exception = e;
        }
        finally
        {
            //AfterTaskRun?.Invoke(null, task);
        }
        if (exception != null)
        {
            //TODO: Log to Insights
            Console.WriteLine(exception);
            onError?.Invoke(exception);
        }
    }

    //public record Car
    //{
    //    public Car(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public string Name;
    //    public int Age;
    //}

    public bool Validation()
    {
        //var car = new Car("Reno", 15);
        //var car2 = car;
        //car.Name = "Honda";

        //Console.WriteLine(car.Name);
        //Console.WriteLine(car2.Name);

        //car = car with { Name = "BMW" };

        //Console.WriteLine(car.Name);
        //Console.WriteLine(car2.Name);

        imgcheckemail.Source = string.Empty;
        bool isValid = false;
        if (string.IsNullOrEmpty(txtValue.Text) || string.IsNullOrWhiteSpace(txtValue.Text))
        {
            App.Current.MainPage.DisplayAlert("Validation", "Please enter number","Ok","Cancel");
            isValid = false;
        }
            
        else if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
        {
            App.Current.MainPage.DisplayAlert("Validation", "Please enter email address", "Ok", "Cancel");
            isValid = false;
        }
        else
            isValid = true;
        return isValid;
    }
}
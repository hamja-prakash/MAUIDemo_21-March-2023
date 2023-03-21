
namespace MAUISampleDemo.View;

public partial class MAUIStyleDemo : ContentPage
{
	int count = 0;
	public MAUIStyleDemo()
	{
		InitializeComponent();
	}

    private void BtnClick_Clicked(object sender, EventArgs e)
    {
		count++;
		//if (count == 1)
  //          btnCounter.Text = $"Clicked {count} time";
		//else
  //          btnCounter.Text = $"Clicked {count} times";
        
        lblDate.Text = DateTimeToString(new DateTime(2020, 5, 1, 8, 30, 52));
        lblDate1.Text = DateTimeToString(DateTime.Now.Date);
        lblDate2.Text = DateTimeToString(DateTime.Now.AddDays(-1).Date);

        btnCounter.Text = (count == 1) ? $"Clicked {count} time" : $"Clicked {count} times";
        Resources["myColor"] = (count % 2 == 0) ? Colors.Red : Colors.Fuchsia;
    }

    public static string DateTimeToString(DateTime value)
    {
        if (value == null)
            return string.Empty;
        if (value.Date == DateTime.Now.Date)
            return "Today";
        var numDays = (DateTime.Now.Date - value.Date).Days;
        if (numDays > 0 && numDays < 8)
        {
            if (numDays == 1)
                return "Yesterday";
            else
                return value.DayOfWeek.ToString();
        }
        if (numDays > 8 && numDays < 30)
        {
            return "One month ago";
        }
        if (numDays < 365)
        {
            return numDays + " days ago";
        }
        else
        {
            int years = numDays / 365;
            return (years == 1) ? years + " year ago" : years + " years ago";
        }
    }
}
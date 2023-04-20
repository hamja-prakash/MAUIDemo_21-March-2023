using MAUISampleDemo.Model;
using MAUISampleDemo.ViewModels;

namespace MAUISampleDemo.View;

public partial class CustomPickerControlDemo : ContentPage
{
    int count = 0;

    public CustomPickerControlDemo()
	{
		InitializeComponent();
		this.BindingContext = new CustomPickerControlViewModel();
    }

    //private async void dropdownControl_OpenPickerEvent(object sender, EventArgs e)
    //{
    //    dropdownControl.IsLoading = true;

    //    // response return from api

    //    var items = new List<TitleValue>();

    //    items.Add(new TitleValue { Title = "Title 1" });
    //    items.Add(new TitleValue { Title = "Title 2" });
    //    items.Add(new TitleValue { Title = "Title 3" });
    //    items.Add(new TitleValue { Title = "Title 4" });
    //    items.Add(new TitleValue { Title = "Title 5" });
    //    items.Add(new TitleValue { Title = "Title 6" });
    //    items.Add(new TitleValue { Title = "Title 7" });

    //    dropdownControl.ItemSource = items;
    //    await Task.Delay(1000);
    //    dropdownControl.IsLoading = false;
    //    dropdownControl.IsDisplayPickerControl = true;
    //}
}
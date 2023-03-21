namespace MAUISampleDemo.View;

public partial class FilePickerPage : ContentPage
{
	public FilePickerPage()
	{
		InitializeComponent();
	}

    private async void PickImage_Clicked(object sender, EventArgs e)
    {
        try
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
                PickerTitle = "Pick Image Please",
                FileTypes = FilePickerFileType.Images
            });

            if (result == null)
                return;

            var stream = await result.OpenReadAsync();

            myImage.Source = ImageSource.FromStream(() => stream);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void PickImages_Clicked(object sender, EventArgs e)
    {
        try
        {
            var results = await FilePicker.PickMultipleAsync(new PickOptions
            {
               
            });

            foreach (var result in results)
            {
                await DisplayAlert("You picked...", result.FileName, "OK");
            }
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}
using MAUISampleDemo.Helpers;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace MAUISampleDemo.View;

public partial class ImageUploadDemo : ContentPage
{
    UploadImage uploadImage { get; set; }
    public ImageUploadDemo()
	{
		InitializeComponent();
        uploadImage = new UploadImage();
    }

    private async void UploadImage_Clicked(object sender, EventArgs e)
    {
        var img = await uploadImage.OpenMediaPickerAsync();

        var imagefile = await uploadImage.Upload(img);

        Image_Upload.Source = ImageSource.FromStream(() =>
            uploadImage.ByteArrayToStream(uploadImage.StringToByteBase64(imagefile.byteBase64))
        );

    }
}
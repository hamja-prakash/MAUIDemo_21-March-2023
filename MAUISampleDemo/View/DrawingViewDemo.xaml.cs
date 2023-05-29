namespace MAUISampleDemo.View;

public partial class DrawingViewDemo : ContentPage
{
    public DrawingViewDemo()
    {
        InitializeComponent();
    }

    private async void BtnSaveDrawingImg_Clicked(object sender, EventArgs e)
    {
        try
        {
            using var stream = await DrawView.GetImageStream(1024, 1024);
            using var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);

            stream.Position = 0;
            memoryStream.Position = 0;
#if WINDOWS
		await System.IO.File.WriteAllBytesAsync(
			@"C:\Users\joverslu\Desktop\DrawingView\Test.png", memoryStream.ToArray());
#elif ANDROID
        var context = Platform.CurrentActivity;

        if (OperatingSystem.IsAndroidVersionAtLeast(29))
        {
            Android.Content.ContentResolver resolver = context.ContentResolver;
            Android.Content.ContentValues contentValues = new();
            contentValues.Put(Android.Provider.MediaStore.IMediaColumns.DisplayName, "test.png");
            contentValues.Put(Android.Provider.MediaStore.IMediaColumns.MimeType, "image/png");
            contentValues.Put(Android.Provider.MediaStore.IMediaColumns.RelativePath, "DCIM/" + "test");
            Android.Net.Uri imageUri = resolver.Insert(Android.Provider.MediaStore.Images.Media.ExternalContentUri, contentValues);
            var os = resolver.OpenOutputStream(imageUri);
            Android.Graphics.BitmapFactory.Options options = new();
            options.InJustDecodeBounds = true;
            var bitmap = Android.Graphics.BitmapFactory.DecodeStream(stream);
            bitmap.Compress(Android.Graphics.Bitmap.CompressFormat.Png, 100, os);
            os.Flush();
            os.Close();
        }
        else
        {
            Java.IO.File storagePath = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures);
            string path = System.IO.Path.Combine(storagePath.ToString(), "test.png");
            System.IO.File.WriteAllBytes(path, memoryStream.ToArray());
            var mediaScanIntent = new Android.Content.Intent(Android.Content.Intent.ActionMediaScannerScanFile);
            mediaScanIntent.SetData(Android.Net.Uri.FromFile(new Java.IO.File(path)));
            context.SendBroadcast(mediaScanIntent);
        }
#elif IOS || MACCATALYST
            var image = new UIKit.UIImage(Foundation.NSData.FromArray(memoryStream.ToArray()));
            image.SaveToPhotosAlbum((image, error) =>
            {
            });
#endif
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void DrawingView_DrawingLineCompleted(object sender, CommunityToolkit.Maui.Core.DrawingLineCompletedEventArgs e)
    {
        try
        {
            var stream = await DrawView.GetImageStream(200, 200);
            imageView.Source = ImageSource.FromStream(() => stream);
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void BtnClear_Clicked(object sender, EventArgs e)
    {
        try
        {
            DrawView.Lines.Clear();
            imageView.Source = "noimage.png";
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void BtnStartVibration_Clicked(object sender, EventArgs e)
    {
        try
        {
            Vibration.Default.Vibrate(TimeSpan.FromSeconds(3));
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void BtnStopVibration_Clicked(object sender, EventArgs e)
    {
        try
        {
            Vibration.Default.Cancel();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private async void BtnTakeScreenshort_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (Screenshot.Default.IsCaptureSupported)
            {
                IScreenshotResult screen = await Screenshot.Default.CaptureAsync();
                Stream stream = await screen.OpenReadAsync();
                imageView.Source = ImageSource.FromStream(() => stream);
            }
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}
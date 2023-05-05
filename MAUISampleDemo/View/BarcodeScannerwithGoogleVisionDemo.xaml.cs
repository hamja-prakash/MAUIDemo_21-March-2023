using BarcodeScanner.Mobile;

namespace MAUISampleDemo.View;

public partial class BarcodeScannerwithGoogleVisionDemo : ContentPage
{
	public BarcodeScannerwithGoogleVisionDemo()
	{
        try
        {
            //BarcodeScanner.Mobile.Methods.SetSupportBarcodeFormat(BarcodeScanner.Mobile.BarcodeFormats.QRCode |
            //                                                      BarcodeScanner.Mobile.BarcodeFormats.Code39);
            InitializeComponent();
            BarcodeScanner.Mobile.Methods.AskForRequiredPermission();
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void CameraView_OnDetected(object sender, BarcodeScanner.Mobile.OnDetectedEventArg e)
    {
        try
        {
            List<BarcodeResult> barcodeResults = e.BarcodeResults;
            string result = string.Empty;
            for (int i = 0; i < barcodeResults.Count; i++)
            {
                result += $"Type : {barcodeResults[i].BarcodeType} {Environment.NewLine} Value : {barcodeResults[i].DisplayValue}{Environment.NewLine}";
            }

            Dispatcher.Dispatch(async () =>
            {
                await DisplayAlert("Result", result, "Ok");
                //If we want to start scanning again
                CameraView.IsScanning = true;
            });
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}
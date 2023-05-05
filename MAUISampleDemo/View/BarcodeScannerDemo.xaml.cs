namespace MAUISampleDemo.View;

public partial class BarcodeScannerDemo : ContentPage
{
	public BarcodeScannerDemo()
    {
        try
        {
            InitializeComponent();
            barcodeReader = new ZXing.Net.Maui.Controls.CameraBarcodeReaderView();
            //barcodeReader.Options = new ZXing.Net.Maui.BarcodeReaderOptions()
            //{
            //    Formats = ZXing.Net.Maui.BarcodeFormats.All
            //};
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        try
        {
            Dispatcher.Dispatch(() =>
            {
                barcodeResult.Text = (!string.IsNullOrEmpty(e.Results[0].Value)) ? e.Results[0].Value : string.Empty;
                barcodeType.Text = (!string.IsNullOrEmpty(e.Results[0].Format.ToString())) ? e.Results[0].Format.ToString() : string.Empty;
            });
        }
        catch (Exception ex)
        {
            var err = ex.Message;
        }
    }
}
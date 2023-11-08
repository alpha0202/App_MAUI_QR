namespace App_MAUI_QR.Page;

public partial class ScanQR : ContentPage
{
	public ScanQR()
	{
		InitializeComponent();
        DetectorImagen.Options = new ZXing.Net.Maui.BarcodeReaderOptions
        {
            Formats = ZXing.Net.Maui.BarcodeFormat.QrCode
        };

    }

    private void btnRegresar_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new PrincipalPage();
    }

    private void DetectorImagen_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        DetectorImagen.IsDetecting = false;
        if(e.Results.Any())
        {
            var result = e.Results.FirstOrDefault();
            Dispatcher.Dispatch(async () =>
            {
                DisplayAlert("Valor", result.Value, "Cancelar");
                App.Current.MainPage = new PrincipalPage();
            });
        }
    }
}
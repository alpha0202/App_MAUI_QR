namespace App_MAUI_QR.Page;

public partial class GenerarQR : ContentPage
{
	public GenerarQR()
	{
		InitializeComponent();
	}

    private void btnRegresar_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new PrincipalPage();
    }

    
}
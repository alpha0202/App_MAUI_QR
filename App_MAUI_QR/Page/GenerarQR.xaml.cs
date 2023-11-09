using App_MAUI_QR.Models;

namespace App_MAUI_QR.Page;

public partial class GenerarQR : ContentPage
{

    public GenerarQRModel oGenerarQRModel { get; set; }
    public string TextoValor { get; set; }
   

    public GenerarQR()
	{
		InitializeComponent();
        oGenerarQRModel = new GenerarQRModel();
        BindingContext = this;
	}

    private void btnRegresar_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new PrincipalPage();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if(!String.IsNullOrEmpty(TextoValor))
        {
            oGenerarQRModel.valorQR = TextoValor;

        }
        else
        {
            throw new Exception("Debe ingresar un valor texto");
        }
    }
}
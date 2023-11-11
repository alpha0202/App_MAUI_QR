using App_MAUI_QR.Models;

namespace App_MAUI_QR.Page;

public partial class GenerarBarCode : ContentPage
{
    public GenerarBardCodeModel	oGenerarBardCodeModel  { get; set; }

    public string TextoValor { get; set; }
    public GenerarBarCode()
	{
		InitializeComponent();
		oGenerarBardCodeModel = new GenerarBardCodeModel();
		BindingContext = this;

	}

    private void btnRegresar_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new PrincipalPage();
    }

  

    private void generarBarCode_Clicked(object sender, EventArgs e)
    {
        if (!String.IsNullOrEmpty(TextoValor))
        {
            oGenerarBardCodeModel.valorBarCode = TextoValor;

        }
        else
        {
            this.DisplayAlert("Advertencia", "Debe ingresar un texto,", "OK");
        }
    }
}
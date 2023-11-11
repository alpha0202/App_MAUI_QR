namespace App_MAUI_QR.Page;

public partial class LoginPage : ContentPage
{
    public string NombreUsuario { get; set; }
    public string Password { get; set; }

    public LoginPage()
	{
		InitializeComponent();
        BindingContext = this;
	}

    private void Ingresar_Clicked(object sender, EventArgs e)
    {

    }
}
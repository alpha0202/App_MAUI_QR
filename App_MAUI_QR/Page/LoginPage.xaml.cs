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
        if(NombreUsuario.Trim() =="edwin" &&  Password.Trim() == "1234")
        {
            App.Current.MainPage = new PrincipalPage();
            Preferences.Set("idusuario", 1);
        }
        else
        {
            DisplayAlert("Error", "Usuario y contrase�a incorrecta.", "Cancelar");
        }
    }
}
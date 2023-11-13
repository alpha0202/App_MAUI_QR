using App_MAUI_QR.Page;

namespace App_MAUI_QR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            if(Preferences.Get("idusuario",0)==0)
            MainPage = new LoginPage();
            else
                MainPage = new PrincipalPage();
        }
    }
}
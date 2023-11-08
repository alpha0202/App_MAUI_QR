using App_MAUI_QR.Page;

namespace App_MAUI_QR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PrincipalPage();
        }
    }
}
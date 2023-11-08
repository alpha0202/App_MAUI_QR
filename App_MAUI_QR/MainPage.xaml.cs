using App_MAUI_QR.Page;

namespace App_MAUI_QR
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

      
        private void btnScannear_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new ScanQR();
        }
    }
}
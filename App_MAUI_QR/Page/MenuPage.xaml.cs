using App_MAUI_QR.Clases;
using System.Linq.Expressions;

namespace App_MAUI_QR.Page;

public partial class MenuPage : ContentPage
{
	public List<MenuCLS> Lista { get; set; }
    public MenuCLS oMenuCLS { get; set; }
    public MenuPage()
	{
		InitializeComponent();
		Lista = new List<MenuCLS>();
		Lista.Add(new MenuCLS { IdMenu=1,NombreOpcion="Leer QR",NombreIcono= "ic_phonereader" });
		Lista.Add(new MenuCLS { IdMenu=2,NombreOpcion="Generar QR",NombreIcono= "ic_generarqr" });
		Lista.Add(new MenuCLS { IdMenu=3,NombreOpcion="Generar Codigo de Barras",NombreIcono= "ic_barcode" });
		Lista.Add(new MenuCLS { IdMenu=4,NombreOpcion="Leer Codigo de Barras",NombreIcono= "ic_leerbarcode" });
		Lista.Add(new MenuCLS { IdMenu=5,NombreOpcion="Alumnos",NombreIcono= "ic_estudiantes" });
		Lista.Add(new MenuCLS { IdMenu=6,NombreOpcion="Asistencia",NombreIcono= "ic_asistencia" });
		Lista.Add(new MenuCLS { IdMenu=100,NombreOpcion="Cerrar Sesión",NombreIcono= "ic_cerrarsesion" });
		BindingContext = this;

	}

    private void lstMenu_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var selectMenu = oMenuCLS.IdMenu;

        //if(oMenuCLS.IdMenu == 1)
        //{
        //	App.Current.MainPage = new ScanQR();
        //}

        switch (selectMenu)
        {
            case 1:

                App.Current.MainPage = new ScanQR();
                break;

            case 2:
                App.Current.MainPage = new GenerarQR();
                break;
            case 3:
                App.Current.MainPage = new GenerarBarCode();
                break;
            case 4:
                App.Current.MainPage = new ScanBarCode();
                break;

            case 5:
                App.Current.MainPage = new AlumnosPage();
                break;
            case 6:
                App.Current.MainPage = new AsistenciaPage();
                break;

            default:
                App.Current.MainPage = new LoginPage();
                Preferences.Remove("idusuario");
                break;
        }



    }
}
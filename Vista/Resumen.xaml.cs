using static System.Runtime.InteropServices.JavaScript.JSType;

namespace jcordovaExamen.Vista;

public partial class Resumen : ContentPage
{
	public Resumen(string usuario2, string nombre, string apellido, string edad, string fecha, string pais, string cuidad, double MontoInicial, double CuotaMensual, double PagoTotal)
	{
        InitializeComponent();


        lblUsuario1.Text = "Usuario conectado:" + usuario2;
        lblnombre.Text = nombre;
        lblapellido.Text = apellido;
        lbledad.Text = edad;
        lblfecha.Text = fecha;  
        lblcuidad.Text = cuidad;
        lblpais.Text = pais;
        lblmontoinicial.Text = Convert.ToString(MontoInicial);
        lblpagomensual.Text = Convert.ToString(CuotaMensual);
        lblpagototal.Text = Convert.ToString(PagoTotal);

    }

}
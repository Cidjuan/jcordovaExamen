namespace jcordovaExamen.Vista;

public partial class Registro : ContentPage
{
    Double PagoMesual;
    Double PagoTotal;
    string usuario1;
    public Registro(string usuario)
    {
		InitializeComponent();

        btnResumen.IsVisible = false;

        Double MontoInicial = Convert.ToDouble(txtMontoInicial.Text);

        string usuario1 = usuario;

        DisplayAlert("Alerta", "Bienvenido " + usuario, "Center");
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void pkPais_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    private void pkCiudad_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    public void btnCalcular_Clicked(object sender, EventArgs e)
    {
        Double MontoInicial = Convert.ToDouble(txtMontoInicial.Text);
        Double CuotaMensual = ((1500 - MontoInicial) / 4) + (1500 * 0.04);
        txtPagoMensual.Text = CuotaMensual.ToString();
        btnResumen.IsVisible = true;
        PagoMesual = CuotaMensual * 4;
        PagoTotal = PagoMesual + MontoInicial;

    }

    public void btnResumen_Clicked(object sender, EventArgs e)
    {
        string usuario2 = usuario1;
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = Convert.ToString(txtEdad.Text);
        string fecha = Convert.ToString(txtfecha.ToString());
        string pais = Convert.ToString(pkPais);
        string cuidad = Convert.ToString(pkCiudad);
        Double MontoInicial = Convert.ToDouble(txtMontoInicial.Text);
        Double CuotaMensual = ((1500 - MontoInicial) / 4) + (1500 * 0.04);
        double PagoMesual = CuotaMensual * 4;
        double PagoTotal = PagoMesual + MontoInicial;

        Navigation.PushAsync(new Resumen(usuario2,nombre,apellido,edad,fecha,pais,cuidad,MontoInicial,CuotaMensual,PagoTotal));


    }

    private void ValidacionEntradas()
    {
        Double MontoInicial = Convert.ToDouble(txtMontoInicial.Text);
        if (MontoInicial > 1500 || MontoInicial < 0)
        {
            DisplayAlert("Error", "Valor ingresado no permitido\n" +
                "Solo se aceptan valores entre 0.1-1500", "Cerrar");
        }
    }

    private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (txtMontoInicial.Text != "")
        {
            ValidacionEntradas();
        }
        

    }
}
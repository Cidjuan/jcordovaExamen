namespace jcordovaExamen.Vista;

public partial class Login : ContentPage
{
    string usuario;
    string contrase�a;
    public Login()
	{
		InitializeComponent();
        usuario = "examen1";
        contrase�a = "parcial1";
    }

    private void btnAcercade_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acerca());
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        if (txtUsuario.Text == usuario && txtContraase�a.Text == contrase�a)
        {
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o Contrase�a incorrectos", "Cerrar");
        }
    }
}
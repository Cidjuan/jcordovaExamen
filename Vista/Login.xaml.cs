namespace jcordovaExamen.Vista;

public partial class Login : ContentPage
{
    string usuario;
    string contraseña;
    public Login()
	{
		InitializeComponent();
        usuario = "examen1";
        contraseña = "parcial1";
    }

    private void btnAcercade_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Acerca());
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        if (txtUsuario.Text == usuario && txtContraaseña.Text == contraseña)
        {
            Navigation.PushAsync(new Registro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario o Contraseña incorrectos", "Cerrar");
        }
    }
}
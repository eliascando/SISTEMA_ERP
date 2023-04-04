using control;

namespace view.Visual.Main
{
    public partial class LoginSuccess : Form
    {
        public LoginSuccess()
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido " + GlobalVariablesCtrl.ObtenerUsuario();
        }
    }
}
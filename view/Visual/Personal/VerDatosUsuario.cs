namespace view.Visual
{
    public partial class VerDatosUsuario : Form
    {
        private VerUsuarios verUsuario_prueba;
        public VerDatosUsuario(VerUsuarios verUsuarios_Prueba)
        {
            InitializeComponent();
            this.verUsuario_prueba = verUsuarios_Prueba;
        }
    }
}
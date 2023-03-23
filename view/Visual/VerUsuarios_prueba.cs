using control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.Visual
{
    public partial class VerUsuarios_prueba : Form
    {
        public VerUsuarios_prueba()
        {
            InitializeComponent();
        }

        private async void VerUsuarios_prueba_Load(object sender, EventArgs e)
        {
            await CargarTabla();
        }
        public async Task CargarTabla()
        {
            PersonalCtrl personalCtrl = new PersonalCtrl();
            gridUsuarios.DataSource = await personalCtrl.ObtenerUsuarios();
        }
    }
}

using Publicaciones.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            tTiempo.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void tTiempo_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTiendas_Click(object sender, EventArgs e)
        {
            new frmTiendas().ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            new frmAutores().ShowDialog();
        }

        private void btnTitulos_Click(object sender, EventArgs e)
        {
            new frmTitulos().ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            new frmEmpleados().ShowDialog();
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            new frmEditoriales().ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            new frmVentas().ShowDialog();
        }
    }
}

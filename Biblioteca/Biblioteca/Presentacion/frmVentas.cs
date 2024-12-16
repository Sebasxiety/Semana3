using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Publicaciones.Presentacion
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void btnRegalias_Click(object sender, EventArgs e)
        {
            new frmRegalias().ShowDialog();
        }
    }
}

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
    public partial class frmTitulos : Form
    {
        public frmTitulos()
        {
            InitializeComponent();
        }

        private void btnRegalias_Click(object sender, EventArgs e)
        {
            new FrmTituloSuAutores().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmDescuentos().ShowDialog();
        }
    }
}

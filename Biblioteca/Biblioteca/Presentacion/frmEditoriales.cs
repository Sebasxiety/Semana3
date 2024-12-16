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
    public partial class frmEditoriales : Form
    {
        public frmEditoriales()
        {
            InitializeComponent();
        }

        private void btnDatosEditoriales_Click(object sender, EventArgs e)
        {
            new FrmDatosEditoriales().ShowDialog();
        }
    }
}

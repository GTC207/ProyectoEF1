using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectEF1
{
    public partial class frmInicio : Form
    {
        gestortramites gestor = new gestortramites();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void pnl_Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar f = new frmRegistrar(gestor);
            f.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmLista f = new frmLista(gestor);
            f.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar f = new frmBuscar(gestor);
            f.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmEliminar f = new frmEliminar(gestor);
            f.ShowDialog();
        }
    }
}

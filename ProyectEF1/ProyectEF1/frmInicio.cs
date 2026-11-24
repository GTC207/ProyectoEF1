using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectEF1
{
    public partial class frmInicio : Form
    {
        gestortramites gestor = new gestortramites();
        public frmInicio()
        {
            InitializeComponent();
            if (File.Exists("tramites.bin"))
            {
                gestor.LeerBinario("tramites.bin");
            }
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificar f = new frmModificar(gestor);
            f.ShowDialog();
        }

        private void btnMayorNota_Click(object sender, EventArgs e)
        {
            frmMayorNota f = new frmMayorNota(gestor);
            f.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmImpresion f = new frmImpresion(gestor);
            f.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

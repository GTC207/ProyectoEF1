using System;
using System.CodeDom;
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
    public partial class frmBuscar : Form
    {
        gestortramites gestor;
        public frmBuscar(gestortramites g)
        {
            InitializeComponent();
            gestor = g;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbCriterio.SelectedIndex==-1 || txtBuscar.Text == "")
            {
                MessageBox.Show("Elija un criterio y escriba que buscar");
                return;
            }

            dgvResultados.Rows.Clear();
            string texto = txtBuscar.Text.ToLower();
            int encontrados = 0;

            for(int i = 0; i < gestor.cantidad; i++)
            {
                tramites t = gestor.Tramites[i];
                bool coincide = false;
                switch (cmbCriterio.SelectedIndex)
                {
                    case 0: coincide = t.CodigoAlumno.ToLower().Contains(texto); break;
                    case 1: coincide = t.NombreAlumno.ToLower().Contains(texto); break;
                    case 2: coincide=t.ApellidosAlumno.ToLower().Contains(texto); break;
                    case 3: coincide = t.TutorProfesor.ToLower().Contains(texto); break;
                    case 4: coincide = t.Curso.ToLower().Contains(texto); break;
                    case 5: coincide = t.Notas == Convert.ToDouble(txtBuscar.Text); break;
                }

                if (coincide)
                {
                    dgvResultados.Rows.Add(t.CodigoAlumno, t.NombreAlumno, t.ApellidosAlumno, t.DNI, t.TutorProfesor, t.Curso, t.Grado, t.Seccion, t.Notas);
                    encontrados++;
                }

                if(encontrados == 0)
                {
                    MessageBox.Show("No se encontraron resultados");
                }
            }
        }
    }
}

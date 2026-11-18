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
    public partial class frmLista : Form
    {
        gestortramites gestor;
        public frmLista(gestortramites g)
        {
            InitializeComponent();
            gestor = g;
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            dgvAlumnos.Rows.Clear();
            for(int i =0; i < gestor.cantidad; i++)
            {
                tramites t = gestor.Tramites[i];
                dgvAlumnos.Rows.Add(t.CodigoAlumno, t.NombreAlumno, t.ApellidosAlumno, t.DNI, t.TutorProfesor, t.Curso, t.Grado, t.Seccion, t.Notas);
            }
        }
        private void btnBurbuja_Click(object sender, EventArgs e)
        {
            gestor.OrdenamientoBurbuja();
            MostrarDatos();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            gestor.OrdenamientoSeleccion();
            MostrarDatos();
        }
    }
}

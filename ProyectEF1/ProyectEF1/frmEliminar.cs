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
    public partial class frmEliminar : Form
    {
        gestortramites gestor;
        public frmEliminar(gestortramites g)
        {
            InitializeComponent();
            gestor = g;
            MostrarDatos();
        }
        private void MostrarDatos()
        {
            dgvAlumnos.Rows.Clear();
            for(int i = 0; i < gestor.cantidad; i++)
            {
                tramites t = gestor.Tramites[i];
                dgvAlumnos.Rows.Add(t.CodigoAlumno, t.NombreAlumno, t.ApellidosAlumno, t.DNI, t.TutorProfesor, t.TutorProfesor, t.Curso, t.Grado, t.Seccion, t.Notas);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un alumno de la tabla");
                return;
            }

            string codigo = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            int indice = gestor.BuscarIndice(codigo);

            DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar a este alumno?", "Eliminar", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes) 
            {
                gestor.Eliminar(indice);
                MessageBox.Show("Registro eliminado");
                MostrarDatos();
            }
        }
    }
}

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
    public partial class frmMayorNota : Form
    {
        public frmMayorNota(gestortramites gestor)
        {
            InitializeComponent();

            if (gestor.cantidad == 0)
            {
                MessageBox.Show("No existen trámites registrados");
                return;
            }

            double mayor = gestor.Tramites[0].Notas;
            for(int i = 1; i < gestor.cantidad; i++)
            {
                if (gestor.Tramites[i].Notas > mayor)
                {
                    mayor = gestor.Tramites[i].Notas;
                }
            }

            for(int i = 0; i < gestor.cantidad; i++)
            {
                tramites t = gestor.Tramites[i];
                if(t.Notas == mayor)
                {
                    dgvMayor.Rows.Add(t.CodigoAlumno, t.NombreAlumno, t.ApellidosAlumno, t.DNI, t.TutorProfesor, t.Curso, t.Grado, t.Seccion, t.Notas);
                }
            }
        }
    }
}

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
    public partial class frmImpresion : Form
    {
        gestortramites gestor;
        public frmImpresion(gestortramites g)
        {
            InitializeComponent();
            gestor = g;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int indice = gestor.BuscarIndice(txtCodigo.Text);
            if(indice == -1)
            {
                MessageBox.Show("No se encontraron resultados");
                return;
            }
            tramites t = gestor.Tramites[indice];
            string salto = Environment.NewLine;
            txtTramite.Text = "=========== Estrellitas de Fátima ===========" + salto + salto +
            "Estudiante: " + t.NombreAlumno + " " + t.ApellidosAlumno + salto +
            "DNI del apoderado: " + t.DNI + salto +
            "Docente a cargo: " + t.TutorProfesor + " || Curso: " + t.Curso + salto +
            "Grado: " + t.Grado + " || Sección: " + t.Seccion + salto + salto +
            "Estimado(a) apoderado(a):" + salto +
            "Nos complace informar que el estudiante " + t.NombreAlumno + " " + t.ApellidosAlumno +
            " ha obtenido una calificación de " + t.Notas + ". Este resultado refleja su esfuerzo, " +
            "dedicación y compromiso con sus actividades académicas." + salto + salto +
            "Felicitamos al estudiante por este importante logro y reconocemos el apoyo constante " +
            "de su familia en su proceso de aprendizaje." + salto + salto +
            "Confiamos en que continuará desarrollando sus capacidades, alcanzando nuevas metas " +
            "y superándose día a día.";
        }
    }
}

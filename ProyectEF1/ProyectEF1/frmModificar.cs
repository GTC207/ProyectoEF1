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
    public partial class frmModificar : Form
    {
        gestortramites gestor;
        int indice = -1;
        public frmModificar(gestortramites g)
        {
            InitializeComponent();
            gestor = g;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            indice = gestor.BuscarIndice(txtBuscarCodigo.Text);

            if(indice == -1)
            {
                MessageBox.Show("No se encontró el alumno");
                return;
            }
            tramites t = gestor.Tramites[indice];
            txtCodigo.Text = t.CodigoAlumno;
            txtDni.Text = t.DNI;
            txtNombre.Text = t.NombreAlumno;
            txtApellidos.Text = t.ApellidosAlumno;
            txtTutor.Text = t.TutorProfesor;
            txtCurso.Text = t.Curso;
            txtGrado.Text = t.Grado;
            txtSeccion.Text = t.Seccion;
            txtNota.Text = t.Notas.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (indice == -1)
            {
                MessageBox.Show("Primero busque un alumno");
                return;
            }

            if (txtNombre.Text == "" || txtApellidos.Text == "" || txtTutor.Text == "" || txtCurso.Text == "" || txtCodigo.Text == "" || txtDni.Text == "" || txtGrado.Text == "" || txtSeccion.Text == "" || txtNota.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            if (txtDni.Text.Length != 8)
            {
                MessageBox.Show("Ingrese un DNI valido");
                return;
            }

            for (int i = 0; i < txtDni.Text.Length; i++)
            {
                if (!char.IsDigit(txtDni.Text[i]))
                {
                    MessageBox.Show("El DNI solo debe tener numeros");
                    return;
                }
            }
            if (txtApellidos.Text.IndexOf(' ') == -1)
            {
                MessageBox.Show("Ingrese los dos apellidos del estudiante");
                return;
            }
            if (txtTutor.Text.IndexOf(' ') == -1)
            {
                MessageBox.Show("Ingrese  nombre y primer apellido del tutor (ej: perez lopez)");
                return;
            }

            if (txtCurso.Text == "")
            {
                MessageBox.Show("Ingrese un curso valido");
                return;
            }

            double nota = Convert.ToDouble(txtNota.Text);
            if (nota < 0 || nota > 20)
            {
                MessageBox.Show("La nota debe estar entre 0 y 20");
                return;
            }

            string nombre = char.ToUpper(txtNombre.Text[0]) + txtNombre.Text.Substring(1);
            string curso = char.ToUpper(txtCurso.Text[0]) + txtCurso.Text.Substring(1);
            string apellidos = gestor.Formateo(txtApellidos.Text);
            string tutor = gestor.Formateo(txtTutor.Text);

            gestor.Tramites[indice] = new tramites(txtCodigo.Text, txtDni.Text, nombre, apellidos, tutor, txtGrado.Text.ToLower(), txtSeccion.Text.ToUpper(), nota, curso);
            gestor.GuardarTodo();
            MessageBox.Show("Registro modificado");
            indice = -1;
        }
    }
}

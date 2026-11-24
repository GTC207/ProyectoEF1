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
    public partial class frmRegistrar : Form
    {
        gestortramites gestor;
        public frmRegistrar(gestortramites g)
        {
            InitializeComponent();
            gestor = g;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" || txtApellidos.Text == "" || txtTutor.Text == "" || txtCurso.Text == "" || txtCodigo.Text == "" || txtDni.Text == "" || txtGrado.Text == "" || txtSeccion.Text == "" || txtNota.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }
            if (txtCodigo.Text.Length != 9)
            {
                MessageBox.Show("Ingrese un código de 9 dígitos");
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
            if(txtTutor.Text.IndexOf(' ') == -1)
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
            if(nota < 0 || nota > 20)
            {
                MessageBox.Show("La nota debe estar entre 0 y 20");
                return;
            }
            

            string nombre = char.ToUpper(txtNombre.Text[0]) + txtNombre.Text.Substring(1);
            string curso = char.ToUpper(txtCurso.Text[0]) + txtCurso.Text.Substring(1);
            string apellidos = gestor.Formateo(txtApellidos.Text);
            string tutor = gestor.Formateo(txtTutor.Text);

            tramites t = new tramites(txtCodigo.Text.ToUpper(), txtDni.Text, nombre, apellidos,tutor, txtGrado.Text.ToUpper(), txtSeccion.Text.ToUpper(), nota, curso);

            if (gestor.Agregar(t))
            {
                gestor.GuardarTodo();
                MessageBox.Show("Trámite registrado");
                txtCodigo.Clear();
                txtDni.Clear();
                txtNombre.Clear();
                txtApellidos.Clear();
                txtTutor.Clear();
                txtCurso.Clear();
                txtGrado.Clear();
                txtSeccion.Clear();
                txtNota.Clear();
            }
            else
            {
                MessageBox.Show("Capacidad máxima alcanzada");
            }
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }
    }
}

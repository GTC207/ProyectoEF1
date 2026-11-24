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

            // Método recursivo: revisa el alumno de la posición i y se llama con la siguiente.
            // Devuelve cuántos alumnos coinciden.
            private int BuscarRecursivo(int i, string texto, int criterio, double nota)
            {
                if (i >= gestor.cantidad)      // caso base: ya se revisaron todos
                    return 0;

                tramites t = gestor.Tramites[i];
                bool coincide = false;

                switch (criterio)
                {
                    case 0: coincide = t.CodigoAlumno.ToLower().Contains(texto); break;
                    case 1: coincide = t.NombreAlumno.ToLower().Contains(texto); break;
                    case 2: coincide = t.ApellidosAlumno.ToLower().Contains(texto); break;
                    case 3: coincide = t.TutorProfesor.ToLower().Contains(texto); break;
                    case 4: coincide = t.Curso.ToLower().Contains(texto); break;
                    case 5: coincide = t.Notas == nota; break;
                }

                int suma = 0;
                if (coincide)
                {
                    dgvResultados.Rows.Add(t.CodigoAlumno, t.NombreAlumno, t.ApellidosAlumno, t.DNI, t.TutorProfesor, t.Curso, t.Grado, t.Seccion, t.Notas);
                    suma = 1;
                }

                return suma + BuscarRecursivo(i + 1, texto, criterio, nota);   // caso recursivo
            }

            private void btnBuscar_Click(object sender, EventArgs e)
            {
                if (cmbCriterio.SelectedIndex == -1 || txtBuscar.Text == "")
                {
                    MessageBox.Show("Elija un criterio y escriba que buscar");
                    return;
                }

                double nota = 0;
                if (cmbCriterio.SelectedIndex == 5 && !double.TryParse(txtBuscar.Text, out nota))
                {
                    MessageBox.Show("Ingrese una nota válida");
                    txtBuscar.Focus();
                    return;
                }

                dgvResultados.Rows.Clear();
                string texto = txtBuscar.Text.ToLower();

                int encontrados = BuscarRecursivo(0, texto, cmbCriterio.SelectedIndex, nota);

                if (encontrados == 0)
                {
                    MessageBox.Show("No se encontraron resultados");
                }
            }

        private void button1_Click(object sender, EventArgs e)
        
        {
            txtBuscar.Clear();
            cmbCriterio.SelectedIndex = -1;
            dgvResultados.Rows.Clear();
            txtBuscar.Focus();
        
        }

    }
    }
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bttnEntrar_Click(object sender, EventArgs e)
     
        {
            // aquí, entre las llaves, escribe esto:
            frmInicio menu = new frmInicio();
            menu.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDesdeCero
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void bntCambiarLeyenda_Click(object sender, EventArgs e)
        {

            string nombreCargado = txtNombre.Text;

            MessageBox.Show(nombreCargado);

            txtNombre.Text = "Otra cosa";
        }

        private void FrmPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditar fEditar = new FrmEditar();
            fEditar.ShowDialog();
        }
    }
}

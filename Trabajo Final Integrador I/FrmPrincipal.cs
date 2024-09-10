using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabajo_Final_Integrador_I.Properties;

namespace Trabajo_Final_Integrador_I
{
    public partial class FrmPrincipal : Form
    {

        string url = "https://fakestoreapi.com";

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola" + tbNombre.Text + " desde el Click del Boton");
        }

        private void btnChau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chau" + tbNombre.Text + " desde el Click del Boton Chau");
        }

        private void btnConsumirAPIEjemplo_Click(object sender, EventArgs e)
        {
            var client = new RestClient(url);

            var request = new RestRequest("products", Method.Get);

            List<Producto> productos = client.Get<List<Producto>>(request);

            dataGridView1.DataSource = productos;

        }

        private void btnProducto1_Click(object sender, EventArgs e)
        {
            var client = new RestClient(url);

            var request = new RestRequest("products/1", Method.Get);

            try { 
                Producto producto = client.Get<Producto>(request);

                tbId.Text = producto.id.ToString();
                tbTitle.Text = producto.title;
                tbPrice.Text = producto.price.ToString();
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show("No hay conexion! " + ex.Message);

                StreamWriter sw = new StreamWriter("log.txt");
                sw.WriteLine(ex.StackTrace);
                sw.Close();
            }


        }

        void GuardarProducto(Producto p)
        {
            var client = new RestClient(url);

            var request = new RestRequest("products/1", Method.Put);
            
            request.AddJsonBody(p);

            var response = client.Put(request);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Se guardo Correctamente");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(string.IsNullOrEmpty(tbTitle.Text))
            {
                errorProvider1.SetError(tbTitle, "No ingreso ningun titulo");
            }

            /*
            Producto p = new Producto();
            p.id = int.Parse(tbId.Text);
            p.title = tbTitle.Text;
            //p.price = decimal.Parse(tbPrice.Text);

            GuardarProducto(p);
            */
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmEditar fEditar = new FrmEditar();

            fEditar.Show();
        }
    }
}

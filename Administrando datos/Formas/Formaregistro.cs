using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrando_datos.Formas
{
    public partial class Formaregistro : Form
    {
        public Formaregistro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text) || string.IsNullOrWhiteSpace(ttelefono.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Administración_de_Estudiantes home = new Administración_de_Estudiantes();
                home.Show();

            }
                

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();

        }

        private void Formaregistro_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ttelefono_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ttelefono.Text))
            {
                if (!Esnumero(ttelefono.Text))
                {
                    MessageBox.Show("Por favor, ingrese solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ttelefono.Text = ""; // Limpiar el campo si se ingresaron caracteres no numéricos.
                }
                
            }
        }

        private bool Esnumero(string texto)
        {
            // Utilizamos int.TryParse para verificar si el texto se puede convertir a un número entero.
            int numero;
            return int.TryParse(texto, out numero);
        }
    }
}
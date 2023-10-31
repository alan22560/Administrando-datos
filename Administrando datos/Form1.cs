using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administrando_datos.Formas;

namespace Administrando_datos
{
    public partial class Form1 : Form
    {
        private int intentosRestantes = 5;
        private const string usuarioCorrecto = "Eduardo";
        private const string contraseñaCorrecta = "1234";
        private bool formularioBloqueado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formularioBloqueado)
            {
                MessageBox.Show("Ya no puedes intentar más. La aplicación se cerrará.");
                Application.Exit();
                return;
            }

            string usuario = textBoxUsuario.Text;
            string contraseña = textBoxContraseña.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else if (usuario.Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos 3 caracteres.");
            }
            else if (usuario == usuarioCorrecto && contraseña != contraseñaCorrecta)
            {
                intentosRestantes--;
                if (intentosRestantes > 0)
                {
                    MessageBox.Show("Contraseña incorrecta. Intentos restantes: " + intentosRestantes);
                }
                else
                {
                    BloquearFormulario();
                }
            }
            else if (usuario != usuarioCorrecto && contraseña == contraseñaCorrecta)
            {
                intentosRestantes--;
                if (intentosRestantes > 0)
                {
                    MessageBox.Show("Usuario incorrecto. Intentos restantes: " + intentosRestantes);
                }
                else
                {
                    BloquearFormulario();
                }
            }
            else if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
            {
                MessageBox.Show("¡Hola de nuevo Eduardo!");
                this.Hide(); // Oculta la ventana de login
                // Aquí debes mostrar la pantalla principal o realizar cualquier otra acción que desees.

                Administración_de_Estudiantes home = new Administración_de_Estudiantes();
                home.Show();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña incorrectos.");
            }
            
        }

        private void BloquearFormulario()
        {
            MessageBox.Show("Tus intentos sean acbado . La aplicación se cerrará.");
            formularioBloqueado = true;
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Formaregistro home = new Formaregistro();
            home.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

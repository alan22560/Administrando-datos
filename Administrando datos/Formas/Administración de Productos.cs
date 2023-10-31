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
    public partial class Administración_de_Estudiantes : Form
    {
        public Administración_de_Estudiantes()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                DataGridViewRow renglon = (DataGridViewRow)dataEstudiante.Rows[0].Clone();

                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox2.Text;
                renglon.Cells[2].Value = texbox3.Text;
                renglon.Cells[3].Value = comboBox1.Text;
                renglon.Cells[4].Value = comboBox2.Text;

                dataEstudiante.Rows.Add(renglon);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Producto",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Desea eliminar el registro?";
            string titulo = "Eliminar registro";

            if (!(dataEstudiante.CurrentRow is null))
            {
                if (MessageBox.Show(mensaje, titulo , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Eliminando",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes selecionar un renglon", "Eliminar",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataEstudiante.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes selecionar un renglon", "Modificando producto",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                textBox1.Text = dataEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox2.Text = dataEstudiante.CurrentRow.Cells["Marca"].Value.ToString();
                texbox3.Text = dataEstudiante.CurrentRow.Cells["Descripcion"].Value.ToString();
                comboBox1.Text = dataEstudiante.CurrentRow.Cells["Unidades"].Value.ToString();
                comboBox2.Text = dataEstudiante.CurrentRow.Cells["Precio"].Value.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void dataEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro_empleados home = new registro_empleados();
            home.Show();
        }
    }
}
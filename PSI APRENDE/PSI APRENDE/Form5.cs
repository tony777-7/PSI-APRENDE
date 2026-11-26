using System;
using System.Windows.Forms;

namespace PSI_APRENDE
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // BOTON GUARDAR PROFESIONAL
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||
                textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else if (textBox2.Text.Length < 3)
            {
                MessageBox.Show("Ingrese un nombre válido");
            }
            else if (textBox3.Text.Length < 7 || textBox3.Text.Length > 8)
            {
                MessageBox.Show("El teléfono debe tener 7 u 8 números");
            }
            else
            {
                bool repetido = false;

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (!fila.IsNewRow && fila.Cells[0].Value != null)
                    {
                        string codigoExistente = Convert.ToString(fila.Cells[0].Value);
                        if (codigoExistente == textBox1.Text)
                        {
                            repetido = true;
                        }
                    }
                }

                if (repetido == true)
                {
                    MessageBox.Show("El código profesional ya existe");
                }
                else
                {
                    dataGridView1.Rows.Add(
                        textBox1.Text,
                        textBox2.Text,
                        textBox3.Text,
                        textBox4.Text
                    );

                    MessageBox.Show("Profesional registrado correctamente");

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
        }
    }
}
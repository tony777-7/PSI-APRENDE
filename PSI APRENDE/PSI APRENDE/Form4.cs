
using System;
using System.Windows.Forms;

namespace PSI_APRENDE
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        // GUARDAR SESION
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||
                textBox3.Text == "" || textBox4.Text == "" ||
                textBox5.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                dataGridView1.Rows.Add(
                    textBox1.Text,
                    dateTimePicker1.Value.ToShortDateString(),
                    textBox2.Text,
                    textBox3.Text,
                    textBox4.Text,
                    textBox5.Text
                );

                MessageBox.Show("Atención registrada correctamente");

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        // CONSULTAR HISTORIAL
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese el nombre del paciente");
            }
            else
            {
                int encontrado = 0;

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (!fila.IsNewRow && fila.Cells[0].Value != null)
                    {
                        if (fila.Cells[0].Value.ToString() == textBox1.Text)
                        {
                            encontrado = 1;
                            fila.Selected = true;
                        }
                        else
                        {
                            fila.Selected = false;
                        }
                    }
                }

                if (encontrado == 1)
                {
                    MessageBox.Show("Paciente encontrado");
                }
                else
                {
                    MessageBox.Show("No se encontraron atenciones");
                }
            }
        }
    }
}

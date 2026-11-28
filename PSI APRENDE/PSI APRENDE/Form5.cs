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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox6.Text == "" ||
        textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            bool existeProfesional = false;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (Convert.ToString(fila.Cells[0].Value) == textBox5.Text)
                {
                    existeProfesional = true;
                }
            }

            if (existeProfesional == false)
            {
                MessageBox.Show("El profesional no está registrado");
                return;
            }
            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                if (Convert.ToString(fila.Cells[0].Value) == textBox6.Text)
                {
                    MessageBox.Show("El usuario ya existe");
                    return;
                }
            }
            dataGridView2.Rows.Add(
                textBox6.Text,
                textBox5.Text,
                textBox8.Text,
                "Activo"
            );

            MessageBox.Show("Cuenta creada correctamente");
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null ||
        dataGridView2.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione una cuenta");
            }
            else
            {
                dataGridView2.CurrentRow.Cells[3].Value = "Inactivo";

                MessageBox.Show("Cuenta desactivada correctamente");
            }
        }
    }
}
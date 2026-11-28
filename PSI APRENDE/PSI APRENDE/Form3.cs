using System;
using System.Windows.Forms;

namespace PSI_APRENDE
{
    public partial class Form3 : Form
    {
        int contador = 1;

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // BOTON GUARDAR
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del paciente");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese el apellido del paciente");
                textBox2.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Ingrese el telefono del paciente");
                textBox3.Focus();
                return;
            }

            foreach (char letra in txtNombre.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show("El nombre solo debe contener letras");
                    txtNombre.Focus();
                    return;
                }
            }

            foreach (char letra in textBox2.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show("El apellido solo debe contener letras");
                    textBox2.Focus();
                    return;
                }
            }

            if (textBox3.Text.Length < 7 || textBox3.Text.Length > 15)
            {
                MessageBox.Show("El telefono debe tener entre 7 y 15 numeros");
                textBox3.Focus();
                return;
            }

            foreach (char numero in textBox3.Text)
            {
                if (!char.IsDigit(numero))
                {
                    MessageBox.Show("El telefono solo debe contener numeros");
                    textBox3.Focus();
                    return;
                }
            }

            if (dateTimePicker1.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura");
                return;
            }

            dataGridView1.Rows.Add(
                contador,
                txtNombre.Text,
                textBox2.Text,
                textBox3.Text,
                dateTimePicker1.Value.ToShortDateString()

            );

            contador++;

            MessageBox.Show("Paciente registrado correctamente");

            LimpiarCampos();
        }

        // BOTON MODIFICAR
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null ||
                dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione un paciente de la lista");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            foreach (char letra in txtNombre.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show("El nombre solo debe contener letras");
                    return;
                }
            }

            foreach (char letra in textBox2.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show("El apellido solo debe contener letras");
                    return;
                }
            }

            if (textBox3.Text.Length < 7 || textBox3.Text.Length > 15)
            {
                MessageBox.Show("El telefono debe tener entre 7 y 15 numeros");
                return;
            }

            foreach (char numero in textBox3.Text)
            {
                if (!char.IsDigit(numero))
                {
                    MessageBox.Show("El telefono solo debe contener numeros");
                    return;
                }
            }

            if (dateTimePicker1.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura");
                return;
            }

            int fila = dataGridView1.CurrentRow.Index;

            dataGridView1.Rows[fila].Cells["Nombre"].Value = txtNombre.Text;
            dataGridView1.Rows[fila].Cells["Apellido"].Value = textBox2.Text;
            dataGridView1.Rows[fila].Cells["Telefono"].Value = textBox3.Text;
            dataGridView1.Rows[fila].Cells["FechaNacimiento"].Value = dateTimePicker1.Value.ToShortDateString();

            MessageBox.Show("Paciente modificado correctamente");

            LimpiarCampos();
        }

        // BOTON LIMPIAR
        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Today;
            txtNombre.Focus();
        }
        // BOTON REGISTRAR CITA
        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidarCita() == true)
            {
                dataGridView2.Rows.Add(
                    textBox4.Text,
                    textBox5.Text,
                    textBox6.Text,
                    textBox7.Text
                );

                MessageBox.Show("Cita registrada correctamente");
                LimpiarCita();
            }
        }


        // BOTON MODIFICAR CITA
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null ||
       dataGridView2.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione una cita");
            }
            else
            {
                if (ValidarCita() == true)
                {
                    int fila = dataGridView2.CurrentRow.Index;

                    dataGridView2.Rows[fila].Cells[0].Value = textBox4.Text;
                    dataGridView2.Rows[fila].Cells[1].Value = textBox5.Text;
                    dataGridView2.Rows[fila].Cells[2].Value = textBox6.Text;
                    dataGridView2.Rows[fila].Cells[3].Value = textBox7.Text;

                    MessageBox.Show("Cita modificada correctamente");
                }
            }
        }

        // BOTON CANCELAR CITA
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Seleccione una cita");
            }
            else
            {
                dataGridView2.CurrentRow.Cells["Estado"].Value = "Cancelada";
                MessageBox.Show("Cita cancelada correctamente");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int fila = e.RowIndex;
                txtNombre.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[fila].Cells[3].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(
                    dataGridView1.Rows[fila].Cells[4].Value);
            }
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private bool ValidarCita()
        {
            if (textBox4.Text == "" ||
                textBox5.Text == "" ||
                textBox6.Text == "" ||
                textBox7.Text == "")
            {
                MessageBox.Show("Complete todos los campos de la cita");
                return false;
            }
            // Comprobar que la fecha sea válida
            DateTime fecha;
            if (DateTime.TryParse(textBox5.Text, out fecha) == false)
            {
                MessageBox.Show("Ingrese una fecha válida");
                return false;
            }
            // No permitir fechas anteriores a hoy
            if (fecha.Date < DateTime.Today)
            {
                MessageBox.Show("No puede registrar citas en fechas pasadas");
                return false;
            }
            return true;
        }
        private void LimpiarCita()
        {
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

    }
}  


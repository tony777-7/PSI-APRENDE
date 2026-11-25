using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PSI_APRENDE
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar campos vacios
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

            // Validar nombre
            foreach (char letra in txtNombre.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show("El nombre solo debe contener letras");
                    txtNombre.Focus();
                    return;
                }
            }

            // Validar apellido
            foreach (char letra in textBox2.Text)
            {
                if (!char.IsLetter(letra) && letra != ' ')
                {
                    MessageBox.Show("El apellido solo debe contener letras");
                    textBox2.Focus();
                    return;
                }
            }

            // Validar telefono
            foreach (char numero in textBox3.Text)
            {
                if (!char.IsDigit(numero))
                {
                    MessageBox.Show("El telefono solo debe contener numeros");
                    textBox3.Focus();
                    return;
                }
            }

            // Validar fecha de nacimiento
            if (dateTimePicker1.Value.Date > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura");
                return;
            }

            MessageBox.Show("Todos los datos son correctos");
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = textBox1.Text.Trim();
            string nombre = textBox2.Text.Trim();
            string telefono = textBox3.Text.Trim();
            string especialidad = textBox4.Text.Trim();

            // 1. Campos obligatorios
            if (string.IsNullOrWhiteSpace(codigo) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(especialidad))
            {
                MessageBox.Show("Complete todos los campos antes de guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Longitud mínima de nombre y especialidad
            if (nombre.Length < 3 || especialidad.Length < 3)
            {
                MessageBox.Show("El nombre y la especialidad deben tener al menos 3 caracteres.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Teléfono solo dígitos (7 u 8 números)
            if (!telefono.All(char.IsDigit) || telefono.Length < 7 || telefono.Length > 8)
            {
                MessageBox.Show("El teléfono debe contener entre 7 y 8 dígitos numéricos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            // 4. Evitar código duplicado en dataGridView1
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (!fila.IsNewRow && fila.Cells[0].Value != null &&
                    fila.Cells[0].Value.ToString().Equals(codigo, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Ese código profesional ya está registrado.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    return;
                }
            }

            // 5. Agregar fila a dataGridView1 y limpiar campos
            dataGridView1.Rows.Add(codigo, nombre, especialidad);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();

            MessageBox.Show("Profesional guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PSI_APRENDE
{
    public partial class Form4 : Form
    {
        // Lista temporal de sesiones
        private List<Sesion> historial = new List<Sesion>();

        public Form4()
        {
            InitializeComponent();

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        // Clase para almacenar cada sesión
        private class Sesion
        {
            public string Paciente { get; set; }
            public DateTime Fecha { get; set; }
            public string Tipo { get; set; }
            public string Estado { get; set; }
            public string Profesional { get; set; }
            public string Actividad { get; set; }
        }

        // BOTÓN GUARDAR SESIÓN
        private void button1_Click(object sender, EventArgs e)
        {
            string paciente = textBox1.Text.Trim();
            string tipo = textBox2.Text.Trim();
            string estado = textBox3.Text.Trim();
            string profesional = textBox4.Text.Trim();
            string actividad = textBox5.Text.Trim();

            // Validar campos
            if (paciente == "" ||
                tipo == "" ||
                estado == "" ||
                profesional == "" ||
                actividad == "")
            {
                MessageBox.Show(
                    "Complete todos los campos antes de guardar.",
                    "Campos obligatorios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Crear nueva sesión
            Sesion nuevaSesion = new Sesion();

            nuevaSesion.Paciente = paciente;
            nuevaSesion.Fecha = dateTimePicker1.Value.Date;
            nuevaSesion.Tipo = tipo;
            nuevaSesion.Estado = estado;
            nuevaSesion.Profesional = profesional;
            nuevaSesion.Actividad = actividad;

            historial.Add(nuevaSesion);

            // Actualizar historial
            MostrarHistorial(paciente);

            MessageBox.Show(
                "La sesión se registró correctamente.",
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Limpiar campos de la sesión
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        // BOTÓN CONSULTAR HISTORIAL
        private void button2_Click(object sender, EventArgs e)
        {
            string paciente = textBox1.Text.Trim();

            if (paciente == "")
            {
                MessageBox.Show(
                    "Ingrese el nombre del paciente.",
                    "Buscar paciente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MostrarHistorial(paciente);

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron sesiones para este paciente.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // MOSTRAR HISTORIAL
        private void MostrarHistorial(string paciente)
        {
            dataGridView1.Rows.Clear();

            foreach (Sesion sesion in historial)
            {
                if (sesion.Paciente.IndexOf(
                    paciente,
                    StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    dataGridView1.Rows.Add(
                        sesion.Fecha.ToString("dd/MM/yyyy"),
                        sesion.Tipo,
                        sesion.Estado
                    );
                }
            }
        }

        // EVENTO DE BÚSQUEDA
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;

namespace PSI_APRENDE
{
    public partial class Form2 : Form
    {
        // Guarda el rol o código del usuario que inició sesión en Form1
        private string rolUsuario;

        public Form2(string rol = "ADMIN")
        {
            InitializeComponent();
            rolUsuario = rol;
        }

        // Botón 1: GESTION DE PACIENTES Y CITAS
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();
        }

        // Botón 2: SEGUIMIENTO DE ATENCIONES
        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form4>();
        }

        // Botón 3: ADMINISTRACION DE SISTEMA
        private void button3_Click(object sender, EventArgs e)
        {
            // Validación de permiso: solo administradores entran aquí
            if (rolUsuario != "ADMIN")
            {
                MessageBox.Show("Acceso denegado. No tiene permisos de administrador.",
                                "Validación de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AbrirFormulario<Form5>();
        }

        // Botón 4: CERRAR SESION
        private void button4_Click(object sender, EventArgs e)
        {
            // Validación de confirmación antes de salir
            DialogResult confirmar = MessageBox.Show(
                "¿Está seguro que desea cerrar la sesión actual?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmar == DialogResult.Yes)
            {
                // Busca Form1 si estaba oculto o crea uno nuevo
                Form1 login = Application.OpenForms.OfType<Form1>().FirstOrDefault();
                if (login != null)
                {
                    login.Show();
                }
                else
                {
                    new Form1().Show();
                }

                this.Close();
            }
        }

        // Validación para evitar abrir el mismo formulario varias veces
        private void AbrirFormulario<T>() where T : Form, new()
        {
            Form abierto = Application.OpenForms.OfType<T>().FirstOrDefault();

            if (abierto != null)
            {
                abierto.BringToFront();
                abierto.WindowState = FormWindowState.Normal;
            }
            else
            {
                T nuevo = new T();
                nuevo.Show();
            }
        }

        // Si el usuario cierra Form2 con la X de la ventana, cierra toda la app
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (Application.OpenForms.OfType<Form1>().All(f => !f.Visible))
            {
                Application.Exit();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 seguimiento=new Form4();
            seguimiento.Show();
            this.Hide();
        }
    }
}
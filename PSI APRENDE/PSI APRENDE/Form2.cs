
namespace PSI_APRENDE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 pacientes = new Form3();
            this.Hide();
            pacientes.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 seguimiento = new Form4();
            this.Hide();
            seguimiento.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 administracion = new Form5();
            this.Hide();
            administracion.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexion = Conexion.Conectar())
                {
                    MessageBox.Show("¡Conexión exitosa con MySQL!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}

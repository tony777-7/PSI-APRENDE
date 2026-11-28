namespace PSI_APRENDE
{
    public partial class Form1 : Form
    {
        int cont = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else if (textBox1.Text == "140822629" &&
                     textBox2.Text == "admin" &&
                     textBox3.Text == "1234")
            {
                Form2 menu = new Form2();
                this.Hide();
                if (menu.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                    cont = 0;

                    this.Show();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                cont++;
                MessageBox.Show("Datos incorrectos. Intento " + cont + " de 3");

                textBox3.Clear();

                if (cont == 3)
                {
                    MessageBox.Show("Se excedió el número de intentos");
                    button1.Enabled = false;
                }
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }
    }
}

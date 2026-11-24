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
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "140822629" && textBox2.Text=="admin" && textBox3.Text == "1234")
            {
                Form2 menu = new Form2();
                menu.Show();
                this.Hide();
            }
            else
            {
                cont ++;
                MessageBox.Show("Datos incorrectos");
                if (cont == 3) 
                {
                    MessageBox.Show("Se excedió el número de intentos");
                    button1.Enabled = false;

                }
            }
        }
    }
} 

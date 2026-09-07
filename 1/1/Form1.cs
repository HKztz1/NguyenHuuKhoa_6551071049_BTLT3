namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword2.Text = "";
            txtPassword1.Clear();
            txtPassword1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPassword2.Text = txtPassword1.Text;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

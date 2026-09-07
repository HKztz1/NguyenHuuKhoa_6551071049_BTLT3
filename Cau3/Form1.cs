namespace Cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblHoTen.Text = txtHo.Text + "" + txtTen.Text;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

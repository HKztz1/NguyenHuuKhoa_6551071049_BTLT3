namespace Câu14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            String nameSV = txtName.Text.Trim();
            if (string.IsNullOrEmpty(nameSV))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            lstLopA.Items.Add(nameSV);
            txtName.Clear();
            txtName.Focus();
        }
        private void btnSangPhai_Click(object sender, EventArgs e)
        {
            while (lstLopA.SelectedItems.Count > 0)
            {
                var item = lstLopA.SelectedItems[0];
                lstLopB.Items.Add(item);
                lstLopA.Items.Remove(item);
            }
        }
        private void btnSangPhaiTatca_Click(object sender, EventArgs e)
        {
            while (lstLopA.Items.Count > 0)
            {
                var item = lstLopA.Items[0];
                lstLopB.Items.Add(item);
                lstLopA.Items.Remove(item);
            }
        }
        private void btnSangTrai_Click(object sender, EventArgs e)
        {
            while (lstLopB.SelectedItems.Count > 0)
            {
                var item = lstLopB.SelectedItems[0];
                lstLopA.Items.Add(item);
                lstLopB.Items.Remove(item);
            }
        }
        private void btnSangTraiTatca_Click(object sender, EventArgs e)
        {
            while (lstLopB.Items.Count > 0)
            {
                var item = lstLopB.Items[0];
                lstLopA.Items.Add(item);
                lstLopB.Items.Remove(item);
            }
        }
        private void btnXoaLopA_Click(object sender, EventArgs e)
        {
            while (lstLopA.SelectedItems.Count > 0)
            {
                lstLopA.Items.Remove(lstLopA.SelectedItems[0]);
            }
        }
        private void btnXoaLopB_Click(object sender, EventArgs e)
        {
            while (lstLopB.SelectedItems.Count > 0)
            {
                lstLopB.Items.Remove(lstLopB.SelectedItems[0]);
            }
        }
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt") + "   Designed by Xavier";
        }
    }
}

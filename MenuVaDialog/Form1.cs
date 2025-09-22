using MenuVaDialog.Forms;

namespace MenuVaDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Form? curentForm;



        void ChangeForm(Form form)
        {
            if (curentForm != null)
            {
                curentForm.Close(); // Đóng lại form cũ
            }

            curentForm = form;
            curentForm.Show();
            curentForm.FormBorderStyle = FormBorderStyle.None; // Bỏ viền của form
            curentForm.TopLevel = false;
            curentForm.Dock = DockStyle.Fill; // Cho form đính vào form cha
            panel1.Controls.Add(curentForm); // Gắn vào panel
            curentForm.BringToFront(); // Mang form ra trước
        }

        private void saToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeForm(new TrangChuForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeForm(new SanPhamForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

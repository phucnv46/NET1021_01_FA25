using ChuaDeMau1.Models;
using ChuaDeMau1.Repositories;

namespace ChuaDeMau1
{
    public partial class Form1 : Form
    {
        NhanVienRepository _repository = new NhanVienRepository();
        public Form1()
        {
            InitializeComponent();
            LoadTable();
        }

        public void LoadTable()
        {
            dataGridView1.DataSource = _repository.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NhanVien nhanVien = _repository.GetAll().Last(); // lấy phần tử cuối cùng
            textBoxMa.Text = nhanVien.MaNhanVien;
            textBoxTen.Text = nhanVien.TenNhanVien;
            textBoxCV.Text = nhanVien.ChucVu;
            radioButtonNam.Checked = nhanVien.GioiTinh.Equals("Nam");
            radioButtonNu.Checked = nhanVien.GioiTinh.Equals("Nữ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is NhanVien nhanVien)
            {
                textBoxMa.Text = nhanVien.MaNhanVien;
                textBoxTen.Text = nhanVien.TenNhanVien;
                textBoxCV.Text = nhanVien.ChucVu;
                radioButtonNam.Checked = nhanVien.GioiTinh.Equals("Nam");
                radioButtonNu.Checked = nhanVien.GioiTinh.Equals("Nữ");
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNhanVien = textBoxMa.Text;
                nhanVien.TenNhanVien = textBoxTen.Text;
                nhanVien.ChucVu = textBoxCV.Text;
                nhanVien.GioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";

                try
                {
                    _repository.Them(nhanVien);

                    MessageBox.Show("Thêm nhân viên thành công");
                    LoadTable();
                }
                catch (Exception)
                {

                    MessageBox.Show("Thêm nhân viên Thất bại");
                }

            }

        }

        bool KiemTraTrong()
        {

            if (string.IsNullOrEmpty(textBoxMa.Text)
                || string.IsNullOrEmpty(textBoxTen.Text)
                || string.IsNullOrEmpty(textBoxCV.Text)
                )
            {
                MessageBox.Show("Có trường đang trống!");
                return false;
            }

            return true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using ChuaDeMau2.Models;
using ChuaDeMau2.Repositories;

namespace ChuaDeMau2
{
    public partial class Form1 : Form
    {
        //Khai báo Repository
        SachRepository _repository;
        public Form1()
        {
            InitializeComponent();
            _repository = new SachRepository();// Khởi tạo Repository

            LoadTable();
        }

        void LoadTable()
        {
            dataGridView1.DataSource = _repository.GetAll();
            /*dataGridView1.Columns[0].HeaderText = "Mã sách";
            dataGridView1.Columns[1].HeaderText = "Tên sách";
            dataGridView1.Columns[2].HeaderText = "Đơn giá";
            dataGridView1.Columns[3].HeaderText = "Số trang";*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sach sach = _repository.GetAll().Last();
            textBoxMa.Text = sach.MaSach;
            textBoxTenSach.Text = sach.TenSach;
            if (sach.DonGia.HasValue) numericUpDown1.Value = sach.DonGia.Value;
            else numericUpDown1.Value = 0;
            radioButton1k.Checked = sach.SoTrang == 1000;
            radioButton1L.Checked = sach.SoTrang == 100;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Sach sach) // lấy dữ liệu ẩn trong dòng
            {
                textBoxMa.Text = sach.MaSach;
                textBoxTenSach.Text = sach.TenSach;
                if (sach.DonGia.HasValue) numericUpDown1.Value = sach.DonGia.Value;
                else numericUpDown1.Value = 0;
                radioButton1k.Checked = sach.SoTrang == 1000;
                radioButton1L.Checked = sach.SoTrang == 100;

            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_repository.GetAll().Any(x=>x.MaSach.Equals(textBoxMa.Text,
                    StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Bị trùng mã");
                    return;
                }

                Sach sach = new Sach();
                sach.MaSach = textBoxMa.Text;
                sach.TenSach = textBoxTenSach.Text;
                sach.DonGia = numericUpDown1.Value;
                sach.SoTrang = radioButton1k.Checked ? 1000 : 100;

                _repository.Them(sach);

                MessageBox.Show("Thêm sách thành công");
                LoadTable();
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi xảy ra khi thêm");
            }
    
            
        }
    }
}

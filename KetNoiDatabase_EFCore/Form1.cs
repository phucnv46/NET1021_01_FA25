using KetNoiDatabase_EFCore.Data;
using KetNoiDatabase_EFCore.Models;
using KetNoiDatabase_EFCore.Repositories;
namespace KetNoiDatabase_EFCore
{
    public partial class Form1 : Form
    {
        SachRepository _sachRepository;
        public Form1()
        {
            InitializeComponent();
            _sachRepository = new SachRepository();
            LoadData();
        }


        void LoadData()
        {
            dataGridView1.DataSource = _sachRepository.LayDanhSach();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.TenSach = textBoxTenSach.Text;
            sach.NamXuatBan = (int)numericUpDownNSX.Value;
            sach.NhaXuatBan = textBoxNXB.Text;
            sach.SoLuong = (int)numericUpDownSL.Value;
            sach.GiaTien = numericUpDownGB.Value;
            _sachRepository.Them(sach);
            LoadData();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Sach sach)
            {
                sach.TenSach = textBoxTenSach.Text;
                sach.NamXuatBan = (int)numericUpDownNSX.Value;
                sach.NhaXuatBan = textBoxNXB.Text;
                sach.SoLuong = (int)numericUpDownSL.Value;
                sach.GiaTien = numericUpDownGB.Value;
                _sachRepository.Sua(sach);
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Sach sach)
            {
                textBoxMaSach.Text = sach.MaSach.ToString();
                textBoxTenSach.Text = sach.TenSach;
                textBoxNXB.Text = sach.NhaXuatBan;
                numericUpDownGB.Value = sach.GiaTien.Value;
                numericUpDownSL.Value = sach.SoLuong.Value;
                numericUpDownNSX.Value = sach.NamXuatBan.Value;
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Sach sach)
            {
                _sachRepository.Xoa(sach);
                LoadData() ;
            }
        }
    }
}

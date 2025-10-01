using KetNoiDatabase_EFCORE_NB.Models;
using KetNoiDatabase_EFCORE_NB.Repositories;

namespace KetNoiDatabase_EFCORE_NB
{
    public partial class Form1 : Form
    {
        //Gọi các phụ thuộc
        SinhVienRepository _svRepository;
        LopRepository _llRepository;
        public Form1()
        {
            InitializeComponent();
            _svRepository = new SinhVienRepository();
            _llRepository = new LopRepository();
            LoadData();
        }


        private void LoadData()
        {
            dataGridView1.DataSource = _svRepository.LayDSKemBangQuanHe();
            comboBoxLop.DataSource = _llRepository.LayDSLop();
            comboBoxLop.DisplayMember = "TenLop";
            comboBoxLop.ValueMember = nameof(Lop.MaLop);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.DataBoundItem is SinhVien sinhVien)
            {
                textBoxMa.Text = sinhVien.MaSinhVien;
                textBoxHT.Text = sinhVien.TenSinhVien;
                textBoxDC.Text = sinhVien.DiaChi;
                dateTimePickerNS.Value = sinhVien.NgaySinh.ToDateTime(new TimeOnly(0,0));
                comboBoxLop.SelectedValue = sinhVien.MaLop;
            }
        }
    }
}

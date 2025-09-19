namespace ControlCoBan2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SinhVien sinhVien = new SinhVien(); // () Hàm tạo (constructor)
            sinhVien.MaSV = textBoxMSV.Text;
            sinhVien.HoTen= textBoxHoTen.Text;
            sinhVien.GioiTinh = radioButtonNam.Checked;
            sinhVien.NgaySinh = dateTimePickerNgaySinh.Value;
            sinhVien.Lop =  comboBoxLop.SelectedItem?.ToString() ?? "Chưa rõ";
            sinhVien.DiaChi = textBoxDC.Text;


            MessageBox.Show(sinhVien.ToString(),"Thông tin sinh viên",MessageBoxButtons.YesNo);
        }
    }
}

using GioiThieuLinQ.Models;
using System.ComponentModel;

namespace GioiThieuLinQ
{
    public partial class Form1 : Form
    {

        BindingList<Giay> giays = new BindingList<Giay>() {
            new Giay(){MaGiay=1,TenGiay="Giày Ninja",ChatLieu="Vải",GioiTinh=GioiTinh.Unisex,Hang="Nike"},
            new Giay(){MaGiay=2,TenGiay="Giày Yezzy 350",ChatLieu="Da lộn",GioiTinh=GioiTinh.Nam,Hang="Adidas"},
            new Giay(){MaGiay=3,TenGiay="Giày Puna",ChatLieu="Vải",GioiTinh=GioiTinh.Nu,Hang="Puma"},

        };
        public Form1()
        {
            InitializeComponent();

            //Thêm nhanh biến thể 
            // Màu (Xanh,Đỏ,Đen) , Size(41,42,43)
            List<string> colors = new List<string>() { "Xanh", "Đỏ", "Đen" };
            List<int> sizes = new List<int>() { 41, 42, 43 };

            //Taọ danh sách biến thể đồng giá:
            /*    List<BienThe> bienThes = new List<BienThe>();
                foreach (var color in colors)
                {
                    foreach (var size in sizes)
                    {
                        BienThe bienThe = new BienThe()
                        {
                            MaGiay = 1,
                            Mau = color,
                            Size = size,
                            Gia = 1_000_000,
                            SoLuong = 10,
                        };
                        bienThes.Add(bienThe);
                    }
                }

                dataGridView1.DataSource = bienThes;*/

            //LinQ tương tự
            /* List<BienThe> bienThes = (from size in sizes
                                       from color in colors
                                       select new BienThe
                                       {
                                           MaGiay = 1,
                                           Mau = color,
                                           Size = size,
                                           SoLuong = 10,
                                           Gia = 1_000_000,
                                       }
                              ).ToList();
             dataGridView1.DataSource = bienThes;*/

            // Dạng biểu thức
            List<BienThe> bienThes = colors.SelectMany(color => sizes,
                (color, size) => new BienThe
                {
                    MaGiay = 1,
                    Mau = color,
                    Size = size,
                    SoLuong = 10,
                    Gia = 1_000_000,
                }
            ).ToList();
            dataGridView1.DataSource = bienThes;

            checkedListBox1.Items.AddRange(colors.ToArray());

            // tìm phần tử đầu tiên
            bienThes.First().MaGiay = 1;
            //tìm phần tử đầu tiên với điều kiện
            bienThes.First(bienThes => bienThes.Mau.Equals("Xanh"));

            //Tìm phần tử cuối cùng
            bienThes.Last();

            //Tìm đối tượng bằng điều kiện
            bienThes.Find(x=>x.Mau=="Xanh");
            //Nếu dùng với EF core thì chỉ cần truyền thẳng key

            //Kiểm tra xem tập hợp có phần tử hay phần tử thỏa mãn điều kiên trả về true/ false

            bienThes.Any(); // true khi có ít nhất 1 phần tử 



        }

        private void textBoxTIm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //C1
            /*
            List<Giay> giayCanTim = new List<Giay>() { };
            //Tìm được theo tên 
            foreach (var giay in giays)
            {
                if (giay.TenGiay.Contains(textBoxTIm.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    giayCanTim.Add(giay);
                }
            }

            dataGridView1.DataSource = giayCanTim;*/


            //C2: query
            /* List<Giay> giayCanTims = ( from giay in giays where
                                        giay.TenGiay.Contains(textBoxTIm.Text, StringComparison.CurrentCultureIgnoreCase)
                                        select giay).ToList();*/

            //C2.5: Sử dụng dạng biểu thức 
            List<Giay> giayCanTims = giays.Where(g => g.TenGiay
            .Contains(textBoxTIm.Text, StringComparison.CurrentCultureIgnoreCase)).ToList();

            dataGridView1.DataSource = giayCanTims;


        }
    }
}

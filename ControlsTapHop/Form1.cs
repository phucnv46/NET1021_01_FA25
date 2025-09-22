using ControlsTapHop.Models;

namespace ControlsTapHop
{
    public partial class Form1 : Form
    {
        List<Mon> mons = new List<Mon>() {
            new Mon(){MaMon="NET101",TenMon="Lập trình C# 1",KyHoc=1},
            new Mon(){MaMon="NET1012",TenMon="Lập trình C# 2",KyHoc=2},
            new Mon(){MaMon="NET103",TenMon="Lập trình C# 3",KyHoc=3},
            new Mon(){MaMon="NET104",TenMon="Lập trình C# 4",KyHoc=4},
        };

        public Form1()
        {
            InitializeComponent();


            /*List<string> tenMons = new List<string>();
            foreach (Mon mon in mons)
            {
                tenMons.Add(mon.TenMon);
            }
            comboBox1.DataSource = tenMons;*/

            comboBox1.DataSource = mons;
            comboBox1.DisplayMember = nameof(Mon.TenMon);
            comboBox1.ValueMember = nameof(Mon.MaMon);

            listBox1 .DataSource = mons;
            listBox1.DisplayMember = nameof(Mon.TenMon);
            listBox1.ValueMember = nameof(Mon.MaMon);

            dataGridView1.DataSource = mons;
            //dataGridView1.Columns[0].HeaderText = "Mã môn";
           // dataGridView1.Columns["MaMon"].HeaderText = "Mã môn";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show($"SelectedIndex: {comboBox1.SelectedIndex}\n" +
                $"SelectedText: {comboBox1.SelectedText}\n" +
                $"SelectedItem:{comboBox1.SelectedItem}\n" +
                $"SelectedValue:{comboBox1.SelectedValue}");*/
        }
    }
}

using System.ComponentModel;

namespace Datagridview_BingdingList
{
    public partial class Form1 : Form
    {
        BindingList<Anime> animes = new()
        {
            new Anime(){Ma=1,Ten="Conan",NamSanXuat=2000,SoTap=80,Studio="NCC"},
            new Anime(){Ma=2,Ten="Doraemon",NamSanXuat=2010,SoTap=150,Studio="AWX"},
            new Anime(){Ma=3,Ten="Berserk",NamSanXuat=2020,SoTap=20,Studio="TAX"},
        };

        List<string> studios = new List<string>() { "NCC", "AWX", "TAX" };
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }


        void LoadData()
        {
            dataGridView1.DataSource = animes;
            comboBoxStudio.DataSource = studios;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Anime anime)
            {
                textBoxMa.Text = anime.Ma.ToString();
                textBoxTen.Text = anime.Ten;
                numericUpDownNamSX.Value = anime.NamSanXuat;
                numericUpDownSoTap.Value = anime.SoTap;
                comboBoxStudio.SelectedItem = anime.Studio;
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {


            Anime anime = new Anime();
            if (!animes.Any())
            {
                anime.Ma = 1;
            }
            else
            {
                //anime.Ma = animes[animes.Count-1].Ma + 1;
                anime.Ma = animes.Last().Ma + 1;
            }

            anime.Ten = textBoxTen.Text;
            anime.SoTap = (int)numericUpDownSoTap.Value;
            anime.NamSanXuat = (int)numericUpDownNamSX.Value;
            anime.Studio = (string)comboBoxStudio.SelectedItem;

            animes.Add(anime);


            // anime.Ma = animes.Any() ? animes.Last().Ma + 1 : 1;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Anime anime)
            {

                anime.Ten = textBoxTen.Text;
                anime.SoTap = (int)numericUpDownSoTap.Value;
                anime.NamSanXuat = (int)numericUpDownNamSX.Value;
                anime.Studio = (string)comboBoxStudio.SelectedItem;

                int index = dataGridView1.CurrentRow.Index;
                animes[index] = anime;
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem is Anime anime)
            {
                animes.Remove(anime);
            }
        }

        private void buttonLM_Click(object sender, EventArgs e)
        {
            textBoxMa.ResetText();
            textBoxTen.ResetText();

        }

      
    }
}

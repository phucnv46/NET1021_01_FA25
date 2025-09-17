namespace GioiThieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            decimal so1 = numericUpDown1.Value;
            decimal so2 = numericUpDown2.Value;

            switch (button.Text)
            {
                default:
                    break;
                case "+":
                    {
                        textBoxKQ.Text = (so1+so2).ToString();
                        break;
                    }
                case "-":
                    {
                        textBoxKQ.Text = (so1-so2).ToString();
                        break;
                    }
            }
        }
    }
}

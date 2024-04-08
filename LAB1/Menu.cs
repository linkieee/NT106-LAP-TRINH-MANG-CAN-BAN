namespace LAB1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai1 b1 = new Bai1();
            b1.ShowDialog();
            b1 = null;
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai2 b2 = new Bai2();
            b2.ShowDialog();
            b2 = null;
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai3 b3 = new Bai3();
            b3.ShowDialog();
            b3 = null;
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bai4 b4 = new Bai4();
            b4.ShowDialog();
            b4 = null;
            this.Show();
        }
    }
}

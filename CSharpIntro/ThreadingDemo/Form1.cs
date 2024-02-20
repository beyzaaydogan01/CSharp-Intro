namespace ThreadingDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 1 çalýþtý");
        }

        private void btnProcess2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ýþlem 2 çalýþtý");
        }
    }
}

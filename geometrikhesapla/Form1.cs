namespace geometrikhesapla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kenar = Convert.ToInt32(textBox4.Text);
            int ksonuc = kenar * kenar;
            karesonuc.Text = ksonuc.ToString();
            int kısak = Convert.ToInt32(textBox2.Text);
            int uzunk = Convert.ToInt32(textBox3.Text);
            int dsonuc = kısak * uzunk;
            dikdortgensonuc.Text = dsonuc.ToString();
            double yaricap = Convert.ToDouble(textBox1.Text);
            double dairealan = Math.PI * (yaricap * yaricap);
            dairesonuc.Text = dairealan.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

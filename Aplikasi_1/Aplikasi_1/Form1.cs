namespace Aplikasi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblkesimpulan.Visible = true;
            lblkesimpulan.Text = "Nama mu adalah " + txtNama.Text
                + ", \nmakanan favoritmu adalah " + txtfavoritfood.Text
                + ", \ndan warna favoritmu adalah " + txtfavoritcolor.Text + ".";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtfavoritfood.Text = "";
            txtfavoritcolor.Text = "";
            lblkesimpulan.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
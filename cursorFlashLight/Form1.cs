namespace cursorFlashLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string message = "То е като мозък с жици и мишка,\r\nЗнае всичко, ала не е книжка.\r\nПише с код, а не с химикал.\r\nПиташ ли го – всичко си разбрал.\r\nЖивее в офиса, вкъщи дори.\r\nКакво е това, ще ми кажеш нали?\r\n";
            int radius = txbRadius.Text != "" ? int.Parse(txbRadius.Text) : 50;
            FormPlayState playState = new FormPlayState(message, radius);
            playState.Show();
            playState.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }
    }
}

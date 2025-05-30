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
            string message = txbMessage.Text;
            int radius = txbRadius.Text != "" ? int.Parse(txbRadius.Text) : 100;
            FormPlayState playState = new FormPlayState(message, radius);
            playState.Show();
            playState.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }
    }
}

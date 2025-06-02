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
            string message = "В междучасието там се бърза,\r\nгладни ученици там се изръсват.\r\nНе е столова, но там храна се намира.\r\nКъде отиваш, като стомахът вибрира?\r\nСандвич, кроасан или бонбон,\r\nвсичко има в училищния ____________ .\r\n";
            int radius = txbRadius.Text != "" ? int.Parse(txbRadius.Text) : 50;
            FormPlayState playState = new FormPlayState(message, radius);
            playState.Show();
            playState.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }
    }
}

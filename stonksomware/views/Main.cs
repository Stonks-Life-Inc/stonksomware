using stonksomware.controllers;


namespace stonksomware
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActionsController.displayRandomErrorMessages();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActionsController.displayRandomErrorMessages();
        }
    }
}
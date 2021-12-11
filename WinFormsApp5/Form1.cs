namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have accepted the conditions");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have denied the conditions ");
        }
    }
}
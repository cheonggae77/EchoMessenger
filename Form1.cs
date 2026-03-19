namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSentButton_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = txtInput.Text;
            libTextSpace.Items.Add(typed_msg);
            txtInput.Clear();
        }
    }
}

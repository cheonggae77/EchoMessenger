namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            // Make Enter trigger the send button when typing in the textbox
            this.AcceptButton = btnSendButton;
            // Update status initially
            UpdateStatus();
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // call the actual button control (fixed name)
                btnSendButton.PerformClick();
            }
        }

        private void btnSentButton_Click(object sender, EventArgs e)
        {
            // Trim leading/trailing whitespace before storing
            string typed_msg = txtInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                txtInput.Focus();
                return;
            }

            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            libTextSpace.Items.Add($"{timestamp} {typed_msg}");

            // Update the status label after adding
            UpdateStatus();

            txtInput.Clear();
            txtInput.Focus();
        }

        private void UpdateStatus()
        {
            if (lblStatus != null)
            {
                lblStatus.Text = $"현재 대화: {libTextSpace.Items.Count}개";
            }
        }
    }
}

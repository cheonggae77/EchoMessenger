namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            // Make Enter trigger the send button when typing in the textbox
            this.AcceptButton = btnSendButton;
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
            string typed_msg = txtInput.Text;

            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                // 비어있으면 아무 동작도 하지 않거나 사용자에게 알림
                // MessageBox.Show("메시지를 입력하세요.");
                txtInput.Focus();
            }
            else
            {
                libTextSpace.Items.Add(typed_msg);
                txtInput.Clear();
                txtInput.Focus();

            }
        }
    }
}

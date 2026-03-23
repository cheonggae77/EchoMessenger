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

            // Enforce 50 character limit (defensive check in case MaxLength was bypassed)
            if (typed_msg.Length > 50)
            {
                MessageBox.Show("메시지는 최대 50자까지 입력할 수 있습니다.", "안내", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (libTextSpace.SelectedIndex >= 0)
                {
                    libTextSpace.Items.RemoveAt(libTextSpace.SelectedIndex);
                    UpdateStatus();
                }
                else
                {
                    // 선택된 항목이 없을 때 예외 대신 사용자에게 안내
                    MessageBox.Show("삭제할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // 예기치 않은 에러 발생 시 사용자에게 알리고 로그 처리 가능
                MessageBox.Show($"삭제 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAllDelete_Click(object sender, EventArgs e)
        {
            libTextSpace.Items.Clear();
            UpdateStatus();
        }

        
    }
}

namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEchoMessenger = new Label();
            txtInput = new TextBox();
            libTextSpace = new ListBox();
            btnSendButton = new Button();
            SuspendLayout();
            // 
            // lblEchoMessenger
            // 
            lblEchoMessenger.AutoSize = true;
            lblEchoMessenger.Font = new Font("휴먼매직체", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblEchoMessenger.ForeColor = Color.Blue;
            lblEchoMessenger.Location = new Point(44, 32);
            lblEchoMessenger.Name = "lblEchoMessenger";
            lblEchoMessenger.Size = new Size(278, 34);
            lblEchoMessenger.TabIndex = 0;
            lblEchoMessenger.Text = "Echo Messenger";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 15F);
            txtInput.Location = new Point(44, 367);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(484, 41);
            txtInput.TabIndex = 1;
            // 
            // libTextSpace
            // 
            libTextSpace.FormattingEnabled = true;
            libTextSpace.Location = new Point(44, 86);
            libTextSpace.Name = "libTextSpace";
            libTextSpace.Size = new Size(712, 244);
            libTextSpace.TabIndex = 2;
            // 
            // lblStatus
            // 
            lblStatus = new Label();
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("맑은 고딕", 9F);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(44, 336);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "현재 대화: 0개";
            // 
            // btnSendButton
            // 
            btnSendButton.BackColor = Color.FromArgb(255, 128, 0);
            btnSendButton.Font = new Font("맑은 고딕", 20F);
            btnSendButton.Location = new Point(593, 359);
            btnSendButton.Name = "btnSendButton";
            btnSendButton.Size = new Size(144, 60);
            btnSendButton.TabIndex = 3;
            btnSendButton.Text = "전송";
            btnSendButton.UseVisualStyleBackColor = false;
            btnSendButton.Click += btnSentButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnSendButton);
            Controls.Add(lblStatus);
            Controls.Add(libTextSpace);
            Controls.Add(txtInput);
            Controls.Add(lblEchoMessenger);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEchoMessenger;
        private TextBox txtInput;
        private ListBox libTextSpace;
        private Button btnSendButton;
        private Label lblStatus;
    }
}

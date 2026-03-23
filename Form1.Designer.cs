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
            lblStatus = new Label();
            btnAllDelete = new Button();
            btnDelete = new Button();
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
            txtInput.MaxLength = 50;
            txtInput.Size = new Size(484, 41);
            txtInput.TabIndex = 1;
            // 
            // libTextSpace
            // 
            libTextSpace.FormattingEnabled = true;
            libTextSpace.Location = new Point(44, 86);
            libTextSpace.Name = "libTextSpace";
            libTextSpace.Size = new Size(708, 244);
            libTextSpace.TabIndex = 2;
            // 
            // btnSendButton
            // 
            btnSendButton.BackColor = Color.FromArgb(255, 128, 0);
            btnSendButton.Font = new Font("맑은 고딕", 20F);
            btnSendButton.Location = new Point(548, 354);
            btnSendButton.Name = "btnSendButton";
            btnSendButton.Size = new Size(120, 60);
            btnSendButton.TabIndex = 3;
            btnSendButton.Text = "전송";
            btnSendButton.UseVisualStyleBackColor = false;
            btnSendButton.Click += btnSentButton_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("맑은 고딕", 9F);
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(44, 336);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(105, 20);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "현재 대화: 0개";
            // 
            // btnAllDelete
            // 
            btnAllDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnAllDelete.Font = new Font("맑은 고딕", 11F);
            btnAllDelete.Location = new Point(685, 12);
            btnAllDelete.Name = "btnAllDelete";
            btnAllDelete.Size = new Size(103, 60);
            btnAllDelete.TabIndex = 5;
            btnAllDelete.Text = "전체 삭제";
            btnAllDelete.UseVisualStyleBackColor = false;
            btnAllDelete.Click += btnAllDelete_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 255, 192);
            btnDelete.Font = new Font("맑은 고딕", 15F);
            btnDelete.Location = new Point(565, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 60);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAllDelete);
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
        private Button btnAllDelete;
        private Button btnDelete;
    }
}

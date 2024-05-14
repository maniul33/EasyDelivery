namespace EasyDelivery
{
    partial class SignupRider
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupRider));
            label3 = new Label();
            label1 = new Label();
            accountNoTextBox = new TextBox();
            branchNameTextBox = new TextBox();
            bankNameTextBox = new TextBox();
            BankInfoLabel = new Label();
            passwordTextBox = new TextBox();
            label4 = new Label();
            FrontLeftPanel = new Panel();
            label2 = new Label();
            EasyDeliveryLogo = new PictureBox();
            FrontRightPanel = new Panel();
            numberTextBox = new TextBox();
            emailTextBox = new TextBox();
            riderNameTextBox = new TextBox();
            SignupAsMerchantLabel = new Label();
            CreateAccountLabel = new Label();
            LoginLabel = new Label();
            AlreadyHaveAccountLabel = new Label();
            signupButton = new Button();
            imageList1 = new ImageList(components);
            passToolTip = new ToolTip(components);
            FrontLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EasyDeliveryLogo).BeginInit();
            FrontRightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(254, 255, 254);
            label3.Location = new Point(46, 170);
            label3.Name = "label3";
            label3.Size = new Size(305, 41);
            label3.TabIndex = 9;
            label3.Text = "Securely Received.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(254, 255, 254);
            label1.Location = new Point(46, 254);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 11;
            label1.Text = "account.";
            // 
            // accountNoTextBox
            // 
            accountNoTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountNoTextBox.ForeColor = SystemColors.ActiveBorder;
            accountNoTextBox.Location = new Point(235, 486);
            accountNoTextBox.Multiline = true;
            accountNoTextBox.Name = "accountNoTextBox";
            accountNoTextBox.Size = new Size(437, 37);
            accountNoTextBox.TabIndex = 30;
            accountNoTextBox.Text = "Account number";
            accountNoTextBox.Enter += accountNoTextBox_Enter;
            accountNoTextBox.Leave += accountNoTextBox_Leave;
            // 
            // branchNameTextBox
            // 
            branchNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branchNameTextBox.ForeColor = SystemColors.ActiveBorder;
            branchNameTextBox.Location = new Point(467, 432);
            branchNameTextBox.Multiline = true;
            branchNameTextBox.Name = "branchNameTextBox";
            branchNameTextBox.Size = new Size(205, 37);
            branchNameTextBox.TabIndex = 29;
            branchNameTextBox.Text = "Branch name";
            branchNameTextBox.Enter += branchNameTextBox_Enter;
            branchNameTextBox.Leave += branchNameTextBox_Leave;
            // 
            // bankNameTextBox
            // 
            bankNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bankNameTextBox.ForeColor = SystemColors.ActiveBorder;
            bankNameTextBox.Location = new Point(235, 432);
            bankNameTextBox.Multiline = true;
            bankNameTextBox.Name = "bankNameTextBox";
            bankNameTextBox.Size = new Size(197, 37);
            bankNameTextBox.TabIndex = 28;
            bankNameTextBox.Text = "Bank name";
            bankNameTextBox.Enter += bankNameTextBox_Enter;
            bankNameTextBox.Leave += bankNameTextBox_Leave;
            // 
            // BankInfoLabel
            // 
            BankInfoLabel.AutoSize = true;
            BankInfoLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BankInfoLabel.ForeColor = Color.FromArgb(19, 39, 71);
            BankInfoLabel.Location = new Point(235, 398);
            BankInfoLabel.Name = "BankInfoLabel";
            BankInfoLabel.Size = new Size(152, 22);
            BankInfoLabel.TabIndex = 27;
            BankInfoLabel.Text = "Bank Information";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = SystemColors.ActiveBorder;
            passwordTextBox.Location = new Point(235, 335);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(437, 37);
            passwordTextBox.TabIndex = 26;
            passwordTextBox.Text = "Password";
            passToolTip.SetToolTip(passwordTextBox, "Enter password");
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(254, 255, 254);
            label4.Location = new Point(46, 120);
            label4.Name = "label4";
            label4.Size = new Size(284, 41);
            label4.TabIndex = 8;
            label4.Text = "Swiftly Delivered,";
            // 
            // FrontLeftPanel
            // 
            FrontLeftPanel.BackColor = Color.FromArgb(170, 193, 243);
            FrontLeftPanel.Controls.Add(label4);
            FrontLeftPanel.Controls.Add(label3);
            FrontLeftPanel.Controls.Add(label2);
            FrontLeftPanel.Controls.Add(label1);
            FrontLeftPanel.Controls.Add(EasyDeliveryLogo);
            FrontLeftPanel.Controls.Add(FrontRightPanel);
            FrontLeftPanel.Location = new Point(64, 61);
            FrontLeftPanel.Name = "FrontLeftPanel";
            FrontLeftPanel.Size = new Size(1235, 681);
            FrontLeftPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(254, 255, 254);
            label2.Location = new Point(46, 226);
            label2.Name = "label2";
            label2.Size = new Size(278, 28);
            label2.TabIndex = 10;
            label2.Text = "Get started by creating an";
            // 
            // EasyDeliveryLogo
            // 
            EasyDeliveryLogo.Image = (Image)resources.GetObject("EasyDeliveryLogo.Image");
            EasyDeliveryLogo.Location = new Point(66, 319);
            EasyDeliveryLogo.Name = "EasyDeliveryLogo";
            EasyDeliveryLogo.Size = new Size(227, 214);
            EasyDeliveryLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            EasyDeliveryLogo.TabIndex = 6;
            EasyDeliveryLogo.TabStop = false;
            // 
            // FrontRightPanel
            // 
            FrontRightPanel.BackColor = Color.FromArgb(254, 254, 255);
            FrontRightPanel.Controls.Add(accountNoTextBox);
            FrontRightPanel.Controls.Add(branchNameTextBox);
            FrontRightPanel.Controls.Add(bankNameTextBox);
            FrontRightPanel.Controls.Add(BankInfoLabel);
            FrontRightPanel.Controls.Add(passwordTextBox);
            FrontRightPanel.Controls.Add(numberTextBox);
            FrontRightPanel.Controls.Add(emailTextBox);
            FrontRightPanel.Controls.Add(riderNameTextBox);
            FrontRightPanel.Controls.Add(SignupAsMerchantLabel);
            FrontRightPanel.Controls.Add(CreateAccountLabel);
            FrontRightPanel.Controls.Add(LoginLabel);
            FrontRightPanel.Controls.Add(AlreadyHaveAccountLabel);
            FrontRightPanel.Controls.Add(signupButton);
            FrontRightPanel.Location = new Point(354, 0);
            FrontRightPanel.Name = "FrontRightPanel";
            FrontRightPanel.Size = new Size(881, 678);
            FrontRightPanel.TabIndex = 0;
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberTextBox.ForeColor = SystemColors.ActiveBorder;
            numberTextBox.Location = new Point(235, 281);
            numberTextBox.Multiline = true;
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(437, 37);
            numberTextBox.TabIndex = 25;
            numberTextBox.Text = "Phone number";
            numberTextBox.Enter += numberTextBox_Enter;
            numberTextBox.Leave += numberTextBox_Leave;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = SystemColors.ActiveBorder;
            emailTextBox.Location = new Point(235, 227);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(437, 37);
            emailTextBox.TabIndex = 24;
            emailTextBox.Text = "Email address";
            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // riderNameTextBox
            // 
            riderNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            riderNameTextBox.ForeColor = SystemColors.ActiveBorder;
            riderNameTextBox.Location = new Point(235, 173);
            riderNameTextBox.Multiline = true;
            riderNameTextBox.Name = "riderNameTextBox";
            riderNameTextBox.Size = new Size(437, 37);
            riderNameTextBox.TabIndex = 23;
            riderNameTextBox.Text = "Rider name";
            riderNameTextBox.Enter += riderNameTextBox_Enter;
            riderNameTextBox.Leave += riderNameTextBox_Leave;
            // 
            // SignupAsMerchantLabel
            // 
            SignupAsMerchantLabel.AutoSize = true;
            SignupAsMerchantLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignupAsMerchantLabel.ForeColor = Color.FromArgb(19, 39, 71);
            SignupAsMerchantLabel.Location = new Point(235, 120);
            SignupAsMerchantLabel.Name = "SignupAsMerchantLabel";
            SignupAsMerchantLabel.Size = new Size(140, 22);
            SignupAsMerchantLabel.TabIndex = 22;
            SignupAsMerchantLabel.Text = "Signup as Rider";
            // 
            // CreateAccountLabel
            // 
            CreateAccountLabel.AutoSize = true;
            CreateAccountLabel.Font = new Font("Bahnschrift SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateAccountLabel.ForeColor = Color.FromArgb(19, 39, 71);
            CreateAccountLabel.Location = new Point(235, 70);
            CreateAccountLabel.Name = "CreateAccountLabel";
            CreateAccountLabel.Size = new Size(252, 41);
            CreateAccountLabel.TabIndex = 19;
            CreateAccountLabel.Text = "Create Account";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Cursor = Cursors.Hand;
            LoginLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginLabel.ForeColor = Color.FromArgb(94, 137, 228);
            LoginLabel.ImageAlign = ContentAlignment.MiddleLeft;
            LoginLabel.Location = new Point(506, 619);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(45, 18);
            LoginLabel.TabIndex = 18;
            LoginLabel.Text = "Login";
            LoginLabel.Click += LoginLabel_Click;
            // 
            // AlreadyHaveAccountLabel
            // 
            AlreadyHaveAccountLabel.AutoSize = true;
            AlreadyHaveAccountLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlreadyHaveAccountLabel.ForeColor = Color.FromArgb(19, 39, 71);
            AlreadyHaveAccountLabel.ImageAlign = ContentAlignment.MiddleLeft;
            AlreadyHaveAccountLabel.Location = new Point(325, 619);
            AlreadyHaveAccountLabel.Name = "AlreadyHaveAccountLabel";
            AlreadyHaveAccountLabel.Size = new Size(176, 18);
            AlreadyHaveAccountLabel.TabIndex = 17;
            AlreadyHaveAccountLabel.Text = "Already have an account?";
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.FromArgb(90, 135, 229);
            signupButton.Cursor = Cursors.Hand;
            signupButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupButton.ForeColor = Color.FromArgb(254, 255, 254);
            signupButton.Location = new Point(235, 559);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(437, 48);
            signupButton.TabIndex = 15;
            signupButton.Text = "Create Account";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Screenshot 2024-05-09 172252.png");
            // 
            // SignupRider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 134, 228);
            ClientSize = new Size(1362, 803);
            Controls.Add(FrontLeftPanel);
            Name = "SignupRider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupRider";
            FrontLeftPanel.ResumeLayout(false);
            FrontLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EasyDeliveryLogo).EndInit();
            FrontRightPanel.ResumeLayout(false);
            FrontRightPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox accountNoTextBox;
        private TextBox branchNameTextBox;
        private TextBox bankNameTextBox;
        private Label BankInfoLabel;
        private TextBox passwordTextBox;
        private Label label4;
        private Panel FrontLeftPanel;
        private Label label2;
        private PictureBox EasyDeliveryLogo;
        private Panel FrontRightPanel;
        private TextBox numberTextBox;
        private TextBox emailTextBox;
        private TextBox riderNameTextBox;
        private Label SignupAsMerchantLabel;
        private Label CreateAccountLabel;
        private Label LoginLabel;
        private Label AlreadyHaveAccountLabel;
        private Button signupButton;
        private ImageList imageList1;
        private ToolTip passToolTip;
    }
}
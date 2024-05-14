namespace EasyDelivery
{
    partial class SignupMerchant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupMerchant));
            FrontRightPanel = new Panel();
            zipTextBox = new TextBox();
            streetTextBox = new TextBox();
            areaTextBox = new TextBox();
            districtTextBox = new TextBox();
            label7 = new Label();
            accountNoTextBox = new TextBox();
            branchNameTextBox = new TextBox();
            bankNameTextBox = new TextBox();
            BankInfoLabel = new Label();
            passwordTextBox = new TextBox();
            numberTextBox = new TextBox();
            emailTextBox = new TextBox();
            storeNameTextBox = new TextBox();
            SignupAsMerchantLabel = new Label();
            CreateAccountLabel = new Label();
            LoginLabel = new Label();
            AlreadyHaveAccountLabel = new Label();
            signUpButton = new Button();
            EasyDeliveryLogo = new PictureBox();
            FrontLeftPanel = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PasswordToolTip = new ToolTip(components);
            FrontRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EasyDeliveryLogo).BeginInit();
            FrontLeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FrontRightPanel
            // 
            FrontRightPanel.BackColor = Color.FromArgb(254, 254, 255);
            FrontRightPanel.Controls.Add(zipTextBox);
            FrontRightPanel.Controls.Add(streetTextBox);
            FrontRightPanel.Controls.Add(areaTextBox);
            FrontRightPanel.Controls.Add(districtTextBox);
            FrontRightPanel.Controls.Add(label7);
            FrontRightPanel.Controls.Add(accountNoTextBox);
            FrontRightPanel.Controls.Add(branchNameTextBox);
            FrontRightPanel.Controls.Add(bankNameTextBox);
            FrontRightPanel.Controls.Add(BankInfoLabel);
            FrontRightPanel.Controls.Add(passwordTextBox);
            FrontRightPanel.Controls.Add(numberTextBox);
            FrontRightPanel.Controls.Add(emailTextBox);
            FrontRightPanel.Controls.Add(storeNameTextBox);
            FrontRightPanel.Controls.Add(SignupAsMerchantLabel);
            FrontRightPanel.Controls.Add(CreateAccountLabel);
            FrontRightPanel.Controls.Add(LoginLabel);
            FrontRightPanel.Controls.Add(AlreadyHaveAccountLabel);
            FrontRightPanel.Controls.Add(signUpButton);
            FrontRightPanel.Location = new Point(354, 0);
            FrontRightPanel.Name = "FrontRightPanel";
            FrontRightPanel.Size = new Size(881, 678);
            FrontRightPanel.TabIndex = 0;
            FrontRightPanel.Paint += FrontRightPanel_Paint;
            // 
            // zipTextBox
            // 
            zipTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zipTextBox.ForeColor = SystemColors.ActiveBorder;
            zipTextBox.Location = new Point(690, 227);
            zipTextBox.Multiline = true;
            zipTextBox.Name = "zipTextBox";
            zipTextBox.Size = new Size(151, 37);
            zipTextBox.TabIndex = 35;
            zipTextBox.Text = "Zip";
            zipTextBox.Enter += zipTextBox_Enter;
            zipTextBox.Leave += zipTextBox_Leave;
            // 
            // streetTextBox
            // 
            streetTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            streetTextBox.ForeColor = SystemColors.ActiveBorder;
            streetTextBox.Location = new Point(458, 227);
            streetTextBox.Multiline = true;
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(152, 37);
            streetTextBox.TabIndex = 34;
            streetTextBox.Text = "Street";
            streetTextBox.Enter += streetTextBox_Enter;
            streetTextBox.Leave += streetTextBox_Leave;
            // 
            // areaTextBox
            // 
            areaTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            areaTextBox.ForeColor = SystemColors.ActiveBorder;
            areaTextBox.Location = new Point(690, 173);
            areaTextBox.Multiline = true;
            areaTextBox.Name = "areaTextBox";
            areaTextBox.Size = new Size(151, 37);
            areaTextBox.TabIndex = 33;
            areaTextBox.Text = "Area";
            areaTextBox.Enter += areaTextBox_Enter;
            areaTextBox.Leave += areaTextBox_Leave;
            // 
            // districtTextBox
            // 
            districtTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            districtTextBox.ForeColor = SystemColors.ActiveBorder;
            districtTextBox.Location = new Point(458, 173);
            districtTextBox.Multiline = true;
            districtTextBox.Name = "districtTextBox";
            districtTextBox.Size = new Size(152, 37);
            districtTextBox.TabIndex = 32;
            districtTextBox.Text = "District";
            districtTextBox.Enter += districtTextBox_Enter;
            districtTextBox.Leave += districtTextBox_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(19, 39, 71);
            label7.Location = new Point(458, 139);
            label7.Name = "label7";
            label7.Size = new Size(128, 22);
            label7.TabIndex = 31;
            label7.Text = "Store Address";
            // 
            // accountNoTextBox
            // 
            accountNoTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountNoTextBox.ForeColor = SystemColors.ActiveBorder;
            accountNoTextBox.Location = new Point(458, 384);
            accountNoTextBox.Multiline = true;
            accountNoTextBox.Name = "accountNoTextBox";
            accountNoTextBox.Size = new Size(383, 37);
            accountNoTextBox.TabIndex = 30;
            accountNoTextBox.Text = "Account number";
            accountNoTextBox.Enter += accountNoTextBox_Enter;
            accountNoTextBox.Leave += accountNoTextBox_Leave;
            // 
            // branchNameTextBox
            // 
            branchNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branchNameTextBox.ForeColor = SystemColors.ActiveBorder;
            branchNameTextBox.Location = new Point(690, 330);
            branchNameTextBox.Multiline = true;
            branchNameTextBox.Name = "branchNameTextBox";
            branchNameTextBox.Size = new Size(151, 37);
            branchNameTextBox.TabIndex = 29;
            branchNameTextBox.Text = "Branch name";
            branchNameTextBox.Enter += branchNameTextBox_Enter;
            branchNameTextBox.Leave += branchNameTextBox_Leave;
            // 
            // bankNameTextBox
            // 
            bankNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bankNameTextBox.ForeColor = SystemColors.ActiveBorder;
            bankNameTextBox.Location = new Point(458, 330);
            bankNameTextBox.Multiline = true;
            bankNameTextBox.Name = "bankNameTextBox";
            bankNameTextBox.Size = new Size(152, 37);
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
            BankInfoLabel.Location = new Point(458, 296);
            BankInfoLabel.Name = "BankInfoLabel";
            BankInfoLabel.Size = new Size(152, 22);
            BankInfoLabel.TabIndex = 27;
            BankInfoLabel.Text = "Bank Information";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = SystemColors.ActiveBorder;
            passwordTextBox.Location = new Point(42, 384);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(383, 37);
            passwordTextBox.TabIndex = 26;
            passwordTextBox.Text = "Password";
            PasswordToolTip.SetToolTip(passwordTextBox, "Enter password");
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberTextBox.ForeColor = SystemColors.ActiveBorder;
            numberTextBox.Location = new Point(42, 319);
            numberTextBox.Multiline = true;
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(383, 37);
            numberTextBox.TabIndex = 25;
            numberTextBox.Text = "Phone number";
            numberTextBox.Enter += numberTextBox_Enter;
            numberTextBox.Leave += numberTextBox_Leave;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = SystemColors.ActiveBorder;
            emailTextBox.Location = new Point(42, 245);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(383, 37);
            emailTextBox.TabIndex = 24;
            emailTextBox.Text = "Email address";
            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // storeNameTextBox
            // 
            storeNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            storeNameTextBox.ForeColor = SystemColors.ActiveBorder;
            storeNameTextBox.Location = new Point(42, 173);
            storeNameTextBox.Multiline = true;
            storeNameTextBox.Name = "storeNameTextBox";
            storeNameTextBox.Size = new Size(383, 37);
            storeNameTextBox.TabIndex = 23;
            storeNameTextBox.Text = "Store name";
            storeNameTextBox.TextChanged += storeNameTextBox_TextChanged;
            storeNameTextBox.Enter += storeNameTextBox_Enter;
            storeNameTextBox.Leave += storeNameTextBox_Leave;
            // 
            // SignupAsMerchantLabel
            // 
            SignupAsMerchantLabel.AutoSize = true;
            SignupAsMerchantLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignupAsMerchantLabel.ForeColor = Color.FromArgb(19, 39, 71);
            SignupAsMerchantLabel.Location = new Point(42, 120);
            SignupAsMerchantLabel.Name = "SignupAsMerchantLabel";
            SignupAsMerchantLabel.Size = new Size(172, 22);
            SignupAsMerchantLabel.TabIndex = 22;
            SignupAsMerchantLabel.Text = "Signup as Merchant";
            // 
            // CreateAccountLabel
            // 
            CreateAccountLabel.AutoSize = true;
            CreateAccountLabel.Font = new Font("Bahnschrift SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateAccountLabel.ForeColor = Color.FromArgb(19, 39, 71);
            CreateAccountLabel.Location = new Point(42, 70);
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
            LoginLabel.Location = new Point(523, 521);
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
            AlreadyHaveAccountLabel.Location = new Point(342, 521);
            AlreadyHaveAccountLabel.Name = "AlreadyHaveAccountLabel";
            AlreadyHaveAccountLabel.Size = new Size(176, 18);
            AlreadyHaveAccountLabel.TabIndex = 17;
            AlreadyHaveAccountLabel.Text = "Already have an account?";
            AlreadyHaveAccountLabel.Click += DontHaveAccountLabel_Click;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.FromArgb(90, 135, 229);
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signUpButton.ForeColor = Color.FromArgb(254, 255, 254);
            signUpButton.Location = new Point(252, 461);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(437, 48);
            signUpButton.TabIndex = 15;
            signUpButton.Text = "Create Account";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click_1;
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
            FrontLeftPanel.TabIndex = 1;
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
            label1.Click += label1_Click;
            // 
            // SignupMerchant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 134, 228);
            ClientSize = new Size(1362, 803);
            Controls.Add(FrontLeftPanel);
            Name = "SignupMerchant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignupMerchant";
            FrontRightPanel.ResumeLayout(false);
            FrontRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EasyDeliveryLogo).EndInit();
            FrontLeftPanel.ResumeLayout(false);
            FrontLeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel FrontRightPanel;
        private Label LoginLabel;
        private Label AlreadyHaveAccountLabel;
        private Button signUpButton;
        private PictureBox EasyDeliveryLogo;
        private Panel FrontLeftPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label CreateAccountLabel;
        private Label SignupAsMerchantLabel;
        private Label BankInfoLabel;
        private TextBox passwordTextBox;
        private TextBox numberTextBox;
        private TextBox emailTextBox;
        private TextBox storeNameTextBox;
        private TextBox accountNoTextBox;
        private TextBox branchNameTextBox;
        private TextBox bankNameTextBox;
        private TextBox areaTextBox;
        private TextBox districtTextBox;
        private Label label7;
        private TextBox zipTextBox;
        private TextBox streetTextBox;
        private ToolTip PasswordToolTip;
    }
}
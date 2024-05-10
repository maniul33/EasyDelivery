namespace EasyDelivery
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            FrontLeftPanel = new Panel();
            EasyDeliveryLogo = new PictureBox();
            leftLabel5 = new Label();
            leftLabel4 = new Label();
            LeftLabel3 = new Label();
            leftLabel2 = new Label();
            leftLable1 = new Label();
            FrontRightPanel = new Panel();
            SignupLabel = new Label();
            DontHaveAccountLabel = new Label();
            clickHereLabel = new Label();
            WannaTrackParcelLabel = new Label();
            loginButton = new Button();
            userPasswordTextBox = new TextBox();
            userCredentialTextBox = new TextBox();
            SignInLabel = new Label();
            imageList1 = new ImageList(components);
            FrontLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EasyDeliveryLogo).BeginInit();
            FrontRightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FrontLeftPanel
            // 
            FrontLeftPanel.BackColor = Color.FromArgb(170, 193, 243);
            FrontLeftPanel.Controls.Add(EasyDeliveryLogo);
            FrontLeftPanel.Controls.Add(leftLabel5);
            FrontLeftPanel.Controls.Add(leftLabel4);
            FrontLeftPanel.Controls.Add(LeftLabel3);
            FrontLeftPanel.Controls.Add(leftLabel2);
            FrontLeftPanel.Controls.Add(leftLable1);
            FrontLeftPanel.Controls.Add(FrontRightPanel);
            FrontLeftPanel.Location = new Point(66, 59);
            FrontLeftPanel.Name = "FrontLeftPanel";
            FrontLeftPanel.Size = new Size(1235, 681);
            FrontLeftPanel.TabIndex = 0;
            // 
            // EasyDeliveryLogo
            // 
            EasyDeliveryLogo.Image = (Image)resources.GetObject("EasyDeliveryLogo.Image");
            EasyDeliveryLogo.Location = new Point(58, 383);
            EasyDeliveryLogo.Name = "EasyDeliveryLogo";
            EasyDeliveryLogo.Size = new Size(227, 214);
            EasyDeliveryLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            EasyDeliveryLogo.TabIndex = 6;
            EasyDeliveryLogo.TabStop = false;
            // 
            // leftLabel5
            // 
            leftLabel5.AutoSize = true;
            leftLabel5.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftLabel5.ForeColor = Color.FromArgb(19, 39, 71);
            leftLabel5.Image = (Image)resources.GetObject("leftLabel5.Image");
            leftLabel5.ImageAlign = ContentAlignment.MiddleLeft;
            leftLabel5.Location = new Point(41, 342);
            leftLabel5.Name = "leftLabel5";
            leftLabel5.Size = new Size(233, 22);
            leftLabel5.TabIndex = 5;
            leftLabel5.Text = "        COD and return policy.";
            // 
            // leftLabel4
            // 
            leftLabel4.AutoSize = true;
            leftLabel4.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftLabel4.ForeColor = Color.FromArgb(19, 39, 71);
            leftLabel4.Image = (Image)resources.GetObject("leftLabel4.Image");
            leftLabel4.ImageAlign = ContentAlignment.MiddleLeft;
            leftLabel4.Location = new Point(41, 303);
            leftLabel4.Name = "leftLabel4";
            leftLabel4.Size = new Size(307, 22);
            leftLabel4.TabIndex = 4;
            leftLabel4.Text = "        100% nationwide home delivery.";
            // 
            // LeftLabel3
            // 
            LeftLabel3.AutoSize = true;
            LeftLabel3.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftLabel3.ForeColor = Color.FromArgb(254, 255, 254);
            LeftLabel3.Location = new Point(40, 232);
            LeftLabel3.Name = "LeftLabel3";
            LeftLabel3.Size = new Size(161, 41);
            LeftLabel3.TabIndex = 3;
            LeftLabel3.Text = "products.";
            // 
            // leftLabel2
            // 
            leftLabel2.AutoSize = true;
            leftLabel2.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftLabel2.ForeColor = Color.FromArgb(254, 255, 254);
            leftLabel2.Location = new Point(40, 179);
            leftLabel2.Name = "leftLabel2";
            leftLabel2.Size = new Size(271, 41);
            leftLabel2.TabIndex = 2;
            leftLabel2.Text = "delivery for your";
            leftLabel2.Click += label2_Click;
            // 
            // leftLable1
            // 
            leftLable1.AutoSize = true;
            leftLable1.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftLable1.ForeColor = Color.White;
            leftLable1.Location = new Point(40, 121);
            leftLable1.Name = "leftLable1";
            leftLable1.Size = new Size(286, 41);
            leftLable1.TabIndex = 1;
            leftLable1.Text = "Providing reliable";
            // 
            // FrontRightPanel
            // 
            FrontRightPanel.BackColor = Color.FromArgb(254, 254, 255);
            FrontRightPanel.Controls.Add(SignupLabel);
            FrontRightPanel.Controls.Add(DontHaveAccountLabel);
            FrontRightPanel.Controls.Add(clickHereLabel);
            FrontRightPanel.Controls.Add(WannaTrackParcelLabel);
            FrontRightPanel.Controls.Add(loginButton);
            FrontRightPanel.Controls.Add(userPasswordTextBox);
            FrontRightPanel.Controls.Add(userCredentialTextBox);
            FrontRightPanel.Controls.Add(SignInLabel);
            FrontRightPanel.Location = new Point(354, 0);
            FrontRightPanel.Name = "FrontRightPanel";
            FrontRightPanel.Size = new Size(881, 678);
            FrontRightPanel.TabIndex = 0;
            FrontRightPanel.Paint += FrontRightPanel_Paint;
            // 
            // SignupLabel
            // 
            SignupLabel.AutoSize = true;
            SignupLabel.Cursor = Cursors.Hand;
            SignupLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignupLabel.ForeColor = Color.FromArgb(94, 137, 228);
            SignupLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SignupLabel.Location = new Point(498, 491);
            SignupLabel.Name = "SignupLabel";
            SignupLabel.Size = new Size(89, 18);
            SignupLabel.TabIndex = 18;
            SignupLabel.Text = "Signup Here";
            SignupLabel.Click += label3_Click;
            // 
            // DontHaveAccountLabel
            // 
            DontHaveAccountLabel.AutoSize = true;
            DontHaveAccountLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DontHaveAccountLabel.ForeColor = Color.FromArgb(19, 39, 71);
            DontHaveAccountLabel.ImageAlign = ContentAlignment.MiddleLeft;
            DontHaveAccountLabel.Location = new Point(317, 491);
            DontHaveAccountLabel.Name = "DontHaveAccountLabel";
            DontHaveAccountLabel.Size = new Size(179, 18);
            DontHaveAccountLabel.TabIndex = 17;
            DontHaveAccountLabel.Text = "     Don't have an account?";
            DontHaveAccountLabel.Click += label4_Click;
            // 
            // clickHereLabel
            // 
            clickHereLabel.AutoSize = true;
            clickHereLabel.Cursor = Cursors.Hand;
            clickHereLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickHereLabel.ForeColor = Color.FromArgb(94, 137, 228);
            clickHereLabel.ImageAlign = ContentAlignment.MiddleLeft;
            clickHereLabel.Location = new Point(511, 461);
            clickHereLabel.Name = "clickHereLabel";
            clickHereLabel.Size = new Size(76, 18);
            clickHereLabel.TabIndex = 16;
            clickHereLabel.Text = "Click Here";
            clickHereLabel.Click += label2_Click_1;
            // 
            // WannaTrackParcelLabel
            // 
            WannaTrackParcelLabel.AutoSize = true;
            WannaTrackParcelLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WannaTrackParcelLabel.ForeColor = Color.FromArgb(19, 39, 71);
            WannaTrackParcelLabel.ImageAlign = ContentAlignment.MiddleLeft;
            WannaTrackParcelLabel.Location = new Point(324, 461);
            WannaTrackParcelLabel.Name = "WannaTrackParcelLabel";
            WannaTrackParcelLabel.Size = new Size(185, 18);
            WannaTrackParcelLabel.TabIndex = 7;
            WannaTrackParcelLabel.Text = " Want to track your parcel?";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(90, 135, 229);
            loginButton.Cursor = Cursors.Hand;
            loginButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.FromArgb(254, 255, 254);
            loginButton.Location = new Point(236, 398);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(437, 48);
            loginButton.TabIndex = 15;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userPasswordTextBox.ForeColor = SystemColors.ActiveBorder;
            userPasswordTextBox.Location = new Point(236, 330);
            userPasswordTextBox.Multiline = true;
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.Size = new Size(437, 43);
            userPasswordTextBox.TabIndex = 14;
            userPasswordTextBox.Text = "Password";
            userPasswordTextBox.UseSystemPasswordChar = true;
            userPasswordTextBox.TextChanged += textBox2_TextChanged;
            userPasswordTextBox.Enter += userPassword_Enter;
            userPasswordTextBox.Leave += userPassword_Leave;
            // 
            // userCredentialTextBox
            // 
            userCredentialTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userCredentialTextBox.ForeColor = SystemColors.ActiveBorder;
            userCredentialTextBox.Location = new Point(236, 268);
            userCredentialTextBox.Multiline = true;
            userCredentialTextBox.Name = "userCredentialTextBox";
            userCredentialTextBox.Size = new Size(437, 43);
            userCredentialTextBox.TabIndex = 13;
            userCredentialTextBox.Text = "Email address or phone number";
            userCredentialTextBox.TextChanged += userCredentialTextBox_TextChanged;
            userCredentialTextBox.Enter += userCredential_Enter;
            userCredentialTextBox.Leave += userCredential_Leave;
            // 
            // SignInLabel
            // 
            SignInLabel.AutoSize = true;
            SignInLabel.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignInLabel.ForeColor = Color.FromArgb(19, 39, 71);
            SignInLabel.Location = new Point(236, 179);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(129, 41);
            SignInLabel.TabIndex = 7;
            SignInLabel.Text = "Sign-in";
            SignInLabel.Click += SignInLabel_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Screenshot 2024-05-09 172252.png");
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 134, 228);
            ClientSize = new Size(1362, 803);
            Controls.Add(FrontLeftPanel);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FrontLeftPanel.ResumeLayout(false);
            FrontLeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EasyDeliveryLogo).EndInit();
            FrontRightPanel.ResumeLayout(false);
            FrontRightPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel FrontLeftPanel;
        private Panel FrontRightPanel;
        private Label leftLable1;
        private Label LeftLabel3;
        private Label leftLabel2;
        private Label leftLabel4;
        private Label leftLabel5;
        private ImageList imageList1;
        private PictureBox EasyDeliveryLogo;
        private Label SignInLabel;
        private TextBox userCredentialTextBox;
        private TextBox userPasswordTextBox;
        private Button loginButton;
        private Label SignupLabel;
        private Label DontHaveAccountLabel;
        private Label clickHereLabel;
        private Label WannaTrackParcelLabel;
    }
}
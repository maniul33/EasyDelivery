namespace EasyDelivery
{
    partial class LoginCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCustomer));
            imageList1 = new ImageList(components);
            leftLabel2 = new Label();
            leftLable1 = new Label();
            FrontRightPanel = new Panel();
            clickHereLabel = new Label();
            DontHaveAccountLabel = new Label();
            trackButton = new Button();
            userCredentialTextBox = new TextBox();
            SignInLabel = new Label();
            EasyDeliveryLogo = new PictureBox();
            leftLabel5 = new Label();
            leftLabel4 = new Label();
            LeftLabel3 = new Label();
            FrontLeftPanel = new Panel();
            totalMerLabel = new Label();
            FrontRightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EasyDeliveryLogo).BeginInit();
            FrontLeftPanel.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Screenshot 2024-05-09 172252.png");
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
            FrontRightPanel.Controls.Add(totalMerLabel);
            FrontRightPanel.Controls.Add(clickHereLabel);
            FrontRightPanel.Controls.Add(DontHaveAccountLabel);
            FrontRightPanel.Controls.Add(trackButton);
            FrontRightPanel.Controls.Add(userCredentialTextBox);
            FrontRightPanel.Controls.Add(SignInLabel);
            FrontRightPanel.Location = new Point(354, 0);
            FrontRightPanel.Name = "FrontRightPanel";
            FrontRightPanel.Size = new Size(881, 678);
            FrontRightPanel.TabIndex = 0;
            // 
            // clickHereLabel
            // 
            clickHereLabel.AutoSize = true;
            clickHereLabel.Cursor = Cursors.Hand;
            clickHereLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clickHereLabel.ForeColor = Color.FromArgb(94, 137, 228);
            clickHereLabel.ImageAlign = ContentAlignment.MiddleLeft;
            clickHereLabel.Location = new Point(469, 403);
            clickHereLabel.Name = "clickHereLabel";
            clickHereLabel.Size = new Size(76, 18);
            clickHereLabel.TabIndex = 18;
            clickHereLabel.Text = "Click Here";
            clickHereLabel.Click += SignupLabel_Click;
            // 
            // DontHaveAccountLabel
            // 
            DontHaveAccountLabel.AutoSize = true;
            DontHaveAccountLabel.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DontHaveAccountLabel.ForeColor = Color.FromArgb(19, 39, 71);
            DontHaveAccountLabel.ImageAlign = ContentAlignment.MiddleLeft;
            DontHaveAccountLabel.Location = new Point(374, 403);
            DontHaveAccountLabel.Name = "DontHaveAccountLabel";
            DontHaveAccountLabel.Size = new Size(83, 18);
            DontHaveAccountLabel.TabIndex = 17;
            DontHaveAccountLabel.Text = "Home page";
            // 
            // trackButton
            // 
            trackButton.BackColor = Color.FromArgb(90, 135, 229);
            trackButton.Cursor = Cursors.Hand;
            trackButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trackButton.ForeColor = Color.FromArgb(254, 255, 254);
            trackButton.Location = new Point(236, 342);
            trackButton.Name = "trackButton";
            trackButton.Size = new Size(437, 48);
            trackButton.TabIndex = 15;
            trackButton.Text = "Track";
            trackButton.UseVisualStyleBackColor = false;
            trackButton.Click += trackButton_Click;
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
            userCredentialTextBox.Text = "Phone number";
            userCredentialTextBox.Click += userCredentialTextBox_Click;
            userCredentialTextBox.TextChanged += userCredentialTextBox_TextChanged;
            userCredentialTextBox.Enter += userCredentialTextBox_Enter;
            userCredentialTextBox.Leave += userCredentialTextBox_Leave;
            // 
            // SignInLabel
            // 
            SignInLabel.AutoSize = true;
            SignInLabel.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignInLabel.ForeColor = Color.FromArgb(19, 39, 71);
            SignInLabel.Location = new Point(236, 152);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(309, 41);
            SignInLabel.TabIndex = 7;
            SignInLabel.Text = "Track your delivery";
            SignInLabel.Click += SignInLabel_Click;
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
            FrontLeftPanel.Location = new Point(64, 61);
            FrontLeftPanel.Name = "FrontLeftPanel";
            FrontLeftPanel.Size = new Size(1235, 681);
            FrontLeftPanel.TabIndex = 1;
            // 
            // totalMerLabel
            // 
            totalMerLabel.AutoSize = true;
            totalMerLabel.Font = new Font("Bahnschrift SemiLight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalMerLabel.ForeColor = Color.Black;
            totalMerLabel.ImageAlign = ContentAlignment.MiddleLeft;
            totalMerLabel.Location = new Point(236, 232);
            totalMerLabel.Name = "totalMerLabel";
            totalMerLabel.Size = new Size(164, 28);
            totalMerLabel.TabIndex = 29;
            totalMerLabel.Text = "Phone number";
            // 
            // LoginCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 134, 228);
            ClientSize = new Size(1362, 803);
            Controls.Add(FrontLeftPanel);
            Name = "LoginCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginCustomer";
            FrontRightPanel.ResumeLayout(false);
            FrontRightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EasyDeliveryLogo).EndInit();
            FrontLeftPanel.ResumeLayout(false);
            FrontLeftPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Label leftLabel2;
        private Label leftLable1;
        private Panel FrontRightPanel;
        private Label clickHereLabel;
        private Label DontHaveAccountLabel;
        private Button trackButton;
        private TextBox userCredentialTextBox;
        private Label SignInLabel;
        private PictureBox EasyDeliveryLogo;
        private Label leftLabel5;
        private Label leftLabel4;
        private Label LeftLabel3;
        private Panel FrontLeftPanel;
        private Label totalMerLabel;
    }
}
namespace EasyDelivery
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            imageList1 = new ImageList(components);
            leftLabel2 = new Label();
            leftLable1 = new Label();
            FrontRightPanel = new Panel();
            OrLabel = new Label();
            riderButton = new Button();
            merchantButton = new Button();
            CreateAccountLabel = new Label();
            EasyDeliveryLogo = new PictureBox();
            FrontLeftPanel = new Panel();
            label1 = new Label();
            LeftLabel3 = new Label();
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
            leftLabel2.Size = new Size(305, 41);
            leftLabel2.TabIndex = 2;
            leftLabel2.Text = "Securely Received.";
            // 
            // leftLable1
            // 
            leftLable1.AutoSize = true;
            leftLable1.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leftLable1.ForeColor = Color.FromArgb(254, 255, 254);
            leftLable1.Location = new Point(40, 121);
            leftLable1.Name = "leftLable1";
            leftLable1.Size = new Size(284, 41);
            leftLable1.TabIndex = 1;
            leftLable1.Text = "Swiftly Delivered,";
            // 
            // FrontRightPanel
            // 
            FrontRightPanel.BackColor = Color.FromArgb(254, 254, 255);
            FrontRightPanel.Controls.Add(OrLabel);
            FrontRightPanel.Controls.Add(riderButton);
            FrontRightPanel.Controls.Add(merchantButton);
            FrontRightPanel.Controls.Add(CreateAccountLabel);
            FrontRightPanel.Location = new Point(354, 0);
            FrontRightPanel.Name = "FrontRightPanel";
            FrontRightPanel.Size = new Size(881, 678);
            FrontRightPanel.TabIndex = 0;
            // 
            // OrLabel
            // 
            OrLabel.AutoSize = true;
            OrLabel.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrLabel.ForeColor = Color.FromArgb(19, 39, 71);
            OrLabel.ImageAlign = ContentAlignment.MiddleLeft;
            OrLabel.Location = new Point(438, 384);
            OrLabel.Name = "OrLabel";
            OrLabel.Size = new Size(28, 21);
            OrLabel.TabIndex = 20;
            OrLabel.Text = "Or";
            // 
            // riderButton
            // 
            riderButton.BackColor = Color.FromArgb(254, 255, 254);
            riderButton.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            riderButton.ForeColor = Color.FromArgb(19, 39, 71);
            riderButton.Location = new Point(236, 422);
            riderButton.Name = "riderButton";
            riderButton.Size = new Size(437, 48);
            riderButton.TabIndex = 19;
            riderButton.Text = "Rider";
            riderButton.UseVisualStyleBackColor = false;
            riderButton.Click += riderButton_Click;
            // 
            // merchantButton
            // 
            merchantButton.BackColor = Color.FromArgb(254, 255, 254);
            merchantButton.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            merchantButton.ForeColor = Color.FromArgb(19, 39, 71);
            merchantButton.Location = new Point(236, 316);
            merchantButton.Name = "merchantButton";
            merchantButton.Size = new Size(437, 48);
            merchantButton.TabIndex = 15;
            merchantButton.Text = "Merchant";
            merchantButton.UseVisualStyleBackColor = false;
            merchantButton.Click += merchantButton_Click;
            // 
            // CreateAccountLabel
            // 
            CreateAccountLabel.AutoSize = true;
            CreateAccountLabel.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateAccountLabel.ForeColor = Color.FromArgb(19, 39, 71);
            CreateAccountLabel.Location = new Point(236, 170);
            CreateAccountLabel.Name = "CreateAccountLabel";
            CreateAccountLabel.Size = new Size(252, 41);
            CreateAccountLabel.TabIndex = 7;
            CreateAccountLabel.Text = "Create Account";
            // 
            // EasyDeliveryLogo
            // 
            EasyDeliveryLogo.Image = (Image)resources.GetObject("EasyDeliveryLogo.Image");
            EasyDeliveryLogo.Location = new Point(59, 348);
            EasyDeliveryLogo.Name = "EasyDeliveryLogo";
            EasyDeliveryLogo.Size = new Size(227, 214);
            EasyDeliveryLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            EasyDeliveryLogo.TabIndex = 6;
            EasyDeliveryLogo.TabStop = false;
            // 
            // FrontLeftPanel
            // 
            FrontLeftPanel.BackColor = Color.FromArgb(170, 193, 243);
            FrontLeftPanel.Controls.Add(label1);
            FrontLeftPanel.Controls.Add(EasyDeliveryLogo);
            FrontLeftPanel.Controls.Add(LeftLabel3);
            FrontLeftPanel.Controls.Add(leftLabel2);
            FrontLeftPanel.Controls.Add(leftLable1);
            FrontLeftPanel.Controls.Add(FrontRightPanel);
            FrontLeftPanel.Location = new Point(64, 61);
            FrontLeftPanel.Name = "FrontLeftPanel";
            FrontLeftPanel.Size = new Size(1235, 681);
            FrontLeftPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(254, 255, 254);
            label1.Location = new Point(40, 271);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 7;
            label1.Text = "account.";
            // 
            // LeftLabel3
            // 
            LeftLabel3.AutoSize = true;
            LeftLabel3.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LeftLabel3.ForeColor = Color.FromArgb(254, 255, 254);
            LeftLabel3.Location = new Point(40, 232);
            LeftLabel3.Name = "LeftLabel3";
            LeftLabel3.Size = new Size(278, 28);
            LeftLabel3.TabIndex = 3;
            LeftLabel3.Text = "Get started by creating an";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 134, 228);
            ClientSize = new Size(1362, 803);
            Controls.Add(FrontLeftPanel);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
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
        private Button merchantButton;
        private Label CreateAccountLabel;
        private PictureBox EasyDeliveryLogo;
        private Panel FrontLeftPanel;
        private Label label1;
        private Label LeftLabel3;
        private Button riderButton;
        private Label OrLabel;
    }
}
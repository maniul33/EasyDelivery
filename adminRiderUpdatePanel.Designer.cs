namespace EasyDelivery
{
    partial class adminRiderUpdatePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminRiderUpdatePanel));
            imageList1 = new ImageList(components);
            emailTextBox = new TextBox();
            riderNameTextBox = new TextBox();
            CreateAccountLabel = new Label();
            numberTextBox = new TextBox();
            updateButton = new Button();
            FrontRightPanel = new Panel();
            searchButton = new Button();
            searchTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            backLabel = new Label();
            accountNoTextBox = new TextBox();
            branchNameTextBox = new TextBox();
            bankNameTextBox = new TextBox();
            BankInfoLabel = new Label();
            passwordTextBox = new TextBox();
            FrontLeftPanel = new Panel();
            FrontRightPanel.SuspendLayout();
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
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.ForeColor = SystemColors.ActiveBorder;
            emailTextBox.Location = new Point(47, 324);
            emailTextBox.Multiline = true;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(437, 37);
            emailTextBox.TabIndex = 24;
            emailTextBox.Text = "Email address";
            // 
            // riderNameTextBox
            // 
            riderNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            riderNameTextBox.ForeColor = SystemColors.ActiveBorder;
            riderNameTextBox.Location = new Point(47, 241);
            riderNameTextBox.Multiline = true;
            riderNameTextBox.Name = "riderNameTextBox";
            riderNameTextBox.Size = new Size(437, 37);
            riderNameTextBox.TabIndex = 23;
            riderNameTextBox.Text = "Rider name";
            // 
            // CreateAccountLabel
            // 
            CreateAccountLabel.AutoSize = true;
            CreateAccountLabel.Font = new Font("Bahnschrift SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateAccountLabel.ForeColor = Color.FromArgb(19, 39, 71);
            CreateAccountLabel.Location = new Point(47, 74);
            CreateAccountLabel.Name = "CreateAccountLabel";
            CreateAccountLabel.Size = new Size(401, 41);
            CreateAccountLabel.TabIndex = 19;
            CreateAccountLabel.Text = "Update Rider Information";
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberTextBox.ForeColor = SystemColors.ActiveBorder;
            numberTextBox.Location = new Point(47, 409);
            numberTextBox.Multiline = true;
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(437, 37);
            numberTextBox.TabIndex = 25;
            numberTextBox.Text = "Phone number";
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(90, 135, 229);
            updateButton.Cursor = Cursors.Hand;
            updateButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.FromArgb(254, 255, 254);
            updateButton.Location = new Point(610, 401);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(437, 48);
            updateButton.TabIndex = 15;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // FrontRightPanel
            // 
            FrontRightPanel.BackColor = Color.FromArgb(254, 254, 255);
            FrontRightPanel.Controls.Add(searchButton);
            FrontRightPanel.Controls.Add(searchTextBox);
            FrontRightPanel.Controls.Add(label6);
            FrontRightPanel.Controls.Add(label5);
            FrontRightPanel.Controls.Add(label4);
            FrontRightPanel.Controls.Add(label3);
            FrontRightPanel.Controls.Add(label2);
            FrontRightPanel.Controls.Add(label1);
            FrontRightPanel.Controls.Add(backLabel);
            FrontRightPanel.Controls.Add(accountNoTextBox);
            FrontRightPanel.Controls.Add(branchNameTextBox);
            FrontRightPanel.Controls.Add(bankNameTextBox);
            FrontRightPanel.Controls.Add(BankInfoLabel);
            FrontRightPanel.Controls.Add(passwordTextBox);
            FrontRightPanel.Controls.Add(numberTextBox);
            FrontRightPanel.Controls.Add(emailTextBox);
            FrontRightPanel.Controls.Add(riderNameTextBox);
            FrontRightPanel.Controls.Add(CreateAccountLabel);
            FrontRightPanel.Controls.Add(updateButton);
            FrontRightPanel.Location = new Point(0, 0);
            FrontRightPanel.Name = "FrontRightPanel";
            FrontRightPanel.Size = new Size(1235, 678);
            FrontRightPanel.TabIndex = 0;
            FrontRightPanel.Paint += FrontRightPanel_Paint;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.FromArgb(90, 135, 229);
            searchButton.Cursor = Cursors.Hand;
            searchButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.FromArgb(254, 255, 254);
            searchButton.Location = new Point(463, 126);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(179, 48);
            searchButton.TabIndex = 49;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.ForeColor = SystemColors.ActiveBorder;
            searchTextBox.Location = new Point(47, 134);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(383, 37);
            searchTextBox.TabIndex = 48;
            searchTextBox.Text = "Rider id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(19, 39, 71);
            label6.Location = new Point(610, 298);
            label6.Name = "label6";
            label6.Size = new Size(147, 22);
            label6.TabIndex = 47;
            label6.Text = "Account Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(19, 39, 71);
            label5.Location = new Point(842, 216);
            label5.Name = "label5";
            label5.Size = new Size(122, 22);
            label5.TabIndex = 46;
            label5.Text = "Branch Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(19, 39, 71);
            label4.Location = new Point(47, 463);
            label4.Name = "label4";
            label4.Size = new Size(91, 22);
            label4.TabIndex = 45;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(19, 39, 71);
            label3.Location = new Point(47, 384);
            label3.Name = "label3";
            label3.Size = new Size(132, 22);
            label3.TabIndex = 44;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(19, 39, 71);
            label2.Location = new Point(47, 299);
            label2.Name = "label2";
            label2.Size = new Size(129, 22);
            label2.TabIndex = 43;
            label2.Text = "Email Address";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(19, 39, 71);
            label1.Location = new Point(47, 216);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 42;
            label1.Text = "Name";
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.Cursor = Cursors.Hand;
            backLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backLabel.ForeColor = Color.FromArgb(19, 39, 71);
            backLabel.Image = (Image)resources.GetObject("backLabel.Image");
            backLabel.ImageAlign = ContentAlignment.MiddleLeft;
            backLabel.Location = new Point(47, 30);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(76, 22);
            backLabel.TabIndex = 41;
            backLabel.Text = "     Back";
            backLabel.Click += backLabel_Click;
            // 
            // accountNoTextBox
            // 
            accountNoTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountNoTextBox.ForeColor = SystemColors.ActiveBorder;
            accountNoTextBox.Location = new Point(610, 323);
            accountNoTextBox.Multiline = true;
            accountNoTextBox.Name = "accountNoTextBox";
            accountNoTextBox.Size = new Size(437, 37);
            accountNoTextBox.TabIndex = 30;
            accountNoTextBox.Text = "Account number";
            // 
            // branchNameTextBox
            // 
            branchNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            branchNameTextBox.ForeColor = SystemColors.ActiveBorder;
            branchNameTextBox.Location = new Point(842, 241);
            branchNameTextBox.Multiline = true;
            branchNameTextBox.Name = "branchNameTextBox";
            branchNameTextBox.Size = new Size(205, 37);
            branchNameTextBox.TabIndex = 29;
            branchNameTextBox.Text = "Branch name";
            // 
            // bankNameTextBox
            // 
            bankNameTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bankNameTextBox.ForeColor = SystemColors.ActiveBorder;
            bankNameTextBox.Location = new Point(610, 241);
            bankNameTextBox.Multiline = true;
            bankNameTextBox.Name = "bankNameTextBox";
            bankNameTextBox.Size = new Size(197, 37);
            bankNameTextBox.TabIndex = 28;
            bankNameTextBox.Text = "Bank name";
            // 
            // BankInfoLabel
            // 
            BankInfoLabel.AutoSize = true;
            BankInfoLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BankInfoLabel.ForeColor = Color.FromArgb(19, 39, 71);
            BankInfoLabel.Location = new Point(610, 216);
            BankInfoLabel.Name = "BankInfoLabel";
            BankInfoLabel.Size = new Size(105, 22);
            BankInfoLabel.TabIndex = 27;
            BankInfoLabel.Text = "Bank Name";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.ForeColor = SystemColors.ActiveBorder;
            passwordTextBox.Location = new Point(47, 488);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(437, 37);
            passwordTextBox.TabIndex = 26;
            passwordTextBox.Text = "Password";
            // 
            // FrontLeftPanel
            // 
            FrontLeftPanel.BackColor = Color.White;
            FrontLeftPanel.Controls.Add(FrontRightPanel);
            FrontLeftPanel.Location = new Point(64, 61);
            FrontLeftPanel.Name = "FrontLeftPanel";
            FrontLeftPanel.Size = new Size(1235, 681);
            FrontLeftPanel.TabIndex = 3;
            // 
            // adminRiderUpdatePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 39, 71);
            ClientSize = new Size(1362, 803);
            Controls.Add(FrontLeftPanel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminRiderUpdatePanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminRiderUpdatePanel";
            FrontRightPanel.ResumeLayout(false);
            FrontRightPanel.PerformLayout();
            FrontLeftPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private TextBox emailTextBox;
        private TextBox riderNameTextBox;
        private Label CreateAccountLabel;
        private TextBox numberTextBox;
        private Button updateButton;
        private Panel FrontRightPanel;
        private TextBox accountNoTextBox;
        private TextBox branchNameTextBox;
        private TextBox bankNameTextBox;
        private Label BankInfoLabel;
        private TextBox passwordTextBox;
        private Panel FrontLeftPanel;
        private Label backLabel;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Button searchButton;
        private TextBox searchTextBox;
    }
}
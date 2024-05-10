namespace EasyDelivery
{
    partial class adminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashboard));
            leftPanel = new Panel();
            deliveryButton = new Button();
            logoutButton = new Button();
            riderButton = new Button();
            merchantButton = new Button();
            dashboardButton = new Button();
            topLeftPanel = new Panel();
            pictureBox1 = new PictureBox();
            mainPanel = new Panel();
            leftPanel.SuspendLayout();
            topLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.FromArgb(19, 39, 71);
            leftPanel.Controls.Add(deliveryButton);
            leftPanel.Controls.Add(logoutButton);
            leftPanel.Controls.Add(riderButton);
            leftPanel.Controls.Add(merchantButton);
            leftPanel.Controls.Add(dashboardButton);
            leftPanel.Controls.Add(topLeftPanel);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(269, 803);
            leftPanel.TabIndex = 0;
            leftPanel.Paint += panel1_Paint;
            // 
            // deliveryButton
            // 
            deliveryButton.BackColor = Color.FromArgb(19, 39, 71);
            deliveryButton.FlatAppearance.BorderSize = 0;
            deliveryButton.FlatStyle = FlatStyle.Flat;
            deliveryButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryButton.ForeColor = Color.White;
            deliveryButton.Image = (Image)resources.GetObject("deliveryButton.Image");
            deliveryButton.ImageAlign = ContentAlignment.MiddleLeft;
            deliveryButton.Location = new Point(0, 395);
            deliveryButton.Name = "deliveryButton";
            deliveryButton.Size = new Size(269, 48);
            deliveryButton.TabIndex = 5;
            deliveryButton.Text = "DELIVERIES";
            deliveryButton.UseVisualStyleBackColor = false;
            deliveryButton.Click += deliveryButton_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(19, 39, 71);
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(0, 449);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(269, 48);
            logoutButton.TabIndex = 4;
            logoutButton.Text = "LOGOUT";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // riderButton
            // 
            riderButton.BackColor = Color.FromArgb(19, 39, 71);
            riderButton.FlatAppearance.BorderSize = 0;
            riderButton.FlatStyle = FlatStyle.Flat;
            riderButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            riderButton.ForeColor = Color.White;
            riderButton.Image = (Image)resources.GetObject("riderButton.Image");
            riderButton.ImageAlign = ContentAlignment.MiddleLeft;
            riderButton.Location = new Point(0, 351);
            riderButton.Name = "riderButton";
            riderButton.Size = new Size(269, 48);
            riderButton.TabIndex = 3;
            riderButton.Text = "RIDER";
            riderButton.UseVisualStyleBackColor = false;
            riderButton.Click += riderButton_Click;
            // 
            // merchantButton
            // 
            merchantButton.BackColor = Color.FromArgb(19, 39, 71);
            merchantButton.FlatAppearance.BorderSize = 0;
            merchantButton.FlatStyle = FlatStyle.Flat;
            merchantButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            merchantButton.ForeColor = Color.White;
            merchantButton.Image = (Image)resources.GetObject("merchantButton.Image");
            merchantButton.ImageAlign = ContentAlignment.MiddleLeft;
            merchantButton.Location = new Point(0, 306);
            merchantButton.Name = "merchantButton";
            merchantButton.Size = new Size(269, 48);
            merchantButton.TabIndex = 2;
            merchantButton.Text = "MERCHANT";
            merchantButton.UseVisualStyleBackColor = false;
            merchantButton.Click += merchantButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(19, 39, 71);
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(0, 261);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(269, 48);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "DASHBOARD";
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // topLeftPanel
            // 
            topLeftPanel.BackColor = Color.White;
            topLeftPanel.Controls.Add(pictureBox1);
            topLeftPanel.Location = new Point(0, 0);
            topLeftPanel.Name = "topLeftPanel";
            topLeftPanel.Size = new Size(269, 264);
            topLeftPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(269, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1093, 803);
            mainPanel.TabIndex = 1;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1362, 803);
            Controls.Add(mainPanel);
            Controls.Add(leftPanel);
            Name = "adminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "adminDashboard";
            leftPanel.ResumeLayout(false);
            topLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private Panel topLeftPanel;
        private PictureBox pictureBox1;
        private Button dashboardButton;
        private Button merchantButton;
        private Button riderButton;
        private Button logoutButton;
        private Panel mainPanel;
        private Button deliveryButton;
    }
}
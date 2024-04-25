namespace EasyDelivery
{
    partial class merchantDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(merchantDashboard));
            sidePanel = new Panel();
            logoutButton = new Button();
            notesButton = new Button();
            invoicesButton = new Button();
            deliveriesButton = new Button();
            newDeliveryButton = new Button();
            dashboardButton = new Button();
            logoPanel = new Panel();
            profileButton = new Button();
            profilePicture = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel3 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            briefStatsLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dateBox = new TextBox();
            calenderIcon = new PictureBox();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            sidePanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)calenderIcon).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(19, 40, 71);
            sidePanel.Controls.Add(logoutButton);
            sidePanel.Controls.Add(notesButton);
            sidePanel.Controls.Add(invoicesButton);
            sidePanel.Controls.Add(deliveriesButton);
            sidePanel.Controls.Add(newDeliveryButton);
            sidePanel.Controls.Add(dashboardButton);
            sidePanel.Controls.Add(logoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(250, 803);
            sidePanel.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.Location = new Point(0, 728);
            logoutButton.Margin = new Padding(0);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(250, 80);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "   Log out";
            logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += button1_Click_2;
            // 
            // notesButton
            // 
            notesButton.Cursor = Cursors.Hand;
            notesButton.FlatAppearance.BorderSize = 0;
            notesButton.FlatStyle = FlatStyle.Flat;
            notesButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notesButton.ForeColor = Color.White;
            notesButton.Image = (Image)resources.GetObject("notesButton.Image");
            notesButton.Location = new Point(0, 648);
            notesButton.Margin = new Padding(0);
            notesButton.Name = "notesButton";
            notesButton.Size = new Size(250, 80);
            notesButton.TabIndex = 5;
            notesButton.Text = "    Notes";
            notesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            notesButton.UseVisualStyleBackColor = true;
            // 
            // invoicesButton
            // 
            invoicesButton.Cursor = Cursors.Hand;
            invoicesButton.FlatAppearance.BorderSize = 0;
            invoicesButton.FlatStyle = FlatStyle.Flat;
            invoicesButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoicesButton.ForeColor = Color.White;
            invoicesButton.Image = (Image)resources.GetObject("invoicesButton.Image");
            invoicesButton.Location = new Point(0, 568);
            invoicesButton.Margin = new Padding(0);
            invoicesButton.Name = "invoicesButton";
            invoicesButton.Size = new Size(250, 80);
            invoicesButton.TabIndex = 4;
            invoicesButton.Text = "   Invoices";
            invoicesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            invoicesButton.UseVisualStyleBackColor = true;
            // 
            // deliveriesButton
            // 
            deliveriesButton.Cursor = Cursors.Hand;
            deliveriesButton.FlatAppearance.BorderSize = 0;
            deliveriesButton.FlatStyle = FlatStyle.Flat;
            deliveriesButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveriesButton.ForeColor = Color.White;
            deliveriesButton.Image = (Image)resources.GetObject("deliveriesButton.Image");
            deliveriesButton.Location = new Point(0, 488);
            deliveriesButton.Margin = new Padding(0);
            deliveriesButton.Name = "deliveriesButton";
            deliveriesButton.Size = new Size(250, 80);
            deliveriesButton.TabIndex = 3;
            deliveriesButton.Text = "  All Deliveries";
            deliveriesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deliveriesButton.UseVisualStyleBackColor = true;
            // 
            // newDeliveryButton
            // 
            newDeliveryButton.Cursor = Cursors.Hand;
            newDeliveryButton.FlatAppearance.BorderSize = 0;
            newDeliveryButton.FlatStyle = FlatStyle.Flat;
            newDeliveryButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newDeliveryButton.ForeColor = Color.White;
            newDeliveryButton.Image = (Image)resources.GetObject("newDeliveryButton.Image");
            newDeliveryButton.Location = new Point(0, 408);
            newDeliveryButton.Margin = new Padding(0);
            newDeliveryButton.Name = "newDeliveryButton";
            newDeliveryButton.Size = new Size(250, 80);
            newDeliveryButton.TabIndex = 2;
            newDeliveryButton.Text = "  New Delivery";
            newDeliveryButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            newDeliveryButton.UseVisualStyleBackColor = true;
            newDeliveryButton.Click += newDeliveryButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.Location = new Point(0, 328);
            dashboardButton.Margin = new Padding(0);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(250, 80);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "   Dashboard";
            dashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += button1_Click_1;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(profileButton);
            logoPanel.Controls.Add(profilePicture);
            logoPanel.Controls.Add(panel1);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(250, 331);
            logoPanel.TabIndex = 1;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.White;
            profileButton.Cursor = Cursors.Hand;
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileButton.ForeColor = Color.FromArgb(19, 40, 71);
            profileButton.Image = (Image)resources.GetObject("profileButton.Image");
            profileButton.Location = new Point(85, 246);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(165, 85);
            profileButton.TabIndex = 1;
            profileButton.Text = " Profile";
            profileButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += button1_Click;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.White;
            profilePicture.Image = (Image)resources.GetObject("profilePicture.Image");
            profilePicture.Location = new Point(0, 244);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(87, 87);
            profilePicture.TabIndex = 1;
            profilePicture.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 250);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 246);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 85);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(325, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(959, 185);
            panel3.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ButtonHighlight;
            panel5.Controls.Add(label1);
            panel5.Location = new Point(3, 69);
            panel5.Name = "panel5";
            panel5.Size = new Size(951, 49);
            panel5.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(19, 40, 71);
            label1.Location = new Point(4, 6);
            label1.Name = "label1";
            label1.Size = new Size(303, 34);
            label1.TabIndex = 9;
            label1.Text = "Pending Delivery";
            label1.Click += label1_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 124);
            panel4.Name = "panel4";
            panel4.Size = new Size(951, 56);
            panel4.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(19, 40, 71);
            label2.Location = new Point(6, 10);
            label2.Name = "label2";
            label2.Size = new Size(285, 34);
            label2.TabIndex = 10;
            label2.Text = "Total Cancelled";
            // 
            // briefStatsLabel
            // 
            briefStatsLabel.AutoSize = true;
            briefStatsLabel.BackColor = Color.Transparent;
            briefStatsLabel.Font = new Font("Lucida Sans Typewriter", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            briefStatsLabel.ForeColor = Color.FromArgb(19, 40, 71);
            briefStatsLabel.Location = new Point(325, 43);
            briefStatsLabel.Name = "briefStatsLabel";
            briefStatsLabel.Size = new Size(237, 39);
            briefStatsLabel.TabIndex = 2;
            briefStatsLabel.Text = "Brief Stats";
            briefStatsLabel.Click += label1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dateBox
            // 
            dateBox.BorderStyle = BorderStyle.FixedSingle;
            dateBox.Cursor = Cursors.Hand;
            dateBox.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateBox.Location = new Point(48, 0);
            dateBox.Multiline = true;
            dateBox.Name = "dateBox";
            dateBox.Size = new Size(325, 39);
            dateBox.TabIndex = 4;
            dateBox.Text = "17 JAN 2024  -  20 FEB 2024";
            dateBox.TextAlign = HorizontalAlignment.Center;
            dateBox.TextChanged += textBox1_TextChanged;
            // 
            // calenderIcon
            // 
            calenderIcon.Image = (Image)resources.GetObject("calenderIcon.Image");
            calenderIcon.Location = new Point(5, -2);
            calenderIcon.Name = "calenderIcon";
            calenderIcon.Size = new Size(39, 39);
            calenderIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            calenderIcon.TabIndex = 5;
            calenderIcon.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(calenderIcon);
            panel6.Controls.Add(dateBox);
            panel6.Location = new Point(910, 43);
            panel6.Name = "panel6";
            panel6.Size = new Size(374, 39);
            panel6.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Location = new Point(325, 410);
            panel7.Name = "panel7";
            panel7.Size = new Size(959, 353);
            panel7.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(248, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1114, 803);
            panel8.TabIndex = 8;
            // 
            // merchantDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1362, 803);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(briefStatsLabel);
            Controls.Add(panel3);
            Controls.Add(sidePanel);
            Controls.Add(panel8);
            Name = "merchantDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Merchant";
            Load += merchantDashboard_Load;
            sidePanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)calenderIcon).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidePanel;
        private Panel logoPanel;
        private Panel panel1;
        private Button profileButton;
        private PictureBox profilePicture;
        private Panel panel2;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button dashboardButton;
        private Button notesButton;
        private Button invoicesButton;
        private Button deliveriesButton;
        private Button newDeliveryButton;
        private Button logoutButton;
        private Panel panel3;
        private Panel panel5;
        private Label briefStatsLabel;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox dateBox;
        private PictureBox calenderIcon;
        private Panel panel6;
        private Panel panel4;
        private Panel panel7;
        private Label label1;
        private Label label2;
        private Panel panel8;
    }
}
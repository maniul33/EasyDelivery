namespace EasyDelivery
{
    partial class allDeliveriesForMerchant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allDeliveriesForMerchant));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip1 = new ContextMenuStrip(components);
            rightPanel = new Panel();
            logoPanel = new Panel();
            profileButton = new Button();
            profilePicture = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            logoBox = new PictureBox();
            dashboardButton = new Button();
            newDeliveryButton = new Button();
            deliveriesButton = new Button();
            logoutButton = new Button();
            sidePanel = new Panel();
            contextMenuStrip2 = new ContextMenuStrip(components);
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            searchbyIDBox = new TextBox();
            contextMenuStrip3 = new ContextMenuStrip(components);
            label12 = new Label();
            label13 = new Label();
            searchByCustomerPhoneBox = new TextBox();
            searchButton = new Button();
            button1 = new Button();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // rightPanel
            // 
            rightPanel.AutoScroll = true;
            rightPanel.BackColor = SystemColors.ButtonHighlight;
            rightPanel.Location = new Point(248, 172);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1114, 608);
            rightPanel.TabIndex = 14;
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
            profileButton.Location = new Point(85, 246);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(165, 85);
            profileButton.TabIndex = 1;
            profileButton.Text = " Profile";
            profileButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            profileButton.UseVisualStyleBackColor = false;
            // 
            // profilePicture
            // 
            profilePicture.BackColor = Color.White;
            profilePicture.Location = new Point(0, 244);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(87, 87);
            profilePicture.TabIndex = 1;
            profilePicture.TabStop = false;
            profilePicture.Click += profilePicture_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(logoBox);
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
            // logoBox
            // 
            logoBox.BackColor = Color.White;
            logoBox.Location = new Point(0, 0);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(250, 250);
            logoBox.TabIndex = 1;
            logoBox.TabStop = false;
            // 
            // dashboardButton
            // 
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Location = new Point(0, 328);
            dashboardButton.Margin = new Padding(0);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(250, 80);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "   Dashboard";
            dashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardButton.UseVisualStyleBackColor = true;
            // 
            // newDeliveryButton
            // 
            newDeliveryButton.Cursor = Cursors.Hand;
            newDeliveryButton.FlatAppearance.BorderSize = 0;
            newDeliveryButton.FlatStyle = FlatStyle.Flat;
            newDeliveryButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newDeliveryButton.ForeColor = Color.White;
            newDeliveryButton.Location = new Point(0, 408);
            newDeliveryButton.Margin = new Padding(0);
            newDeliveryButton.Name = "newDeliveryButton";
            newDeliveryButton.Size = new Size(250, 80);
            newDeliveryButton.TabIndex = 2;
            newDeliveryButton.Text = "  New Delivery";
            newDeliveryButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            newDeliveryButton.UseVisualStyleBackColor = true;
            // 
            // deliveriesButton
            // 
            deliveriesButton.Cursor = Cursors.Hand;
            deliveriesButton.FlatAppearance.BorderSize = 0;
            deliveriesButton.FlatStyle = FlatStyle.Flat;
            deliveriesButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveriesButton.ForeColor = Color.White;
            deliveriesButton.Location = new Point(0, 488);
            deliveriesButton.Margin = new Padding(0);
            deliveriesButton.Name = "deliveriesButton";
            deliveriesButton.Size = new Size(250, 80);
            deliveriesButton.TabIndex = 3;
            deliveriesButton.Text = "  All Deliveries";
            deliveriesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deliveriesButton.UseVisualStyleBackColor = true;
            // 
            // logoutButton
            // 
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(0, 568);
            logoutButton.Margin = new Padding(0);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(250, 80);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "   Log out";
            logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(19, 40, 71);
            sidePanel.Controls.Add(logoutButton);
            sidePanel.Controls.Add(deliveriesButton);
            sidePanel.Controls.Add(newDeliveryButton);
            sidePanel.Controls.Add(dashboardButton);
            sidePanel.Controls.Add(logoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(250, 803);
            sidePanel.TabIndex = 9;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip1";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 115);
            label3.Name = "label3";
            label3.Size = new Size(133, 27);
            label3.TabIndex = 15;
            label3.Text = "Delivery ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1216, 115);
            label1.Name = "label1";
            label1.Size = new Size(64, 27);
            label1.TabIndex = 16;
            label1.Text = "COD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(980, 115);
            label2.Name = "label2";
            label2.Size = new Size(180, 27);
            label2.TabIndex = 17;
            label2.Text = "Delivery Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(697, 115);
            label4.Name = "label4";
            label4.Size = new Size(204, 27);
            label4.TabIndex = 18;
            label4.Text = "Customer Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(486, 115);
            label5.Name = "label5";
            label5.Size = new Size(144, 27);
            label5.TabIndex = 19;
            label5.Text = "Store Name";
            // 
            // searchbyIDBox
            // 
            searchbyIDBox.BorderStyle = BorderStyle.FixedSingle;
            searchbyIDBox.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbyIDBox.ForeColor = Color.Black;
            searchbyIDBox.Location = new Point(295, 48);
            searchbyIDBox.Multiline = true;
            searchbyIDBox.Name = "searchbyIDBox";
            searchbyIDBox.Size = new Size(252, 38);
            searchbyIDBox.TabIndex = 20;
            searchbyIDBox.TextChanged += textBox1_TextChanged;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(295, 17);
            label12.Name = "label12";
            label12.Size = new Size(176, 28);
            label12.TabIndex = 21;
            label12.Text = "Search by Delivery ID";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(603, 17);
            label13.Name = "label13";
            label13.Size = new Size(247, 28);
            label13.TabIndex = 23;
            label13.Text = "Search by Customer Phone No.";
            // 
            // searchByCustomerPhoneBox
            // 
            searchByCustomerPhoneBox.BorderStyle = BorderStyle.FixedSingle;
            searchByCustomerPhoneBox.Font = new Font("Bahnschrift Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchByCustomerPhoneBox.ForeColor = Color.Black;
            searchByCustomerPhoneBox.Location = new Point(603, 48);
            searchByCustomerPhoneBox.Multiline = true;
            searchByCustomerPhoneBox.Name = "searchByCustomerPhoneBox";
            searchByCustomerPhoneBox.Size = new Size(252, 38);
            searchByCustomerPhoneBox.TabIndex = 22;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.ButtonHighlight;
            searchButton.Cursor = Cursors.Hand;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = SystemColors.Desktop;
            searchButton.Image = (Image)resources.GetObject("searchButton.Image");
            searchButton.Location = new Point(905, 48);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(120, 38);
            searchButton.TabIndex = 24;
            searchButton.Text = "Search";
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1094, 66);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 25;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // allDeliveriesForMerchant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1362, 803);
            Controls.Add(button1);
            Controls.Add(searchButton);
            Controls.Add(label13);
            Controls.Add(searchByCustomerPhoneBox);
            Controls.Add(label12);
            Controls.Add(searchbyIDBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(sidePanel);
            Controls.Add(rightPanel);
            Name = "allDeliveriesForMerchant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "allDeliveriesForMerchant";
            Load += allDeliveriesForMerchant_Load;
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            sidePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel logoPanel;
        private Button profileButton;
        private PictureBox profilePicture;
        private Panel panel1;
        private Panel panel2;
        private PictureBox logoBox;
        private Button dashboardButton;
        private Button newDeliveryButton;
        private Button deliveriesButton;
        private Button logoutButton;
        private Panel sidePanel;
        private Label briefStatsLabel;
        private TextBox dateBox;
        private PictureBox calenderIcon;
        private Panel panel6;
        private Panel oftPanel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label price1Label;
        private Label phone1label;
        private Label deliveryid1Label;
        private Label name1Label;
        private Panel oftPanel3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label price3Label;
        private Label phone3Label;
        private Label deliveryid3Label;
        private Label name3Label;
        private Panel oftPanel2;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Label price2Label;
        private Label phone2Label;
        private Label deliveryid2Label;
        private Label name2Label;
        private Panel oftPanel4;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private Label price4Label;
        private Label phone4Label;
        private Label deliveryid4Label;
        private Label name4Label;
        private Panel panel7;
        private Panel rootPanel;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label label1;
        private Panel panel10;
        private Label label4;
        private Panel rightPanel;
        private Panel panel11;
        private PictureBox pictureBox14;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label9;
        private PictureBox pictureBox16;
        private PictureBox pictureBox15;
        private Label label11;
        private PictureBox pictureBox17;
        private Label label10;
        private Panel panel8;
        private Panel panel9;
        private ContextMenuStrip contextMenuStrip2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label3;
        private TextBox searchbyIDBox;
        private ContextMenuStrip contextMenuStrip3;
        private Label label12;
        private Label label13;
        private TextBox searchByCustomerPhoneBox;
        private Button searchButton;
        private Button button1;
    }
}
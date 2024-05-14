namespace EasyDelivery
{
    partial class allDeliveriesForRider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(allDeliveriesForRider));
            button1 = new Button();
            contextMenuStrip3 = new ContextMenuStrip(components);
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            contextMenuStrip2 = new ContextMenuStrip(components);
            sidePanel = new Panel();
            logoutButton = new Button();
            deliveriesButton = new Button();
            dashboardButton = new Button();
            logoPanel = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            logoBox = new PictureBox();
            rightPanel = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label6 = new Label();
            sidePanel.SuspendLayout();
            logoPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1094, 66);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 38;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(486, 115);
            label5.Name = "label5";
            label5.Size = new Size(144, 27);
            label5.TabIndex = 32;
            label5.Text = "Store Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(697, 115);
            label4.Name = "label4";
            label4.Size = new Size(204, 27);
            label4.TabIndex = 31;
            label4.Text = "Customer Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(980, 115);
            label2.Name = "label2";
            label2.Size = new Size(180, 27);
            label2.TabIndex = 30;
            label2.Text = "Delivery Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(1216, 115);
            label1.Name = "label1";
            label1.Size = new Size(64, 27);
            label1.TabIndex = 29;
            label1.Text = "COD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(295, 115);
            label3.Name = "label3";
            label3.Size = new Size(133, 27);
            label3.TabIndex = 28;
            label3.Text = "Delivery ID";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip1";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(19, 40, 71);
            sidePanel.Controls.Add(logoutButton);
            sidePanel.Controls.Add(deliveriesButton);
            sidePanel.Controls.Add(dashboardButton);
            sidePanel.Controls.Add(logoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(250, 803);
            sidePanel.TabIndex = 26;
            // 
            // logoutButton
            // 
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.Location = new Point(0, 414);
            logoutButton.Margin = new Padding(0);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(250, 80);
            logoutButton.TabIndex = 6;
            logoutButton.Text = "   Log out";
            logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // deliveriesButton
            // 
            deliveriesButton.Cursor = Cursors.Hand;
            deliveriesButton.FlatAppearance.BorderSize = 0;
            deliveriesButton.FlatStyle = FlatStyle.Flat;
            deliveriesButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveriesButton.ForeColor = Color.White;
            deliveriesButton.Image = (Image)resources.GetObject("deliveriesButton.Image");
            deliveriesButton.Location = new Point(0, 334);
            deliveriesButton.Margin = new Padding(0);
            deliveriesButton.Name = "deliveriesButton";
            deliveriesButton.Size = new Size(250, 80);
            deliveriesButton.TabIndex = 3;
            deliveriesButton.Text = "  All Deliveries";
            deliveriesButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deliveriesButton.UseVisualStyleBackColor = true;
            // 
            // dashboardButton
            // 
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.Location = new Point(0, 254);
            dashboardButton.Margin = new Padding(0);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(250, 80);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "   Dashboard";
            dashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(panel1);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(250, 331);
            logoPanel.TabIndex = 1;
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
            logoBox.Image = (Image)resources.GetObject("logoBox.Image");
            logoBox.Location = new Point(0, 0);
            logoBox.Name = "logoBox";
            logoBox.Size = new Size(250, 250);
            logoBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoBox.TabIndex = 1;
            logoBox.TabStop = false;
            // 
            // rightPanel
            // 
            rightPanel.AutoScroll = true;
            rightPanel.BackColor = SystemColors.ButtonHighlight;
            rightPanel.Location = new Point(248, 172);
            rightPanel.Name = "rightPanel";
            rightPanel.Size = new Size(1114, 608);
            rightPanel.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(295, 36);
            label6.Name = "label6";
            label6.Size = new Size(260, 48);
            label6.TabIndex = 39;
            label6.Text = "All Deliveries";
            // 
            // allDeliveriesForRider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1362, 803);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(sidePanel);
            Controls.Add(rightPanel);
            Name = "allDeliveriesForRider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "allDeliveriesForRider";
            sidePanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ContextMenuStrip contextMenuStrip3;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private ContextMenuStrip contextMenuStrip2;
        private Panel sidePanel;
        private Button logoutButton;
        private Button deliveriesButton;
        private Button dashboardButton;
        private Panel logoPanel;
        private Panel panel1;
        private Panel panel2;
        private PictureBox logoBox;
        private Panel rightPanel;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label6;
    }
}
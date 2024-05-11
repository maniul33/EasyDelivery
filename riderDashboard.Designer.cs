namespace EasyDelivery
{
    partial class riderDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(riderDashboard));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            riderDelivery_button = new Button();
            riderProfile_button = new Button();
            riderDashboard_button = new Button();
            panel2 = new Panel();
            area_comboBox = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            deliverylist_panel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 39, 71);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(riderDelivery_button);
            panel1.Controls.Add(riderProfile_button);
            panel1.Controls.Add(riderDashboard_button);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 747);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 401);
            button1.Name = "button1";
            button1.Size = new Size(236, 63);
            button1.TabIndex = 4;
            button1.Text = "   Logout";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._437316590_412614248190655_6311576414775504443_n;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 232);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // riderDelivery_button
            // 
            riderDelivery_button.FlatStyle = FlatStyle.Flat;
            riderDelivery_button.Font = new Font("Consolas", 12F, FontStyle.Bold);
            riderDelivery_button.ForeColor = Color.White;
            riderDelivery_button.Image = Properties.Resources.rsz_image_2;
            riderDelivery_button.Location = new Point(0, 341);
            riderDelivery_button.Name = "riderDelivery_button";
            riderDelivery_button.Size = new Size(236, 63);
            riderDelivery_button.TabIndex = 3;
            riderDelivery_button.Text = "  Deliveries";
            riderDelivery_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            riderDelivery_button.UseVisualStyleBackColor = true;
            riderDelivery_button.Click += riderDelivery_button_Click;
            // 
            // riderProfile_button
            // 
            riderProfile_button.BackColor = Color.FromArgb(19, 40, 71);
            riderProfile_button.BackgroundImageLayout = ImageLayout.None;
            riderProfile_button.FlatStyle = FlatStyle.Flat;
            riderProfile_button.Font = new Font("Consolas", 12F, FontStyle.Bold);
            riderProfile_button.ForeColor = Color.White;
            riderProfile_button.Image = (Image)resources.GetObject("riderProfile_button.Image");
            riderProfile_button.Location = new Point(0, 229);
            riderProfile_button.Name = "riderProfile_button";
            riderProfile_button.Size = new Size(236, 56);
            riderProfile_button.TabIndex = 2;
            riderProfile_button.Text = "  Profile";
            riderProfile_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            riderProfile_button.UseVisualStyleBackColor = false;
            // 
            // riderDashboard_button
            // 
            riderDashboard_button.BackColor = Color.FromArgb(19, 40, 71);
            riderDashboard_button.BackgroundImageLayout = ImageLayout.None;
            riderDashboard_button.FlatStyle = FlatStyle.Flat;
            riderDashboard_button.Font = new Font("Consolas", 12F, FontStyle.Bold);
            riderDashboard_button.ForeColor = Color.White;
            riderDashboard_button.Image = (Image)resources.GetObject("riderDashboard_button.Image");
            riderDashboard_button.Location = new Point(0, 282);
            riderDashboard_button.Name = "riderDashboard_button";
            riderDashboard_button.Size = new Size(236, 63);
            riderDashboard_button.TabIndex = 1;
            riderDashboard_button.Text = "  Dashboard";
            riderDashboard_button.TextImageRelation = TextImageRelation.ImageBeforeText;
            riderDashboard_button.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(area_comboBox);
            panel2.Location = new Point(276, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 80);
            panel2.TabIndex = 1;
            // 
            // area_comboBox
            // 
            area_comboBox.FormattingEnabled = true;
            area_comboBox.Location = new Point(18, 40);
            area_comboBox.Name = "area_comboBox";
            area_comboBox.Size = new Size(271, 23);
            area_comboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(19, 39, 71);
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(58, 24);
            label1.TabIndex = 1;
            label1.Text = "Area";
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(253, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(1090, 47);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(19, 39, 71);
            label2.Location = new Point(32, 16);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 0;
            label2.Text = "Delivery ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(19, 39, 71);
            label3.Location = new Point(258, 16);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 1;
            label3.Text = "Store";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(19, 39, 71);
            label4.Location = new Point(464, 16);
            label4.Name = "label4";
            label4.Size = new Size(126, 19);
            label4.TabIndex = 2;
            label4.Text = "Customer Info";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(19, 39, 71);
            label5.Location = new Point(736, 16);
            label5.Name = "label5";
            label5.Size = new Size(63, 19);
            label5.TabIndex = 3;
            label5.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(19, 39, 71);
            label6.Location = new Point(942, 16);
            label6.Name = "label6";
            label6.Size = new Size(63, 19);
            label6.TabIndex = 4;
            label6.Text = "Amount";
            label6.Click += label6_Click;
            // 
            // deliverylist_panel
            // 
            deliverylist_panel.Location = new Point(253, 183);
            deliverylist_panel.Name = "deliverylist_panel";
            deliverylist_panel.Size = new Size(1090, 545);
            deliverylist_panel.TabIndex = 3;
            // 
            // riderDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1364, 749);
            Controls.Add(deliverylist_panel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "riderDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard-Rider";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button riderDashboard_button;
        private Button riderDelivery_button;
        private Button riderProfile_button;
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel2;
        private ComboBox area_comboBox;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel deliverylist_panel;
    }
}
namespace EasyDelivery
{
    partial class riderDeliveries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(riderDeliveries));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            riderDelivery_button = new Button();
            riderProfile_button = new Button();
            riderDashboard_button = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 39, 71);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(riderDelivery_button);
            panel1.Controls.Add(riderProfile_button);
            panel1.Controls.Add(riderDashboard_button);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 747);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._437316590_412614248190655_6311576414775504443_n;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 232);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            // riderDeliveries
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 749);
            Controls.Add(panel1);
            Name = "riderDeliveries";
            Text = "Deliveries-Rider";
            Load += riderDeliveries_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button riderDelivery_button;
        private Button riderProfile_button;
        private Button riderDashboard_button;
    }
}
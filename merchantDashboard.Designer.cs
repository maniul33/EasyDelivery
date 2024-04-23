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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(merchantDashboard));
            sidePanel = new Panel();
            logoPanel = new Panel();
            profileButton = new Button();
            profilePicture = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            sidePanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePicture).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.Controls.Add(logoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(250, 803);
            sidePanel.TabIndex = 0;
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
            profileButton.BackColor = Color.FromArgb(15, 161, 219);
            profileButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileButton.ForeColor = Color.White;
            profileButton.Location = new Point(117, 248);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(130, 45);
            profileButton.TabIndex = 1;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += button1_Click;
            // 
            // profilePicture
            // 
            profilePicture.Image = (Image)resources.GetObject("profilePicture.Image");
            profilePicture.Location = new Point(18, 230);
            profilePicture.Name = "profilePicture";
            profilePicture.Size = new Size(85, 85);
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 250);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // merchantDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 803);
            Controls.Add(sidePanel);
            Name = "merchantDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Merchant";
            Load += merchantDashboard_Load;
            sidePanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profilePicture).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel logoPanel;
        private Panel panel1;
        private Button profileButton;
        private PictureBox profilePicture;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}
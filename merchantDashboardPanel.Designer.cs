namespace EasyDelivery
{
    partial class merchantDashboardPanel
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
            allMerchantDataGridView = new DataGridView();
            updateButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)allMerchantDataGridView).BeginInit();
            SuspendLayout();
            // 
            // allMerchantDataGridView
            // 
            allMerchantDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allMerchantDataGridView.Dock = DockStyle.Top;
            allMerchantDataGridView.Location = new Point(0, 0);
            allMerchantDataGridView.Name = "allMerchantDataGridView";
            allMerchantDataGridView.RowHeadersWidth = 51;
            allMerchantDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            allMerchantDataGridView.Size = new Size(1362, 675);
            allMerchantDataGridView.TabIndex = 0;
            allMerchantDataGridView.SelectionChanged += allMerchantDataGridView_SelectionChanged;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(19, 39, 71);
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.ImageAlign = ContentAlignment.MiddleLeft;
            updateButton.Location = new Point(269, 709);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(269, 48);
            updateButton.TabIndex = 2;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(19, 39, 71);
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteButton.Location = new Point(582, 709);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(269, 48);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // merchantDashboardPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 803);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(allMerchantDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "merchantDashboardPanel";
            Text = "merchantDashboardPanel";
            Load += merchantDashboardPanel_Load;
            ((System.ComponentModel.ISupportInitialize)allMerchantDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView allMerchantDataGridView;
        private Button updateButton;
        private Button deleteButton;
    }
}
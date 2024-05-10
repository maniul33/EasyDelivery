namespace EasyDelivery
{
    partial class riderDashboardPanel
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
            riderDataGridView = new DataGridView();
            deleteButton = new Button();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)riderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // riderDataGridView
            // 
            riderDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            riderDataGridView.Dock = DockStyle.Top;
            riderDataGridView.Location = new Point(0, 0);
            riderDataGridView.Name = "riderDataGridView";
            riderDataGridView.RowHeadersWidth = 51;
            riderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            riderDataGridView.Size = new Size(1362, 665);
            riderDataGridView.TabIndex = 0;
            riderDataGridView.SelectionChanged += riderDataGridView_SelectionChanged;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(19, 39, 71);
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.ForeColor = Color.White;
            deleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteButton.Location = new Point(575, 704);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(269, 48);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(19, 39, 71);
            updateButton.FlatAppearance.BorderSize = 0;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateButton.ForeColor = Color.White;
            updateButton.ImageAlign = ContentAlignment.MiddleLeft;
            updateButton.Location = new Point(262, 704);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(269, 48);
            updateButton.TabIndex = 4;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // riderDashboardPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 803);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(riderDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "riderDashboardPanel";
            Text = "riderDashboardPanel";
            ((System.ComponentModel.ISupportInitialize)riderDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView riderDataGridView;
        private Button deleteButton;
        private Button updateButton;
    }
}
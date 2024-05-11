namespace EasyDelivery
{
    partial class adminDeliveriesPanel
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
            deliveryDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)deliveryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // deliveryDataGridView
            // 
            deliveryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            deliveryDataGridView.Dock = DockStyle.Fill;
            deliveryDataGridView.Location = new Point(0, 0);
            deliveryDataGridView.Name = "deliveryDataGridView";
            deliveryDataGridView.RowHeadersWidth = 51;
            deliveryDataGridView.Size = new Size(1380, 850);
            deliveryDataGridView.TabIndex = 0;
            // 
            // adminDeliveriesPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 850);
            Controls.Add(deliveryDataGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminDeliveriesPanel";
            Text = "adminDeliveriesPanel";
            ((System.ComponentModel.ISupportInitialize)deliveryDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView deliveryDataGridView;
    }
}
namespace EasyDelivery
{
    partial class acceptDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acceptDelivery));
            backLabel = new Label();
            FrontLeftPanel = new Panel();
            FrontRightPanel = new Panel();
            bottomRightPanel = new Panel();
            statusLabel = new Label();
            label8 = new Label();
            label20 = new Label();
            label30 = new Label();
            deliveryIdLabel = new Label();
            label29 = new Label();
            productTypeLabel = new Label();
            label23 = new Label();
            weightLabel = new Label();
            label26 = new Label();
            collectAmountLabel = new Label();
            panel1 = new Panel();
            cusZipLabel = new Label();
            label14 = new Label();
            label15 = new Label();
            cusAreaLabel = new Label();
            cusStreetLabel = new Label();
            label18 = new Label();
            cusDistrictLabel = new Label();
            label10 = new Label();
            cusPhoneLabel = new Label();
            cusNameLabel = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            bottomLeftPanel = new Panel();
            cancelledLabel = new Label();
            cancelledIconLabel = new Label();
            deliveredIconLabel = new Label();
            outForDeliveryDoneIconLabel = new Label();
            outForDeliveryGreenTickLabel = new Label();
            outForDeliveryLabel = new Label();
            NotDeliveredCancelledIconLabel = new Label();
            outForDeliveryIconLabel = new Label();
            deliveredLabel = new Label();
            pendingLabel = new Label();
            pendingCheckedIconLabel = new Label();
            label4 = new Label();
            TopPanel = new Panel();
            cancelButton = new Button();
            acceptButton = new Button();
            topStorePhoneLabel = new Label();
            label3 = new Label();
            topStoreNameLabel = new Label();
            topDeliveryLabel = new Label();
            topStatusLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            FrontLeftPanel.SuspendLayout();
            FrontRightPanel.SuspendLayout();
            bottomRightPanel.SuspendLayout();
            panel1.SuspendLayout();
            bottomLeftPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // backLabel
            // 
            backLabel.AutoSize = true;
            backLabel.Cursor = Cursors.Hand;
            backLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backLabel.ForeColor = Color.FromArgb(19, 39, 71);
            backLabel.Image = (Image)resources.GetObject("backLabel.Image");
            backLabel.ImageAlign = ContentAlignment.MiddleLeft;
            backLabel.Location = new Point(27, 11);
            backLabel.Name = "backLabel";
            backLabel.Size = new Size(76, 22);
            backLabel.TabIndex = 41;
            backLabel.Text = "     Back";
            backLabel.Click += backLabel_Click;
            // 
            // FrontLeftPanel
            // 
            FrontLeftPanel.BackColor = Color.White;
            FrontLeftPanel.Controls.Add(FrontRightPanel);
            FrontLeftPanel.Location = new Point(64, 61);
            FrontLeftPanel.Name = "FrontLeftPanel";
            FrontLeftPanel.Size = new Size(1235, 681);
            FrontLeftPanel.TabIndex = 5;
            // 
            // FrontRightPanel
            // 
            FrontRightPanel.BackColor = Color.FromArgb(254, 254, 255);
            FrontRightPanel.Controls.Add(bottomRightPanel);
            FrontRightPanel.Controls.Add(panel1);
            FrontRightPanel.Controls.Add(bottomLeftPanel);
            FrontRightPanel.Controls.Add(TopPanel);
            FrontRightPanel.Controls.Add(backLabel);
            FrontRightPanel.Location = new Point(0, 0);
            FrontRightPanel.Name = "FrontRightPanel";
            FrontRightPanel.Size = new Size(1235, 678);
            FrontRightPanel.TabIndex = 0;
            // 
            // bottomRightPanel
            // 
            bottomRightPanel.BorderStyle = BorderStyle.Fixed3D;
            bottomRightPanel.Controls.Add(statusLabel);
            bottomRightPanel.Controls.Add(label8);
            bottomRightPanel.Controls.Add(label20);
            bottomRightPanel.Controls.Add(label30);
            bottomRightPanel.Controls.Add(deliveryIdLabel);
            bottomRightPanel.Controls.Add(label29);
            bottomRightPanel.Controls.Add(productTypeLabel);
            bottomRightPanel.Controls.Add(label23);
            bottomRightPanel.Controls.Add(weightLabel);
            bottomRightPanel.Controls.Add(label26);
            bottomRightPanel.Controls.Add(collectAmountLabel);
            bottomRightPanel.Location = new Point(847, 57);
            bottomRightPanel.Name = "bottomRightPanel";
            bottomRightPanel.Size = new Size(355, 605);
            bottomRightPanel.TabIndex = 46;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.FromArgb(19, 39, 71);
            statusLabel.Location = new Point(14, 506);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(62, 22);
            statusLabel.TabIndex = 92;
            statusLabel.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(19, 39, 71);
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(14, 13);
            label8.Name = "label8";
            label8.Size = new Size(195, 24);
            label8.TabIndex = 70;
            label8.Text = "Delivery Information";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(19, 39, 71);
            label20.ImageAlign = ContentAlignment.MiddleLeft;
            label20.Location = new Point(14, 471);
            label20.Name = "label20";
            label20.Size = new Size(62, 22);
            label20.TabIndex = 91;
            label20.Text = "Status";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.FromArgb(19, 39, 71);
            label30.Image = (Image)resources.GetObject("label30.Image");
            label30.ImageAlign = ContentAlignment.MiddleLeft;
            label30.Location = new Point(14, 68);
            label30.Name = "label30";
            label30.Size = new Size(141, 22);
            label30.TabIndex = 81;
            label30.Text = "     Product Type";
            // 
            // deliveryIdLabel
            // 
            deliveryIdLabel.AutoSize = true;
            deliveryIdLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryIdLabel.ForeColor = Color.FromArgb(19, 39, 71);
            deliveryIdLabel.Location = new Point(13, 412);
            deliveryIdLabel.Name = "deliveryIdLabel";
            deliveryIdLabel.Size = new Size(98, 22);
            deliveryIdLabel.TabIndex = 90;
            deliveryIdLabel.Text = "Delivery Id";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.FromArgb(19, 39, 71);
            label29.Image = (Image)resources.GetObject("label29.Image");
            label29.ImageAlign = ContentAlignment.MiddleLeft;
            label29.Location = new Point(14, 174);
            label29.Name = "label29";
            label29.Size = new Size(90, 22);
            label29.TabIndex = 82;
            label29.Text = "     Weight";
            // 
            // productTypeLabel
            // 
            productTypeLabel.AutoSize = true;
            productTypeLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productTypeLabel.ForeColor = Color.FromArgb(19, 39, 71);
            productTypeLabel.Location = new Point(14, 105);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new Size(116, 22);
            productTypeLabel.TabIndex = 83;
            productTypeLabel.Text = "Product Type";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(19, 39, 71);
            label23.Image = (Image)resources.GetObject("label23.Image");
            label23.ImageAlign = ContentAlignment.MiddleLeft;
            label23.Location = new Point(14, 379);
            label23.Name = "label23";
            label23.Size = new Size(123, 22);
            label23.TabIndex = 88;
            label23.Text = "     Delivery Id";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            weightLabel.ForeColor = Color.FromArgb(19, 39, 71);
            weightLabel.Location = new Point(14, 209);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(65, 22);
            weightLabel.TabIndex = 84;
            weightLabel.Text = "Weight";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.FromArgb(19, 39, 71);
            label26.Image = (Image)resources.GetObject("label26.Image");
            label26.ImageAlign = ContentAlignment.MiddleLeft;
            label26.Location = new Point(25, 276);
            label26.Name = "label26";
            label26.Size = new Size(159, 22);
            label26.TabIndex = 85;
            label26.Text = "     Collect Amount";
            // 
            // collectAmountLabel
            // 
            collectAmountLabel.AutoSize = true;
            collectAmountLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            collectAmountLabel.ForeColor = Color.FromArgb(19, 39, 71);
            collectAmountLabel.Location = new Point(23, 309);
            collectAmountLabel.Name = "collectAmountLabel";
            collectAmountLabel.Size = new Size(134, 22);
            collectAmountLabel.TabIndex = 86;
            collectAmountLabel.Text = "Collect Amount";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cusZipLabel);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(cusAreaLabel);
            panel1.Controls.Add(cusStreetLabel);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(cusDistrictLabel);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cusPhoneLabel);
            panel1.Controls.Add(cusNameLabel);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(27, 234);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 257);
            panel1.TabIndex = 45;
            // 
            // cusZipLabel
            // 
            cusZipLabel.AutoSize = true;
            cusZipLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusZipLabel.ForeColor = Color.FromArgb(19, 39, 71);
            cusZipLabel.Location = new Point(494, 201);
            cusZipLabel.Name = "cusZipLabel";
            cusZipLabel.Size = new Size(35, 22);
            cusZipLabel.TabIndex = 80;
            cusZipLabel.Text = "Zip";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(19, 39, 71);
            label14.Image = (Image)resources.GetObject("label14.Image");
            label14.ImageAlign = ContentAlignment.MiddleLeft;
            label14.Location = new Point(494, 179);
            label14.Name = "label14";
            label14.Size = new Size(60, 22);
            label14.TabIndex = 79;
            label14.Text = "     Zip";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(19, 39, 71);
            label15.Image = (Image)resources.GetObject("label15.Image");
            label15.ImageAlign = ContentAlignment.MiddleLeft;
            label15.Location = new Point(494, 116);
            label15.Name = "label15";
            label15.Size = new Size(86, 22);
            label15.TabIndex = 78;
            label15.Text = "     Street";
            // 
            // cusAreaLabel
            // 
            cusAreaLabel.AutoSize = true;
            cusAreaLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusAreaLabel.ForeColor = Color.FromArgb(19, 39, 71);
            cusAreaLabel.Location = new Point(493, 76);
            cusAreaLabel.Name = "cusAreaLabel";
            cusAreaLabel.Size = new Size(50, 22);
            cusAreaLabel.TabIndex = 77;
            cusAreaLabel.Text = "Area";
            // 
            // cusStreetLabel
            // 
            cusStreetLabel.AutoSize = true;
            cusStreetLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusStreetLabel.ForeColor = Color.FromArgb(19, 39, 71);
            cusStreetLabel.Location = new Point(493, 138);
            cusStreetLabel.Name = "cusStreetLabel";
            cusStreetLabel.Size = new Size(61, 22);
            cusStreetLabel.TabIndex = 76;
            cusStreetLabel.Text = "Street";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(19, 39, 71);
            label18.Image = (Image)resources.GetObject("label18.Image");
            label18.ImageAlign = ContentAlignment.MiddleLeft;
            label18.Location = new Point(493, 54);
            label18.Name = "label18";
            label18.Size = new Size(75, 22);
            label18.TabIndex = 75;
            label18.Text = "     Area";
            // 
            // cusDistrictLabel
            // 
            cusDistrictLabel.AutoSize = true;
            cusDistrictLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusDistrictLabel.ForeColor = Color.FromArgb(19, 39, 71);
            cusDistrictLabel.Location = new Point(13, 201);
            cusDistrictLabel.Name = "cusDistrictLabel";
            cusDistrictLabel.Size = new Size(70, 22);
            cusDistrictLabel.TabIndex = 74;
            cusDistrictLabel.Text = "District";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(19, 39, 71);
            label10.Image = (Image)resources.GetObject("label10.Image");
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(13, 179);
            label10.Name = "label10";
            label10.Size = new Size(95, 22);
            label10.TabIndex = 73;
            label10.Text = "     District";
            // 
            // cusPhoneLabel
            // 
            cusPhoneLabel.AutoSize = true;
            cusPhoneLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusPhoneLabel.ForeColor = Color.FromArgb(19, 39, 71);
            cusPhoneLabel.Location = new Point(13, 139);
            cusPhoneLabel.Name = "cusPhoneLabel";
            cusPhoneLabel.Size = new Size(61, 22);
            cusPhoneLabel.TabIndex = 72;
            cusPhoneLabel.Text = "Phone";
            // 
            // cusNameLabel
            // 
            cusNameLabel.AutoSize = true;
            cusNameLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cusNameLabel.ForeColor = Color.FromArgb(19, 39, 71);
            cusNameLabel.Location = new Point(12, 76);
            cusNameLabel.Name = "cusNameLabel";
            cusNameLabel.Size = new Size(58, 22);
            cusNameLabel.TabIndex = 71;
            cusNameLabel.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(19, 39, 71);
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(13, 117);
            label7.Name = "label7";
            label7.Size = new Size(86, 22);
            label7.TabIndex = 70;
            label7.Text = "     Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(19, 39, 71);
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(12, 54);
            label6.Name = "label6";
            label6.Size = new Size(83, 22);
            label6.TabIndex = 60;
            label6.Text = "     Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(19, 39, 71);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(12, 13);
            label5.Name = "label5";
            label5.Size = new Size(162, 24);
            label5.TabIndex = 69;
            label5.Text = "Recipient Details";
            // 
            // bottomLeftPanel
            // 
            bottomLeftPanel.BorderStyle = BorderStyle.Fixed3D;
            bottomLeftPanel.Controls.Add(cancelledLabel);
            bottomLeftPanel.Controls.Add(cancelledIconLabel);
            bottomLeftPanel.Controls.Add(deliveredIconLabel);
            bottomLeftPanel.Controls.Add(outForDeliveryDoneIconLabel);
            bottomLeftPanel.Controls.Add(outForDeliveryGreenTickLabel);
            bottomLeftPanel.Controls.Add(outForDeliveryLabel);
            bottomLeftPanel.Controls.Add(NotDeliveredCancelledIconLabel);
            bottomLeftPanel.Controls.Add(outForDeliveryIconLabel);
            bottomLeftPanel.Controls.Add(deliveredLabel);
            bottomLeftPanel.Controls.Add(pendingLabel);
            bottomLeftPanel.Controls.Add(pendingCheckedIconLabel);
            bottomLeftPanel.Controls.Add(label4);
            bottomLeftPanel.Location = new Point(27, 507);
            bottomLeftPanel.Name = "bottomLeftPanel";
            bottomLeftPanel.Size = new Size(796, 155);
            bottomLeftPanel.TabIndex = 44;
            bottomLeftPanel.Paint += bottomLeftPanel_Paint;
            // 
            // cancelledLabel
            // 
            cancelledLabel.AutoSize = true;
            cancelledLabel.Cursor = Cursors.Hand;
            cancelledLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelledLabel.ForeColor = Color.FromArgb(19, 39, 71);
            cancelledLabel.ImageAlign = ContentAlignment.MiddleLeft;
            cancelledLabel.Location = new Point(580, 97);
            cancelledLabel.Name = "cancelledLabel";
            cancelledLabel.Size = new Size(99, 24);
            cancelledLabel.TabIndex = 75;
            cancelledLabel.Text = "Cancelled";
            // 
            // cancelledIconLabel
            // 
            cancelledIconLabel.AutoSize = true;
            cancelledIconLabel.Font = new Font("Californian FB", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelledIconLabel.ForeColor = Color.White;
            cancelledIconLabel.Image = (Image)resources.GetObject("cancelledIconLabel.Image");
            cancelledIconLabel.Location = new Point(611, 43);
            cancelledIconLabel.Name = "cancelledIconLabel";
            cancelledIconLabel.Size = new Size(38, 63);
            cancelledIconLabel.TabIndex = 74;
            cancelledIconLabel.Text = ".";
            // 
            // deliveredIconLabel
            // 
            deliveredIconLabel.AutoSize = true;
            deliveredIconLabel.Font = new Font("Californian FB", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveredIconLabel.ForeColor = Color.White;
            deliveredIconLabel.Image = (Image)resources.GetObject("deliveredIconLabel.Image");
            deliveredIconLabel.Location = new Point(611, 43);
            deliveredIconLabel.Name = "deliveredIconLabel";
            deliveredIconLabel.Size = new Size(38, 63);
            deliveredIconLabel.TabIndex = 73;
            deliveredIconLabel.Text = ".";
            // 
            // outForDeliveryDoneIconLabel
            // 
            outForDeliveryDoneIconLabel.AutoSize = true;
            outForDeliveryDoneIconLabel.Font = new Font("Californian FB", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outForDeliveryDoneIconLabel.ForeColor = Color.White;
            outForDeliveryDoneIconLabel.Image = (Image)resources.GetObject("outForDeliveryDoneIconLabel.Image");
            outForDeliveryDoneIconLabel.Location = new Point(370, 43);
            outForDeliveryDoneIconLabel.Name = "outForDeliveryDoneIconLabel";
            outForDeliveryDoneIconLabel.Size = new Size(38, 63);
            outForDeliveryDoneIconLabel.TabIndex = 72;
            outForDeliveryDoneIconLabel.Text = ".";
            // 
            // outForDeliveryGreenTickLabel
            // 
            outForDeliveryGreenTickLabel.AutoSize = true;
            outForDeliveryGreenTickLabel.Font = new Font("Californian FB", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outForDeliveryGreenTickLabel.ForeColor = Color.White;
            outForDeliveryGreenTickLabel.Image = (Image)resources.GetObject("outForDeliveryGreenTickLabel.Image");
            outForDeliveryGreenTickLabel.Location = new Point(370, 43);
            outForDeliveryGreenTickLabel.Name = "outForDeliveryGreenTickLabel";
            outForDeliveryGreenTickLabel.Size = new Size(38, 63);
            outForDeliveryGreenTickLabel.TabIndex = 71;
            outForDeliveryGreenTickLabel.Text = ".";
            // 
            // outForDeliveryLabel
            // 
            outForDeliveryLabel.AutoSize = true;
            outForDeliveryLabel.Cursor = Cursors.Hand;
            outForDeliveryLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outForDeliveryLabel.ForeColor = Color.FromArgb(19, 39, 71);
            outForDeliveryLabel.ImageAlign = ContentAlignment.MiddleLeft;
            outForDeliveryLabel.Location = new Point(315, 97);
            outForDeliveryLabel.Name = "outForDeliveryLabel";
            outForDeliveryLabel.Size = new Size(157, 24);
            outForDeliveryLabel.TabIndex = 64;
            outForDeliveryLabel.Text = "Out For Delivery";
            // 
            // NotDeliveredCancelledIconLabel
            // 
            NotDeliveredCancelledIconLabel.AutoSize = true;
            NotDeliveredCancelledIconLabel.Font = new Font("Californian FB", 31.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            NotDeliveredCancelledIconLabel.ForeColor = Color.White;
            NotDeliveredCancelledIconLabel.Image = (Image)resources.GetObject("NotDeliveredCancelledIconLabel.Image");
            NotDeliveredCancelledIconLabel.Location = new Point(611, 43);
            NotDeliveredCancelledIconLabel.Name = "NotDeliveredCancelledIconLabel";
            NotDeliveredCancelledIconLabel.Size = new Size(35, 63);
            NotDeliveredCancelledIconLabel.TabIndex = 69;
            NotDeliveredCancelledIconLabel.Text = ".";
            // 
            // outForDeliveryIconLabel
            // 
            outForDeliveryIconLabel.AutoSize = true;
            outForDeliveryIconLabel.Font = new Font("Californian FB", 31.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            outForDeliveryIconLabel.ForeColor = Color.White;
            outForDeliveryIconLabel.Image = (Image)resources.GetObject("outForDeliveryIconLabel.Image");
            outForDeliveryIconLabel.Location = new Point(370, 43);
            outForDeliveryIconLabel.Name = "outForDeliveryIconLabel";
            outForDeliveryIconLabel.Size = new Size(35, 63);
            outForDeliveryIconLabel.TabIndex = 67;
            outForDeliveryIconLabel.Text = ".";
            // 
            // deliveredLabel
            // 
            deliveredLabel.AutoSize = true;
            deliveredLabel.Cursor = Cursors.Hand;
            deliveredLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveredLabel.ForeColor = Color.FromArgb(19, 39, 71);
            deliveredLabel.ImageAlign = ContentAlignment.MiddleLeft;
            deliveredLabel.Location = new Point(580, 97);
            deliveredLabel.Name = "deliveredLabel";
            deliveredLabel.Size = new Size(97, 24);
            deliveredLabel.TabIndex = 65;
            deliveredLabel.Text = "Delivered";
            // 
            // pendingLabel
            // 
            pendingLabel.AutoSize = true;
            pendingLabel.Cursor = Cursors.Hand;
            pendingLabel.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingLabel.ForeColor = Color.FromArgb(19, 39, 71);
            pendingLabel.ImageAlign = ContentAlignment.MiddleLeft;
            pendingLabel.Location = new Point(127, 97);
            pendingLabel.Name = "pendingLabel";
            pendingLabel.Size = new Size(81, 24);
            pendingLabel.TabIndex = 63;
            pendingLabel.Text = "Pending";
            // 
            // pendingCheckedIconLabel
            // 
            pendingCheckedIconLabel.AutoSize = true;
            pendingCheckedIconLabel.Font = new Font("Californian FB", 31.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingCheckedIconLabel.ForeColor = Color.White;
            pendingCheckedIconLabel.Image = (Image)resources.GetObject("pendingCheckedIconLabel.Image");
            pendingCheckedIconLabel.Location = new Point(149, 43);
            pendingCheckedIconLabel.Name = "pendingCheckedIconLabel";
            pendingCheckedIconLabel.Size = new Size(38, 63);
            pendingCheckedIconLabel.TabIndex = 60;
            pendingCheckedIconLabel.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(19, 39, 71);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(86, 24);
            label4.TabIndex = 44;
            label4.Text = "Timeline";
            // 
            // TopPanel
            // 
            TopPanel.BorderStyle = BorderStyle.Fixed3D;
            TopPanel.Controls.Add(cancelButton);
            TopPanel.Controls.Add(acceptButton);
            TopPanel.Controls.Add(topStorePhoneLabel);
            TopPanel.Controls.Add(label3);
            TopPanel.Controls.Add(topStoreNameLabel);
            TopPanel.Controls.Add(topDeliveryLabel);
            TopPanel.Controls.Add(topStatusLabel);
            TopPanel.Controls.Add(label2);
            TopPanel.Controls.Add(label1);
            TopPanel.Controls.Add(label11);
            TopPanel.Location = new Point(27, 57);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(796, 162);
            TopPanel.TabIndex = 43;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(19, 39, 71);
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelButton.ForeColor = Color.White;
            cancelButton.ImageAlign = ContentAlignment.MiddleLeft;
            cancelButton.Location = new Point(637, 92);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(131, 48);
            cancelButton.TabIndex = 65;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = Color.FromArgb(19, 39, 71);
            acceptButton.FlatAppearance.BorderSize = 0;
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Font = new Font("Bahnschrift", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            acceptButton.ForeColor = Color.White;
            acceptButton.ImageAlign = ContentAlignment.MiddleLeft;
            acceptButton.Location = new Point(637, 91);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(131, 48);
            acceptButton.TabIndex = 44;
            acceptButton.Text = "Accept";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // topStorePhoneLabel
            // 
            topStorePhoneLabel.AutoSize = true;
            topStorePhoneLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topStorePhoneLabel.ForeColor = Color.FromArgb(19, 39, 71);
            topStorePhoneLabel.ImageAlign = ContentAlignment.MiddleLeft;
            topStorePhoneLabel.Location = new Point(329, 117);
            topStorePhoneLabel.Name = "topStorePhoneLabel";
            topStorePhoneLabel.Size = new Size(60, 22);
            topStorePhoneLabel.TabIndex = 64;
            topStorePhoneLabel.Text = "phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(19, 39, 71);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(140, 22);
            label3.TabIndex = 63;
            label3.Text = "      Store phone";
            // 
            // topStoreNameLabel
            // 
            topStoreNameLabel.AutoSize = true;
            topStoreNameLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topStoreNameLabel.ForeColor = Color.FromArgb(19, 39, 71);
            topStoreNameLabel.ImageAlign = ContentAlignment.MiddleLeft;
            topStoreNameLabel.Location = new Point(329, 82);
            topStoreNameLabel.Name = "topStoreNameLabel";
            topStoreNameLabel.Size = new Size(55, 22);
            topStoreNameLabel.TabIndex = 62;
            topStoreNameLabel.Text = "Store";
            // 
            // topDeliveryLabel
            // 
            topDeliveryLabel.AutoSize = true;
            topDeliveryLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topDeliveryLabel.ForeColor = Color.FromArgb(19, 39, 71);
            topDeliveryLabel.Location = new Point(329, 48);
            topDeliveryLabel.Name = "topDeliveryLabel";
            topDeliveryLabel.Size = new Size(98, 22);
            topDeliveryLabel.TabIndex = 61;
            topDeliveryLabel.Text = "Delivery id";
            // 
            // topStatusLabel
            // 
            topStatusLabel.AutoSize = true;
            topStatusLabel.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            topStatusLabel.ForeColor = Color.FromArgb(19, 39, 71);
            topStatusLabel.Location = new Point(329, 15);
            topStatusLabel.Name = "topStatusLabel";
            topStatusLabel.Size = new Size(62, 22);
            topStatusLabel.TabIndex = 60;
            topStatusLabel.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(19, 39, 71);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(85, 22);
            label2.TabIndex = 59;
            label2.Text = "      Store";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(19, 39, 71);
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 58;
            label1.Text = "Delivery id";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(19, 39, 71);
            label11.Location = new Point(12, 15);
            label11.Name = "label11";
            label11.Size = new Size(62, 22);
            label11.TabIndex = 57;
            label11.Text = "Status";
            // 
            // acceptDelivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 39, 71);
            ClientSize = new Size(1362, 803);
            Controls.Add(FrontLeftPanel);
            Name = "acceptDelivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AcceptDelivery";
            FrontLeftPanel.ResumeLayout(false);
            FrontRightPanel.ResumeLayout(false);
            FrontRightPanel.PerformLayout();
            bottomRightPanel.ResumeLayout(false);
            bottomRightPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            bottomLeftPanel.ResumeLayout(false);
            bottomLeftPanel.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label backLabel;
        private Panel FrontLeftPanel;
        private Panel FrontRightPanel;
        private Panel TopPanel;
        private Label topStoreNameLabel;
        private Label topDeliveryLabel;
        private Label topStatusLabel;
        private Label label2;
        private Label label1;
        private Label label11;
        private Label topStorePhoneLabel;
        private Label label3;
        private Button acceptButton;
        private Panel bottomLeftPanel;
        private Label outForDeliveryLabel;
        private Label NotDeliveredCancelledIconLabel;
        private Label outForDeliveryIconLabel;
        private Label deliveredLabel;
        private Label pendingLabel;
        private Label pendingCheckedIconLabel;
        private Label label4;
        private Panel panel1;
        private Label cusZipLabel;
        private Label label14;
        private Label label15;
        private Label cusAreaLabel;
        private Label cusStreetLabel;
        private Label label18;
        private Label cusDistrictLabel;
        private Label label10;
        private Label cusPhoneLabel;
        private Label cusNameLabel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel bottomRightPanel;
        private Label statusLabel;
        private Label label8;
        private Label label20;
        private Label label30;
        private Label deliveryIdLabel;
        private Label label29;
        private Label productTypeLabel;
        private Label label23;
        private Label weightLabel;
        private Label label26;
        private Label collectAmountLabel;
        private Button cancelButton;
        private Label outForDeliveryGreenTickLabel;
        private Label outForDeliveryDoneIconLabel;
        private Label deliveredIconLabel;
        private Label cancelledIconLabel;
        private Label cancelledLabel;
    }
}
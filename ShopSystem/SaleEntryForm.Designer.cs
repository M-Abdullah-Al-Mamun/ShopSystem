namespace ShopSystem
{
    partial class SaleEntryForm
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
            this.btnBackfromSE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPcodeSaleEntrySearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPpriceShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPnameShow = new System.Windows.Forms.TextBox();
            this.txtPcodeShow = new System.Windows.Forms.TextBox();
            this.lblcode = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPquantityShow = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gridSaleEntry = new System.Windows.Forms.DataGridView();
            this.ProduceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtAddedQuantity = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleEntry)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackfromSE
            // 
            this.btnBackfromSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackfromSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBackfromSE.Location = new System.Drawing.Point(821, 535);
            this.btnBackfromSE.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackfromSE.Name = "btnBackfromSE";
            this.btnBackfromSE.Size = new System.Drawing.Size(137, 46);
            this.btnBackfromSE.TabIndex = 7;
            this.btnBackfromSE.Text = "Back";
            this.btnBackfromSE.UseVisualStyleBackColor = false;
            this.btnBackfromSE.Click += new System.EventHandler(this.btnBackfromSE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 91);
            this.panel1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(13, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 32);
            this.label11.TabIndex = 7;
            this.label11.Text = "Sale Dashboard";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAddedQuantity);
            this.panel2.Controls.Add(this.lblDetails);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPcodeSaleEntrySearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtPpriceShow);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPnameShow);
            this.panel2.Controls.Add(this.txtPcodeShow);
            this.panel2.Controls.Add(this.lblcode);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtPquantityShow);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 503);
            this.panel2.TabIndex = 9;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDetails.Location = new System.Drawing.Point(59, 256);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(182, 26);
            this.lblDetails.TabIndex = 14;
            this.lblDetails.Text = "Product Details:";
            this.lblDetails.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(61, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product Quantity";
            // 
            // txtPcodeSaleEntrySearch
            // 
            this.txtPcodeSaleEntrySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcodeSaleEntrySearch.Location = new System.Drawing.Point(51, 46);
            this.txtPcodeSaleEntrySearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtPcodeSaleEntrySearch.Name = "txtPcodeSaleEntrySearch";
            this.txtPcodeSaleEntrySearch.Size = new System.Drawing.Size(220, 27);
            this.txtPcodeSaleEntrySearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(105, 78);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 32);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPpriceShow
            // 
            this.txtPpriceShow.Enabled = false;
            this.txtPpriceShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPpriceShow.Location = new System.Drawing.Point(142, 394);
            this.txtPpriceShow.Margin = new System.Windows.Forms.Padding(4);
            this.txtPpriceShow.Name = "txtPpriceShow";
            this.txtPpriceShow.Size = new System.Drawing.Size(139, 28);
            this.txtPpriceShow.TabIndex = 11;
            this.txtPpriceShow.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Code";
            // 
            // txtPnameShow
            // 
            this.txtPnameShow.Enabled = false;
            this.txtPnameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPnameShow.Location = new System.Drawing.Point(142, 350);
            this.txtPnameShow.Margin = new System.Windows.Forms.Padding(4);
            this.txtPnameShow.Name = "txtPnameShow";
            this.txtPnameShow.Size = new System.Drawing.Size(139, 28);
            this.txtPnameShow.TabIndex = 10;
            this.txtPnameShow.Visible = false;
            // 
            // txtPcodeShow
            // 
            this.txtPcodeShow.Enabled = false;
            this.txtPcodeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcodeShow.Location = new System.Drawing.Point(142, 304);
            this.txtPcodeShow.Margin = new System.Windows.Forms.Padding(4);
            this.txtPcodeShow.Name = "txtPcodeShow";
            this.txtPcodeShow.Size = new System.Drawing.Size(139, 28);
            this.txtPcodeShow.TabIndex = 9;
            this.txtPcodeShow.Visible = false;
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcode.Location = new System.Drawing.Point(31, 299);
            this.lblcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(68, 26);
            this.lblcode.TabIndex = 8;
            this.lblcode.Text = "Code";
            this.lblcode.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(103, 193);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPquantityShow
            // 
            this.txtPquantityShow.Enabled = false;
            this.txtPquantityShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPquantityShow.Location = new System.Drawing.Point(142, 438);
            this.txtPquantityShow.Margin = new System.Windows.Forms.Padding(4);
            this.txtPquantityShow.Name = "txtPquantityShow";
            this.txtPquantityShow.Size = new System.Drawing.Size(139, 28);
            this.txtPquantityShow.TabIndex = 5;
            this.txtPquantityShow.Visible = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuantity.Location = new System.Drawing.Point(31, 435);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(99, 26);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "In Stock";
            this.lblQuantity.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(31, 390);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 26);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            this.lblPrice.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(31, 347);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // gridSaleEntry
            // 
            this.gridSaleEntry.AllowUserToAddRows = false;
            this.gridSaleEntry.AllowUserToDeleteRows = false;
            this.gridSaleEntry.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridSaleEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSaleEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProduceCode,
            this.ProduceName,
            this.Price,
            this.Quantity,
            this.TotalPrice});
            this.gridSaleEntry.Location = new System.Drawing.Point(313, 90);
            this.gridSaleEntry.Name = "gridSaleEntry";
            this.gridSaleEntry.ReadOnly = true;
            this.gridSaleEntry.RowHeadersWidth = 51;
            this.gridSaleEntry.RowTemplate.Height = 24;
            this.gridSaleEntry.Size = new System.Drawing.Size(819, 360);
            this.gridSaleEntry.TabIndex = 10;
            // 
            // ProduceCode
            // 
            this.ProduceCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProduceCode.HeaderText = "Produce Code";
            this.ProduceCode.MinimumWidth = 6;
            this.ProduceCode.Name = "ProduceCode";
            this.ProduceCode.ReadOnly = true;
            // 
            // ProduceName
            // 
            this.ProduceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProduceName.HeaderText = "Produce Name";
            this.ProduceName.MinimumWidth = 6;
            this.ProduceName.Name = "ProduceName";
            this.ProduceName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Unit Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSave.Location = new System.Drawing.Point(966, 535);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 46);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.txtGrandTotal);
            this.panel3.Controls.Add(this.lblGrandTotal);
            this.panel3.Location = new System.Drawing.Point(313, 441);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 72);
            this.panel3.TabIndex = 12;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGrandTotal.Location = new System.Drawing.Point(542, 22);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(126, 20);
            this.lblGrandTotal.TabIndex = 15;
            this.lblGrandTotal.Text = "Grand Total : ";
            this.lblGrandTotal.Visible = false;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtGrandTotal.Location = new System.Drawing.Point(684, 19);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(114, 27);
            this.txtGrandTotal.TabIndex = 16;
            this.txtGrandTotal.Visible = false;
            // 
            // txtAddedQuantity
            // 
            this.txtAddedQuantity.Enabled = false;
            this.txtAddedQuantity.FormattingEnabled = true;
            this.txtAddedQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.txtAddedQuantity.Location = new System.Drawing.Point(51, 159);
            this.txtAddedQuantity.Name = "txtAddedQuantity";
            this.txtAddedQuantity.Size = new System.Drawing.Size(220, 28);
            this.txtAddedQuantity.TabIndex = 15;
            this.txtAddedQuantity.SelectedIndexChanged += new System.EventHandler(this.txtAddedQuantity_SelectedIndexChanged);
            // 
            // SaleEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 594);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gridSaleEntry);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackfromSE);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaleEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleEntryForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleEntry)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBackfromSE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPquantityShow;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPpriceShow;
        private System.Windows.Forms.TextBox txtPnameShow;
        private System.Windows.Forms.TextBox txtPcodeShow;
        private System.Windows.Forms.DataGridView gridSaleEntry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPcodeSaleEntrySearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.ComboBox txtAddedQuantity;
    }
}
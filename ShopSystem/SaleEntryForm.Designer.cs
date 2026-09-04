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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.lblQuantitu = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProduceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel2.Controls.Add(this.lblDetails);
            this.panel2.Controls.Add(this.textBox1);
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
            this.panel2.Controls.Add(this.lblQuantitu);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 503);
            this.panel2.TabIndex = 9;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDetails.Location = new System.Drawing.Point(82, 256);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(175, 26);
            this.lblDetails.TabIndex = 14;
            this.lblDetails.Text = "Product Details";
            this.lblDetails.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(72, 158);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 27);
            this.textBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(82, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product Quantity";
            // 
            // txtPcodeSaleEntrySearch
            // 
            this.txtPcodeSaleEntrySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPcodeSaleEntrySearch.Location = new System.Drawing.Point(72, 46);
            this.txtPcodeSaleEntrySearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtPcodeSaleEntrySearch.Name = "txtPcodeSaleEntrySearch";
            this.txtPcodeSaleEntrySearch.Size = new System.Drawing.Size(220, 27);
            this.txtPcodeSaleEntrySearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(126, 78);
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
            this.txtPpriceShow.Location = new System.Drawing.Point(163, 394);
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
            this.label1.Location = new System.Drawing.Point(96, 17);
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
            this.txtPnameShow.Location = new System.Drawing.Point(163, 350);
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
            this.txtPcodeShow.Location = new System.Drawing.Point(163, 304);
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
            this.lblcode.Location = new System.Drawing.Point(52, 299);
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
            this.btnAdd.Location = new System.Drawing.Point(124, 188);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtPquantityShow
            // 
            this.txtPquantityShow.Enabled = false;
            this.txtPquantityShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPquantityShow.Location = new System.Drawing.Point(163, 438);
            this.txtPquantityShow.Margin = new System.Windows.Forms.Padding(4);
            this.txtPquantityShow.Name = "txtPquantityShow";
            this.txtPquantityShow.Size = new System.Drawing.Size(139, 28);
            this.txtPquantityShow.TabIndex = 5;
            this.txtPquantityShow.Visible = false;
            // 
            // lblQuantitu
            // 
            this.lblQuantitu.AutoSize = true;
            this.lblQuantitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantitu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuantitu.Location = new System.Drawing.Point(52, 435);
            this.lblQuantitu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantitu.Name = "lblQuantitu";
            this.lblQuantitu.Size = new System.Drawing.Size(99, 26);
            this.lblQuantitu.TabIndex = 4;
            this.lblQuantitu.Text = "In Stock";
            this.lblQuantitu.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(52, 390);
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
            this.lblName.Location = new System.Drawing.Point(52, 347);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProduceCode,
            this.ProduceName,
            this.Price,
            this.Quantity,
            this.TotalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(368, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 421);
            this.dataGridView1.TabIndex = 10;
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
            this.TotalPrice.HeaderText = "Total Price";
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
            // SaleEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1132, 594);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackfromSE);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaleEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaleEntryForm_FormClosing);
            this.Load += new System.EventHandler(this.SaleEntryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label lblQuantitu;
        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPpriceShow;
        private System.Windows.Forms.TextBox txtPnameShow;
        private System.Windows.Forms.TextBox txtPcodeShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPcodeSaleEntrySearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDetails;
    }
}
namespace ShopSystem
{
    partial class SaleSummaryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.gridSaleSummary = new System.Windows.Forms.DataGridView();
            this.SalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesDateandTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salesquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSelesAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBackfromSE = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleSummary)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 84);
            this.panel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(10, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 26);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sale Summary bord";
            // 
            // gridSaleSummary
            // 
            this.gridSaleSummary.AllowUserToAddRows = false;
            this.gridSaleSummary.AllowUserToDeleteRows = false;
            this.gridSaleSummary.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridSaleSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSaleSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesId,
            this.SalesDateandTime,
            this.Salesquantity,
            this.TotalSelesAmount});
            this.gridSaleSummary.Location = new System.Drawing.Point(0, 84);
            this.gridSaleSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridSaleSummary.Name = "gridSaleSummary";
            this.gridSaleSummary.ReadOnly = true;
            this.gridSaleSummary.RowHeadersWidth = 51;
            this.gridSaleSummary.RowTemplate.Height = 24;
            this.gridSaleSummary.Size = new System.Drawing.Size(800, 331);
            this.gridSaleSummary.TabIndex = 3;
            this.gridSaleSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SalesId
            // 
            this.SalesId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesId.DataPropertyName = "SalesId";
            this.SalesId.HeaderText = "Sales Id";
            this.SalesId.MinimumWidth = 6;
            this.SalesId.Name = "SalesId";
            this.SalesId.ReadOnly = true;
            // 
            // SalesDateandTime
            // 
            this.SalesDateandTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesDateandTime.DataPropertyName = "SalesDateandTime";
            this.SalesDateandTime.HeaderText = "Sales Date and Time";
            this.SalesDateandTime.MinimumWidth = 6;
            this.SalesDateandTime.Name = "SalesDateandTime";
            this.SalesDateandTime.ReadOnly = true;
            // 
            // Salesquantity
            // 
            this.Salesquantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salesquantity.DataPropertyName = "SalesQuantity";
            this.Salesquantity.HeaderText = "Sales Quantity";
            this.Salesquantity.MinimumWidth = 6;
            this.Salesquantity.Name = "Salesquantity";
            this.Salesquantity.ReadOnly = true;
            // 
            // TotalSelesAmount
            // 
            this.TotalSelesAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalSelesAmount.DataPropertyName = "TotalSalesAmount";
            this.TotalSelesAmount.HeaderText = "Total Sales Amount (BDT)";
            this.TotalSelesAmount.MinimumWidth = 6;
            this.TotalSelesAmount.Name = "TotalSelesAmount";
            this.TotalSelesAmount.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnBackfromSE);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 51);
            this.panel2.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPrint.Location = new System.Drawing.Point(689, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 37);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnBackfromSE
            // 
            this.btnBackfromSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackfromSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnBackfromSE.Location = new System.Drawing.Point(578, 9);
            this.btnBackfromSE.Name = "btnBackfromSE";
            this.btnBackfromSE.Size = new System.Drawing.Size(103, 37);
            this.btnBackfromSE.TabIndex = 8;
            this.btnBackfromSE.Text = "Back";
            this.btnBackfromSE.UseVisualStyleBackColor = false;
            this.btnBackfromSE.Click += new System.EventHandler(this.btnBackfromSE_Click);
            // 
            // SaleSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gridSaleSummary);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SaleSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale Summary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SaleSummaryForm_FormClosed);
            this.Load += new System.EventHandler(this.SaleSummaryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSaleSummary)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView gridSaleSummary;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBackfromSE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesDateandTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salesquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSelesAmount;
    }
}
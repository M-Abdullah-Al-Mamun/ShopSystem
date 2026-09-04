namespace ShopSystem
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.btnSaleDetails = new System.Windows.Forms.Button();
            this.btnSaleEntry = new System.Windows.Forms.Button();
            this.btnShowData = new System.Windows.Forms.Button();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prdouctcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaleSummary = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridShowData = new System.Windows.Forms.DataGridView();
            this.txtExit = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManagerUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaleDetails
            // 
            this.btnSaleDetails.Location = new System.Drawing.Point(19, 370);
            this.btnSaleDetails.Name = "btnSaleDetails";
            this.btnSaleDetails.Size = new System.Drawing.Size(118, 45);
            this.btnSaleDetails.TabIndex = 14;
            this.btnSaleDetails.Text = "Sale Details";
            this.btnSaleDetails.UseVisualStyleBackColor = true;
            // 
            // btnSaleEntry
            // 
            this.btnSaleEntry.Location = new System.Drawing.Point(19, 218);
            this.btnSaleEntry.Name = "btnSaleEntry";
            this.btnSaleEntry.Size = new System.Drawing.Size(118, 45);
            this.btnSaleEntry.TabIndex = 12;
            this.btnSaleEntry.Text = "Sale Entry";
            this.btnSaleEntry.UseVisualStyleBackColor = true;
            this.btnSaleEntry.Click += new System.EventHandler(this.btnSaleEntry_Click);
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(19, 147);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(118, 45);
            this.btnShowData.TabIndex = 11;
            this.btnShowData.Text = "Show Product List";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Productname
            // 
            this.Productname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Productname.DataPropertyName = "ProductName";
            this.Productname.HeaderText = "Prdouct Name";
            this.Productname.MinimumWidth = 6;
            this.Productname.Name = "Productname";
            this.Productname.ReadOnly = true;
            // 
            // Prdouctcode
            // 
            this.Prdouctcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prdouctcode.DataPropertyName = "ProductCode";
            this.Prdouctcode.HeaderText = "Prdouct Code";
            this.Prdouctcode.MinimumWidth = 6;
            this.Prdouctcode.Name = "Prdouctcode";
            this.Prdouctcode.ReadOnly = true;
            // 
            // btnSaleSummary
            // 
            this.btnSaleSummary.Location = new System.Drawing.Point(19, 294);
            this.btnSaleSummary.Name = "btnSaleSummary";
            this.btnSaleSummary.Size = new System.Drawing.Size(118, 45);
            this.btnSaleSummary.TabIndex = 13;
            this.btnSaleSummary.Text = "Sale Summary";
            this.btnSaleSummary.UseVisualStyleBackColor = true;
            this.btnSaleSummary.Click += new System.EventHandler(this.btnSaleSummary_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(330, 455);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 27);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // gridShowData
            // 
            this.gridShowData.AllowUserToAddRows = false;
            this.gridShowData.AllowUserToDeleteRows = false;
            this.gridShowData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Prdouctcode,
            this.Productname,
            this.Price,
            this.Quantity});
            this.gridShowData.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridShowData.Location = new System.Drawing.Point(0, -1);
            this.gridShowData.Name = "gridShowData";
            this.gridShowData.ReadOnly = true;
            this.gridShowData.RowHeadersWidth = 51;
            this.gridShowData.RowTemplate.Height = 24;
            this.gridShowData.Size = new System.Drawing.Size(954, 453);
            this.gridShowData.TabIndex = 0;
            // 
            // txtExit
            // 
            this.txtExit.BackColor = System.Drawing.Color.Red;
            this.txtExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExit.Location = new System.Drawing.Point(1019, 5);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(90, 32);
            this.txtExit.TabIndex = 8;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = false;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // btnout
            // 
            this.btnout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnout.Location = new System.Drawing.Point(923, 5);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(90, 32);
            this.btnout.TabIndex = 7;
            this.btnout.Text = "Logout";
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblManagerUsername
            // 
            this.lblManagerUsername.AutoSize = true;
            this.lblManagerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerUsername.ForeColor = System.Drawing.Color.Transparent;
            this.lblManagerUsername.Location = new System.Drawing.Point(52, 15);
            this.lblManagerUsername.Name = "lblManagerUsername";
            this.lblManagerUsername.Size = new System.Drawing.Size(109, 22);
            this.lblManagerUsername.TabIndex = 3;
            this.lblManagerUsername.Text = "User Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.txtExit);
            this.panel2.Controls.Add(this.btnout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblManagerUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 44);
            this.panel2.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(171, 458);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 24);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(2, 457);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(148, 22);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search Product";
            this.lblSearch.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(991, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(118, 34);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Manager Window";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.gridShowData);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.lblSearch);
            this.panel3.Location = new System.Drawing.Point(167, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 489);
            this.panel3.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 109);
            this.panel1.TabIndex = 8;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 642);
            this.Controls.Add(this.btnSaleDetails);
            this.Controls.Add(this.btnSaleEntry);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.btnSaleSummary);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaleDetails;
        private System.Windows.Forms.Button btnSaleEntry;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prdouctcode;
        private System.Windows.Forms.Button btnSaleSummary;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView gridShowData;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManagerUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}
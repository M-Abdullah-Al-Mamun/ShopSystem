namespace ShopSystem
{
    partial class AdminForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productEntryStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productUpdateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProductListStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salePunchStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleSummaryStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReceiveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StackStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlAddMember = new System.Windows.Forms.Panel();
            this.btnBackfromAddMember = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlAddMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 453);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Controls.Add(this.menuStrip3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 405);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterSetupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 80);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(238, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterSetupToolStripMenuItem
            // 
            this.masterSetupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.masterSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productEntryStripMenuItem,
            this.productUpdateStripMenuItem,
            this.allProductListStripMenuItem});
            this.masterSetupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.masterSetupToolStripMenuItem.Name = "masterSetupToolStripMenuItem";
            this.masterSetupToolStripMenuItem.Size = new System.Drawing.Size(168, 36);
            this.masterSetupToolStripMenuItem.Text = "Master Setup";
            this.masterSetupToolStripMenuItem.Click += new System.EventHandler(this.masterSetupToolStripMenuItem_Click);
            // 
            // productEntryStripMenuItem
            // 
            this.productEntryStripMenuItem.Name = "productEntryStripMenuItem";
            this.productEntryStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.productEntryStripMenuItem.Text = "Product Entry";
            this.productEntryStripMenuItem.Click += new System.EventHandler(this.productEntryStripMenuItem_Click);
            // 
            // productUpdateStripMenuItem
            // 
            this.productUpdateStripMenuItem.Name = "productUpdateStripMenuItem";
            this.productUpdateStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.productUpdateStripMenuItem.Text = "Product Update";
            // 
            // allProductListStripMenuItem
            // 
            this.allProductListStripMenuItem.Name = "allProductListStripMenuItem";
            this.allProductListStripMenuItem.Size = new System.Drawing.Size(254, 36);
            this.allProductListStripMenuItem.Text = "All Product List";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(51, 328);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 40);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(238, 40);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salePunchStripMenuItem,
            this.saleSummaryStripMenuItem});
            this.saleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(70, 36);
            this.saleToolStripMenuItem.Text = "Sale";
            // 
            // salePunchStripMenuItem
            // 
            this.salePunchStripMenuItem.Name = "salePunchStripMenuItem";
            this.salePunchStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.salePunchStripMenuItem.Text = "Sale Entry";
            this.salePunchStripMenuItem.Click += new System.EventHandler(this.salePunchStripMenuItem_Click);
            // 
            // saleSummaryStripMenuItem
            // 
            this.saleSummaryStripMenuItem.Name = "saleSummaryStripMenuItem";
            this.saleSummaryStripMenuItem.Size = new System.Drawing.Size(240, 36);
            this.saleSummaryStripMenuItem.Text = "Sale Summary";
            this.saleSummaryStripMenuItem.Click += new System.EventHandler(this.saleSummaryStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(238, 40);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productReceiveStripMenuItem,
            this.StackStripMenuItem});
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // productReceiveStripMenuItem
            // 
            this.productReceiveStripMenuItem.Name = "productReceiveStripMenuItem";
            this.productReceiveStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.productReceiveStripMenuItem.Text = "Product Receive ";
            this.productReceiveStripMenuItem.Click += new System.EventHandler(this.productReceiveStripMenuItem_Click);
            // 
            // StackStripMenuItem
            // 
            this.StackStripMenuItem.Name = "StackStripMenuItem";
            this.StackStripMenuItem.Size = new System.Drawing.Size(265, 36);
            this.StackStripMenuItem.Text = "Stock ";
            this.StackStripMenuItem.Click += new System.EventHandler(this.StackStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.linkLabel1.Location = new System.Drawing.Point(74, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 25);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Menue";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(238, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(592, 112);
            this.panel3.TabIndex = 2;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.linkLabel2.Location = new System.Drawing.Point(230, 40);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(156, 25);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Welcome Admin";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.pnlAddMember);
            this.panel4.Controls.Add(this.btnAddMember);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(238, 110);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(592, 343);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pnlAddMember
            // 
            this.pnlAddMember.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlAddMember.Controls.Add(this.btnBackfromAddMember);
            this.pnlAddMember.Controls.Add(this.btnAdd);
            this.pnlAddMember.Controls.Add(this.btnClear);
            this.pnlAddMember.Controls.Add(this.linkLabel3);
            this.pnlAddMember.Controls.Add(this.txtRole);
            this.pnlAddMember.Controls.Add(this.txtPassword);
            this.pnlAddMember.Controls.Add(this.txtName);
            this.pnlAddMember.Controls.Add(this.txtId);
            this.pnlAddMember.Controls.Add(this.label8);
            this.pnlAddMember.Controls.Add(this.label6);
            this.pnlAddMember.Controls.Add(this.label4);
            this.pnlAddMember.Controls.Add(this.label1);
            this.pnlAddMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddMember.Location = new System.Drawing.Point(0, 0);
            this.pnlAddMember.Name = "pnlAddMember";
            this.pnlAddMember.Size = new System.Drawing.Size(592, 343);
            this.pnlAddMember.TabIndex = 14;
            this.pnlAddMember.Visible = false;
            // 
            // btnBackfromAddMember
            // 
            this.btnBackfromAddMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackfromAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBackfromAddMember.Location = new System.Drawing.Point(467, 276);
            this.btnBackfromAddMember.Name = "btnBackfromAddMember";
            this.btnBackfromAddMember.Size = new System.Drawing.Size(87, 32);
            this.btnBackfromAddMember.TabIndex = 16;
            this.btnBackfromAddMember.Text = "Back";
            this.btnBackfromAddMember.UseVisualStyleBackColor = false;
            this.btnBackfromAddMember.Click += new System.EventHandler(this.btnBackfromAddMember_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.Location = new System.Drawing.Point(355, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 31);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClear.Location = new System.Drawing.Point(283, 185);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 32);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clean";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLabel3.Location = new System.Drawing.Point(225, 24);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(168, 17);
            this.linkLabel3.TabIndex = 13;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "New Member Information ";
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(259, 139);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(165, 20);
            this.txtRole.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(259, 113);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(259, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(259, 58);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 20);
            this.txtId.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(163, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(163, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(163, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(163, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddMember.Location = new System.Drawing.Point(467, 0);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(122, 42);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 453);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "AdminForm";
            this.Text = "Admin Dashbord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlAddMember.ResumeLayout(false);
            this.pnlAddMember.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productEntryStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productUpdateStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salePunchStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleSummaryStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem allProductListStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productReceiveStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StackStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlAddMember;
        private System.Windows.Forms.Button btnBackfromAddMember;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}
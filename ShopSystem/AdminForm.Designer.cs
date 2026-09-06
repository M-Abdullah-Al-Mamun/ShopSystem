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
            this.pnlMenue = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productEntryStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productUpdateStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allProductListStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salePunchStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleSummaryStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productReceiveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StackStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.masterSetupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMemberListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowMenue = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linklblUserName = new System.Windows.Forms.LinkLabel();
            this.pnlMenue.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenue
            // 
            this.pnlMenue.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMenue.Controls.Add(this.panel2);
            this.pnlMenue.Controls.Add(this.linkLabel1);
            this.pnlMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenue.Location = new System.Drawing.Point(0, 0);
            this.pnlMenue.Name = "pnlMenue";
            this.pnlMenue.Size = new System.Drawing.Size(214, 453);
            this.pnlMenue.TabIndex = 0;
            this.pnlMenue.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Controls.Add(this.menuStrip2);
            this.panel2.Controls.Add(this.menuStrip3);
            this.panel2.Controls.Add(this.menuStrip4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 385);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterSetupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 120);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(214, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterSetupToolStripMenuItem
            // 
            this.masterSetupToolStripMenuItem.BackColor = System.Drawing.Color.MidnightBlue;
            this.masterSetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productEntryStripMenuItem,
            this.productUpdateStripMenuItem,
            this.allProductListStripMenuItem});
            this.masterSetupToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.masterSetupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.masterSetupToolStripMenuItem.Name = "masterSetupToolStripMenuItem";
            this.masterSetupToolStripMenuItem.Size = new System.Drawing.Size(177, 36);
            this.masterSetupToolStripMenuItem.Text = "Product Setup";
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
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 80);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(214, 40);
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
            this.saleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
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
            this.menuStrip3.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 40);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(214, 40);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productReceiveStripMenuItem,
            this.StackStripMenuItem});
            this.inventoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.inventoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
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
            // menuStrip4
            // 
            this.menuStrip4.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip4.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterSetupToolStripMenuItem1});
            this.menuStrip4.Location = new System.Drawing.Point(0, 0);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(214, 40);
            this.menuStrip4.TabIndex = 3;
            this.menuStrip4.Text = "menuStrip4";
            this.menuStrip4.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip4_ItemClicked);
            // 
            // masterSetupToolStripMenuItem1
            // 
            this.masterSetupToolStripMenuItem1.BackColor = System.Drawing.Color.MidnightBlue;
            this.masterSetupToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMemberToolStripMenuItem,
            this.showMemberListToolStripMenuItem});
            this.masterSetupToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.masterSetupToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.masterSetupToolStripMenuItem1.Name = "masterSetupToolStripMenuItem1";
            this.masterSetupToolStripMenuItem1.Size = new System.Drawing.Size(168, 36);
            this.masterSetupToolStripMenuItem1.Text = "Master Setup";
            // 
            // addMemberToolStripMenuItem
            // 
            this.addMemberToolStripMenuItem.Name = "addMemberToolStripMenuItem";
            this.addMemberToolStripMenuItem.Size = new System.Drawing.Size(286, 36);
            this.addMemberToolStripMenuItem.Text = "Add Member";
            this.addMemberToolStripMenuItem.Click += new System.EventHandler(this.addMemberToolStripMenuItem_Click);
            // 
            // showMemberListToolStripMenuItem
            // 
            this.showMemberListToolStripMenuItem.Name = "showMemberListToolStripMenuItem";
            this.showMemberListToolStripMenuItem.Size = new System.Drawing.Size(286, 36);
            this.showMemberListToolStripMenuItem.Text = "Show Member List";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(12, 31);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 25);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Menue";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(492, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Logout";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnShowMenue);
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(214, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(616, 112);
            this.panel3.TabIndex = 2;
            // 
            // btnShowMenue
            // 
            this.btnShowMenue.BackColor = System.Drawing.Color.Honeydew;
            this.btnShowMenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnShowMenue.Location = new System.Drawing.Point(3, 3);
            this.btnShowMenue.Name = "btnShowMenue";
            this.btnShowMenue.Size = new System.Drawing.Size(46, 38);
            this.btnShowMenue.TabIndex = 17;
            this.btnShowMenue.Text = "☰";
            this.btnShowMenue.UseVisualStyleBackColor = false;
            this.btnShowMenue.Click += new System.EventHandler(this.btnShowMenue_Click);
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
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(214, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(616, 342);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.linklblUserName);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 65);
            this.panel1.TabIndex = 2;
            // 
            // linklblUserName
            // 
            this.linklblUserName.AutoSize = true;
            this.linklblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.linklblUserName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.linklblUserName.Location = new System.Drawing.Point(38, 20);
            this.linklblUserName.Name = "linklblUserName";
            this.linklblUserName.Size = new System.Drawing.Size(134, 25);
            this.linklblUserName.TabIndex = 2;
            this.linklblUserName.TabStop = true;
            this.linklblUserName.Text = "Current User: ";
            this.linklblUserName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblUserName_LinkClicked);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 453);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlMenue);
            this.MainMenuStrip = this.menuStrip3;
            this.Name = "AdminForm";
            this.Text = "Admin Dashbord";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.pnlMenue.ResumeLayout(false);
            this.pnlMenue.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenue;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnShowMenue;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem masterSetupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMemberListToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklblUserName;
    }
}
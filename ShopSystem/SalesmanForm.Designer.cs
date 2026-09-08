namespace ShopSystem
{
    partial class SalesmanForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_saleentry = new System.Windows.Forms.Button();
            this.button_salesummary = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(-63, -18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 116);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(68, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(323, 39);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salesman Dashboard";
            // 
            // button_saleentry
            // 
            this.button_saleentry.BackColor = System.Drawing.Color.LimeGreen;
            this.button_saleentry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_saleentry.Location = new System.Drawing.Point(12, 142);
            this.button_saleentry.Name = "button_saleentry";
            this.button_saleentry.Size = new System.Drawing.Size(195, 70);
            this.button_saleentry.TabIndex = 2;
            this.button_saleentry.Text = "Sale Entry";
            this.button_saleentry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_saleentry.UseVisualStyleBackColor = false;
            this.button_saleentry.Click += new System.EventHandler(this.button_saleentry_Click);
            // 
            // button_salesummary
            // 
            this.button_salesummary.BackColor = System.Drawing.Color.LimeGreen;
            this.button_salesummary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salesummary.Location = new System.Drawing.Point(12, 236);
            this.button_salesummary.Name = "button_salesummary";
            this.button_salesummary.Size = new System.Drawing.Size(257, 77);
            this.button_salesummary.TabIndex = 3;
            this.button_salesummary.Text = "Sale summary";
            this.button_salesummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_salesummary.UseVisualStyleBackColor = false;
            this.button_salesummary.Click += new System.EventHandler(this.button_salesummary_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Red;
            this.button_exit.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.Location = new System.Drawing.Point(695, 392);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(93, 46);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = false;
            // 
            // SalesmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_salesummary);
            this.Controls.Add(this.button_saleentry);
            this.Controls.Add(this.panel1);
            this.Name = "SalesmanForm";
            this.Text = "SalesmanForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_saleentry;
        private System.Windows.Forms.Button button_salesummary;
        private System.Windows.Forms.Button button_exit;
    }
}
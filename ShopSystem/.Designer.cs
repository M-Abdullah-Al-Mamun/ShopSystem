namespace ShopSystem
{
    partial class ProductUpdateForm
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
            this.btnBackfromPE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBackfromPE
            // 
            this.btnBackfromPE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackfromPE.Location = new System.Drawing.Point(633, 384);
            this.btnBackfromPE.Name = "btnBackfromPE";
            this.btnBackfromPE.Size = new System.Drawing.Size(155, 54);
            this.btnBackfromPE.TabIndex = 1;
            this.btnBackfromPE.Text = "Back";
            this.btnBackfromPE.UseVisualStyleBackColor = false;
            // 
            // ProductUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackfromPE);
            this.Name = "ProductUpdateForm";
            this.Text = "Product Update";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductUpdateForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackfromPE;
    }
}
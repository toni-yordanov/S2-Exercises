namespace Assignment_Snackbar
{
    partial class Form1
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
            this.tbSnack1 = new System.Windows.Forms.TextBox();
            this.tbSnack3 = new System.Windows.Forms.TextBox();
            this.tbSnack2 = new System.Windows.Forms.TextBox();
            this.lblSnack1 = new System.Windows.Forms.Label();
            this.lblSnack2 = new System.Windows.Forms.Label();
            this.lblSnack3 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnGetRevenue = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSnack1
            // 
            this.tbSnack1.Location = new System.Drawing.Point(71, 69);
            this.tbSnack1.Name = "tbSnack1";
            this.tbSnack1.Size = new System.Drawing.Size(100, 20);
            this.tbSnack1.TabIndex = 0;
            // 
            // tbSnack3
            // 
            this.tbSnack3.Location = new System.Drawing.Point(71, 197);
            this.tbSnack3.Name = "tbSnack3";
            this.tbSnack3.Size = new System.Drawing.Size(100, 20);
            this.tbSnack3.TabIndex = 1;
            // 
            // tbSnack2
            // 
            this.tbSnack2.Location = new System.Drawing.Point(71, 132);
            this.tbSnack2.Name = "tbSnack2";
            this.tbSnack2.Size = new System.Drawing.Size(100, 20);
            this.tbSnack2.TabIndex = 2;
            // 
            // lblSnack1
            // 
            this.lblSnack1.AutoSize = true;
            this.lblSnack1.Location = new System.Drawing.Point(68, 38);
            this.lblSnack1.Name = "lblSnack1";
            this.lblSnack1.Size = new System.Drawing.Size(41, 15);
            this.lblSnack1.TabIndex = 3;
            this.lblSnack1.Text = "label1";
            // 
            // lblSnack2
            // 
            this.lblSnack2.AutoSize = true;
            this.lblSnack2.Location = new System.Drawing.Point(68, 105);
            this.lblSnack2.Name = "lblSnack2";
            this.lblSnack2.Size = new System.Drawing.Size(41, 15);
            this.lblSnack2.TabIndex = 4;
            this.lblSnack2.Text = "label2";
            // 
            // lblSnack3
            // 
            this.lblSnack3.AutoSize = true;
            this.lblSnack3.Location = new System.Drawing.Point(68, 170);
            this.lblSnack3.Name = "lblSnack3";
            this.lblSnack3.Size = new System.Drawing.Size(41, 15);
            this.lblSnack3.TabIndex = 5;
            this.lblSnack3.Text = "label3";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(497, 65);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(140, 55);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnGetRevenue
            // 
            this.btnGetRevenue.Location = new System.Drawing.Point(497, 179);
            this.btnGetRevenue.Name = "btnGetRevenue";
            this.btnGetRevenue.Size = new System.Drawing.Size(140, 59);
            this.btnGetRevenue.TabIndex = 9;
            this.btnGetRevenue.Text = "Check Revenue";
            this.btnGetRevenue.UseVisualStyleBackColor = true;
            this.btnGetRevenue.Click += new System.EventHandler(this.btnGetRevenue_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(71, 368);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 15);
            this.lblTotalPrice.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnGetRevenue);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblSnack3);
            this.Controls.Add(this.lblSnack2);
            this.Controls.Add(this.lblSnack1);
            this.Controls.Add(this.tbSnack2);
            this.Controls.Add(this.tbSnack3);
            this.Controls.Add(this.tbSnack1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSnack1;
        private System.Windows.Forms.TextBox tbSnack3;
        private System.Windows.Forms.TextBox tbSnack2;
        private System.Windows.Forms.Label lblSnack1;
        private System.Windows.Forms.Label lblSnack2;
        private System.Windows.Forms.Label lblSnack3;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnGetRevenue;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}


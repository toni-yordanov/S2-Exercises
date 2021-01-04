namespace Library_App
{
    partial class BorrowForm
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
            this.lblBookInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBorrowerInfo = new System.Windows.Forms.TextBox();
            this.btnBorrowToBorrower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookInfo
            // 
            this.lblBookInfo.AutoSize = true;
            this.lblBookInfo.Location = new System.Drawing.Point(40, 34);
            this.lblBookInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookInfo.Name = "lblBookInfo";
            this.lblBookInfo.Size = new System.Drawing.Size(67, 17);
            this.lblBookInfo.TabIndex = 0;
            this.lblBookInfo.Text = "Book Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrower Info";
            // 
            // tbBorrowerInfo
            // 
            this.tbBorrowerInfo.Location = new System.Drawing.Point(155, 71);
            this.tbBorrowerInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBorrowerInfo.Name = "tbBorrowerInfo";
            this.tbBorrowerInfo.Size = new System.Drawing.Size(468, 22);
            this.tbBorrowerInfo.TabIndex = 2;
            // 
            // btnBorrowToBorrower
            // 
            this.btnBorrowToBorrower.Location = new System.Drawing.Point(279, 113);
            this.btnBorrowToBorrower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrowToBorrower.Name = "btnBorrowToBorrower";
            this.btnBorrowToBorrower.Size = new System.Drawing.Size(112, 28);
            this.btnBorrowToBorrower.TabIndex = 3;
            this.btnBorrowToBorrower.Text = "Borrow";
            this.btnBorrowToBorrower.UseVisualStyleBackColor = true;
            this.btnBorrowToBorrower.Click += new System.EventHandler(this.btnBorrowToBorrower_Click);
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 156);
            this.Controls.Add(this.btnBorrowToBorrower);
            this.Controls.Add(this.tbBorrowerInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBookInfo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBorrowerInfo;
        private System.Windows.Forms.Button btnBorrowToBorrower;
    }
}
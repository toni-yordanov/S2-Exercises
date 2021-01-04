namespace Finances
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
            this.gbExpenses = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.nudShowAmounnt = new System.Windows.Forms.NumericUpDown();
            this.lblShowAmount = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnShowSameAmount = new System.Windows.Forms.Button();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.gbExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowAmounnt)).BeginInit();
            this.SuspendLayout();
            // 
            // gbExpenses
            // 
            this.gbExpenses.Controls.Add(this.nudAmount);
            this.gbExpenses.Controls.Add(this.tbName);
            this.gbExpenses.Controls.Add(this.btnAdd);
            this.gbExpenses.Controls.Add(this.lblAmount);
            this.gbExpenses.Controls.Add(this.lblName);
            this.gbExpenses.Location = new System.Drawing.Point(12, 12);
            this.gbExpenses.Name = "gbExpenses";
            this.gbExpenses.Size = new System.Drawing.Size(268, 192);
            this.gbExpenses.TabIndex = 0;
            this.gbExpenses.TabStop = false;
            this.gbExpenses.Text = "Expenses";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(7, 84);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(75, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 49);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add expenses to log";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(75, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(165, 22);
            this.tbName.TabIndex = 3;
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(75, 79);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(100, 22);
            this.nudAmount.TabIndex = 4;
            // 
            // nudShowAmounnt
            // 
            this.nudShowAmounnt.Location = new System.Drawing.Point(87, 279);
            this.nudShowAmounnt.Name = "nudShowAmounnt";
            this.nudShowAmounnt.Size = new System.Drawing.Size(193, 22);
            this.nudShowAmounnt.TabIndex = 6;
            // 
            // lblShowAmount
            // 
            this.lblShowAmount.AutoSize = true;
            this.lblShowAmount.Location = new System.Drawing.Point(19, 284);
            this.lblShowAmount.Name = "lblShowAmount";
            this.lblShowAmount.Size = new System.Drawing.Size(56, 17);
            this.lblShowAmount.TabIndex = 5;
            this.lblShowAmount.Text = "Amount";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(12, 235);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(268, 33);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Show all expenses";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnShowSameAmount
            // 
            this.btnShowSameAmount.Location = new System.Drawing.Point(12, 309);
            this.btnShowSameAmount.Name = "btnShowSameAmount";
            this.btnShowSameAmount.Size = new System.Drawing.Size(268, 35);
            this.btnShowSameAmount.TabIndex = 8;
            this.btnShowSameAmount.Text = "Show expenses with the same amount";
            this.btnShowSameAmount.UseVisualStyleBackColor = true;
            this.btnShowSameAmount.Click += new System.EventHandler(this.btnShowSameAmount_Click);
            // 
            // lbShow
            // 
            this.lbShow.FormattingEnabled = true;
            this.lbShow.ItemHeight = 16;
            this.lbShow.Location = new System.Drawing.Point(312, 12);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(271, 340);
            this.lbShow.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 377);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.btnShowSameAmount);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.nudShowAmounnt);
            this.Controls.Add(this.lblShowAmount);
            this.Controls.Add(this.gbExpenses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbExpenses.ResumeLayout(false);
            this.gbExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowAmounnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExpenses;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudShowAmounnt;
        private System.Windows.Forms.Label lblShowAmount;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnShowSameAmount;
        private System.Windows.Forms.ListBox lbShow;
    }
}


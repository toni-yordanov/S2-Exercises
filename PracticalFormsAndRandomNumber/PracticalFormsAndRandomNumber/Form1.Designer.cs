namespace PracticalFormsAndRandomNumber
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
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.cbStudentGrade = new System.Windows.Forms.ComboBox();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.btnEnterGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(52, 94);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(100, 20);
            this.tbStudentName.TabIndex = 0;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(49, 62);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(119, 15);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Enter Student name:";
            // 
            // cbStudentGrade
            // 
            this.cbStudentGrade.FormattingEnabled = true;
            this.cbStudentGrade.Location = new System.Drawing.Point(369, 90);
            this.cbStudentGrade.Name = "cbStudentGrade";
            this.cbStudentGrade.Size = new System.Drawing.Size(121, 21);
            this.cbStudentGrade.TabIndex = 2;
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Location = new System.Drawing.Point(369, 69);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(114, 15);
            this.lblStudentGrade.TabIndex = 3;
            this.lblStudentGrade.Text = "Enter Stident Grade";
            // 
            // btnEnterGrade
            // 
            this.btnEnterGrade.Location = new System.Drawing.Point(52, 220);
            this.btnEnterGrade.Name = "btnEnterGrade";
            this.btnEnterGrade.Size = new System.Drawing.Size(116, 50);
            this.btnEnterGrade.TabIndex = 4;
            this.btnEnterGrade.Text = "Enter grade";
            this.btnEnterGrade.UseVisualStyleBackColor = true;
            this.btnEnterGrade.Click += new System.EventHandler(this.btnEnterGrade_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnterGrade);
            this.Controls.Add(this.lblStudentGrade);
            this.Controls.Add(this.cbStudentGrade);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.tbStudentName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.ComboBox cbStudentGrade;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.Button btnEnterGrade;
    }
}


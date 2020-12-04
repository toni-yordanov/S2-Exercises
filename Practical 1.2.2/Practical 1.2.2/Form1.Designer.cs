namespace Practical_1._2._2
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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseEC = new System.Windows.Forms.Label();
            this.lblShowInfo = new System.Windows.Forms.Label();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.tbCourseEC = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnShowInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(50, 98);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(94, 17);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourseEC
            // 
            this.lblCourseEC.AutoSize = true;
            this.lblCourseEC.Location = new System.Drawing.Point(50, 165);
            this.lblCourseEC.Name = "lblCourseEC";
            this.lblCourseEC.Size = new System.Drawing.Size(75, 17);
            this.lblCourseEC.TabIndex = 1;
            this.lblCourseEC.Text = "Course EC";
            // 
            // lblShowInfo
            // 
            this.lblShowInfo.AutoSize = true;
            this.lblShowInfo.Location = new System.Drawing.Point(102, 379);
            this.lblShowInfo.Name = "lblShowInfo";
            this.lblShowInfo.Size = new System.Drawing.Size(0, 17);
            this.lblShowInfo.TabIndex = 2;
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(251, 92);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(100, 22);
            this.tbCourseName.TabIndex = 3;
            // 
            // tbCourseEC
            // 
            this.tbCourseEC.Location = new System.Drawing.Point(251, 165);
            this.tbCourseEC.Name = "tbCourseEC";
            this.tbCourseEC.Size = new System.Drawing.Size(100, 22);
            this.tbCourseEC.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(192, 283);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(208, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create Course Object";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.Location = new System.Drawing.Point(192, 328);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(208, 23);
            this.btnShowInfo.TabIndex = 6;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.UseVisualStyleBackColor = true;
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 430);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbCourseEC);
            this.Controls.Add(this.tbCourseName);
            this.Controls.Add(this.lblShowInfo);
            this.Controls.Add(this.lblCourseEC);
            this.Controls.Add(this.lblCourseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseEC;
        private System.Windows.Forms.Label lblShowInfo;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.TextBox tbCourseEC;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnShowInfo;
    }
}


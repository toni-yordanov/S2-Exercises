namespace S_Week14_Reservation
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNrNights = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNrNights = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.lblSmoker = new System.Windows.Forms.Label();
            this.cbSmoker = new System.Windows.Forms.CheckBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnShowRoom = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(28, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Input name:";
            // 
            // lblNrNights
            // 
            this.lblNrNights.AutoSize = true;
            this.lblNrNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNrNights.Location = new System.Drawing.Point(28, 89);
            this.lblNrNights.Name = "lblNrNights";
            this.lblNrNights.Size = new System.Drawing.Size(142, 20);
            this.lblNrNights.TabIndex = 1;
            this.lblNrNights.Text = "Number of nights:";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(141, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 27);
            this.tbName.TabIndex = 2;
            // 
            // tbNrNights
            // 
            this.tbNrNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNrNights.Location = new System.Drawing.Point(190, 86);
            this.tbNrNights.Name = "tbNrNights";
            this.tbNrNights.Size = new System.Drawing.Size(100, 27);
            this.tbNrNights.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(29, 125);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(94, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Room type:";
            // 
            // cbxType
            // 
            this.cbxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(141, 122);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 28);
            this.cbxType.TabIndex = 5;
            // 
            // lblSmoker
            // 
            this.lblSmoker.AutoSize = true;
            this.lblSmoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSmoker.Location = new System.Drawing.Point(30, 163);
            this.lblSmoker.Name = "lblSmoker";
            this.lblSmoker.Size = new System.Drawing.Size(75, 20);
            this.lblSmoker.TabIndex = 6;
            this.lblSmoker.Text = "Smoker?";
            // 
            // cbSmoker
            // 
            this.cbSmoker.AutoSize = true;
            this.cbSmoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSmoker.Location = new System.Drawing.Point(120, 162);
            this.cbSmoker.Name = "cbSmoker";
            this.cbSmoker.Size = new System.Drawing.Size(88, 24);
            this.cbSmoker.TabIndex = 7;
            this.cbSmoker.Text = "Smoker";
            this.cbSmoker.UseVisualStyleBackColor = true;
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.cbSmoker);
            this.gbInfo.Controls.Add(this.lblNrNights);
            this.gbInfo.Controls.Add(this.lblSmoker);
            this.gbInfo.Controls.Add(this.tbName);
            this.gbInfo.Controls.Add(this.cbxType);
            this.gbInfo.Controls.Add(this.tbNrNights);
            this.gbInfo.Controls.Add(this.lblType);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(357, 254);
            this.gbInfo.TabIndex = 8;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Select info";
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btnCalculate);
            this.gbButtons.Controls.Add(this.btnCreate);
            this.gbButtons.Controls.Add(this.btnShowRoom);
            this.gbButtons.Controls.Add(this.btnReservation);
            this.gbButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbButtons.Location = new System.Drawing.Point(375, 12);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(354, 254);
            this.gbButtons.TabIndex = 9;
            this.gbButtons.TabStop = false;
            this.gbButtons.Text = "Buttons";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 189);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(213, 47);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate total price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(6, 26);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(213, 47);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create Reservation";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnShowRoom
            // 
            this.btnShowRoom.Location = new System.Drawing.Point(6, 135);
            this.btnShowRoom.Name = "btnShowRoom";
            this.btnShowRoom.Size = new System.Drawing.Size(213, 48);
            this.btnShowRoom.TabIndex = 12;
            this.btnShowRoom.Text = "Show Room Info";
            this.btnShowRoom.UseVisualStyleBackColor = true;
            this.btnShowRoom.Click += new System.EventHandler(this.btnShowRoom_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Location = new System.Drawing.Point(6, 79);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(213, 50);
            this.btnReservation.TabIndex = 13;
            this.btnReservation.Text = "Show Reservation Info";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 383);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNrNights;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNrNights;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.Label lblSmoker;
        private System.Windows.Forms.CheckBox cbSmoker;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnShowRoom;
        private System.Windows.Forms.Button btnReservation;
    }
}


namespace mortgageCalculator
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblLoanTerm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.sedLoanTerm = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.grbCalculated = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.redSchedule = new System.Windows.Forms.RichTextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.txtTotalInterest = new System.Windows.Forms.TextBox();
            this.lblMontly = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonthlyRepayment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sedLoanTerm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbCalculated.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(126, 14);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(94, 26);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount:";
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.Location = new System.Drawing.Point(2, 67);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(218, 26);
            this.lblIR.TabIndex = 2;
            this.lblIR.Text = "Intrest Rate (Annual):";
            // 
            // lblLoanTerm
            // 
            this.lblLoanTerm.AutoSize = true;
            this.lblLoanTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanTerm.Location = new System.Drawing.Point(20, 127);
            this.lblLoanTerm.Name = "lblLoanTerm";
            this.lblLoanTerm.Size = new System.Drawing.Size(200, 26);
            this.lblLoanTerm.TabIndex = 3;
            this.lblLoanTerm.Text = "Loan Term (Years):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(61, 180);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 36);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(207, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(243, 14);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(120, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // sedLoanTerm
            // 
            this.sedLoanTerm.Location = new System.Drawing.Point(243, 127);
            this.sedLoanTerm.Name = "sedLoanTerm";
            this.sedLoanTerm.Size = new System.Drawing.Size(120, 20);
            this.sedLoanTerm.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(351, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(306, 37);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Mortgage Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInterestRate);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblIR);
            this.groupBox1.Controls.Add(this.lblLoanTerm);
            this.groupBox1.Controls.Add(this.sedLoanTerm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 485);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(243, 73);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(120, 20);
            this.txtInterestRate.TabIndex = 13;
            // 
            // grbCalculated
            // 
            this.grbCalculated.Controls.Add(this.label3);
            this.grbCalculated.Controls.Add(this.redSchedule);
            this.grbCalculated.Controls.Add(this.txtTotalAmount);
            this.grbCalculated.Controls.Add(this.txtTotalInterest);
            this.grbCalculated.Controls.Add(this.lblMontly);
            this.grbCalculated.Controls.Add(this.lblTotalInterest);
            this.grbCalculated.Controls.Add(this.label4);
            this.grbCalculated.Controls.Add(this.label5);
            this.grbCalculated.Controls.Add(this.txtMonthlyRepayment);
            this.grbCalculated.Location = new System.Drawing.Point(508, 49);
            this.grbCalculated.Name = "grbCalculated";
            this.grbCalculated.Size = new System.Drawing.Size(480, 485);
            this.grbCalculated.TabIndex = 15;
            this.grbCalculated.TabStop = false;
            this.grbCalculated.Text = "Calculated Amounts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Amortization schedule:";
            // 
            // redSchedule
            // 
            this.redSchedule.Location = new System.Drawing.Point(6, 170);
            this.redSchedule.Name = "redSchedule";
            this.redSchedule.Size = new System.Drawing.Size(468, 309);
            this.redSchedule.TabIndex = 15;
            this.redSchedule.Text = "";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(313, 109);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(120, 20);
            this.txtTotalAmount.TabIndex = 14;
            // 
            // txtTotalInterest
            // 
            this.txtTotalInterest.Location = new System.Drawing.Point(313, 66);
            this.txtTotalInterest.Name = "txtTotalInterest";
            this.txtTotalInterest.Size = new System.Drawing.Size(120, 20);
            this.txtTotalInterest.TabIndex = 13;
            // 
            // lblMontly
            // 
            this.lblMontly.AutoSize = true;
            this.lblMontly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontly.Location = new System.Drawing.Point(-5, 16);
            this.lblMontly.Name = "lblMontly";
            this.lblMontly.Size = new System.Drawing.Size(294, 26);
            this.lblMontly.TabIndex = 1;
            this.lblMontly.Text = "Monthly Repayment Amount:";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInterest.Location = new System.Drawing.Point(146, 60);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(143, 26);
            this.lblTotalInterest.TabIndex = 2;
            this.lblTotalInterest.Text = "Total Interest:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 4;
            // 
            // txtMonthlyRepayment
            // 
            this.txtMonthlyRepayment.Location = new System.Drawing.Point(313, 20);
            this.txtMonthlyRepayment.Name = "txtMonthlyRepayment";
            this.txtMonthlyRepayment.Size = new System.Drawing.Size(120, 20);
            this.txtMonthlyRepayment.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1006, 546);
            this.Controls.Add(this.grbCalculated);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Mortgage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.sedLoanTerm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbCalculated.ResumeLayout(false);
            this.grbCalculated.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblLoanTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.NumericUpDown sedLoanTerm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbCalculated;
        private System.Windows.Forms.Label lblMontly;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonthlyRepayment;
        private System.Windows.Forms.TextBox txtTotalInterest;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.RichTextBox redSchedule;
    }
}


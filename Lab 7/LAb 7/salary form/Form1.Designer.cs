namespace salary_form
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWageRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaxRate = new System.Windows.Forms.TextBox();
            this.txtLoanRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLoan = new System.Windows.Forms.CheckBox();
            this.chkKiwiSaverEmployee = new System.Windows.Forms.CheckBox();
            this.txtKiwiSaverEmployeeRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkKiwiSaverEmployer = new System.Windows.Forms.CheckBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(353, 135);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(115, 62);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtHoursWorked.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hour worked";
            // 
            // txtWageRate
            // 
            this.txtWageRate.Location = new System.Drawing.Point(115, 119);
            this.txtWageRate.Name = "txtWageRate";
            this.txtWageRate.Size = new System.Drawing.Size(100, 20);
            this.txtWageRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rate Per Hour $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tax %";
            // 
            // txtTaxRate
            // 
            this.txtTaxRate.Location = new System.Drawing.Point(115, 163);
            this.txtTaxRate.Name = "txtTaxRate";
            this.txtTaxRate.Size = new System.Drawing.Size(100, 20);
            this.txtTaxRate.TabIndex = 6;
            // 
            // txtLoanRate
            // 
            this.txtLoanRate.Location = new System.Drawing.Point(126, 236);
            this.txtLoanRate.Name = "txtLoanRate";
            this.txtLoanRate.Size = new System.Drawing.Size(100, 20);
            this.txtLoanRate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Deducateable";
            // 
            // chkLoan
            // 
            this.chkLoan.AutoSize = true;
            this.chkLoan.Location = new System.Drawing.Point(12, 236);
            this.chkLoan.Name = "chkLoan";
            this.chkLoan.Size = new System.Drawing.Size(107, 17);
            this.chkLoan.TabIndex = 9;
            this.chkLoan.Text = "Student Loan (%)";
            this.chkLoan.UseVisualStyleBackColor = true;
            // 
            // chkKiwiSaverEmployee
            // 
            this.chkKiwiSaverEmployee.AutoSize = true;
            this.chkKiwiSaverEmployee.Location = new System.Drawing.Point(12, 269);
            this.chkKiwiSaverEmployee.Name = "chkKiwiSaverEmployee";
            this.chkKiwiSaverEmployee.Size = new System.Drawing.Size(93, 17);
            this.chkKiwiSaverEmployee.TabIndex = 10;
            this.chkKiwiSaverEmployee.Text = "Kiwi Saver (%)";
            this.chkKiwiSaverEmployee.UseVisualStyleBackColor = true;
            // 
            // txtKiwiSaverEmployeeRate
            // 
            this.txtKiwiSaverEmployeeRate.Location = new System.Drawing.Point(126, 269);
            this.txtKiwiSaverEmployeeRate.Name = "txtKiwiSaverEmployeeRate";
            this.txtKiwiSaverEmployeeRate.Size = new System.Drawing.Size(100, 20);
            this.txtKiwiSaverEmployeeRate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Receivable";
            // 
            // chkKiwiSaverEmployer
            // 
            this.chkKiwiSaverEmployer.AutoSize = true;
            this.chkKiwiSaverEmployer.Location = new System.Drawing.Point(29, 347);
            this.chkKiwiSaverEmployer.Name = "chkKiwiSaverEmployer";
            this.chkKiwiSaverEmployer.Size = new System.Drawing.Size(96, 17);
            this.chkKiwiSaverEmployer.TabIndex = 14;
            this.chkKiwiSaverEmployer.Text = "KiwiSaver (3%)";
            this.chkKiwiSaverEmployer.UseVisualStyleBackColor = true;
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(350, 207);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(79, 13);
            this.LblResult.TabIndex = 15;
            this.LblResult.Text = "$___________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.chkKiwiSaverEmployer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKiwiSaverEmployeeRate);
            this.Controls.Add(this.chkKiwiSaverEmployee);
            this.Controls.Add(this.chkLoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoanRate);
            this.Controls.Add(this.txtTaxRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWageRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "salary calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWageRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaxRate;
        private System.Windows.Forms.TextBox txtLoanRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkLoan;
        private System.Windows.Forms.CheckBox chkKiwiSaverEmployee;
        private System.Windows.Forms.TextBox txtKiwiSaverEmployeeRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkKiwiSaverEmployer;
        private System.Windows.Forms.Label LblResult;
    }
}


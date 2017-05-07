namespace BankingApp
{
    partial class Bank
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
            this.btnExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblAccountID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.radioDeposit = new System.Windows.Forms.RadioButton();
            this.radioWithdraw = new System.Windows.Forms.RadioButton();
            this.radioBalance = new System.Windows.Forms.RadioButton();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(170, 230);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(100, 23);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "ITSE 2453 Bank \r\nDallas, TX\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(23, 80);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 20);
            this.txtAccount.TabIndex = 2;
            // 
            // lblAccountID
            // 
            this.lblAccountID.AutoSize = true;
            this.lblAccountID.Location = new System.Drawing.Point(41, 103);
            this.lblAccountID.Name = "lblAccountID";
            this.lblAccountID.Size = new System.Drawing.Size(61, 13);
            this.lblAccountID.TabIndex = 3;
            this.lblAccountID.Text = "Account ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(170, 80);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(23, 229);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(100, 23);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // radioDeposit
            // 
            this.radioDeposit.AutoSize = true;
            this.radioDeposit.Location = new System.Drawing.Point(12, 19);
            this.radioDeposit.Name = "radioDeposit";
            this.radioDeposit.Size = new System.Drawing.Size(61, 17);
            this.radioDeposit.TabIndex = 7;
            this.radioDeposit.TabStop = true;
            this.radioDeposit.Text = "Deposit";
            this.radioDeposit.UseVisualStyleBackColor = true;
            // 
            // radioWithdraw
            // 
            this.radioWithdraw.AutoSize = true;
            this.radioWithdraw.Location = new System.Drawing.Point(12, 43);
            this.radioWithdraw.Name = "radioWithdraw";
            this.radioWithdraw.Size = new System.Drawing.Size(70, 17);
            this.radioWithdraw.TabIndex = 8;
            this.radioWithdraw.TabStop = true;
            this.radioWithdraw.Text = "Withdraw";
            this.radioWithdraw.UseVisualStyleBackColor = true;
            // 
            // radioBalance
            // 
            this.radioBalance.AutoSize = true;
            this.radioBalance.Location = new System.Drawing.Point(12, 67);
            this.radioBalance.Name = "radioBalance";
            this.radioBalance.Size = new System.Drawing.Size(64, 17);
            this.radioBalance.TabIndex = 9;
            this.radioBalance.TabStop = true;
            this.radioBalance.Text = "Balance";
            this.radioBalance.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(44, 274);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioDeposit);
            this.groupBox1.Controls.Add(this.radioWithdraw);
            this.groupBox1.Controls.Add(this.radioBalance);
            this.groupBox1.Location = new System.Drawing.Point(170, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // Bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAccountID);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecute);
            this.Name = "Bank";
            this.Text = "Bank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblAccountID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.RadioButton radioDeposit;
        private System.Windows.Forms.RadioButton radioWithdraw;
        private System.Windows.Forms.RadioButton radioBalance;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}


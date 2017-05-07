namespace _06_EnterInvoices
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
            writer.Close();
            outFile.Close();

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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvoiceBox = new System.Windows.Forms.TextBox();
            this.txtNameBox = new System.Windows.Forms.TextBox();
            this.txtAmountBox = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Invoide Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invoice Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // txtInvoiceBox
            // 
            this.txtInvoiceBox.Location = new System.Drawing.Point(158, 64);
            this.txtInvoiceBox.Name = "txtInvoiceBox";
            this.txtInvoiceBox.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceBox.TabIndex = 4;
            // 
            // txtNameBox
            // 
            this.txtNameBox.Location = new System.Drawing.Point(158, 99);
            this.txtNameBox.Name = "txtNameBox";
            this.txtNameBox.Size = new System.Drawing.Size(100, 20);
            this.txtNameBox.TabIndex = 5;
            // 
            // txtAmountBox
            // 
            this.txtAmountBox.Location = new System.Drawing.Point(158, 139);
            this.txtAmountBox.Name = "txtAmountBox";
            this.txtAmountBox.Size = new System.Drawing.Size(100, 20);
            this.txtAmountBox.TabIndex = 6;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(158, 195);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(99, 23);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Enter Record";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtAmountBox);
            this.Controls.Add(this.txtNameBox);
            this.Controls.Add(this.txtInvoiceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Invoice Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvoiceBox;
        private System.Windows.Forms.TextBox txtNameBox;
        private System.Windows.Forms.TextBox txtAmountBox;
        private System.Windows.Forms.Button btnEnter;
    }
}


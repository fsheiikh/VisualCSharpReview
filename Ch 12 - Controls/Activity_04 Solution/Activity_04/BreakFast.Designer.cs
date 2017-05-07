namespace Activity_04
{
    partial class BreakFast
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.radioContinental = new System.Windows.Forms.RadioButton();
            this.radioFull = new System.Windows.Forms.RadioButton();
            this.radioDeluxe = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select your meal options";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(145, 214);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 23);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price: ";
            // 
            // radioContinental
            // 
            this.radioContinental.AutoSize = true;
            this.radioContinental.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioContinental.Location = new System.Drawing.Point(6, 19);
            this.radioContinental.Name = "radioContinental";
            this.radioContinental.Size = new System.Drawing.Size(106, 27);
            this.radioContinental.TabIndex = 2;
            this.radioContinental.TabStop = true;
            this.radioContinental.Text = "Continental";
            this.radioContinental.UseVisualStyleBackColor = true;
            this.radioContinental.CheckedChanged += new System.EventHandler(this.radioContinental_CheckedChanged);
            // 
            // radioFull
            // 
            this.radioFull.AutoSize = true;
            this.radioFull.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFull.Location = new System.Drawing.Point(6, 43);
            this.radioFull.Name = "radioFull";
            this.radioFull.Size = new System.Drawing.Size(52, 27);
            this.radioFull.TabIndex = 3;
            this.radioFull.TabStop = true;
            this.radioFull.Text = "Full";
            this.radioFull.UseVisualStyleBackColor = true;
            this.radioFull.CheckedChanged += new System.EventHandler(this.radioFull_CheckedChanged);
            // 
            // radioDeluxe
            // 
            this.radioDeluxe.AutoSize = true;
            this.radioDeluxe.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDeluxe.Location = new System.Drawing.Point(6, 67);
            this.radioDeluxe.Name = "radioDeluxe";
            this.radioDeluxe.Size = new System.Drawing.Size(71, 27);
            this.radioDeluxe.TabIndex = 4;
            this.radioDeluxe.TabStop = true;
            this.radioDeluxe.Text = "Deluxe";
            this.radioDeluxe.UseVisualStyleBackColor = true;
            this.radioDeluxe.CheckedChanged += new System.EventHandler(this.radioDeluxe_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioContinental);
            this.groupBox1.Controls.Add(this.radioDeluxe);
            this.groupBox1.Controls.Add(this.radioFull);
            this.groupBox1.Location = new System.Drawing.Point(65, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 104);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // BreakFast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Name = "BreakFast";
            this.Text = "BreakFast";
            this.Load += new System.EventHandler(this.BreakFast_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.RadioButton radioContinental;
        private System.Windows.Forms.RadioButton radioFull;
        private System.Windows.Forms.RadioButton radioDeluxe;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
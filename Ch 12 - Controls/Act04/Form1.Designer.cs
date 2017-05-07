namespace Activity_04
{
    partial class BaileysForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.bellaireCheckBox = new System.Windows.Forms.CheckBox();
            this.lincolnCheckBox = new System.Windows.Forms.CheckBox();
            this.btnMeal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Baileys";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check our rates";
            // 
            // bellaireCheckBox
            // 
            this.bellaireCheckBox.AutoSize = true;
            this.bellaireCheckBox.Location = new System.Drawing.Point(43, 119);
            this.bellaireCheckBox.Name = "bellaireCheckBox";
            this.bellaireCheckBox.Size = new System.Drawing.Size(87, 17);
            this.bellaireCheckBox.TabIndex = 2;
            this.bellaireCheckBox.Text = "Bellaire Suite";
            this.bellaireCheckBox.UseVisualStyleBackColor = true;
            this.bellaireCheckBox.CheckedChanged += new System.EventHandler(this.bellaireCheckBox_CheckedChanged);
            // 
            // lincolnCheckBox
            // 
            this.lincolnCheckBox.AutoSize = true;
            this.lincolnCheckBox.Location = new System.Drawing.Point(43, 143);
            this.lincolnCheckBox.Name = "lincolnCheckBox";
            this.lincolnCheckBox.Size = new System.Drawing.Size(60, 17);
            this.lincolnCheckBox.TabIndex = 3;
            this.lincolnCheckBox.Text = "Lincoln";
            this.lincolnCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnMeal
            // 
            this.btnMeal.Location = new System.Drawing.Point(43, 226);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(75, 23);
            this.btnMeal.TabIndex = 4;
            this.btnMeal.Text = "Meal Option";
            this.btnMeal.UseVisualStyleBackColor = true;
            this.btnMeal.Click += new System.EventHandler(this.btnMeal_Click);
            // 
            // BaileysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMeal);
            this.Controls.Add(this.lincolnCheckBox);
            this.Controls.Add(this.bellaireCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(20, 30);
            this.Name = "BaileysForm";
            this.Text = "Bed and Breakfast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox bellaireCheckBox;
        private System.Windows.Forms.CheckBox lincolnCheckBox;
        private System.Windows.Forms.Button btnMeal;
    }
}


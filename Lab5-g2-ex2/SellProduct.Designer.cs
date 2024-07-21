namespace Lab5_g2_ex2
{
    partial class SellProduct
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
            this.btnVanzare = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVanzare
            // 
            this.btnVanzare.Location = new System.Drawing.Point(65, 158);
            this.btnVanzare.Name = "btnVanzare";
            this.btnVanzare.Size = new System.Drawing.Size(75, 23);
            this.btnVanzare.TabIndex = 0;
            this.btnVanzare.Text = "Vanzare";
            this.btnVanzare.UseVisualStyleBackColor = true;
            this.btnVanzare.Click += new System.EventHandler(this.btnVanzare_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(52, 66);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Cantitate:";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(125, 63);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 2;
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(183, 158);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(75, 23);
            this.btnIesire.TabIndex = 3;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 297);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnVanzare);
            this.Name = "SellProduct";
            this.Text = "SellProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVanzare;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btnIesire;
    }
}
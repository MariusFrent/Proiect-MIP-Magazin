namespace Lab5_g2_ex2
{
    partial class AddUser
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtUsrNm = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnInreg = new System.Windows.Forms.Button();
            this.btnIesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(132, 47);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(135, 20);
            this.txtNume.TabIndex = 4;
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(132, 93);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(135, 20);
            this.txtPrenume.TabIndex = 5;
            // 
            // txtUsrNm
            // 
            this.txtUsrNm.Location = new System.Drawing.Point(132, 137);
            this.txtUsrNm.Name = "txtUsrNm";
            this.txtUsrNm.Size = new System.Drawing.Size(135, 20);
            this.txtUsrNm.TabIndex = 6;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(132, 184);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(135, 20);
            this.txtParola.TabIndex = 7;
            // 
            // btnInreg
            // 
            this.btnInreg.Location = new System.Drawing.Point(89, 233);
            this.btnInreg.Name = "btnInreg";
            this.btnInreg.Size = new System.Drawing.Size(75, 23);
            this.btnInreg.TabIndex = 8;
            this.btnInreg.Text = "Sign Up";
            this.btnInreg.UseVisualStyleBackColor = true;
            this.btnInreg.Click += new System.EventHandler(this.btnInreg_Click);
            // 
            // btnIesi
            // 
            this.btnIesi.Location = new System.Drawing.Point(221, 233);
            this.btnIesi.Name = "btnIesi";
            this.btnIesi.Size = new System.Drawing.Size(75, 23);
            this.btnIesi.TabIndex = 9;
            this.btnIesi.Text = "Iesire";
            this.btnIesi.UseVisualStyleBackColor = true;
            this.btnIesi.Click += new System.EventHandler(this.btnIesi_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 297);
            this.Controls.Add(this.btnIesi);
            this.Controls.Add(this.btnInreg);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUsrNm);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "Inregistrare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtUsrNm;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnInreg;
        private System.Windows.Forms.Button btnIesi;
    }
}
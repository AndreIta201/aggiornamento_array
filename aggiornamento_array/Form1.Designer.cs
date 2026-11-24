namespace aggiornamento_array
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.lbl_risultato = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(304, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(234, 33);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Inserire la frase";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(367, 99);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 1;
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(367, 134);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(100, 38);
            this.btn_n1.TabIndex = 2;
            this.btn_n1.Text = "ELIMINA";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(354, 49);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(129, 20);
            this.txt_n2.TabIndex = 3;
            // 
            // lbl_risultato
            // 
            this.lbl_risultato.AutoSize = true;
            this.lbl_risultato.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_risultato.Location = new System.Drawing.Point(384, 192);
            this.lbl_risultato.Name = "lbl_risultato";
            this.lbl_risultato.Size = new System.Drawing.Size(66, 14);
            this.lbl_risultato.TabIndex = 4;
            this.lbl_risultato.Text = "Risultato";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(318, 72);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(199, 24);
            this.lbl_n2.TabIndex = 5;
            this.lbl_n2.Text = "Inserire cosa eliminare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_risultato);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.Label lbl_risultato;
        private System.Windows.Forms.Label lbl_n2;
    }
}


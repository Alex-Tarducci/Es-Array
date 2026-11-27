namespace esercizio_array2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nomi = new System.Windows.Forms.Label();
            this.lbl_numeri = new System.Windows.Forms.Label();
            this.lbl_saldi = new System.Windows.Forms.Label();
            this.lst_nomi = new System.Windows.Forms.ListBox();
            this.lst_numeri = new System.Windows.Forms.ListBox();
            this.lst_saldo = new System.Windows.Forms.ListBox();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.btn_n3 = new System.Windows.Forms.Button();
            this.btn_n4 = new System.Windows.Forms.Button();
            this.btn_n5 = new System.Windows.Forms.Button();
            this.btn_n6 = new System.Windows.Forms.Button();
            this.lst_risultato = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_nomi
            // 
            this.lbl_nomi.AutoSize = true;
            this.lbl_nomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomi.Location = new System.Drawing.Point(37, 80);
            this.lbl_nomi.Name = "lbl_nomi";
            this.lbl_nomi.Size = new System.Drawing.Size(59, 24);
            this.lbl_nomi.TabIndex = 0;
            this.lbl_nomi.Text = "Nomi";
            // 
            // lbl_numeri
            // 
            this.lbl_numeri.AutoSize = true;
            this.lbl_numeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeri.Location = new System.Drawing.Point(222, 80);
            this.lbl_numeri.Name = "lbl_numeri";
            this.lbl_numeri.Size = new System.Drawing.Size(78, 24);
            this.lbl_numeri.TabIndex = 1;
            this.lbl_numeri.Text = "Numeri";
            // 
            // lbl_saldi
            // 
            this.lbl_saldi.AutoSize = true;
            this.lbl_saldi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldi.Location = new System.Drawing.Point(412, 80);
            this.lbl_saldi.Name = "lbl_saldi";
            this.lbl_saldi.Size = new System.Drawing.Size(56, 24);
            this.lbl_saldi.TabIndex = 2;
            this.lbl_saldi.Text = "Saldi";
            // 
            // lst_nomi
            // 
            this.lst_nomi.FormattingEnabled = true;
            this.lst_nomi.Location = new System.Drawing.Point(12, 111);
            this.lst_nomi.Name = "lst_nomi";
            this.lst_nomi.Size = new System.Drawing.Size(113, 108);
            this.lst_nomi.TabIndex = 3;
            this.lst_nomi.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lst_numeri
            // 
            this.lst_numeri.FormattingEnabled = true;
            this.lst_numeri.Location = new System.Drawing.Point(207, 111);
            this.lst_numeri.Name = "lst_numeri";
            this.lst_numeri.Size = new System.Drawing.Size(105, 108);
            this.lst_numeri.TabIndex = 4;
            // 
            // lst_saldo
            // 
            this.lst_saldo.FormattingEnabled = true;
            this.lst_saldo.Location = new System.Drawing.Point(394, 111);
            this.lst_saldo.Name = "lst_saldo";
            this.lst_saldo.Size = new System.Drawing.Size(102, 108);
            this.lst_saldo.TabIndex = 5;
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(236, 9);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(321, 42);
            this.lbl_titolo.TabIndex = 6;
            this.lbl_titolo.Text = "CONTI BANCARI";
            // 
            // btn_n1
            // 
            this.btn_n1.ForeColor = System.Drawing.Color.Red;
            this.btn_n1.Location = new System.Drawing.Point(12, 251);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(113, 74);
            this.btn_n1.TabIndex = 7;
            this.btn_n1.Text = "visualizzare cognome e nome dell\'intestatario e il suo saldo";
            this.btn_n1.UseVisualStyleBackColor = true;
            // 
            // btn_n2
            // 
            this.btn_n2.ForeColor = System.Drawing.Color.Red;
            this.btn_n2.Location = new System.Drawing.Point(12, 342);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(113, 79);
            this.btn_n2.TabIndex = 8;
            this.btn_n2.Text = "visualizzare numero del conto e saldo";
            this.btn_n2.UseVisualStyleBackColor = true;
            // 
            // btn_n3
            // 
            this.btn_n3.ForeColor = System.Drawing.Color.Red;
            this.btn_n3.Location = new System.Drawing.Point(207, 251);
            this.btn_n3.Name = "btn_n3";
            this.btn_n3.Size = new System.Drawing.Size(105, 74);
            this.btn_n3.TabIndex = 9;
            this.btn_n3.Text = "Visualizzare cognome e nome delle persone che hanno il conto in rosso";
            this.btn_n3.UseVisualStyleBackColor = true;
            // 
            // btn_n4
            // 
            this.btn_n4.ForeColor = System.Drawing.Color.Red;
            this.btn_n4.Location = new System.Drawing.Point(207, 342);
            this.btn_n4.Name = "btn_n4";
            this.btn_n4.Size = new System.Drawing.Size(105, 79);
            this.btn_n4.TabIndex = 10;
            this.btn_n4.Text = "Visualizzare cognome e nome del cliente che ha il saldo massimo";
            this.btn_n4.UseVisualStyleBackColor = true;
            // 
            // btn_n5
            // 
            this.btn_n5.ForeColor = System.Drawing.Color.Red;
            this.btn_n5.Location = new System.Drawing.Point(394, 251);
            this.btn_n5.Name = "btn_n5";
            this.btn_n5.Size = new System.Drawing.Size(102, 74);
            this.btn_n5.TabIndex = 11;
            this.btn_n5.Text = "Visualizzare la media dei saldi";
            this.btn_n5.UseVisualStyleBackColor = true;
            // 
            // btn_n6
            // 
            this.btn_n6.ForeColor = System.Drawing.Color.Red;
            this.btn_n6.Location = new System.Drawing.Point(394, 342);
            this.btn_n6.Name = "btn_n6";
            this.btn_n6.Size = new System.Drawing.Size(102, 79);
            this.btn_n6.TabIndex = 12;
            this.btn_n6.Text = "Visualizzare l\'elenco dei cognomi dei clienti ordinati in base al saldo";
            this.btn_n6.UseVisualStyleBackColor = true;
            // 
            // lst_risultato
            // 
            this.lst_risultato.FormattingEnabled = true;
            this.lst_risultato.Location = new System.Drawing.Point(546, 111);
            this.lst_risultato.Name = "lst_risultato";
            this.lst_risultato.Size = new System.Drawing.Size(231, 316);
            this.lst_risultato.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst_risultato);
            this.Controls.Add(this.btn_n6);
            this.Controls.Add(this.btn_n5);
            this.Controls.Add(this.btn_n4);
            this.Controls.Add(this.btn_n3);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.lbl_titolo);
            this.Controls.Add(this.lst_saldo);
            this.Controls.Add(this.lst_numeri);
            this.Controls.Add(this.lst_nomi);
            this.Controls.Add(this.lbl_saldi);
            this.Controls.Add(this.lbl_numeri);
            this.Controls.Add(this.lbl_nomi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomi;
        private System.Windows.Forms.Label lbl_numeri;
        private System.Windows.Forms.Label lbl_saldi;
        private System.Windows.Forms.ListBox lst_nomi;
        private System.Windows.Forms.ListBox lst_numeri;
        private System.Windows.Forms.ListBox lst_saldo;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Button btn_n2;
        private System.Windows.Forms.Button btn_n3;
        private System.Windows.Forms.Button btn_n4;
        private System.Windows.Forms.Button btn_n5;
        private System.Windows.Forms.Button btn_n6;
        private System.Windows.Forms.ListBox lst_risultato;
    }
}


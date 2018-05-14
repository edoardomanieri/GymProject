namespace ViewProject
{
    partial class FormEliminaEsercizi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminaEsercizi));
            this.labelGiornoSettimana = new System.Windows.Forms.Label();
            this.comboGiorno = new System.Windows.Forms.ComboBox();
            this.labelEserzizio = new System.Windows.Forms.Label();
            this.labelTitolo = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonEliminaEsercizio = new System.Windows.Forms.Button();
            this.buttonAggiungiEsercizio = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelGiornoSettimana
            // 
            this.labelGiornoSettimana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGiornoSettimana.AutoSize = true;
            this.labelGiornoSettimana.BackColor = System.Drawing.Color.Transparent;
            this.labelGiornoSettimana.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiornoSettimana.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelGiornoSettimana.Location = new System.Drawing.Point(145, 105);
            this.labelGiornoSettimana.Name = "labelGiornoSettimana";
            this.labelGiornoSettimana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGiornoSettimana.Size = new System.Drawing.Size(243, 31);
            this.labelGiornoSettimana.TabIndex = 56;
            this.labelGiornoSettimana.Text = "Indica il giorno della settimana";
            this.labelGiornoSettimana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboGiorno
            // 
            this.comboGiorno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboGiorno.BackColor = System.Drawing.Color.Tomato;
            this.comboGiorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGiorno.ForeColor = System.Drawing.Color.Black;
            this.comboGiorno.FormattingEnabled = true;
            this.comboGiorno.Items.AddRange(new object[] {
            "Lunedì",
            "Mercoledì",
            "Venerdì",
            "Sabato"});
            this.comboGiorno.Location = new System.Drawing.Point(430, 115);
            this.comboGiorno.Name = "comboGiorno";
            this.comboGiorno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboGiorno.Size = new System.Drawing.Size(120, 21);
            this.comboGiorno.TabIndex = 55;
            this.comboGiorno.Text = "Giorno Settimana";
            // 
            // labelEserzizio
            // 
            this.labelEserzizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEserzizio.AutoSize = true;
            this.labelEserzizio.BackColor = System.Drawing.Color.Transparent;
            this.labelEserzizio.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEserzizio.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelEserzizio.Location = new System.Drawing.Point(74, 207);
            this.labelEserzizio.Name = "labelEserzizio";
            this.labelEserzizio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEserzizio.Size = new System.Drawing.Size(327, 31);
            this.labelEserzizio.TabIndex = 50;
            this.labelEserzizio.Text = "Seleziona gli esercizi che vuoi rimuovere";
            this.labelEserzizio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitolo
            // 
            this.labelTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitolo.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitolo.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelTitolo.Location = new System.Drawing.Point(309, 34);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitolo.Size = new System.Drawing.Size(225, 29);
            this.labelTitolo.TabIndex = 49;
            this.labelTitolo.Text = "Rimuovi esercizi";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.Tomato;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Panca Piana",
            "Croci",
            "Distensioni",
            "Leg extension",
            "Pressa",
            "Leg Curl"});
            this.checkedListBox1.Location = new System.Drawing.Point(430, 218);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 64);
            this.checkedListBox1.TabIndex = 57;
            // 
            // buttonEliminaEsercizio
            // 
            this.buttonEliminaEsercizio.BackColor = System.Drawing.Color.Tomato;
            this.buttonEliminaEsercizio.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonEliminaEsercizio.FlatAppearance.BorderSize = 2;
            this.buttonEliminaEsercizio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonEliminaEsercizio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonEliminaEsercizio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminaEsercizio.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminaEsercizio.Location = new System.Drawing.Point(615, 455);
            this.buttonEliminaEsercizio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminaEsercizio.Name = "buttonEliminaEsercizio";
            this.buttonEliminaEsercizio.Size = new System.Drawing.Size(160, 30);
            this.buttonEliminaEsercizio.TabIndex = 59;
            this.buttonEliminaEsercizio.Tag = "";
            this.buttonEliminaEsercizio.Text = "Conferma rimozione";
            this.buttonEliminaEsercizio.UseVisualStyleBackColor = false;
            // 
            // buttonAggiungiEsercizio
            // 
            this.buttonAggiungiEsercizio.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonAggiungiEsercizio.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonAggiungiEsercizio.FlatAppearance.BorderSize = 2;
            this.buttonAggiungiEsercizio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonAggiungiEsercizio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonAggiungiEsercizio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAggiungiEsercizio.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggiungiEsercizio.Location = new System.Drawing.Point(38, 455);
            this.buttonAggiungiEsercizio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAggiungiEsercizio.Name = "buttonAggiungiEsercizio";
            this.buttonAggiungiEsercizio.Size = new System.Drawing.Size(130, 30);
            this.buttonAggiungiEsercizio.TabIndex = 58;
            this.buttonAggiungiEsercizio.Tag = "";
            this.buttonAggiungiEsercizio.Text = "Indietro";
            this.buttonAggiungiEsercizio.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(598, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(203, 346);
            this.textBox1.TabIndex = 60;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormEliminaEsercizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 512);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonEliminaEsercizio);
            this.Controls.Add(this.buttonAggiungiEsercizio);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelGiornoSettimana);
            this.Controls.Add(this.comboGiorno);
            this.Controls.Add(this.labelEserzizio);
            this.Controls.Add(this.labelTitolo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEliminaEsercizi";
            this.Text = "FormEliminaEsercizi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGiornoSettimana;
        private System.Windows.Forms.ComboBox comboGiorno;
        private System.Windows.Forms.Label labelEserzizio;
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonEliminaEsercizio;
        private System.Windows.Forms.Button buttonAggiungiEsercizio;
        private System.Windows.Forms.TextBox textBox1;
    }
}
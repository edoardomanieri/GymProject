namespace ViewProject
{
    partial class CreaSchedaAutomaticaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreaSchedaAutomaticaView));
            this.labelTitolo = new System.Windows.Forms.Label();
            this.numericUpDownAllenamenti = new System.Windows.Forms.NumericUpDown();
            this.labelObiettivo = new System.Windows.Forms.Label();
            this.comboBoxObiettivo = new System.Windows.Forms.ComboBox();
            this.labelGiorniAllenamento = new System.Windows.Forms.Label();
            this.labelRisorse = new System.Windows.Forms.Label();
            this.comboModalita = new System.Windows.Forms.ComboBox();
            this.buttonProcedi = new System.Windows.Forms.Button();
            this.buttonIndietro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAllenamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitolo
            // 
            this.labelTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitolo.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitolo.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelTitolo.Location = new System.Drawing.Point(155, 39);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitolo.Size = new System.Drawing.Size(563, 60);
            this.labelTitolo.TabIndex = 3;
            this.labelTitolo.Text = "            Inserisci i seguenti dati ai fini di\r\n generare automaticamente la tu" +
    "a scheda!";
            // 
            // numericUpDownAllenamenti
            // 
            this.numericUpDownAllenamenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownAllenamenti.BackColor = System.Drawing.Color.IndianRed;
            this.numericUpDownAllenamenti.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAllenamenti.ForeColor = System.Drawing.Color.Transparent;
            this.numericUpDownAllenamenti.Location = new System.Drawing.Point(591, 178);
            this.numericUpDownAllenamenti.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownAllenamenti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAllenamenti.Name = "numericUpDownAllenamenti";
            this.numericUpDownAllenamenti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownAllenamenti.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownAllenamenti.TabIndex = 25;
            this.numericUpDownAllenamenti.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelObiettivo
            // 
            this.labelObiettivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelObiettivo.AutoSize = true;
            this.labelObiettivo.BackColor = System.Drawing.Color.Transparent;
            this.labelObiettivo.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObiettivo.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelObiettivo.Location = new System.Drawing.Point(211, 245);
            this.labelObiettivo.Name = "labelObiettivo";
            this.labelObiettivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelObiettivo.Size = new System.Drawing.Size(311, 31);
            this.labelObiettivo.TabIndex = 24;
            this.labelObiettivo.Text = "Specifica l\'obiettivo del tuo allenamento";
            this.labelObiettivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxObiettivo
            // 
            this.comboBoxObiettivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxObiettivo.BackColor = System.Drawing.Color.IndianRed;
            this.comboBoxObiettivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxObiettivo.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxObiettivo.ForeColor = System.Drawing.Color.Transparent;
            this.comboBoxObiettivo.FormattingEnabled = true;
            this.comboBoxObiettivo.Items.AddRange(new object[] {
            "Ipertrofia",
            "Definizione",
            "Forza",
            "Tonificazione"});
            this.comboBoxObiettivo.Location = new System.Drawing.Point(566, 251);
            this.comboBoxObiettivo.Name = "comboBoxObiettivo";
            this.comboBoxObiettivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxObiettivo.Size = new System.Drawing.Size(94, 25);
            this.comboBoxObiettivo.TabIndex = 23;
            this.comboBoxObiettivo.Text = "Obiettivo";
            this.comboBoxObiettivo.SelectedIndexChanged += new System.EventHandler(this.comboBoxObiettivo_SelectedIndexChanged);
            // 
            // labelGiorniAllenamento
            // 
            this.labelGiorniAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGiorniAllenamento.AutoSize = true;
            this.labelGiorniAllenamento.BackColor = System.Drawing.Color.Transparent;
            this.labelGiorniAllenamento.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiorniAllenamento.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelGiorniAllenamento.Location = new System.Drawing.Point(199, 170);
            this.labelGiorniAllenamento.Name = "labelGiorniAllenamento";
            this.labelGiorniAllenamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGiorniAllenamento.Size = new System.Drawing.Size(334, 31);
            this.labelGiorniAllenamento.TabIndex = 22;
            this.labelGiorniAllenamento.Text = "Specifica il numero di giorni d\'allenamento";
            this.labelGiorniAllenamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRisorse
            // 
            this.labelRisorse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRisorse.AutoSize = true;
            this.labelRisorse.BackColor = System.Drawing.Color.Transparent;
            this.labelRisorse.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRisorse.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelRisorse.Location = new System.Drawing.Point(199, 325);
            this.labelRisorse.Name = "labelRisorse";
            this.labelRisorse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRisorse.Size = new System.Drawing.Size(343, 31);
            this.labelRisorse.TabIndex = 27;
            this.labelRisorse.Text = "Indica la modalità di allenamento desiderata";
            this.labelRisorse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboModalita
            // 
            this.comboModalita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboModalita.BackColor = System.Drawing.Color.IndianRed;
            this.comboModalita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboModalita.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboModalita.ForeColor = System.Drawing.Color.Transparent;
            this.comboModalita.FormattingEnabled = true;
            this.comboModalita.Items.AddRange(new object[] {
            "Sala pesi",
            "Corpo libero"});
            this.comboModalita.Location = new System.Drawing.Point(566, 331);
            this.comboModalita.Name = "comboModalita";
            this.comboModalita.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboModalita.Size = new System.Drawing.Size(94, 25);
            this.comboModalita.TabIndex = 26;
            this.comboModalita.Text = "Modalità";
            this.comboModalita.SelectedIndexChanged += new System.EventHandler(this.comboModalita_SelectedIndexChanged);
            // 
            // buttonProcedi
            // 
            this.buttonProcedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProcedi.AutoSize = true;
            this.buttonProcedi.BackColor = System.Drawing.Color.White;
            this.buttonProcedi.FlatAppearance.BorderSize = 2;
            this.buttonProcedi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.buttonProcedi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonProcedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcedi.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcedi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonProcedi.Location = new System.Drawing.Point(685, 457);
            this.buttonProcedi.Name = "buttonProcedi";
            this.buttonProcedi.Size = new System.Drawing.Size(80, 31);
            this.buttonProcedi.TabIndex = 29;
            this.buttonProcedi.Text = "Procedi";
            this.buttonProcedi.UseVisualStyleBackColor = false;
            this.buttonProcedi.Click += new System.EventHandler(this.buttonProcedi_Click);
            // 
            // buttonIndietro
            // 
            this.buttonIndietro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIndietro.AutoSize = true;
            this.buttonIndietro.BackColor = System.Drawing.Color.White;
            this.buttonIndietro.FlatAppearance.BorderSize = 2;
            this.buttonIndietro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.GreenYellow;
            this.buttonIndietro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonIndietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndietro.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndietro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonIndietro.Location = new System.Drawing.Point(40, 457);
            this.buttonIndietro.Name = "buttonIndietro";
            this.buttonIndietro.Size = new System.Drawing.Size(86, 31);
            this.buttonIndietro.TabIndex = 30;
            this.buttonIndietro.Text = "Indietro";
            this.buttonIndietro.UseVisualStyleBackColor = false;
            // 
            // CreaSchedaAutomaticaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonIndietro);
            this.Controls.Add(this.buttonProcedi);
            this.Controls.Add(this.labelRisorse);
            this.Controls.Add(this.comboModalita);
            this.Controls.Add(this.numericUpDownAllenamenti);
            this.Controls.Add(this.labelObiettivo);
            this.Controls.Add(this.comboBoxObiettivo);
            this.Controls.Add(this.labelGiorniAllenamento);
            this.Controls.Add(this.labelTitolo);
            this.Name = "CreaSchedaAutomaticaView";
            this.Size = new System.Drawing.Size(822, 512);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAllenamenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.Label labelObiettivo;
        private System.Windows.Forms.Label labelGiorniAllenamento;
        private System.Windows.Forms.Label labelRisorse;
        private System.Windows.Forms.Button buttonIndietro;
        public System.Windows.Forms.Button buttonProcedi;
        public System.Windows.Forms.NumericUpDown numericUpDownAllenamenti;
        public System.Windows.Forms.ComboBox comboBoxObiettivo;
        public System.Windows.Forms.ComboBox comboModalita;
    }
}
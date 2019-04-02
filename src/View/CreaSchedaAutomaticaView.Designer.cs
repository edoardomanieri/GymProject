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
            this.labelTitolo.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitolo.ForeColor = System.Drawing.Color.Lavender;
            this.labelTitolo.Location = new System.Drawing.Point(-76, 40);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitolo.Size = new System.Drawing.Size(841, 32);
            this.labelTitolo.TabIndex = 3;
            this.labelTitolo.Text = "            Inserisci i dati e genera automaticamente la tua scheda!";
            // 
            // numericUpDownAllenamenti
            // 
            this.numericUpDownAllenamenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownAllenamenti.BackColor = System.Drawing.Color.SlateBlue;
            this.numericUpDownAllenamenti.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAllenamenti.ForeColor = System.Drawing.Color.Lavender;
            this.numericUpDownAllenamenti.Location = new System.Drawing.Point(528, 146);
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
            this.numericUpDownAllenamenti.Size = new System.Drawing.Size(44, 24);
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
            this.labelObiettivo.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObiettivo.ForeColor = System.Drawing.Color.Lavender;
            this.labelObiettivo.Location = new System.Drawing.Point(153, 240);
            this.labelObiettivo.Name = "labelObiettivo";
            this.labelObiettivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelObiettivo.Size = new System.Drawing.Size(341, 21);
            this.labelObiettivo.TabIndex = 24;
            this.labelObiettivo.Text = "Seleziona l\'obiettivo del tuo allenamento";
            this.labelObiettivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxObiettivo
            // 
            this.comboBoxObiettivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxObiettivo.BackColor = System.Drawing.Color.SlateBlue;
            this.comboBoxObiettivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxObiettivo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxObiettivo.ForeColor = System.Drawing.Color.Lavender;
            this.comboBoxObiettivo.FormattingEnabled = true;
            this.comboBoxObiettivo.Location = new System.Drawing.Point(528, 241);
            this.comboBoxObiettivo.Name = "comboBoxObiettivo";
            this.comboBoxObiettivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxObiettivo.Size = new System.Drawing.Size(103, 24);
            this.comboBoxObiettivo.TabIndex = 23;
            this.comboBoxObiettivo.Text = "Obiettivo";
            this.comboBoxObiettivo.SelectedIndexChanged += new System.EventHandler(this.comboBoxObiettivo_SelectedIndexChanged);
            // 
            // labelGiorniAllenamento
            // 
            this.labelGiorniAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGiorniAllenamento.AutoSize = true;
            this.labelGiorniAllenamento.BackColor = System.Drawing.Color.Transparent;
            this.labelGiorniAllenamento.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiorniAllenamento.ForeColor = System.Drawing.Color.Lavender;
            this.labelGiorniAllenamento.Location = new System.Drawing.Point(127, 146);
            this.labelGiorniAllenamento.Name = "labelGiorniAllenamento";
            this.labelGiorniAllenamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGiorniAllenamento.Size = new System.Drawing.Size(367, 21);
            this.labelGiorniAllenamento.TabIndex = 22;
            this.labelGiorniAllenamento.Text = "Specifica il numero di giorni d\'allenamento";
            this.labelGiorniAllenamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRisorse
            // 
            this.labelRisorse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRisorse.AutoSize = true;
            this.labelRisorse.BackColor = System.Drawing.Color.Transparent;
            this.labelRisorse.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRisorse.ForeColor = System.Drawing.Color.Lavender;
            this.labelRisorse.Location = new System.Drawing.Point(113, 336);
            this.labelRisorse.Name = "labelRisorse";
            this.labelRisorse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRisorse.Size = new System.Drawing.Size(381, 21);
            this.labelRisorse.TabIndex = 27;
            this.labelRisorse.Text = "Indica la modalità di allenamento desiderata";
            this.labelRisorse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboModalita
            // 
            this.comboModalita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboModalita.BackColor = System.Drawing.Color.SlateBlue;
            this.comboModalita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboModalita.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboModalita.ForeColor = System.Drawing.Color.Lavender;
            this.comboModalita.FormattingEnabled = true;
            this.comboModalita.Location = new System.Drawing.Point(528, 336);
            this.comboModalita.Name = "comboModalita";
            this.comboModalita.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboModalita.Size = new System.Drawing.Size(105, 24);
            this.comboModalita.TabIndex = 26;
            this.comboModalita.Text = "Modalità";
            this.comboModalita.SelectedIndexChanged += new System.EventHandler(this.comboModalita_SelectedIndexChanged);
            // 
            // buttonProcedi
            // 
            this.buttonProcedi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProcedi.AutoSize = true;
            this.buttonProcedi.BackColor = System.Drawing.Color.Transparent;
            this.buttonProcedi.FlatAppearance.BorderSize = 2;
            this.buttonProcedi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonProcedi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.buttonProcedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProcedi.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcedi.ForeColor = System.Drawing.Color.Lavender;
            this.buttonProcedi.Location = new System.Drawing.Point(685, 457);
            this.buttonProcedi.Name = "buttonProcedi";
            this.buttonProcedi.Size = new System.Drawing.Size(80, 31);
            this.buttonProcedi.TabIndex = 29;
            this.buttonProcedi.Text = "Procedi";
            this.buttonProcedi.UseVisualStyleBackColor = false;
            // 
            // buttonIndietro
            // 
            this.buttonIndietro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIndietro.AutoSize = true;
            this.buttonIndietro.BackColor = System.Drawing.Color.Transparent;
            this.buttonIndietro.FlatAppearance.BorderSize = 2;
            this.buttonIndietro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonIndietro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.buttonIndietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndietro.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndietro.ForeColor = System.Drawing.Color.Lavender;
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
            this.ForeColor = System.Drawing.Color.Lavender;
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
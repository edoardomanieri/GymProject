namespace ViewProject
{
    partial class CreaSchedaManualeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreaSchedaManualeView));
            this.labelTitolo = new System.Windows.Forms.Label();
            this.buttonSalvaScheda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelASerie = new System.Windows.Forms.Panel();
            this.carico = new System.Windows.Forms.NumericUpDown();
            this.labelPeso = new System.Windows.Forms.Label();
            this.tempoRecupero = new System.Windows.Forms.NumericUpDown();
            this.labelTempoRecupero = new System.Windows.Forms.Label();
            this.numeroRipetizioni = new System.Windows.Forms.NumericUpDown();
            this.labelNumeroRipetizioni = new System.Windows.Forms.Label();
            this.numeroSerie = new System.Windows.Forms.NumericUpDown();
            this.labelNumeroSerie = new System.Windows.Forms.Label();
            this.comboBoxEserciziSerie = new System.Windows.Forms.ComboBox();
            this.labelFasciaMuscolare = new System.Windows.Forms.Label();
            this.comboBoxFasciaMuscolare = new System.Windows.Forms.ComboBox();
            this.labelEserzizio = new System.Windows.Forms.Label();
            this.comboBoxEsecuzioneEsercizio = new System.Windows.Forms.ComboBox();
            this.labelEsecuzioneEsercizio = new System.Windows.Forms.Label();
            this.giornoSettimana = new System.Windows.Forms.ComboBox();
            this.labelGiornoSettimana = new System.Windows.Forms.Label();
            this.buttonAggiungiEsercizio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRimuoviEsercizi = new System.Windows.Forms.Label();
            this.listBoxEsecuzioneEsercizi = new System.Windows.Forms.ListBox();
            this.buttonEliminaEsercizio = new System.Windows.Forms.Button();
            this.buttonSalvaGiornata = new System.Windows.Forms.Button();
            this.labelRecuperoGiornoAllenamento = new System.Windows.Forms.Label();
            this.recuperoGiornoAllenamento = new System.Windows.Forms.NumericUpDown();
            this.buttonIndietro = new System.Windows.Forms.Button();
            this.panelATempo = new System.Windows.Forms.Panel();
            this.numericUpDownTempo = new System.Windows.Forms.NumericUpDown();
            this.labelTempo2 = new System.Windows.Forms.Label();
            this.comboBoxEserciziTempo = new System.Windows.Forms.ComboBox();
            this.labelEsercizio2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelASerie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoRecupero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroRipetizioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSerie)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recuperoGiornoAllenamento)).BeginInit();
            this.panelATempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitolo
            // 
            this.labelTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitolo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitolo.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelTitolo.Location = new System.Drawing.Point(277, -2);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitolo.Size = new System.Drawing.Size(239, 28);
            this.labelTitolo.TabIndex = 2;
            this.labelTitolo.Text = "Crea la tua Scheda!";
            // 
            // buttonSalvaScheda
            // 
            this.buttonSalvaScheda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvaScheda.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSalvaScheda.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSalvaScheda.FlatAppearance.BorderSize = 2;
            this.buttonSalvaScheda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonSalvaScheda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonSalvaScheda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvaScheda.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvaScheda.Location = new System.Drawing.Point(643, 462);
            this.buttonSalvaScheda.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvaScheda.Name = "buttonSalvaScheda";
            this.buttonSalvaScheda.Size = new System.Drawing.Size(160, 30);
            this.buttonSalvaScheda.TabIndex = 46;
            this.buttonSalvaScheda.Tag = "";
            this.buttonSalvaScheda.Text = "Termina e Salva";
            this.buttonSalvaScheda.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panelASerie);
            this.panel1.Controls.Add(this.comboBoxEsecuzioneEsercizio);
            this.panel1.Controls.Add(this.labelEsecuzioneEsercizio);
            this.panel1.Controls.Add(this.giornoSettimana);
            this.panel1.Controls.Add(this.labelGiornoSettimana);
            this.panel1.Controls.Add(this.buttonAggiungiEsercizio);
            this.panel1.Location = new System.Drawing.Point(17, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 380);
            this.panel1.TabIndex = 47;
            // 
            // panelASerie
            // 
            this.panelASerie.BackColor = System.Drawing.Color.Transparent;
            this.panelASerie.Controls.Add(this.carico);
            this.panelASerie.Controls.Add(this.labelPeso);
            this.panelASerie.Controls.Add(this.tempoRecupero);
            this.panelASerie.Controls.Add(this.labelTempoRecupero);
            this.panelASerie.Controls.Add(this.numeroRipetizioni);
            this.panelASerie.Controls.Add(this.labelNumeroRipetizioni);
            this.panelASerie.Controls.Add(this.numeroSerie);
            this.panelASerie.Controls.Add(this.labelNumeroSerie);
            this.panelASerie.Controls.Add(this.comboBoxEserciziSerie);
            this.panelASerie.Controls.Add(this.labelFasciaMuscolare);
            this.panelASerie.Controls.Add(this.comboBoxFasciaMuscolare);
            this.panelASerie.Controls.Add(this.labelEserzizio);
            this.panelASerie.Location = new System.Drawing.Point(-2, 69);
            this.panelASerie.Name = "panelASerie";
            this.panelASerie.Size = new System.Drawing.Size(472, 254);
            this.panelASerie.TabIndex = 65;
            // 
            // carico
            // 
            this.carico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carico.BackColor = System.Drawing.Color.Lime;
            this.carico.Location = new System.Drawing.Point(316, 215);
            this.carico.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.carico.Name = "carico";
            this.carico.Size = new System.Drawing.Size(44, 20);
            this.carico.TabIndex = 101;
            // 
            // labelPeso
            // 
            this.labelPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.Color.Transparent;
            this.labelPeso.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelPeso.Location = new System.Drawing.Point(3, 204);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPeso.Size = new System.Drawing.Size(279, 31);
            this.labelPeso.TabIndex = 100;
            this.labelPeso.Text = "Inserisci il carico in Kg (opzionale)";
            this.labelPeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempoRecupero
            // 
            this.tempoRecupero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tempoRecupero.BackColor = System.Drawing.Color.Lime;
            this.tempoRecupero.Location = new System.Drawing.Point(314, 175);
            this.tempoRecupero.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.tempoRecupero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tempoRecupero.Name = "tempoRecupero";
            this.tempoRecupero.Size = new System.Drawing.Size(44, 20);
            this.tempoRecupero.TabIndex = 95;
            this.tempoRecupero.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelTempoRecupero
            // 
            this.labelTempoRecupero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTempoRecupero.AutoSize = true;
            this.labelTempoRecupero.BackColor = System.Drawing.Color.Transparent;
            this.labelTempoRecupero.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempoRecupero.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelTempoRecupero.Location = new System.Drawing.Point(38, 164);
            this.labelTempoRecupero.Name = "labelTempoRecupero";
            this.labelTempoRecupero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTempoRecupero.Size = new System.Drawing.Size(235, 31);
            this.labelTempoRecupero.TabIndex = 94;
            this.labelTempoRecupero.Text = "Tempo di recupero (secondi)";
            this.labelTempoRecupero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeroRipetizioni
            // 
            this.numeroRipetizioni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeroRipetizioni.BackColor = System.Drawing.Color.Lime;
            this.numeroRipetizioni.Location = new System.Drawing.Point(314, 134);
            this.numeroRipetizioni.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeroRipetizioni.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroRipetizioni.Name = "numeroRipetizioni";
            this.numeroRipetizioni.Size = new System.Drawing.Size(44, 20);
            this.numeroRipetizioni.TabIndex = 93;
            this.numeroRipetizioni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumeroRipetizioni
            // 
            this.labelNumeroRipetizioni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumeroRipetizioni.AutoSize = true;
            this.labelNumeroRipetizioni.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeroRipetizioni.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroRipetizioni.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelNumeroRipetizioni.Location = new System.Drawing.Point(28, 121);
            this.labelNumeroRipetizioni.Name = "labelNumeroRipetizioni";
            this.labelNumeroRipetizioni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNumeroRipetizioni.Size = new System.Drawing.Size(245, 31);
            this.labelNumeroRipetizioni.TabIndex = 92;
            this.labelNumeroRipetizioni.Text = "Numero di ripetizioni per serie";
            this.labelNumeroRipetizioni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeroSerie
            // 
            this.numeroSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeroSerie.BackColor = System.Drawing.Color.Lime;
            this.numeroSerie.Location = new System.Drawing.Point(314, 95);
            this.numeroSerie.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numeroSerie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeroSerie.Name = "numeroSerie";
            this.numeroSerie.Size = new System.Drawing.Size(44, 20);
            this.numeroSerie.TabIndex = 91;
            this.numeroSerie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumeroSerie
            // 
            this.labelNumeroSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumeroSerie.AutoSize = true;
            this.labelNumeroSerie.BackColor = System.Drawing.Color.Transparent;
            this.labelNumeroSerie.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroSerie.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelNumeroSerie.Location = new System.Drawing.Point(52, 84);
            this.labelNumeroSerie.Name = "labelNumeroSerie";
            this.labelNumeroSerie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNumeroSerie.Size = new System.Drawing.Size(221, 31);
            this.labelNumeroSerie.TabIndex = 90;
            this.labelNumeroSerie.Text = "Specifica il numero di serie";
            this.labelNumeroSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxEserciziSerie
            // 
            this.comboBoxEserciziSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEserciziSerie.BackColor = System.Drawing.Color.Lime;
            this.comboBoxEserciziSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEserciziSerie.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEserciziSerie.FormattingEnabled = true;
            this.comboBoxEserciziSerie.Items.AddRange(new object[] {
            "Panca Piana",
            "Curl",
            "Leg Exstension",
            "blabla",
            "blabla",
            "blabla",
            "blabla",
            "adasdada",
            "ds",
            "d",
            "d",
            "d",
            "d",
            "d",
            "ds",
            "sa",
            "d",
            "s",
            "s",
            "s",
            "s",
            "",
            "d",
            "d",
            "d",
            "d"});
            this.comboBoxEserciziSerie.Location = new System.Drawing.Point(302, 52);
            this.comboBoxEserciziSerie.Name = "comboBoxEserciziSerie";
            this.comboBoxEserciziSerie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxEserciziSerie.Size = new System.Drawing.Size(120, 21);
            this.comboBoxEserciziSerie.TabIndex = 89;
            this.comboBoxEserciziSerie.Text = "Esercizio";
            // 
            // labelFasciaMuscolare
            // 
            this.labelFasciaMuscolare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFasciaMuscolare.AutoSize = true;
            this.labelFasciaMuscolare.BackColor = System.Drawing.Color.Transparent;
            this.labelFasciaMuscolare.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFasciaMuscolare.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelFasciaMuscolare.Location = new System.Drawing.Point(58, 4);
            this.labelFasciaMuscolare.Name = "labelFasciaMuscolare";
            this.labelFasciaMuscolare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFasciaMuscolare.Size = new System.Drawing.Size(217, 31);
            this.labelFasciaMuscolare.TabIndex = 88;
            this.labelFasciaMuscolare.Text = "Indica la fascia muscolare ";
            this.labelFasciaMuscolare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxFasciaMuscolare
            // 
            this.comboBoxFasciaMuscolare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxFasciaMuscolare.BackColor = System.Drawing.Color.Lime;
            this.comboBoxFasciaMuscolare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFasciaMuscolare.ForeColor = System.Drawing.Color.Black;
            this.comboBoxFasciaMuscolare.FormattingEnabled = true;
            this.comboBoxFasciaMuscolare.Items.AddRange(new object[] {
            "Addominali",
            "Bicipiti",
            "Tricipiti",
            "Deltoidi",
            "Dorsali",
            "Pettorali",
            "Polpacci",
            "Quadricipiti",
            "Adduttori"});
            this.comboBoxFasciaMuscolare.Location = new System.Drawing.Point(302, 14);
            this.comboBoxFasciaMuscolare.Name = "comboBoxFasciaMuscolare";
            this.comboBoxFasciaMuscolare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFasciaMuscolare.Size = new System.Drawing.Size(120, 21);
            this.comboBoxFasciaMuscolare.TabIndex = 87;
            this.comboBoxFasciaMuscolare.Text = "Fascia Muscolare";
            // 
            // labelEserzizio
            // 
            this.labelEserzizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEserzizio.AutoSize = true;
            this.labelEserzizio.BackColor = System.Drawing.Color.Transparent;
            this.labelEserzizio.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEserzizio.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelEserzizio.Location = new System.Drawing.Point(104, 42);
            this.labelEserzizio.Name = "labelEserzizio";
            this.labelEserzizio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEserzizio.Size = new System.Drawing.Size(169, 31);
            this.labelEserzizio.TabIndex = 86;
            this.labelEserzizio.Text = "Seleziona l\'esercizio";
            this.labelEserzizio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxEsecuzioneEsercizio
            // 
            this.comboBoxEsecuzioneEsercizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEsecuzioneEsercizio.BackColor = System.Drawing.Color.Lime;
            this.comboBoxEsecuzioneEsercizio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEsecuzioneEsercizio.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEsecuzioneEsercizio.FormattingEnabled = true;
            this.comboBoxEsecuzioneEsercizio.Items.AddRange(new object[] {
            "Esercizio a tempo",
            "Esercizio a serie"});
            this.comboBoxEsecuzioneEsercizio.Location = new System.Drawing.Point(300, 49);
            this.comboBoxEsecuzioneEsercizio.Name = "comboBoxEsecuzioneEsercizio";
            this.comboBoxEsecuzioneEsercizio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxEsecuzioneEsercizio.Size = new System.Drawing.Size(120, 21);
            this.comboBoxEsecuzioneEsercizio.TabIndex = 64;
            this.comboBoxEsecuzioneEsercizio.Text = "Tipo Esercizio";
            this.comboBoxEsecuzioneEsercizio.SelectedIndexChanged += new System.EventHandler(this.comboBoxEsecuzioneEsercizio_TextChanged);
            // 
            // labelEsecuzioneEsercizio
            // 
            this.labelEsecuzioneEsercizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEsecuzioneEsercizio.AutoSize = true;
            this.labelEsecuzioneEsercizio.BackColor = System.Drawing.Color.Transparent;
            this.labelEsecuzioneEsercizio.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEsecuzioneEsercizio.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelEsecuzioneEsercizio.Location = new System.Drawing.Point(77, 38);
            this.labelEsecuzioneEsercizio.Name = "labelEsecuzioneEsercizio";
            this.labelEsecuzioneEsercizio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEsecuzioneEsercizio.Size = new System.Drawing.Size(196, 31);
            this.labelEsecuzioneEsercizio.TabIndex = 63;
            this.labelEsecuzioneEsercizio.Text = "Indica il tipo di esercizio";
            this.labelEsecuzioneEsercizio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // giornoSettimana
            // 
            this.giornoSettimana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.giornoSettimana.BackColor = System.Drawing.Color.Lime;
            this.giornoSettimana.FormattingEnabled = true;
            this.giornoSettimana.Items.AddRange(new object[] {
            "1"});
            this.giornoSettimana.Location = new System.Drawing.Point(300, 16);
            this.giornoSettimana.Name = "giornoSettimana";
            this.giornoSettimana.Size = new System.Drawing.Size(120, 21);
            this.giornoSettimana.TabIndex = 62;
            this.giornoSettimana.Text = "Giorno Settimana";
            // 
            // labelGiornoSettimana
            // 
            this.labelGiornoSettimana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGiornoSettimana.AutoSize = true;
            this.labelGiornoSettimana.BackColor = System.Drawing.Color.Transparent;
            this.labelGiornoSettimana.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiornoSettimana.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelGiornoSettimana.Location = new System.Drawing.Point(124, 6);
            this.labelGiornoSettimana.Name = "labelGiornoSettimana";
            this.labelGiornoSettimana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelGiornoSettimana.Size = new System.Drawing.Size(149, 31);
            this.labelGiornoSettimana.TabIndex = 52;
            this.labelGiornoSettimana.Text = "Specifica il giorno";
            this.labelGiornoSettimana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAggiungiEsercizio
            // 
            this.buttonAggiungiEsercizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAggiungiEsercizio.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonAggiungiEsercizio.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonAggiungiEsercizio.FlatAppearance.BorderSize = 2;
            this.buttonAggiungiEsercizio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonAggiungiEsercizio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonAggiungiEsercizio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAggiungiEsercizio.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggiungiEsercizio.Location = new System.Drawing.Point(185, 326);
            this.buttonAggiungiEsercizio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAggiungiEsercizio.Name = "buttonAggiungiEsercizio";
            this.buttonAggiungiEsercizio.Size = new System.Drawing.Size(130, 30);
            this.buttonAggiungiEsercizio.TabIndex = 61;
            this.buttonAggiungiEsercizio.Tag = "";
            this.buttonAggiungiEsercizio.Text = "Aggiungi esercizio";
            this.buttonAggiungiEsercizio.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelRimuoviEsercizi);
            this.panel2.Controls.Add(this.listBoxEsecuzioneEsercizi);
            this.panel2.Controls.Add(this.buttonEliminaEsercizio);
            this.panel2.Location = new System.Drawing.Point(519, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 380);
            this.panel2.TabIndex = 65;
            // 
            // labelRimuoviEsercizi
            // 
            this.labelRimuoviEsercizi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRimuoviEsercizi.AutoSize = true;
            this.labelRimuoviEsercizi.BackColor = System.Drawing.Color.Transparent;
            this.labelRimuoviEsercizi.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRimuoviEsercizi.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelRimuoviEsercizi.Location = new System.Drawing.Point(58, 256);
            this.labelRimuoviEsercizi.Name = "labelRimuoviEsercizi";
            this.labelRimuoviEsercizi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRimuoviEsercizi.Size = new System.Drawing.Size(169, 48);
            this.labelRimuoviEsercizi.TabIndex = 69;
            this.labelRimuoviEsercizi.Text = "Indica il giorno e seleziona \r\nl\'esercizio per rimuoverlo";
            this.labelRimuoviEsercizi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxEsecuzioneEsercizi
            // 
            this.listBoxEsecuzioneEsercizi.FormattingEnabled = true;
            this.listBoxEsecuzioneEsercizi.Location = new System.Drawing.Point(20, 16);
            this.listBoxEsecuzioneEsercizi.Name = "listBoxEsecuzioneEsercizi";
            this.listBoxEsecuzioneEsercizi.Size = new System.Drawing.Size(243, 225);
            this.listBoxEsecuzioneEsercizi.TabIndex = 68;
            // 
            // buttonEliminaEsercizio
            // 
            this.buttonEliminaEsercizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEliminaEsercizio.BackColor = System.Drawing.Color.Crimson;
            this.buttonEliminaEsercizio.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonEliminaEsercizio.FlatAppearance.BorderSize = 2;
            this.buttonEliminaEsercizio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonEliminaEsercizio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonEliminaEsercizio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminaEsercizio.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminaEsercizio.Location = new System.Drawing.Point(74, 326);
            this.buttonEliminaEsercizio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminaEsercizio.Name = "buttonEliminaEsercizio";
            this.buttonEliminaEsercizio.Size = new System.Drawing.Size(127, 30);
            this.buttonEliminaEsercizio.TabIndex = 66;
            this.buttonEliminaEsercizio.Tag = "";
            this.buttonEliminaEsercizio.Text = "Rimuovi esercizio";
            this.buttonEliminaEsercizio.UseVisualStyleBackColor = false;
            // 
            // buttonSalvaGiornata
            // 
            this.buttonSalvaGiornata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvaGiornata.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonSalvaGiornata.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSalvaGiornata.FlatAppearance.BorderSize = 2;
            this.buttonSalvaGiornata.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonSalvaGiornata.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonSalvaGiornata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvaGiornata.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvaGiornata.Location = new System.Drawing.Point(204, 452);
            this.buttonSalvaGiornata.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvaGiornata.Name = "buttonSalvaGiornata";
            this.buttonSalvaGiornata.Size = new System.Drawing.Size(130, 30);
            this.buttonSalvaGiornata.TabIndex = 66;
            this.buttonSalvaGiornata.Tag = "";
            this.buttonSalvaGiornata.Text = "Salva Giornata";
            this.buttonSalvaGiornata.UseVisualStyleBackColor = false;
            // 
            // labelRecuperoGiornoAllenamento
            // 
            this.labelRecuperoGiornoAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRecuperoGiornoAllenamento.AutoSize = true;
            this.labelRecuperoGiornoAllenamento.BackColor = System.Drawing.Color.Transparent;
            this.labelRecuperoGiornoAllenamento.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecuperoGiornoAllenamento.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelRecuperoGiornoAllenamento.Location = new System.Drawing.Point(113, 418);
            this.labelRecuperoGiornoAllenamento.Name = "labelRecuperoGiornoAllenamento";
            this.labelRecuperoGiornoAllenamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRecuperoGiornoAllenamento.Size = new System.Drawing.Size(289, 20);
            this.labelRecuperoGiornoAllenamento.TabIndex = 67;
            this.labelRecuperoGiornoAllenamento.Text = "Tempo di recupero tra un esercizio e un altro (secondi)";
            this.labelRecuperoGiornoAllenamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recuperoGiornoAllenamento
            // 
            this.recuperoGiornoAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recuperoGiornoAllenamento.BackColor = System.Drawing.Color.Lime;
            this.recuperoGiornoAllenamento.Location = new System.Drawing.Point(408, 418);
            this.recuperoGiornoAllenamento.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.recuperoGiornoAllenamento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.recuperoGiornoAllenamento.Name = "recuperoGiornoAllenamento";
            this.recuperoGiornoAllenamento.Size = new System.Drawing.Size(40, 20);
            this.recuperoGiornoAllenamento.TabIndex = 68;
            this.recuperoGiornoAllenamento.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // buttonIndietro
            // 
            this.buttonIndietro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIndietro.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonIndietro.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonIndietro.FlatAppearance.BorderSize = 2;
            this.buttonIndietro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonIndietro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonIndietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndietro.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndietro.Location = new System.Drawing.Point(20, 462);
            this.buttonIndietro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIndietro.Name = "buttonIndietro";
            this.buttonIndietro.Size = new System.Drawing.Size(86, 30);
            this.buttonIndietro.TabIndex = 69;
            this.buttonIndietro.Tag = "";
            this.buttonIndietro.Text = "Indietro";
            this.buttonIndietro.UseVisualStyleBackColor = false;
            // 
            // panelATempo
            // 
            this.panelATempo.BackColor = System.Drawing.Color.Transparent;
            this.panelATempo.Controls.Add(this.numericUpDownTempo);
            this.panelATempo.Controls.Add(this.labelTempo2);
            this.panelATempo.Controls.Add(this.comboBoxEserciziTempo);
            this.panelATempo.Controls.Add(this.labelEsercizio2);
            this.panelATempo.Location = new System.Drawing.Point(17, 101);
            this.panelATempo.Name = "panelATempo";
            this.panelATempo.Size = new System.Drawing.Size(472, 254);
            this.panelATempo.TabIndex = 102;
            // 
            // numericUpDownTempo
            // 
            this.numericUpDownTempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownTempo.BackColor = System.Drawing.Color.Lime;
            this.numericUpDownTempo.Location = new System.Drawing.Point(299, 69);
            this.numericUpDownTempo.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTempo.Name = "numericUpDownTempo";
            this.numericUpDownTempo.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownTempo.TabIndex = 96;
            this.numericUpDownTempo.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelTempo2
            // 
            this.labelTempo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTempo2.AutoSize = true;
            this.labelTempo2.BackColor = System.Drawing.Color.Transparent;
            this.labelTempo2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempo2.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelTempo2.Location = new System.Drawing.Point(91, 42);
            this.labelTempo2.Name = "labelTempo2";
            this.labelTempo2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTempo2.Size = new System.Drawing.Size(179, 62);
            this.labelTempo2.TabIndex = 67;
            this.labelTempo2.Text = "     Indica la durata \r\ndell\'esercizio (minuti)";
            this.labelTempo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxEserciziTempo
            // 
            this.comboBoxEserciziTempo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEserciziTempo.BackColor = System.Drawing.Color.Lime;
            this.comboBoxEserciziTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEserciziTempo.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEserciziTempo.FormattingEnabled = true;
            this.comboBoxEserciziTempo.Location = new System.Drawing.Point(299, 16);
            this.comboBoxEserciziTempo.Name = "comboBoxEserciziTempo";
            this.comboBoxEserciziTempo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxEserciziTempo.Size = new System.Drawing.Size(120, 21);
            this.comboBoxEserciziTempo.TabIndex = 66;
            this.comboBoxEserciziTempo.Text = "Esercizio";
            // 
            // labelEsercizio2
            // 
            this.labelEsercizio2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEsercizio2.AutoSize = true;
            this.labelEsercizio2.BackColor = System.Drawing.Color.Transparent;
            this.labelEsercizio2.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEsercizio2.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelEsercizio2.Location = new System.Drawing.Point(101, 6);
            this.labelEsercizio2.Name = "labelEsercizio2";
            this.labelEsercizio2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEsercizio2.Size = new System.Drawing.Size(169, 31);
            this.labelEsercizio2.TabIndex = 65;
            this.labelEsercizio2.Text = "Seleziona l\'esercizio";
            this.labelEsercizio2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CreaSchedaManualeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelATempo);
            this.Controls.Add(this.buttonIndietro);
            this.Controls.Add(this.recuperoGiornoAllenamento);
            this.Controls.Add(this.labelRecuperoGiornoAllenamento);
            this.Controls.Add(this.buttonSalvaGiornata);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSalvaScheda);
            this.Controls.Add(this.labelTitolo);
            this.Name = "CreaSchedaManualeView";
            this.Size = new System.Drawing.Size(822, 512);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelASerie.ResumeLayout(false);
            this.panelASerie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoRecupero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroRipetizioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSerie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recuperoGiornoAllenamento)).EndInit();
            this.panelATempo.ResumeLayout(false);
            this.panelATempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboGiorno;
        private System.Windows.Forms.Label labelGiornoSettimana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRimuoviEsercizi;
        public System.Windows.Forms.Button buttonSalvaScheda;
        public System.Windows.Forms.Button buttonAggiungiEsercizio;
        public System.Windows.Forms.ListBox listBoxEsecuzioneEsercizi;
        public System.Windows.Forms.Button buttonEliminaEsercizio;
        public System.Windows.Forms.ComboBox comboBoxEsecuzioneEsercizio;
        private System.Windows.Forms.Label labelEsecuzioneEsercizio;
        public System.Windows.Forms.Button buttonSalvaGiornata;
        private System.Windows.Forms.Label labelRecuperoGiornoAllenamento;
        public System.Windows.Forms.NumericUpDown recuperoGiornoAllenamento;
        private System.Windows.Forms.Panel panelASerie;
        public System.Windows.Forms.NumericUpDown tempoRecupero;
        private System.Windows.Forms.Label labelTempoRecupero;
        public System.Windows.Forms.NumericUpDown numeroRipetizioni;
        private System.Windows.Forms.Label labelNumeroRipetizioni;
        public System.Windows.Forms.NumericUpDown numeroSerie;
        private System.Windows.Forms.Label labelNumeroSerie;
        public System.Windows.Forms.ComboBox comboBoxEserciziSerie;
        private System.Windows.Forms.Label labelFasciaMuscolare;
        public System.Windows.Forms.ComboBox comboBoxFasciaMuscolare;
        private System.Windows.Forms.Label labelEserzizio;
        public System.Windows.Forms.NumericUpDown carico;
        private System.Windows.Forms.Label labelPeso;
        public System.Windows.Forms.ComboBox giornoSettimana;
        public System.Windows.Forms.Button buttonIndietro;
        private System.Windows.Forms.Panel panelATempo;
        public System.Windows.Forms.NumericUpDown numericUpDownTempo;
        private System.Windows.Forms.Label labelTempo2;
        public System.Windows.Forms.ComboBox comboBoxEserciziTempo;
        private System.Windows.Forms.Label labelEsercizio2;
    }
}
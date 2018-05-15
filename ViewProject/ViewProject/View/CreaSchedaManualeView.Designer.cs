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
            this.giornoSettimana = new System.Windows.Forms.ComboBox();
            this.labelGiornoSettimana = new System.Windows.Forms.Label();
            this.buttonAggiungiEsercizio = new System.Windows.Forms.Button();
            this.carico = new System.Windows.Forms.NumericUpDown();
            this.labelPeso = new System.Windows.Forms.Label();
            this.tempoRecupero = new System.Windows.Forms.NumericUpDown();
            this.labelTempoRecupero = new System.Windows.Forms.Label();
            this.numeroRipetizioni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numeroSerie = new System.Windows.Forms.NumericUpDown();
            this.labelNumeroSerie = new System.Windows.Forms.Label();
            this.comboBoxEsercizi = new System.Windows.Forms.ComboBox();
            this.labelFasciaMuscolare = new System.Windows.Forms.Label();
            this.comboBoxFasciaMuscolare = new System.Windows.Forms.ComboBox();
            this.labelEserzizio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRimuoviEsercizi = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBoxGiornoAllenamento = new System.Windows.Forms.ComboBox();
            this.buttonEliminaEsercizio = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoRecupero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroRipetizioni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSerie)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitolo
            // 
            this.labelTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitolo.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitolo.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelTitolo.Location = new System.Drawing.Point(248, 24);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitolo.Size = new System.Drawing.Size(262, 29);
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
            this.buttonSalvaScheda.Location = new System.Drawing.Point(315, 447);
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
            this.panel1.Controls.Add(this.giornoSettimana);
            this.panel1.Controls.Add(this.labelGiornoSettimana);
            this.panel1.Controls.Add(this.buttonAggiungiEsercizio);
            this.panel1.Controls.Add(this.carico);
            this.panel1.Controls.Add(this.labelPeso);
            this.panel1.Controls.Add(this.tempoRecupero);
            this.panel1.Controls.Add(this.labelTempoRecupero);
            this.panel1.Controls.Add(this.numeroRipetizioni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numeroSerie);
            this.panel1.Controls.Add(this.labelNumeroSerie);
            this.panel1.Controls.Add(this.comboBoxEsercizi);
            this.panel1.Controls.Add(this.labelFasciaMuscolare);
            this.panel1.Controls.Add(this.comboBoxFasciaMuscolare);
            this.panel1.Controls.Add(this.labelEserzizio);
            this.panel1.Location = new System.Drawing.Point(33, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 363);
            this.panel1.TabIndex = 47;
            // 
            // giornoSettimana
            // 
            this.giornoSettimana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.giornoSettimana.BackColor = System.Drawing.Color.Lime;
            this.giornoSettimana.FormattingEnabled = true;
            this.giornoSettimana.Items.AddRange(new object[] {
            "Lunedì",
            "Martedì",
            "Mercoledì",
            "Giovedì",
            "Sabato",
            "Domenica"});
            this.giornoSettimana.Location = new System.Drawing.Point(303, 19);
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
            this.labelGiornoSettimana.Location = new System.Drawing.Point(143, 9);
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
            this.buttonAggiungiEsercizio.Location = new System.Drawing.Point(179, 311);
            this.buttonAggiungiEsercizio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAggiungiEsercizio.Name = "buttonAggiungiEsercizio";
            this.buttonAggiungiEsercizio.Size = new System.Drawing.Size(130, 30);
            this.buttonAggiungiEsercizio.TabIndex = 61;
            this.buttonAggiungiEsercizio.Tag = "";
            this.buttonAggiungiEsercizio.Text = "Aggiungi esercizio";
            this.buttonAggiungiEsercizio.UseVisualStyleBackColor = false;
            // 
            // carico
            // 
            this.carico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.carico.BackColor = System.Drawing.Color.Lime;
            this.carico.Location = new System.Drawing.Point(307, 269);
            this.carico.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.carico.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.carico.Name = "carico";
            this.carico.Size = new System.Drawing.Size(44, 20);
            this.carico.TabIndex = 60;
            this.carico.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPeso
            // 
            this.labelPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.Color.Transparent;
            this.labelPeso.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelPeso.Location = new System.Drawing.Point(13, 258);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPeso.Size = new System.Drawing.Size(279, 31);
            this.labelPeso.TabIndex = 59;
            this.labelPeso.Text = "Inserisci il carico in Kg (opzionale)";
            this.labelPeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempoRecupero
            // 
            this.tempoRecupero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tempoRecupero.BackColor = System.Drawing.Color.Lime;
            this.tempoRecupero.Location = new System.Drawing.Point(307, 227);
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
            this.tempoRecupero.TabIndex = 58;
            this.tempoRecupero.Value = new decimal(new int[] {
            1,
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
            this.labelTempoRecupero.Location = new System.Drawing.Point(57, 216);
            this.labelTempoRecupero.Name = "labelTempoRecupero";
            this.labelTempoRecupero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTempoRecupero.Size = new System.Drawing.Size(235, 31);
            this.labelTempoRecupero.TabIndex = 57;
            this.labelTempoRecupero.Text = "Tempo di recupero (secondi)";
            this.labelTempoRecupero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeroRipetizioni
            // 
            this.numeroRipetizioni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeroRipetizioni.BackColor = System.Drawing.Color.Lime;
            this.numeroRipetizioni.Location = new System.Drawing.Point(307, 185);
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
            this.numeroRipetizioni.TabIndex = 56;
            this.numeroRipetizioni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(47, 174);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 55;
            this.label1.Text = "Numero di ripetizioni per serie";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numeroSerie
            // 
            this.numeroSerie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numeroSerie.BackColor = System.Drawing.Color.Lime;
            this.numeroSerie.Location = new System.Drawing.Point(307, 148);
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
            this.numeroSerie.TabIndex = 54;
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
            this.labelNumeroSerie.Location = new System.Drawing.Point(71, 135);
            this.labelNumeroSerie.Name = "labelNumeroSerie";
            this.labelNumeroSerie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNumeroSerie.Size = new System.Drawing.Size(221, 31);
            this.labelNumeroSerie.TabIndex = 53;
            this.labelNumeroSerie.Text = "Specifica il numero di serie";
            this.labelNumeroSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxEsercizi
            // 
            this.comboBoxEsercizi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEsercizi.BackColor = System.Drawing.Color.Lime;
            this.comboBoxEsercizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEsercizi.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEsercizi.FormattingEnabled = true;
            this.comboBoxEsercizi.Items.AddRange(new object[] {
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
            this.comboBoxEsercizi.Location = new System.Drawing.Point(305, 103);
            this.comboBoxEsercizi.Name = "comboBoxEsercizi";
            this.comboBoxEsercizi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxEsercizi.Size = new System.Drawing.Size(120, 21);
            this.comboBoxEsercizi.TabIndex = 52;
            this.comboBoxEsercizi.Text = "Esercizio";
            // 
            // labelFasciaMuscolare
            // 
            this.labelFasciaMuscolare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFasciaMuscolare.AutoSize = true;
            this.labelFasciaMuscolare.BackColor = System.Drawing.Color.Transparent;
            this.labelFasciaMuscolare.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFasciaMuscolare.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelFasciaMuscolare.Location = new System.Drawing.Point(82, 48);
            this.labelFasciaMuscolare.Name = "labelFasciaMuscolare";
            this.labelFasciaMuscolare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFasciaMuscolare.Size = new System.Drawing.Size(217, 31);
            this.labelFasciaMuscolare.TabIndex = 51;
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
            "Quadricipiti"});
            this.comboBoxFasciaMuscolare.Location = new System.Drawing.Point(305, 58);
            this.comboBoxFasciaMuscolare.Name = "comboBoxFasciaMuscolare";
            this.comboBoxFasciaMuscolare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFasciaMuscolare.Size = new System.Drawing.Size(120, 21);
            this.comboBoxFasciaMuscolare.TabIndex = 50;
            this.comboBoxFasciaMuscolare.Text = "Fascia Muscolare";
            // 
            // labelEserzizio
            // 
            this.labelEserzizio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEserzizio.AutoSize = true;
            this.labelEserzizio.BackColor = System.Drawing.Color.Transparent;
            this.labelEserzizio.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEserzizio.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelEserzizio.Location = new System.Drawing.Point(123, 93);
            this.labelEserzizio.Name = "labelEserzizio";
            this.labelEserzizio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEserzizio.Size = new System.Drawing.Size(169, 31);
            this.labelEserzizio.TabIndex = 49;
            this.labelEserzizio.Text = "Seleziona l\'esercizio";
            this.labelEserzizio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.labelRimuoviEsercizi);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.comboBoxGiornoAllenamento);
            this.panel2.Controls.Add(this.buttonEliminaEsercizio);
            this.panel2.Location = new System.Drawing.Point(526, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 363);
            this.panel2.TabIndex = 65;
            // 
            // labelRimuoviEsercizi
            // 
            this.labelRimuoviEsercizi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRimuoviEsercizi.AutoSize = true;
            this.labelRimuoviEsercizi.BackColor = System.Drawing.Color.Transparent;
            this.labelRimuoviEsercizi.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRimuoviEsercizi.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelRimuoviEsercizi.Location = new System.Drawing.Point(59, 251);
            this.labelRimuoviEsercizi.Name = "labelRimuoviEsercizi";
            this.labelRimuoviEsercizi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRimuoviEsercizi.Size = new System.Drawing.Size(169, 48);
            this.labelRimuoviEsercizi.TabIndex = 69;
            this.labelRimuoviEsercizi.Text = "Indica il giorno e seleziona \r\nl\'esercizio per rimuoverlo";
            this.labelRimuoviEsercizi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "-Panca Piana: 4x8, 2 min di recupero, 50 Kg",
            "-Leg Curl: 3x8, 3 min di recupero, 20 Kg",
            "etcc"});
            this.listBox1.Location = new System.Drawing.Point(8, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 186);
            this.listBox1.TabIndex = 68;
            // 
            // comboBoxGiornoAllenamento
            // 
            this.comboBoxGiornoAllenamento.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBoxGiornoAllenamento.FormattingEnabled = true;
            this.comboBoxGiornoAllenamento.Location = new System.Drawing.Point(63, 19);
            this.comboBoxGiornoAllenamento.Name = "comboBoxGiornoAllenamento";
            this.comboBoxGiornoAllenamento.Size = new System.Drawing.Size(123, 21);
            this.comboBoxGiornoAllenamento.TabIndex = 67;
            this.comboBoxGiornoAllenamento.Text = "Popolato man mano";
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
            this.buttonEliminaEsercizio.Location = new System.Drawing.Point(77, 311);
            this.buttonEliminaEsercizio.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEliminaEsercizio.Name = "buttonEliminaEsercizio";
            this.buttonEliminaEsercizio.Size = new System.Drawing.Size(127, 30);
            this.buttonEliminaEsercizio.TabIndex = 66;
            this.buttonEliminaEsercizio.Tag = "";
            this.buttonEliminaEsercizio.Text = "Rimuovi esercizio";
            this.buttonEliminaEsercizio.UseVisualStyleBackColor = false;
            // 
            // CreaSchedaManualeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSalvaScheda);
            this.Controls.Add(this.labelTitolo);
            this.Name = "CreaSchedaManualeView";
            this.Size = new System.Drawing.Size(822, 512);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempoRecupero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroRipetizioni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeroSerie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelTempoRecupero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumeroSerie;
        private System.Windows.Forms.Label labelFasciaMuscolare;
        private System.Windows.Forms.Label labelEserzizio;
        private System.Windows.Forms.ComboBox comboGiorno;
        private System.Windows.Forms.Label labelGiornoSettimana;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRimuoviEsercizi;
        public System.Windows.Forms.ComboBox giornoSettimana;
        public System.Windows.Forms.Button buttonSalvaScheda;
        public System.Windows.Forms.Button buttonAggiungiEsercizio;
        public System.Windows.Forms.NumericUpDown carico;
        public System.Windows.Forms.NumericUpDown tempoRecupero;
        public System.Windows.Forms.NumericUpDown numeroRipetizioni;
        public System.Windows.Forms.NumericUpDown numeroSerie;
        public System.Windows.Forms.ComboBox comboBoxEsercizi;
        public System.Windows.Forms.ComboBox comboBoxFasciaMuscolare;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ComboBox comboBoxGiornoAllenamento;
        public System.Windows.Forms.Button buttonEliminaEsercizio;
    }
}
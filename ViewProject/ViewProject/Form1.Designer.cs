namespace ViewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.labelTitolo = new System.Windows.Forms.Label();
            this.TextBoxCognome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCognome = new System.Windows.Forms.Label();
            this.labelSesso = new System.Windows.Forms.Label();
            this.RadioButtonMaschio = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemmina = new System.Windows.Forms.RadioButton();
            this.labelDataNascita = new System.Windows.Forms.Label();
            this.comboBoxGiorno = new System.Windows.Forms.ComboBox();
            this.comboBoxMese = new System.Windows.Forms.ComboBox();
            this.comboBoxAnno = new System.Windows.Forms.ComboBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfermaPassword = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelPeso = new System.Windows.Forms.Label();
            this.numericUpDownPeso = new System.Windows.Forms.NumericUpDown();
            this.labelAltezza = new System.Windows.Forms.Label();
            this.numericUpDownAltezza = new System.Windows.Forms.NumericUpDown();
            this.imageShowPassword = new System.Windows.Forms.PictureBox();
            this.imageHidePassword = new System.Windows.Forms.PictureBox();
            this.buttonProcedi = new System.Windows.Forms.Button();
            this.buttonShowHide1 = new System.Windows.Forms.Button();
            this.buttonShowHide2 = new System.Windows.Forms.Button();
            this.labelScheda = new System.Windows.Forms.Label();
            this.checkBoxAutomatica = new System.Windows.Forms.CheckBox();
            this.checkBoxManuale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltezza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHidePassword)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxNome.BackColor = System.Drawing.Color.IndianRed;
            this.TextBoxNome.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNome.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxNome.Location = new System.Drawing.Point(376, 107);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxNome.Size = new System.Drawing.Size(114, 23);
            this.TextBoxNome.TabIndex = 0;
            this.TextBoxNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTitolo
            // 
            this.labelTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitolo.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitolo.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelTitolo.Location = new System.Drawing.Point(253, 26);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitolo.Size = new System.Drawing.Size(311, 29);
            this.labelTitolo.TabIndex = 1;
            this.labelTitolo.Text = "Crea un nuovo account!";
            this.labelTitolo.Click += new System.EventHandler(this.inserisciNome_Click);
            // 
            // TextBoxCognome
            // 
            this.TextBoxCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxCognome.BackColor = System.Drawing.Color.IndianRed;
            this.TextBoxCognome.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCognome.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxCognome.Location = new System.Drawing.Point(376, 141);
            this.TextBoxCognome.Name = "TextBoxCognome";
            this.TextBoxCognome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxCognome.Size = new System.Drawing.Size(114, 23);
            this.TextBoxCognome.TabIndex = 2;
            this.TextBoxCognome.Tag = "";
            this.TextBoxCognome.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelNome
            // 
            this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNome.AutoSize = true;
            this.labelNome.BackColor = System.Drawing.Color.Transparent;
            this.labelNome.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelNome.Location = new System.Drawing.Point(305, 100);
            this.labelNome.Name = "labelNome";
            this.labelNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNome.Size = new System.Drawing.Size(43, 24);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelCognome
            // 
            this.labelCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCognome.AutoSize = true;
            this.labelCognome.BackColor = System.Drawing.Color.Transparent;
            this.labelCognome.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCognome.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelCognome.Location = new System.Drawing.Point(284, 135);
            this.labelCognome.Name = "labelCognome";
            this.labelCognome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCognome.Size = new System.Drawing.Size(64, 24);
            this.labelCognome.TabIndex = 5;
            this.labelCognome.Text = "Cognome";
            this.labelCognome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCognome.Click += new System.EventHandler(this.labelCognome_Click);
            // 
            // labelSesso
            // 
            this.labelSesso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSesso.AutoSize = true;
            this.labelSesso.BackColor = System.Drawing.Color.Transparent;
            this.labelSesso.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSesso.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelSesso.Location = new System.Drawing.Point(302, 176);
            this.labelSesso.Name = "labelSesso";
            this.labelSesso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSesso.Size = new System.Drawing.Size(46, 24);
            this.labelSesso.TabIndex = 9;
            this.labelSesso.Text = "Sesso";
            this.labelSesso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSesso.Click += new System.EventHandler(this.labelSesso_Click);
            // 
            // RadioButtonMaschio
            // 
            this.RadioButtonMaschio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RadioButtonMaschio.AutoSize = true;
            this.RadioButtonMaschio.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonMaschio.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMaschio.ForeColor = System.Drawing.Color.White;
            this.RadioButtonMaschio.Location = new System.Drawing.Point(376, 180);
            this.RadioButtonMaschio.Name = "RadioButtonMaschio";
            this.RadioButtonMaschio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadioButtonMaschio.Size = new System.Drawing.Size(68, 24);
            this.RadioButtonMaschio.TabIndex = 10;
            this.RadioButtonMaschio.TabStop = true;
            this.RadioButtonMaschio.Text = "Maschio";
            this.RadioButtonMaschio.UseVisualStyleBackColor = false;
            this.RadioButtonMaschio.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RadioButtonFemmina
            // 
            this.RadioButtonFemmina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RadioButtonFemmina.AutoSize = true;
            this.RadioButtonFemmina.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonFemmina.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemmina.ForeColor = System.Drawing.Color.White;
            this.RadioButtonFemmina.Location = new System.Drawing.Point(459, 180);
            this.RadioButtonFemmina.Name = "RadioButtonFemmina";
            this.RadioButtonFemmina.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadioButtonFemmina.Size = new System.Drawing.Size(71, 24);
            this.RadioButtonFemmina.TabIndex = 11;
            this.RadioButtonFemmina.TabStop = true;
            this.RadioButtonFemmina.Text = "Femmina";
            this.RadioButtonFemmina.UseVisualStyleBackColor = false;
            this.RadioButtonFemmina.CheckedChanged += new System.EventHandler(this.buttonFemmina_CheckedChanged);
            // 
            // labelDataNascita
            // 
            this.labelDataNascita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDataNascita.AutoSize = true;
            this.labelDataNascita.BackColor = System.Drawing.Color.Transparent;
            this.labelDataNascita.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascita.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelDataNascita.Location = new System.Drawing.Point(252, 212);
            this.labelDataNascita.Name = "labelDataNascita";
            this.labelDataNascita.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDataNascita.Size = new System.Drawing.Size(96, 24);
            this.labelDataNascita.TabIndex = 12;
            this.labelDataNascita.Text = "Data Di Nascita";
            this.labelDataNascita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDataNascita.Click += new System.EventHandler(this.labelDataNascita_Click);
            // 
            // comboBoxGiorno
            // 
            this.comboBoxGiorno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxGiorno.BackColor = System.Drawing.Color.IndianRed;
            this.comboBoxGiorno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxGiorno.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGiorno.ForeColor = System.Drawing.Color.Transparent;
            this.comboBoxGiorno.FormattingEnabled = true;
            this.comboBoxGiorno.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxGiorno.Location = new System.Drawing.Point(376, 212);
            this.comboBoxGiorno.Name = "comboBoxGiorno";
            this.comboBoxGiorno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxGiorno.Size = new System.Drawing.Size(56, 25);
            this.comboBoxGiorno.TabIndex = 13;
            this.comboBoxGiorno.Text = "Giorno";
            this.comboBoxGiorno.SelectedIndexChanged += new System.EventHandler(this.comboBoxGiorno_SelectedIndexChanged);
            // 
            // comboBoxMese
            // 
            this.comboBoxMese.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxMese.BackColor = System.Drawing.Color.IndianRed;
            this.comboBoxMese.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxMese.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMese.ForeColor = System.Drawing.Color.Transparent;
            this.comboBoxMese.FormattingEnabled = true;
            this.comboBoxMese.Items.AddRange(new object[] {
            "Gennaio",
            "Febbraio",
            "Marzo",
            "Aprile",
            "Maggio",
            "Giugno",
            "Luglio",
            "Agosto",
            "Settembre",
            "Ottobre",
            "Novembre",
            "Dicembre"});
            this.comboBoxMese.Location = new System.Drawing.Point(438, 212);
            this.comboBoxMese.Name = "comboBoxMese";
            this.comboBoxMese.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxMese.Size = new System.Drawing.Size(52, 25);
            this.comboBoxMese.TabIndex = 14;
            this.comboBoxMese.Text = "Mese";
            this.comboBoxMese.SelectedIndexChanged += new System.EventHandler(this.comboBoxMese_SelectedIndexChanged);
            // 
            // comboBoxAnno
            // 
            this.comboBoxAnno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxAnno.BackColor = System.Drawing.Color.IndianRed;
            this.comboBoxAnno.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxAnno.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAnno.ForeColor = System.Drawing.Color.White;
            this.comboBoxAnno.FormattingEnabled = true;
            this.comboBoxAnno.Items.AddRange(new object[] {
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.comboBoxAnno.Location = new System.Drawing.Point(496, 212);
            this.comboBoxAnno.Name = "comboBoxAnno";
            this.comboBoxAnno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxAnno.Size = new System.Drawing.Size(52, 25);
            this.comboBoxAnno.TabIndex = 15;
            this.comboBoxAnno.Text = "Anno";
            this.comboBoxAnno.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnno_SelectedIndexChanged);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.BackColor = System.Drawing.Color.IndianRed;
            this.Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.Control;
            this.Password.Location = new System.Drawing.Point(376, 335);
            this.Password.Name = "Password";
            this.Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password.Size = new System.Drawing.Size(130, 23);
            this.Password.TabIndex = 16;
            this.Password.Tag = "";
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelPassword.Location = new System.Drawing.Point(278, 331);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPassword.Size = new System.Drawing.Size(70, 24);
            this.labelPassword.TabIndex = 17;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // labelConfermaPassword
            // 
            this.labelConfermaPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfermaPassword.AutoSize = true;
            this.labelConfermaPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelConfermaPassword.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfermaPassword.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelConfermaPassword.Location = new System.Drawing.Point(218, 376);
            this.labelConfermaPassword.Name = "labelConfermaPassword";
            this.labelConfermaPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelConfermaPassword.Size = new System.Drawing.Size(130, 24);
            this.labelConfermaPassword.TabIndex = 18;
            this.labelConfermaPassword.Text = "Conferma Password";
            this.labelConfermaPassword.Click += new System.EventHandler(this.labelConfermaPassword_Click);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmPassword.BackColor = System.Drawing.Color.IndianRed;
            this.ConfirmPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.ConfirmPassword.Location = new System.Drawing.Point(376, 382);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConfirmPassword.Size = new System.Drawing.Size(130, 23);
            this.ConfirmPassword.TabIndex = 19;
            this.ConfirmPassword.Tag = "";
            this.ConfirmPassword.UseSystemPasswordChar = true;
            this.ConfirmPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // labelPeso
            // 
            this.labelPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.Color.Transparent;
            this.labelPeso.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelPeso.Location = new System.Drawing.Point(275, 245);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPeso.Size = new System.Drawing.Size(71, 24);
            this.labelPeso.TabIndex = 20;
            this.labelPeso.Text = "Peso in Kg";
            this.labelPeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPeso.Click += new System.EventHandler(this.labelPeso_Click);
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownPeso.BackColor = System.Drawing.Color.IndianRed;
            this.numericUpDownPeso.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPeso.ForeColor = System.Drawing.Color.Transparent;
            this.numericUpDownPeso.Location = new System.Drawing.Point(376, 249);
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownPeso.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownPeso.TabIndex = 21;
            this.numericUpDownPeso.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownPeso.ValueChanged += new System.EventHandler(this.numericUpDownPeso_ValueChanged);
            // 
            // labelAltezza
            // 
            this.labelAltezza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAltezza.AutoSize = true;
            this.labelAltezza.BackColor = System.Drawing.Color.Transparent;
            this.labelAltezza.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltezza.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelAltezza.Location = new System.Drawing.Point(259, 288);
            this.labelAltezza.Name = "labelAltezza";
            this.labelAltezza.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAltezza.Size = new System.Drawing.Size(89, 24);
            this.labelAltezza.TabIndex = 22;
            this.labelAltezza.Text = "Altezza in cm";
            this.labelAltezza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAltezza.Click += new System.EventHandler(this.labelAltezza_Click);
            // 
            // numericUpDownAltezza
            // 
            this.numericUpDownAltezza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownAltezza.BackColor = System.Drawing.Color.IndianRed;
            this.numericUpDownAltezza.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAltezza.ForeColor = System.Drawing.Color.Transparent;
            this.numericUpDownAltezza.Location = new System.Drawing.Point(376, 292);
            this.numericUpDownAltezza.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownAltezza.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAltezza.Name = "numericUpDownAltezza";
            this.numericUpDownAltezza.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownAltezza.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownAltezza.TabIndex = 23;
            this.numericUpDownAltezza.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAltezza.ValueChanged += new System.EventHandler(this.numericUpDownAltezza_ValueChanged);
            // 
            // imageShowPassword
            // 
            this.imageShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageShowPassword.BackColor = System.Drawing.Color.IndianRed;
            this.imageShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageShowPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageShowPassword.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageShowPassword.ErrorImage")));
            this.imageShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("imageShowPassword.Image")));
            this.imageShowPassword.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageShowPassword.InitialImage")));
            this.imageShowPassword.Location = new System.Drawing.Point(731, 480);
            this.imageShowPassword.Name = "imageShowPassword";
            this.imageShowPassword.Size = new System.Drawing.Size(20, 20);
            this.imageShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageShowPassword.TabIndex = 24;
            this.imageShowPassword.TabStop = false;
            this.imageShowPassword.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageHidePassword
            // 
            this.imageHidePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageHidePassword.BackColor = System.Drawing.Color.IndianRed;
            this.imageHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageHidePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("imageHidePassword.Image")));
            this.imageHidePassword.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageHidePassword.InitialImage")));
            this.imageHidePassword.Location = new System.Drawing.Point(767, 480);
            this.imageHidePassword.Name = "imageHidePassword";
            this.imageHidePassword.Size = new System.Drawing.Size(20, 20);
            this.imageHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageHidePassword.TabIndex = 25;
            this.imageHidePassword.TabStop = false;
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
            this.buttonProcedi.Location = new System.Drawing.Point(707, 470);
            this.buttonProcedi.Name = "buttonProcedi";
            this.buttonProcedi.Size = new System.Drawing.Size(80, 31);
            this.buttonProcedi.TabIndex = 28;
            this.buttonProcedi.Text = "Procedi";
            this.buttonProcedi.UseVisualStyleBackColor = false;
            // 
            // buttonShowHide1
            // 
            this.buttonShowHide1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowHide1.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowHide1.Image")));
            this.buttonShowHide1.Location = new System.Drawing.Point(524, 335);
            this.buttonShowHide1.Name = "buttonShowHide1";
            this.buttonShowHide1.Size = new System.Drawing.Size(24, 23);
            this.buttonShowHide1.TabIndex = 29;
            this.buttonShowHide1.UseVisualStyleBackColor = true;
            this.buttonShowHide1.VisibleChanged += new System.EventHandler(this.pictureBox1_Click);
            this.buttonShowHide1.Click += new System.EventHandler(this.buttonShowHide1_Click);
            // 
            // buttonShowHide2
            // 
            this.buttonShowHide2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShowHide2.Image = ((System.Drawing.Image)(resources.GetObject("buttonShowHide2.Image")));
            this.buttonShowHide2.Location = new System.Drawing.Point(524, 382);
            this.buttonShowHide2.Name = "buttonShowHide2";
            this.buttonShowHide2.Size = new System.Drawing.Size(24, 23);
            this.buttonShowHide2.TabIndex = 31;
            this.buttonShowHide2.UseVisualStyleBackColor = true;
            this.buttonShowHide2.Click += new System.EventHandler(this.buttonShowHide2_Click);
            // 
            // labelScheda
            // 
            this.labelScheda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelScheda.AutoSize = true;
            this.labelScheda.BackColor = System.Drawing.Color.Transparent;
            this.labelScheda.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScheda.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelScheda.Location = new System.Drawing.Point(293, 432);
            this.labelScheda.Name = "labelScheda";
            this.labelScheda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelScheda.Size = new System.Drawing.Size(53, 24);
            this.labelScheda.TabIndex = 32;
            this.labelScheda.Text = "Scheda";
            this.labelScheda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxAutomatica
            // 
            this.checkBoxAutomatica.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxAutomatica.AutoSize = true;
            this.checkBoxAutomatica.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.checkBoxAutomatica.FlatAppearance.BorderSize = 3;
            this.checkBoxAutomatica.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxAutomatica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.checkBoxAutomatica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxAutomatica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxAutomatica.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutomatica.Location = new System.Drawing.Point(459, 434);
            this.checkBoxAutomatica.Name = "checkBoxAutomatica";
            this.checkBoxAutomatica.Size = new System.Drawing.Size(80, 24);
            this.checkBoxAutomatica.TabIndex = 34;
            this.checkBoxAutomatica.Text = "Automatica";
            this.checkBoxAutomatica.UseVisualStyleBackColor = true;
            this.checkBoxAutomatica.CheckedChanged += new System.EventHandler(this.checkBoxAutomatica_CheckedChanged);
            // 
            // checkBoxManuale
            // 
            this.checkBoxManuale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxManuale.AutoSize = true;
            this.checkBoxManuale.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.checkBoxManuale.FlatAppearance.BorderSize = 3;
            this.checkBoxManuale.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            this.checkBoxManuale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.checkBoxManuale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxManuale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxManuale.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxManuale.Location = new System.Drawing.Point(376, 434);
            this.checkBoxManuale.Name = "checkBoxManuale";
            this.checkBoxManuale.Size = new System.Drawing.Size(66, 24);
            this.checkBoxManuale.TabIndex = 35;
            this.checkBoxManuale.Text = "Manuale";
            this.checkBoxManuale.UseVisualStyleBackColor = true;
            this.checkBoxManuale.CheckedChanged += new System.EventHandler(this.checkBoxManuale_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 512);
            this.Controls.Add(this.checkBoxManuale);
            this.Controls.Add(this.checkBoxAutomatica);
            this.Controls.Add(this.labelScheda);
            this.Controls.Add(this.buttonShowHide2);
            this.Controls.Add(this.buttonShowHide1);
            this.Controls.Add(this.buttonProcedi);
            this.Controls.Add(this.imageHidePassword);
            this.Controls.Add(this.imageShowPassword);
            this.Controls.Add(this.numericUpDownAltezza);
            this.Controls.Add(this.labelAltezza);
            this.Controls.Add(this.numericUpDownPeso);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.labelConfermaPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.comboBoxAnno);
            this.Controls.Add(this.comboBoxMese);
            this.Controls.Add(this.comboBoxGiorno);
            this.Controls.Add(this.labelDataNascita);
            this.Controls.Add(this.RadioButtonFemmina);
            this.Controls.Add(this.RadioButtonMaschio);
            this.Controls.Add(this.labelSesso);
            this.Controls.Add(this.labelCognome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.TextBoxCognome);
            this.Controls.Add(this.labelTitolo);
            this.Controls.Add(this.TextBoxNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No Pain No Gain";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAltezza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageHidePassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.TextBox TextBoxCognome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCognome;
        private System.Windows.Forms.Label labelSesso;
        private System.Windows.Forms.RadioButton RadioButtonMaschio;
        private System.Windows.Forms.RadioButton RadioButtonFemmina;
        private System.Windows.Forms.Label labelDataNascita;
        private System.Windows.Forms.ComboBox comboBoxGiorno;
        private System.Windows.Forms.ComboBox comboBoxMese;
        private System.Windows.Forms.ComboBox comboBoxAnno;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfermaPassword;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.NumericUpDown numericUpDownPeso;
        private System.Windows.Forms.Label labelAltezza;
        private System.Windows.Forms.NumericUpDown numericUpDownAltezza;
        private System.Windows.Forms.PictureBox imageShowPassword;
        private System.Windows.Forms.PictureBox imageHidePassword;
        private System.Windows.Forms.Button buttonProcedi;
        private System.Windows.Forms.Button buttonShowHide1;
        private System.Windows.Forms.Button buttonShowHide2;
        private System.Windows.Forms.Label labelScheda;
        private System.Windows.Forms.CheckBox checkBoxAutomatica;
        private System.Windows.Forms.CheckBox checkBoxManuale;
    }
}


namespace ViewProject
{
    partial class FormVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideo));
            this.comboBoxFasciaMuscolare = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.listBoxEsercizi = new System.Windows.Forms.ListBox();
            this.buttonIndietro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
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
            this.comboBoxFasciaMuscolare.Location = new System.Drawing.Point(23, 29);
            this.comboBoxFasciaMuscolare.Name = "comboBoxFasciaMuscolare";
            this.comboBoxFasciaMuscolare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFasciaMuscolare.Size = new System.Drawing.Size(120, 21);
            this.comboBoxFasciaMuscolare.TabIndex = 14;
            this.comboBoxFasciaMuscolare.Text = "Fascia Muscolare";
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(197, 29);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(586, 366);
            this.axWindowsMediaPlayer.TabIndex = 15;
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.BackColor = System.Drawing.Color.SpringGreen;
            this.textBoxDescrizione.Location = new System.Drawing.Point(197, 413);
            this.textBoxDescrizione.Multiline = true;
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.ReadOnly = true;
            this.textBoxDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescrizione.Size = new System.Drawing.Size(586, 79);
            this.textBoxDescrizione.TabIndex = 16;
            this.textBoxDescrizione.Text = resources.GetString("textBoxDescrizione.Text");
            // 
            // listBoxEsercizi
            // 
            this.listBoxEsercizi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBoxEsercizi.FormattingEnabled = true;
            this.listBoxEsercizi.Items.AddRange(new object[] {
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
            this.listBoxEsercizi.Location = new System.Drawing.Point(23, 88);
            this.listBoxEsercizi.Name = "listBoxEsercizi";
            this.listBoxEsercizi.Size = new System.Drawing.Size(120, 316);
            this.listBoxEsercizi.TabIndex = 17;
            // 
            // buttonIndietro
            // 
            this.buttonIndietro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIndietro.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonIndietro.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonIndietro.FlatAppearance.BorderSize = 2;
            this.buttonIndietro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonIndietro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonIndietro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndietro.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndietro.Location = new System.Drawing.Point(23, 462);
            this.buttonIndietro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIndietro.Name = "buttonIndietro";
            this.buttonIndietro.Size = new System.Drawing.Size(120, 30);
            this.buttonIndietro.TabIndex = 74;
            this.buttonIndietro.Tag = "";
            this.buttonIndietro.Text = "Torna al Menu";
            this.buttonIndietro.UseVisualStyleBackColor = false;
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 512);
            this.Controls.Add(this.buttonIndietro);
            this.Controls.Add(this.listBoxEsercizi);
            this.Controls.Add(this.textBoxDescrizione);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.comboBoxFasciaMuscolare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVideo";
            this.Text = "No Pain No Gain";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxFasciaMuscolare;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        public System.Windows.Forms.TextBox textBoxDescrizione;
        private System.Windows.Forms.ListBox listBoxEsercizi;
        private System.Windows.Forms.Button buttonIndietro;
    }
}
namespace ViewProject.View
{
    partial class TempoRecuperoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempoRecuperoForm));
            this.labelRecuperoGiornoAllenamento = new System.Windows.Forms.Label();
            this.recuperoGiornoAllenamento = new System.Windows.Forms.NumericUpDown();
            this.buttonConferma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recuperoGiornoAllenamento)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRecuperoGiornoAllenamento
            // 
            this.labelRecuperoGiornoAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRecuperoGiornoAllenamento.AutoSize = true;
            this.labelRecuperoGiornoAllenamento.BackColor = System.Drawing.Color.Transparent;
            this.labelRecuperoGiornoAllenamento.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecuperoGiornoAllenamento.ForeColor = System.Drawing.Color.Lavender;
            this.labelRecuperoGiornoAllenamento.Location = new System.Drawing.Point(12, 44);
            this.labelRecuperoGiornoAllenamento.Name = "labelRecuperoGiornoAllenamento";
            this.labelRecuperoGiornoAllenamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRecuperoGiornoAllenamento.Size = new System.Drawing.Size(309, 46);
            this.labelRecuperoGiornoAllenamento.TabIndex = 84;
            this.labelRecuperoGiornoAllenamento.Text = "Scegli il tempo di recupero tra \r\nun esercizio e un altro (secondi)";
            this.labelRecuperoGiornoAllenamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // recuperoGiornoAllenamento
            // 
            this.recuperoGiornoAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.recuperoGiornoAllenamento.BackColor = System.Drawing.Color.SlateBlue;
            this.recuperoGiornoAllenamento.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuperoGiornoAllenamento.ForeColor = System.Drawing.Color.Lavender;
            this.recuperoGiornoAllenamento.Location = new System.Drawing.Point(329, 60);
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
            this.recuperoGiornoAllenamento.Size = new System.Drawing.Size(40, 24);
            this.recuperoGiornoAllenamento.TabIndex = 85;
            this.recuperoGiornoAllenamento.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // buttonConferma
            // 
            this.buttonConferma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConferma.BackColor = System.Drawing.Color.Transparent;
            this.buttonConferma.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.buttonConferma.FlatAppearance.BorderSize = 2;
            this.buttonConferma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonConferma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.buttonConferma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConferma.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConferma.ForeColor = System.Drawing.Color.Lavender;
            this.buttonConferma.Location = new System.Drawing.Point(146, 133);
            this.buttonConferma.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConferma.Name = "buttonConferma";
            this.buttonConferma.Size = new System.Drawing.Size(97, 30);
            this.buttonConferma.TabIndex = 86;
            this.buttonConferma.Tag = "";
            this.buttonConferma.Text = "Conferma";
            this.buttonConferma.UseVisualStyleBackColor = false;
            // 
            // TempoRecuperoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(381, 197);
            this.Controls.Add(this.buttonConferma);
            this.Controls.Add(this.recuperoGiornoAllenamento);
            this.Controls.Add(this.labelRecuperoGiornoAllenamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TempoRecuperoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No Pain No Gain";
            ((System.ComponentModel.ISupportInitialize)(this.recuperoGiornoAllenamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelRecuperoGiornoAllenamento;
        public System.Windows.Forms.NumericUpDown recuperoGiornoAllenamento;
        public System.Windows.Forms.Button buttonConferma;
    }
}
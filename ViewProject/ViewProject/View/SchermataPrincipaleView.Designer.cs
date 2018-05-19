namespace ViewProject
{
    partial class SchermataPrincipaleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchermataPrincipaleView));
            this.labelTitolo = new System.Windows.Forms.Label();
            this.buttonModificaScheda = new System.Windows.Forms.Button();
            this.panelSchermataPrincipale = new System.Windows.Forms.Panel();
            this.buttonFrase = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonProgressi = new System.Windows.Forms.Button();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.buttonProfilo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewScheda = new System.Windows.Forms.DataGridView();
            this.panelSchermataPrincipale.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheda)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitolo
            // 
            this.labelTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitolo.AutoSize = true;
            this.labelTitolo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitolo.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitolo.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelTitolo.Location = new System.Drawing.Point(228, -2);
            this.labelTitolo.Name = "labelTitolo";
            this.labelTitolo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitolo.Size = new System.Drawing.Size(187, 29);
            this.labelTitolo.TabIndex = 8;
            this.labelTitolo.Text = "La mia Scheda";
            // 
            // buttonModificaScheda
            // 
            this.buttonModificaScheda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModificaScheda.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonModificaScheda.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonModificaScheda.FlatAppearance.BorderSize = 3;
            this.buttonModificaScheda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonModificaScheda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonModificaScheda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificaScheda.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificaScheda.Location = new System.Drawing.Point(234, 457);
            this.buttonModificaScheda.Name = "buttonModificaScheda";
            this.buttonModificaScheda.Size = new System.Drawing.Size(150, 39);
            this.buttonModificaScheda.TabIndex = 9;
            this.buttonModificaScheda.Tag = "";
            this.buttonModificaScheda.Text = "Modifica Scheda";
            this.buttonModificaScheda.UseVisualStyleBackColor = false;
            this.buttonModificaScheda.Click += new System.EventHandler(this.buttonModificaScheda_Click);
            // 
            // panelSchermataPrincipale
            // 
            this.panelSchermataPrincipale.AutoSize = true;
            this.panelSchermataPrincipale.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelSchermataPrincipale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelSchermataPrincipale.Controls.Add(this.buttonFrase);
            this.panelSchermataPrincipale.Controls.Add(this.buttonReset);
            this.panelSchermataPrincipale.Controls.Add(this.buttonProgressi);
            this.panelSchermataPrincipale.Controls.Add(this.buttonVideo);
            this.panelSchermataPrincipale.Controls.Add(this.buttonProfilo);
            this.panelSchermataPrincipale.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSchermataPrincipale.Location = new System.Drawing.Point(626, 0);
            this.panelSchermataPrincipale.Name = "panelSchermataPrincipale";
            this.panelSchermataPrincipale.Size = new System.Drawing.Size(196, 512);
            this.panelSchermataPrincipale.TabIndex = 10;
            // 
            // buttonFrase
            // 
            this.buttonFrase.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonFrase.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonFrase.FlatAppearance.BorderSize = 3;
            this.buttonFrase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonFrase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonFrase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFrase.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFrase.Location = new System.Drawing.Point(8, 321);
            this.buttonFrase.Name = "buttonFrase";
            this.buttonFrase.Size = new System.Drawing.Size(172, 35);
            this.buttonFrase.TabIndex = 16;
            this.buttonFrase.Tag = "";
            this.buttonFrase.Text = "Frase Motivazionale";
            this.buttonFrase.UseVisualStyleBackColor = false;
            this.buttonFrase.Click += new System.EventHandler(this.buttonFrase_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Crimson;
            this.buttonReset.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonReset.FlatAppearance.BorderSize = 3;
            this.buttonReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(30, 461);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(150, 35);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Tag = "";
            this.buttonReset.Text = "Cancella Account";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonProgressi
            // 
            this.buttonProgressi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonProgressi.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonProgressi.FlatAppearance.BorderSize = 3;
            this.buttonProgressi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonProgressi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonProgressi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProgressi.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgressi.Location = new System.Drawing.Point(8, 148);
            this.buttonProgressi.Name = "buttonProgressi";
            this.buttonProgressi.Size = new System.Drawing.Size(185, 35);
            this.buttonProgressi.TabIndex = 14;
            this.buttonProgressi.Tag = "";
            this.buttonProgressi.Text = "Registra Allenamento";
            this.buttonProgressi.UseVisualStyleBackColor = false;
            this.buttonProgressi.Click += new System.EventHandler(this.buttonProgressi_Click);
            // 
            // buttonVideo
            // 
            this.buttonVideo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonVideo.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonVideo.FlatAppearance.BorderSize = 3;
            this.buttonVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVideo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVideo.Location = new System.Drawing.Point(30, 229);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(134, 35);
            this.buttonVideo.TabIndex = 13;
            this.buttonVideo.Tag = "";
            this.buttonVideo.Text = "Esercizi Guida";
            this.buttonVideo.UseVisualStyleBackColor = false;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // buttonProfilo
            // 
            this.buttonProfilo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonProfilo.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonProfilo.FlatAppearance.BorderSize = 3;
            this.buttonProfilo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonProfilo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonProfilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfilo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfilo.Location = new System.Drawing.Point(30, 65);
            this.buttonProfilo.Name = "buttonProfilo";
            this.buttonProfilo.Size = new System.Drawing.Size(134, 35);
            this.buttonProfilo.TabIndex = 12;
            this.buttonProfilo.Tag = "";
            this.buttonProfilo.Text = "Profilo";
            this.buttonProfilo.UseVisualStyleBackColor = false;
            this.buttonProfilo.Click += new System.EventHandler(this.buttonProfilo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelTitolo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 29);
            this.panel2.TabIndex = 11;
            // 
            // dataGridViewScheda
            // 
            this.dataGridViewScheda.AllowUserToAddRows = false;
            this.dataGridViewScheda.AllowUserToDeleteRows = false;
            this.dataGridViewScheda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScheda.Location = new System.Drawing.Point(69, 65);
            this.dataGridViewScheda.Name = "dataGridViewScheda";
            this.dataGridViewScheda.ReadOnly = true;
            this.dataGridViewScheda.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewScheda.TabIndex = 12;
            // 
            // SchermataPrincipaleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.dataGridViewScheda);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSchermataPrincipale);
            this.Controls.Add(this.buttonModificaScheda);
            this.Name = "SchermataPrincipaleView";
            this.Size = new System.Drawing.Size(822, 512);
            this.panelSchermataPrincipale.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScheda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panelSchermataPrincipale;
        public System.Windows.Forms.Button buttonProfilo;
        public System.Windows.Forms.Button buttonProgressi;
        public System.Windows.Forms.Button buttonVideo;
        public System.Windows.Forms.Button buttonFrase;
        public System.Windows.Forms.Button buttonReset;
        public System.Windows.Forms.Button buttonModificaScheda;
        public System.Windows.Forms.DataGridView dataGridViewScheda;
    }
}
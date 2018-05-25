namespace ViewProject
{
    partial class VideoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoView));
            this.comboBoxFasciaMuscolareVideo = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.listBoxEserciziVideo = new System.Windows.Forms.ListBox();
            this.buttonIndietroVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFasciaMuscolareVideo
            // 
            this.comboBoxFasciaMuscolareVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxFasciaMuscolareVideo.BackColor = System.Drawing.Color.SlateBlue;
            this.comboBoxFasciaMuscolareVideo.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFasciaMuscolareVideo.ForeColor = System.Drawing.Color.Lavender;
            this.comboBoxFasciaMuscolareVideo.FormattingEnabled = true;
            this.comboBoxFasciaMuscolareVideo.Items.AddRange(new object[] {
            "Addominali",
            "Bicipiti",
            "Tricipiti",
            "Deltoidi",
            "Dorsali",
            "Pettorali",
            "Polpacci",
            "Quadricipiti"});
            this.comboBoxFasciaMuscolareVideo.Location = new System.Drawing.Point(23, 29);
            this.comboBoxFasciaMuscolareVideo.Name = "comboBoxFasciaMuscolareVideo";
            this.comboBoxFasciaMuscolareVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxFasciaMuscolareVideo.Size = new System.Drawing.Size(150, 23);
            this.comboBoxFasciaMuscolareVideo.TabIndex = 14;
            this.comboBoxFasciaMuscolareVideo.Text = "Fascia Muscolare";
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
            this.textBoxDescrizione.BackColor = System.Drawing.Color.Black;
            this.textBoxDescrizione.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescrizione.ForeColor = System.Drawing.Color.Lavender;
            this.textBoxDescrizione.Location = new System.Drawing.Point(197, 413);
            this.textBoxDescrizione.Multiline = true;
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.ReadOnly = true;
            this.textBoxDescrizione.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescrizione.Size = new System.Drawing.Size(586, 79);
            this.textBoxDescrizione.TabIndex = 16;
            // 
            // listBoxEserciziVideo
            // 
            this.listBoxEserciziVideo.BackColor = System.Drawing.Color.Black;
            this.listBoxEserciziVideo.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEserciziVideo.ForeColor = System.Drawing.Color.Lavender;
            this.listBoxEserciziVideo.FormattingEnabled = true;
            this.listBoxEserciziVideo.ItemHeight = 15;
            this.listBoxEserciziVideo.Location = new System.Drawing.Point(23, 88);
            this.listBoxEserciziVideo.Name = "listBoxEserciziVideo";
            this.listBoxEserciziVideo.Size = new System.Drawing.Size(150, 304);
            this.listBoxEserciziVideo.TabIndex = 17;
            // 
            // buttonIndietroVideo
            // 
            this.buttonIndietroVideo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIndietroVideo.BackColor = System.Drawing.Color.Transparent;
            this.buttonIndietroVideo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.buttonIndietroVideo.FlatAppearance.BorderSize = 2;
            this.buttonIndietroVideo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateBlue;
            this.buttonIndietroVideo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.buttonIndietroVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndietroVideo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndietroVideo.ForeColor = System.Drawing.Color.Lavender;
            this.buttonIndietroVideo.Location = new System.Drawing.Point(23, 462);
            this.buttonIndietroVideo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIndietroVideo.Name = "buttonIndietroVideo";
            this.buttonIndietroVideo.Size = new System.Drawing.Size(120, 30);
            this.buttonIndietroVideo.TabIndex = 74;
            this.buttonIndietroVideo.Tag = "";
            this.buttonIndietroVideo.Text = "Torna al Menu";
            this.buttonIndietroVideo.UseVisualStyleBackColor = false;
            // 
            // VideoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonIndietroVideo);
            this.Controls.Add(this.listBoxEserciziVideo);
            this.Controls.Add(this.textBoxDescrizione);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.Controls.Add(this.comboBoxFasciaMuscolareVideo);
            this.Name = "VideoView";
            this.Size = new System.Drawing.Size(822, 512);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxDescrizione;
        public System.Windows.Forms.Button buttonIndietroVideo;
        public System.Windows.Forms.ListBox listBoxEserciziVideo;
        public System.Windows.Forms.ComboBox comboBoxFasciaMuscolareVideo;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
    }
}
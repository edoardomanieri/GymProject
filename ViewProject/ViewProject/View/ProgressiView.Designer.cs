namespace ViewProject
{
    partial class ProgressiView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn1 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.LegendCellColumn legendCellColumn2 = new System.Windows.Forms.DataVisualization.Charting.LegendCellColumn();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressiView));
            this.buttonIndietroProgressi = new System.Windows.Forms.Button();
            this.chartDurata = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPeso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCompletamentoScheda = new System.Windows.Forms.Label();
            this.dateTimePickerDataAllenamento = new System.Windows.Forms.DateTimePicker();
            this.labelDataAllenamento = new System.Windows.Forms.Label();
            this.numericUpDownDurataProgressi = new System.Windows.Forms.NumericUpDown();
            this.labelPeso = new System.Windows.Forms.Label();
            this.numericUpDownPesoProgressi = new System.Windows.Forms.NumericUpDown();
            this.buttonSalvaAllenamentoProgressi = new System.Windows.Forms.Button();
            this.labelContatore = new System.Windows.Forms.Label();
            this.labelAllenamenti = new System.Windows.Forms.Label();
            this.progressBarAllenamenti = new System.Windows.Forms.ProgressBar();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.labelDurata = new System.Windows.Forms.Label();
            this.labelRegistraAllenamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDurata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurataProgressi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPesoProgressi)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIndietroProgressi
            // 
            this.buttonIndietroProgressi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonIndietroProgressi.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonIndietroProgressi.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonIndietroProgressi.FlatAppearance.BorderSize = 2;
            this.buttonIndietroProgressi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonIndietroProgressi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonIndietroProgressi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIndietroProgressi.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndietroProgressi.Location = new System.Drawing.Point(34, 453);
            this.buttonIndietroProgressi.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIndietroProgressi.Name = "buttonIndietroProgressi";
            this.buttonIndietroProgressi.Size = new System.Drawing.Size(139, 30);
            this.buttonIndietroProgressi.TabIndex = 74;
            this.buttonIndietroProgressi.Tag = "";
            this.buttonIndietroProgressi.Text = "Torna al Menu";
            this.buttonIndietroProgressi.UseVisualStyleBackColor = false;
            // 
            // chartDurata
            // 
            this.chartDurata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartDurata.BackColor = System.Drawing.Color.DimGray;
            this.chartDurata.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chartDurata.BackSecondaryColor = System.Drawing.Color.White;
            this.chartDurata.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartDurata.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartDurata.BorderlineWidth = 0;
            this.chartDurata.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.PaleGreen;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.LightUpwardDiagonal;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Blue;
            chartArea1.Name = "ChartArea1";
            this.chartDurata.ChartAreas.Add(chartArea1);
            legendCellColumn1.Name = "Column1";
            legend1.CellColumns.Add(legendCellColumn1);
            legend1.Name = "Legend1";
            this.chartDurata.Legends.Add(legend1);
            this.chartDurata.Location = new System.Drawing.Point(330, 26);
            this.chartDurata.Name = "chartDurata";
            this.chartDurata.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series1.BackSecondaryColor = System.Drawing.Color.LimeGreen;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawingStyle=Emboss";
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Durata";
            series1.ShadowColor = System.Drawing.Color.RoyalBlue;
            series1.ShadowOffset = 4;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValuesPerPoint = 20;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartDurata.Series.Add(series1);
            this.chartDurata.Size = new System.Drawing.Size(480, 211);
            this.chartDurata.TabIndex = 81;
            title1.BackColor = System.Drawing.Color.DarkOrchid;
            title1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            title1.BackSecondaryColor = System.Drawing.Color.LimeGreen;
            title1.BorderColor = System.Drawing.Color.Transparent;
            title1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            title1.Name = "TitoloGrafico";
            title1.ShadowColor = System.Drawing.Color.RoyalBlue;
            title1.ShadowOffset = 3;
            title1.Text = "I tuoi progressi";
            this.chartDurata.Titles.Add(title1);
            // 
            // chartPeso
            // 
            this.chartPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chartPeso.BackColor = System.Drawing.Color.DimGray;
            this.chartPeso.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chartPeso.BackSecondaryColor = System.Drawing.Color.White;
            this.chartPeso.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartPeso.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartPeso.BorderlineWidth = 0;
            this.chartPeso.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea2.BackColor = System.Drawing.Color.PaleGreen;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.LightUpwardDiagonal;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Blue;
            chartArea2.Name = "ChartArea1";
            this.chartPeso.ChartAreas.Add(chartArea2);
            legendCellColumn2.Name = "Column1";
            legend2.CellColumns.Add(legendCellColumn2);
            legend2.Name = "Legend1";
            this.chartPeso.Legends.Add(legend2);
            this.chartPeso.Location = new System.Drawing.Point(330, 272);
            this.chartPeso.Name = "chartPeso";
            this.chartPeso.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            series2.BackSecondaryColor = System.Drawing.Color.LimeGreen;
            series2.BorderColor = System.Drawing.Color.Blue;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.RoyalBlue;
            series2.CustomProperties = "DrawingStyle=Emboss";
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Blue;
            series2.MarkerBorderWidth = 10;
            series2.MarkerColor = System.Drawing.Color.Blue;
            series2.MarkerSize = 10;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series2.Name = "Peso";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ShadowColor = System.Drawing.Color.Plum;
            series2.ShadowOffset = 22;
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValuesPerPoint = 20;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartPeso.Series.Add(series2);
            this.chartPeso.Size = new System.Drawing.Size(480, 211);
            this.chartPeso.TabIndex = 83;
            title2.BackColor = System.Drawing.Color.DarkOrchid;
            title2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            title2.BackSecondaryColor = System.Drawing.Color.LimeGreen;
            title2.BorderColor = System.Drawing.Color.Transparent;
            title2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            title2.Name = "TitoloGrafico";
            title2.ShadowColor = System.Drawing.Color.RoyalBlue;
            title2.ShadowOffset = 3;
            title2.Text = "I tuoi progressi";
            this.chartPeso.Titles.Add(title2);
            // 
            // labelCompletamentoScheda
            // 
            this.labelCompletamentoScheda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCompletamentoScheda.AutoSize = true;
            this.labelCompletamentoScheda.BackColor = System.Drawing.Color.Transparent;
            this.labelCompletamentoScheda.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompletamentoScheda.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelCompletamentoScheda.Location = new System.Drawing.Point(40, 312);
            this.labelCompletamentoScheda.Name = "labelCompletamentoScheda";
            this.labelCompletamentoScheda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCompletamentoScheda.Size = new System.Drawing.Size(102, 48);
            this.labelCompletamentoScheda.TabIndex = 88;
            this.labelCompletamentoScheda.Text = "Completamento \r\n       scheda";
            this.labelCompletamentoScheda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerDataAllenamento
            // 
            this.dateTimePickerDataAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerDataAllenamento.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePickerDataAllenamento.Location = new System.Drawing.Point(108, 81);
            this.dateTimePickerDataAllenamento.Name = "dateTimePickerDataAllenamento";
            this.dateTimePickerDataAllenamento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataAllenamento.TabIndex = 3;
            // 
            // labelDataAllenamento
            // 
            this.labelDataAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDataAllenamento.AutoSize = true;
            this.labelDataAllenamento.BackColor = System.Drawing.Color.Transparent;
            this.labelDataAllenamento.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataAllenamento.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelDataAllenamento.Location = new System.Drawing.Point(30, 77);
            this.labelDataAllenamento.Name = "labelDataAllenamento";
            this.labelDataAllenamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDataAllenamento.Size = new System.Drawing.Size(35, 24);
            this.labelDataAllenamento.TabIndex = 76;
            this.labelDataAllenamento.Text = "Data";
            this.labelDataAllenamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownDurataProgressi
            // 
            this.numericUpDownDurataProgressi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownDurataProgressi.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDownDurataProgressi.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDurataProgressi.ForeColor = System.Drawing.Color.Transparent;
            this.numericUpDownDurataProgressi.Location = new System.Drawing.Point(264, 128);
            this.numericUpDownDurataProgressi.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownDurataProgressi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDurataProgressi.Name = "numericUpDownDurataProgressi";
            this.numericUpDownDurataProgressi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownDurataProgressi.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownDurataProgressi.TabIndex = 78;
            this.numericUpDownDurataProgressi.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // labelPeso
            // 
            this.labelPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPeso.AutoSize = true;
            this.labelPeso.BackColor = System.Drawing.Color.Transparent;
            this.labelPeso.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeso.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelPeso.Location = new System.Drawing.Point(30, 172);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPeso.Size = new System.Drawing.Size(183, 24);
            this.labelPeso.TabIndex = 79;
            this.labelPeso.Text = "Peso attuale in Kg (opzionale)";
            this.labelPeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownPesoProgressi
            // 
            this.numericUpDownPesoProgressi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownPesoProgressi.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDownPesoProgressi.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPesoProgressi.ForeColor = System.Drawing.Color.Transparent;
            this.numericUpDownPesoProgressi.Location = new System.Drawing.Point(264, 173);
            this.numericUpDownPesoProgressi.Name = "numericUpDownPesoProgressi";
            this.numericUpDownPesoProgressi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownPesoProgressi.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownPesoProgressi.TabIndex = 80;
            // 
            // buttonSalvaAllenamentoProgressi
            // 
            this.buttonSalvaAllenamentoProgressi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvaAllenamentoProgressi.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSalvaAllenamentoProgressi.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSalvaAllenamentoProgressi.FlatAppearance.BorderSize = 2;
            this.buttonSalvaAllenamentoProgressi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonSalvaAllenamentoProgressi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonSalvaAllenamentoProgressi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvaAllenamentoProgressi.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvaAllenamentoProgressi.Location = new System.Drawing.Point(108, 216);
            this.buttonSalvaAllenamentoProgressi.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvaAllenamentoProgressi.Name = "buttonSalvaAllenamentoProgressi";
            this.buttonSalvaAllenamentoProgressi.Size = new System.Drawing.Size(139, 30);
            this.buttonSalvaAllenamentoProgressi.TabIndex = 84;
            this.buttonSalvaAllenamentoProgressi.Tag = "";
            this.buttonSalvaAllenamentoProgressi.Text = "Salva Allenamento";
            this.buttonSalvaAllenamentoProgressi.UseVisualStyleBackColor = false;
            // 
            // labelContatore
            // 
            this.labelContatore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContatore.AutoSize = true;
            this.labelContatore.BackColor = System.Drawing.Color.Transparent;
            this.labelContatore.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContatore.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelContatore.Location = new System.Drawing.Point(696, 242);
            this.labelContatore.Name = "labelContatore";
            this.labelContatore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelContatore.Size = new System.Drawing.Size(17, 24);
            this.labelContatore.TabIndex = 89;
            this.labelContatore.Text = "0";
            this.labelContatore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAllenamenti
            // 
            this.labelAllenamenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAllenamenti.AutoSize = true;
            this.labelAllenamenti.BackColor = System.Drawing.Color.Transparent;
            this.labelAllenamenti.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAllenamenti.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelAllenamenti.Location = new System.Drawing.Point(368, 242);
            this.labelAllenamenti.Name = "labelAllenamenti";
            this.labelAllenamenti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelAllenamenti.Size = new System.Drawing.Size(81, 24);
            this.labelAllenamenti.TabIndex = 90;
            this.labelAllenamenti.Text = "Allenamenti ";
            this.labelAllenamenti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarAllenamenti
            // 
            this.progressBarAllenamenti.AccessibleDescription = "";
            this.progressBarAllenamenti.AccessibleName = "";
            this.progressBarAllenamenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBarAllenamenti.BackColor = System.Drawing.Color.OrangeRed;
            this.progressBarAllenamenti.Location = new System.Drawing.Point(455, 243);
            this.progressBarAllenamenti.Maximum = 20;
            this.progressBarAllenamenti.Name = "progressBarAllenamenti";
            this.progressBarAllenamenti.Size = new System.Drawing.Size(224, 23);
            this.progressBarAllenamenti.TabIndex = 85;
            this.progressBarAllenamenti.Tag = "";
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 500;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.SpringGreen;
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(148, 272);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.circularProgressBar.ProgressWidth = 25;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.Size = new System.Drawing.Size(127, 127);
            this.circularProgressBar.StartAngle = 180;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.DimGray;
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "%  ";
            this.circularProgressBar.TabIndex = 91;
            this.circularProgressBar.Text = "0%";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 5;
            // 
            // labelDurata
            // 
            this.labelDurata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDurata.AutoSize = true;
            this.labelDurata.BackColor = System.Drawing.Color.Transparent;
            this.labelDurata.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDurata.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelDurata.Location = new System.Drawing.Point(30, 124);
            this.labelDurata.Name = "labelDurata";
            this.labelDurata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDurata.Size = new System.Drawing.Size(195, 24);
            this.labelDurata.TabIndex = 77;
            this.labelDurata.Text = "Durata dell\'allenamento (minuti)";
            this.labelDurata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRegistraAllenamento
            // 
            this.labelRegistraAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRegistraAllenamento.AutoSize = true;
            this.labelRegistraAllenamento.BackColor = System.Drawing.Color.Transparent;
            this.labelRegistraAllenamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistraAllenamento.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelRegistraAllenamento.Location = new System.Drawing.Point(30, 26);
            this.labelRegistraAllenamento.Name = "labelRegistraAllenamento";
            this.labelRegistraAllenamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRegistraAllenamento.Size = new System.Drawing.Size(292, 24);
            this.labelRegistraAllenamento.TabIndex = 92;
            this.labelRegistraAllenamento.Text = "Registra il tuo allenamento !";
            this.labelRegistraAllenamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProgressiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelRegistraAllenamento);
            this.Controls.Add(this.circularProgressBar);
            this.Controls.Add(this.labelAllenamenti);
            this.Controls.Add(this.labelContatore);
            this.Controls.Add(this.labelCompletamentoScheda);
            this.Controls.Add(this.progressBarAllenamenti);
            this.Controls.Add(this.buttonSalvaAllenamentoProgressi);
            this.Controls.Add(this.chartPeso);
            this.Controls.Add(this.chartDurata);
            this.Controls.Add(this.numericUpDownPesoProgressi);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.numericUpDownDurataProgressi);
            this.Controls.Add(this.labelDurata);
            this.Controls.Add(this.labelDataAllenamento);
            this.Controls.Add(this.buttonIndietroProgressi);
            this.Controls.Add(this.dateTimePickerDataAllenamento);
            this.Name = "ProgressiView";
            this.Size = new System.Drawing.Size(822, 512);
            ((System.ComponentModel.ISupportInitialize)(this.chartDurata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurataProgressi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPesoProgressi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCompletamentoScheda;
        private System.Windows.Forms.Label labelDataAllenamento;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.Label labelAllenamenti;
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.Label labelDurata;
        private System.Windows.Forms.Label labelRegistraAllenamento;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartDurata;
        public System.Windows.Forms.ProgressBar progressBarAllenamenti;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartPeso;
        public System.Windows.Forms.Button buttonIndietroProgressi;
        public CircularProgressBar.CircularProgressBar circularProgressBar;
        public System.Windows.Forms.Button buttonSalvaAllenamentoProgressi;
        public System.Windows.Forms.NumericUpDown numericUpDownPesoProgressi;
        public System.Windows.Forms.DateTimePicker dateTimePickerDataAllenamento;
        public System.Windows.Forms.NumericUpDown numericUpDownDurataProgressi;
        public System.Windows.Forms.Label labelContatore;
    }
}
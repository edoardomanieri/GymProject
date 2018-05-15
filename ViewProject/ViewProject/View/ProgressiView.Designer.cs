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
            this.buttonIndietro = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCompletamentoScheda = new System.Windows.Forms.Label();
            this.dateTimePickerDataAllenamento = new System.Windows.Forms.DateTimePicker();
            this.labelDataAllenamento = new System.Windows.Forms.Label();
            this.numericUpDownDurata = new System.Windows.Forms.NumericUpDown();
            this.labelPeso = new System.Windows.Forms.Label();
            this.numericUpDownPeso = new System.Windows.Forms.NumericUpDown();
            this.buttonSalvaAllenamento = new System.Windows.Forms.Button();
            this.labelContatore = new System.Windows.Forms.Label();
            this.labelAllenamenti = new System.Windows.Forms.Label();
            this.progressBarAllenamenti = new System.Windows.Forms.ProgressBar();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.labelDurata = new System.Windows.Forms.Label();
            this.labelRegistraAllenamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).BeginInit();
            this.SuspendLayout();
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
            this.buttonIndietro.Location = new System.Drawing.Point(34, 453);
            this.buttonIndietro.Margin = new System.Windows.Forms.Padding(0);
            this.buttonIndietro.Name = "buttonIndietro";
            this.buttonIndietro.Size = new System.Drawing.Size(139, 30);
            this.buttonIndietro.TabIndex = 74;
            this.buttonIndietro.Tag = "";
            this.buttonIndietro.Text = "Torna al Menu";
            this.buttonIndietro.UseVisualStyleBackColor = false;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderlineWidth = 0;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.PaleGreen;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.LightUpwardDiagonal;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Blue;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legendCellColumn1.Name = "Column1";
            legend1.CellColumns.Add(legendCellColumn1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(330, 26);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
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
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(480, 211);
            this.chart1.TabIndex = 81;
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
            this.chart1.Titles.Add(title1);
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart2.BackColor = System.Drawing.Color.DimGray;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart2.BackSecondaryColor = System.Drawing.Color.White;
            this.chart2.BorderlineColor = System.Drawing.Color.Transparent;
            this.chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart2.BorderlineWidth = 0;
            this.chart2.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea2.BackColor = System.Drawing.Color.PaleGreen;
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.LightUpwardDiagonal;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Blue;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legendCellColumn2.Name = "Column1";
            legend2.CellColumns.Add(legendCellColumn2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(330, 272);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
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
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(480, 211);
            this.chart2.TabIndex = 83;
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
            this.chart2.Titles.Add(title2);
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
            // numericUpDownDurata
            // 
            this.numericUpDownDurata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownDurata.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDownDurata.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDurata.ForeColor = System.Drawing.Color.Transparent;
            this.numericUpDownDurata.Location = new System.Drawing.Point(264, 128);
            this.numericUpDownDurata.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownDurata.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDurata.Name = "numericUpDownDurata";
            this.numericUpDownDurata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownDurata.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownDurata.TabIndex = 78;
            this.numericUpDownDurata.Value = new decimal(new int[] {
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
            this.labelPeso.Location = new System.Drawing.Point(30, 173);
            this.labelPeso.Name = "labelPeso";
            this.labelPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelPeso.Size = new System.Drawing.Size(112, 24);
            this.labelPeso.TabIndex = 79;
            this.labelPeso.Text = "Peso attuale in Kg";
            this.labelPeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownPeso
            // 
            this.numericUpDownPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownPeso.BackColor = System.Drawing.Color.SteelBlue;
            this.numericUpDownPeso.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownPeso.ForeColor = System.Drawing.Color.Transparent;
            this.numericUpDownPeso.Location = new System.Drawing.Point(181, 173);
            this.numericUpDownPeso.Name = "numericUpDownPeso";
            this.numericUpDownPeso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownPeso.Size = new System.Drawing.Size(44, 23);
            this.numericUpDownPeso.TabIndex = 80;
            this.numericUpDownPeso.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // buttonSalvaAllenamento
            // 
            this.buttonSalvaAllenamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSalvaAllenamento.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSalvaAllenamento.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonSalvaAllenamento.FlatAppearance.BorderSize = 2;
            this.buttonSalvaAllenamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.buttonSalvaAllenamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.buttonSalvaAllenamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvaAllenamento.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvaAllenamento.Location = new System.Drawing.Point(108, 216);
            this.buttonSalvaAllenamento.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSalvaAllenamento.Name = "buttonSalvaAllenamento";
            this.buttonSalvaAllenamento.Size = new System.Drawing.Size(139, 30);
            this.buttonSalvaAllenamento.TabIndex = 84;
            this.buttonSalvaAllenamento.Tag = "";
            this.buttonSalvaAllenamento.Text = "Salva Allenamento";
            this.buttonSalvaAllenamento.UseVisualStyleBackColor = false;
            this.buttonSalvaAllenamento.Click += new System.EventHandler(this.buttonSalvaAllenamento_Click);
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
            // FormRegistraAllenamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 512);
            this.Controls.Add(this.labelRegistraAllenamento);
            this.Controls.Add(this.circularProgressBar);
            this.Controls.Add(this.labelAllenamenti);
            this.Controls.Add(this.labelContatore);
            this.Controls.Add(this.labelCompletamentoScheda);
            this.Controls.Add(this.progressBarAllenamenti);
            this.Controls.Add(this.buttonSalvaAllenamento);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.numericUpDownPeso);
            this.Controls.Add(this.labelPeso);
            this.Controls.Add(this.numericUpDownDurata);
            this.Controls.Add(this.labelDurata);
            this.Controls.Add(this.labelDataAllenamento);
            this.Controls.Add(this.buttonIndietro);
            this.Controls.Add(this.dateTimePickerDataAllenamento);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistraAllenamento";
            this.Text = "No Pain No Gain";
            this.Load += new System.EventHandler(this.FormRegistraAllenamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDurata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonIndietro;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label labelCompletamentoScheda;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAllenamento;
        private System.Windows.Forms.Label labelDataAllenamento;
        private System.Windows.Forms.NumericUpDown numericUpDownDurata;
        private System.Windows.Forms.Label labelPeso;
        private System.Windows.Forms.NumericUpDown numericUpDownPeso;
        private System.Windows.Forms.Button buttonSalvaAllenamento;
        private System.Windows.Forms.Label labelContatore;
        private System.Windows.Forms.Label labelAllenamenti;
        private System.Windows.Forms.ProgressBar progressBarAllenamenti;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Label labelTitolo;
        private System.Windows.Forms.Label labelDurata;
        private System.Windows.Forms.Label labelRegistraAllenamento;
    }
}
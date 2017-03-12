namespace NoruST.Forms
{
    partial class ForecastForm
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
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.nudSeasonalPeriod = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfHoldouts = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfForecasts = new System.Windows.Forms.NumericUpDown();
            this.cbxLabels = new System.Windows.Forms.ComboBox();
            this.lblSeasonalPeriod = new System.Windows.Forms.Label();
            this.lblNumberOfHoldouts = new System.Windows.Forms.Label();
            this.lblNumberOfForecasts = new System.Windows.Forms.Label();
            this.chkLabels = new System.Windows.Forms.CheckBox();
            this.chkOptimizeParameters = new System.Windows.Forms.CheckBox();
            this.lstDataSets = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpMethods = new System.Windows.Forms.GroupBox();
            this.tlpMethods = new System.Windows.Forms.TableLayoutPanel();
            this.rdbWintersExponentialSmoothing = new System.Windows.Forms.RadioButton();
            this.rdbSimpleExponentialSmoothing = new System.Windows.Forms.RadioButton();
            this.rdbMovingAverage = new System.Windows.Forms.RadioButton();
            this.rdbHoltsExponentialSmoothing = new System.Windows.Forms.RadioButton();
            this.nudSpan = new System.Windows.Forms.NumericUpDown();
            this.lblSpan = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTrend = new System.Windows.Forms.Label();
            this.lblSeasonality = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtTrend = new System.Windows.Forms.TextBox();
            this.txtSeasonality = new System.Windows.Forms.TextBox();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasonalPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfHoldouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfForecasts)).BeginInit();
            this.grpMethods.SuspendLayout();
            this.tlpMethods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpan)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpForm
            // 
            this.tlpForm.AutoSize = true;
            this.tlpForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.ColumnCount = 3;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.Controls.Add(this.dgvDataSet, 0, 1);
            this.tlpForm.Controls.Add(this.grpOptions, 0, 2);
            this.tlpForm.Controls.Add(this.lstDataSets, 0, 0);
            this.tlpForm.Controls.Add(this.btnOk, 1, 4);
            this.tlpForm.Controls.Add(this.btnCancel, 2, 4);
            this.tlpForm.Controls.Add(this.grpMethods, 0, 3);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 5;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.Size = new System.Drawing.Size(768, 1079);
            this.tlpForm.TabIndex = 22;
            // 
            // dgvDataSet
            // 
            this.dgvDataSet.AllowUserToAddRows = false;
            this.dgvDataSet.AllowUserToDeleteRows = false;
            this.dgvDataSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpForm.SetColumnSpan(this.dgvDataSet, 3);
            this.dgvDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataSet.Location = new System.Drawing.Point(6, 150);
            this.dgvDataSet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgvDataSet.MinimumSize = new System.Drawing.Size(600, 0);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.RowHeadersVisible = false;
            this.dgvDataSet.Size = new System.Drawing.Size(756, 368);
            this.dgvDataSet.TabIndex = 14;
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.AutoSize = true;
            this.grpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.SetColumnSpan(this.grpOptions, 3);
            this.grpOptions.Controls.Add(this.tlpOptions);
            this.grpOptions.Location = new System.Drawing.Point(6, 530);
            this.grpOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpOptions.Size = new System.Drawing.Size(756, 261);
            this.grpOptions.TabIndex = 18;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // tlpOptions
            // 
            this.tlpOptions.AutoSize = true;
            this.tlpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptions.ColumnCount = 3;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.Controls.Add(this.nudSeasonalPeriod, 1, 4);
            this.tlpOptions.Controls.Add(this.nudNumberOfHoldouts, 1, 3);
            this.tlpOptions.Controls.Add(this.nudNumberOfForecasts, 1, 2);
            this.tlpOptions.Controls.Add(this.cbxLabels, 1, 1);
            this.tlpOptions.Controls.Add(this.lblSeasonalPeriod, 0, 4);
            this.tlpOptions.Controls.Add(this.lblNumberOfHoldouts, 0, 3);
            this.tlpOptions.Controls.Add(this.lblNumberOfForecasts, 0, 2);
            this.tlpOptions.Controls.Add(this.chkLabels, 0, 1);
            this.tlpOptions.Controls.Add(this.chkOptimizeParameters, 0, 0);
            this.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpOptions.Location = new System.Drawing.Point(6, 30);
            this.tlpOptions.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tlpOptions.RowCount = 5;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.Size = new System.Drawing.Size(744, 225);
            this.tlpOptions.TabIndex = 32;
            // 
            // nudSeasonalPeriod
            // 
            this.nudSeasonalPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSeasonalPeriod.Location = new System.Drawing.Point(262, 188);
            this.nudSeasonalPeriod.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudSeasonalPeriod.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSeasonalPeriod.Name = "nudSeasonalPeriod";
            this.nudSeasonalPeriod.Size = new System.Drawing.Size(200, 31);
            this.nudSeasonalPeriod.TabIndex = 37;
            this.nudSeasonalPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudNumberOfHoldouts
            // 
            this.nudNumberOfHoldouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNumberOfHoldouts.Location = new System.Drawing.Point(262, 145);
            this.nudNumberOfHoldouts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudNumberOfHoldouts.Name = "nudNumberOfHoldouts";
            this.nudNumberOfHoldouts.Size = new System.Drawing.Size(200, 31);
            this.nudNumberOfHoldouts.TabIndex = 29;
            // 
            // nudNumberOfForecasts
            // 
            this.nudNumberOfForecasts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNumberOfForecasts.Location = new System.Drawing.Point(262, 102);
            this.nudNumberOfForecasts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudNumberOfForecasts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfForecasts.Name = "nudNumberOfForecasts";
            this.nudNumberOfForecasts.Size = new System.Drawing.Size(200, 31);
            this.nudNumberOfForecasts.TabIndex = 28;
            this.nudNumberOfForecasts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxLabels
            // 
            this.cbxLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxLabels.FormattingEnabled = true;
            this.cbxLabels.Location = new System.Drawing.Point(262, 57);
            this.cbxLabels.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxLabels.Name = "cbxLabels";
            this.cbxLabels.Size = new System.Drawing.Size(200, 33);
            this.cbxLabels.TabIndex = 26;
            // 
            // lblSeasonalPeriod
            // 
            this.lblSeasonalPeriod.AutoSize = true;
            this.lblSeasonalPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeasonalPeriod.Location = new System.Drawing.Point(6, 182);
            this.lblSeasonalPeriod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSeasonalPeriod.Name = "lblSeasonalPeriod";
            this.lblSeasonalPeriod.Size = new System.Drawing.Size(244, 43);
            this.lblSeasonalPeriod.TabIndex = 33;
            this.lblSeasonalPeriod.Text = "Seasonal Period";
            this.lblSeasonalPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOfHoldouts
            // 
            this.lblNumberOfHoldouts.AutoSize = true;
            this.lblNumberOfHoldouts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumberOfHoldouts.Location = new System.Drawing.Point(6, 139);
            this.lblNumberOfHoldouts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfHoldouts.Name = "lblNumberOfHoldouts";
            this.lblNumberOfHoldouts.Size = new System.Drawing.Size(244, 43);
            this.lblNumberOfHoldouts.TabIndex = 31;
            this.lblNumberOfHoldouts.Text = "Number of Holdouts";
            this.lblNumberOfHoldouts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberOfForecasts
            // 
            this.lblNumberOfForecasts.AutoSize = true;
            this.lblNumberOfForecasts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumberOfForecasts.Location = new System.Drawing.Point(6, 96);
            this.lblNumberOfForecasts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumberOfForecasts.Name = "lblNumberOfForecasts";
            this.lblNumberOfForecasts.Size = new System.Drawing.Size(244, 43);
            this.lblNumberOfForecasts.TabIndex = 30;
            this.lblNumberOfForecasts.Text = "Number of Forecasts";
            this.lblNumberOfForecasts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkLabels
            // 
            this.chkLabels.AutoSize = true;
            this.chkLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLabels.Location = new System.Drawing.Point(6, 57);
            this.chkLabels.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkLabels.Name = "chkLabels";
            this.chkLabels.Size = new System.Drawing.Size(244, 33);
            this.chkLabels.TabIndex = 27;
            this.chkLabels.Text = "Labels";
            this.chkLabels.UseVisualStyleBackColor = true;
            // 
            // chkOptimizeParameters
            // 
            this.chkOptimizeParameters.AutoSize = true;
            this.chkOptimizeParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkOptimizeParameters.Location = new System.Drawing.Point(6, 16);
            this.chkOptimizeParameters.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkOptimizeParameters.Name = "chkOptimizeParameters";
            this.chkOptimizeParameters.Size = new System.Drawing.Size(244, 29);
            this.chkOptimizeParameters.TabIndex = 32;
            this.chkOptimizeParameters.Text = "Optimize Parameters";
            this.chkOptimizeParameters.UseVisualStyleBackColor = true;
            // 
            // lstDataSets
            // 
            this.tlpForm.SetColumnSpan(this.lstDataSets, 3);
            this.lstDataSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataSets.FormattingEnabled = true;
            this.lstDataSets.ItemHeight = 25;
            this.lstDataSets.Location = new System.Drawing.Point(6, 6);
            this.lstDataSets.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstDataSets.Name = "lstDataSets";
            this.lstDataSets.Size = new System.Drawing.Size(756, 132);
            this.lstDataSets.TabIndex = 15;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(450, 1023);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 50);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(612, 1023);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 50);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpMethods
            // 
            this.grpMethods.AutoSize = true;
            this.grpMethods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.SetColumnSpan(this.grpMethods, 3);
            this.grpMethods.Controls.Add(this.tlpMethods);
            this.grpMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMethods.Location = new System.Drawing.Point(6, 803);
            this.grpMethods.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpMethods.Name = "grpMethods";
            this.grpMethods.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpMethods.Size = new System.Drawing.Size(756, 208);
            this.grpMethods.TabIndex = 19;
            this.grpMethods.TabStop = false;
            this.grpMethods.Text = "Methods";
            // 
            // tlpMethods
            // 
            this.tlpMethods.AutoSize = true;
            this.tlpMethods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMethods.ColumnCount = 4;
            this.tlpMethods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMethods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMethods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMethods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMethods.Controls.Add(this.rdbWintersExponentialSmoothing, 0, 3);
            this.tlpMethods.Controls.Add(this.rdbSimpleExponentialSmoothing, 0, 1);
            this.tlpMethods.Controls.Add(this.rdbMovingAverage, 0, 0);
            this.tlpMethods.Controls.Add(this.rdbHoltsExponentialSmoothing, 0, 2);
            this.tlpMethods.Controls.Add(this.nudSpan, 2, 0);
            this.tlpMethods.Controls.Add(this.lblSpan, 1, 0);
            this.tlpMethods.Controls.Add(this.lblLevel, 1, 1);
            this.tlpMethods.Controls.Add(this.lblTrend, 1, 2);
            this.tlpMethods.Controls.Add(this.lblSeasonality, 1, 3);
            this.tlpMethods.Controls.Add(this.txtLevel, 2, 1);
            this.tlpMethods.Controls.Add(this.txtTrend, 2, 2);
            this.tlpMethods.Controls.Add(this.txtSeasonality, 2, 3);
            this.tlpMethods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMethods.Location = new System.Drawing.Point(6, 30);
            this.tlpMethods.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tlpMethods.Name = "tlpMethods";
            this.tlpMethods.RowCount = 4;
            this.tlpMethods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMethods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMethods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMethods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMethods.Size = new System.Drawing.Size(744, 172);
            this.tlpMethods.TabIndex = 0;
            // 
            // rdbWintersExponentialSmoothing
            // 
            this.rdbWintersExponentialSmoothing.AutoSize = true;
            this.rdbWintersExponentialSmoothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbWintersExponentialSmoothing.Location = new System.Drawing.Point(6, 135);
            this.rdbWintersExponentialSmoothing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbWintersExponentialSmoothing.Name = "rdbWintersExponentialSmoothing";
            this.rdbWintersExponentialSmoothing.Size = new System.Drawing.Size(347, 31);
            this.rdbWintersExponentialSmoothing.TabIndex = 36;
            this.rdbWintersExponentialSmoothing.TabStop = true;
            this.rdbWintersExponentialSmoothing.Text = "Winter\'s Exponential Smoothing";
            this.rdbWintersExponentialSmoothing.UseVisualStyleBackColor = true;
            // 
            // rdbSimpleExponentialSmoothing
            // 
            this.rdbSimpleExponentialSmoothing.AutoSize = true;
            this.rdbSimpleExponentialSmoothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbSimpleExponentialSmoothing.Location = new System.Drawing.Point(6, 49);
            this.rdbSimpleExponentialSmoothing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbSimpleExponentialSmoothing.Name = "rdbSimpleExponentialSmoothing";
            this.rdbSimpleExponentialSmoothing.Size = new System.Drawing.Size(347, 31);
            this.rdbSimpleExponentialSmoothing.TabIndex = 34;
            this.rdbSimpleExponentialSmoothing.TabStop = true;
            this.rdbSimpleExponentialSmoothing.Text = "Simple Exponential Smoothing";
            this.rdbSimpleExponentialSmoothing.UseVisualStyleBackColor = true;
            // 
            // rdbMovingAverage
            // 
            this.rdbMovingAverage.AutoSize = true;
            this.rdbMovingAverage.Checked = true;
            this.rdbMovingAverage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbMovingAverage.Location = new System.Drawing.Point(6, 6);
            this.rdbMovingAverage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbMovingAverage.Name = "rdbMovingAverage";
            this.rdbMovingAverage.Size = new System.Drawing.Size(347, 31);
            this.rdbMovingAverage.TabIndex = 33;
            this.rdbMovingAverage.TabStop = true;
            this.rdbMovingAverage.Text = "Moving Average";
            this.rdbMovingAverage.UseVisualStyleBackColor = true;
            // 
            // rdbHoltsExponentialSmoothing
            // 
            this.rdbHoltsExponentialSmoothing.AutoSize = true;
            this.rdbHoltsExponentialSmoothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbHoltsExponentialSmoothing.Location = new System.Drawing.Point(6, 92);
            this.rdbHoltsExponentialSmoothing.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbHoltsExponentialSmoothing.Name = "rdbHoltsExponentialSmoothing";
            this.rdbHoltsExponentialSmoothing.Size = new System.Drawing.Size(347, 31);
            this.rdbHoltsExponentialSmoothing.TabIndex = 35;
            this.rdbHoltsExponentialSmoothing.TabStop = true;
            this.rdbHoltsExponentialSmoothing.Text = "Holt\'s Exponential Smoothing";
            this.rdbHoltsExponentialSmoothing.UseVisualStyleBackColor = true;
            // 
            // nudSpan
            // 
            this.nudSpan.AutoSize = true;
            this.nudSpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudSpan.Location = new System.Drawing.Point(501, 6);
            this.nudSpan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudSpan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpan.Name = "nudSpan";
            this.nudSpan.Size = new System.Drawing.Size(156, 31);
            this.nudSpan.TabIndex = 37;
            this.nudSpan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSpan
            // 
            this.lblSpan.AutoSize = true;
            this.lblSpan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSpan.Location = new System.Drawing.Point(365, 0);
            this.lblSpan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpan.Name = "lblSpan";
            this.lblSpan.Size = new System.Drawing.Size(124, 43);
            this.lblSpan.TabIndex = 38;
            this.lblSpan.Text = "Span";
            this.lblSpan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLevel.Location = new System.Drawing.Point(365, 43);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(124, 43);
            this.lblLevel.TabIndex = 39;
            this.lblLevel.Text = "Level";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTrend
            // 
            this.lblTrend.AutoSize = true;
            this.lblTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrend.Location = new System.Drawing.Point(365, 86);
            this.lblTrend.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTrend.Name = "lblTrend";
            this.lblTrend.Size = new System.Drawing.Size(124, 43);
            this.lblTrend.TabIndex = 40;
            this.lblTrend.Text = "Trend";
            this.lblTrend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSeasonality
            // 
            this.lblSeasonality.AutoSize = true;
            this.lblSeasonality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeasonality.Location = new System.Drawing.Point(365, 129);
            this.lblSeasonality.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSeasonality.Name = "lblSeasonality";
            this.lblSeasonality.Size = new System.Drawing.Size(124, 43);
            this.lblSeasonality.TabIndex = 41;
            this.lblSeasonality.Text = "Seasonality";
            this.lblSeasonality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLevel
            // 
            this.txtLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLevel.Location = new System.Drawing.Point(501, 49);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(156, 31);
            this.txtLevel.TabIndex = 49;
            this.txtLevel.Text = "0.1";
            // 
            // txtTrend
            // 
            this.txtTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTrend.Location = new System.Drawing.Point(501, 92);
            this.txtTrend.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTrend.Name = "txtTrend";
            this.txtTrend.Size = new System.Drawing.Size(156, 31);
            this.txtTrend.TabIndex = 48;
            this.txtTrend.Text = "0.1";
            // 
            // txtSeasonality
            // 
            this.txtSeasonality.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSeasonality.Location = new System.Drawing.Point(501, 135);
            this.txtSeasonality.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSeasonality.Name = "txtSeasonality";
            this.txtSeasonality.Size = new System.Drawing.Size(156, 31);
            this.txtSeasonality.TabIndex = 51;
            this.txtSeasonality.Text = "0.1";
            // 
            // ForecastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 1079);
            this.Controls.Add(this.tlpForm);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(774, 704);
            this.Name = "ForecastForm";
            this.Text = "NoruST - Forecast";
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasonalPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfHoldouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfForecasts)).EndInit();
            this.grpMethods.ResumeLayout(false);
            this.grpMethods.PerformLayout();
            this.tlpMethods.ResumeLayout(false);
            this.tlpMethods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.ListBox lstDataSets;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbxLabels;
        private System.Windows.Forms.CheckBox chkLabels;
        private System.Windows.Forms.NumericUpDown nudNumberOfForecasts;
        private System.Windows.Forms.NumericUpDown nudNumberOfHoldouts;
        private System.Windows.Forms.Label lblNumberOfForecasts;
        private System.Windows.Forms.Label lblNumberOfHoldouts;
        private System.Windows.Forms.GroupBox grpMethods;
        private System.Windows.Forms.TableLayoutPanel tlpMethods;
        private System.Windows.Forms.RadioButton rdbWintersExponentialSmoothing;
        private System.Windows.Forms.RadioButton rdbSimpleExponentialSmoothing;
        private System.Windows.Forms.RadioButton rdbMovingAverage;
        private System.Windows.Forms.RadioButton rdbHoltsExponentialSmoothing;
        private System.Windows.Forms.CheckBox chkOptimizeParameters;
        private System.Windows.Forms.NumericUpDown nudSeasonalPeriod;
        private System.Windows.Forms.Label lblSeasonalPeriod;
        private System.Windows.Forms.NumericUpDown nudSpan;
        private System.Windows.Forms.Label lblSpan;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTrend;
        private System.Windows.Forms.Label lblSeasonality;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtTrend;
        private System.Windows.Forms.TextBox txtSeasonality;
    }
}
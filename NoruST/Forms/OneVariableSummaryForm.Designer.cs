namespace NoruST.Forms
{
    partial class OneVariableSummaryForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstDataSets = new System.Windows.Forms.ListBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.chkMode = new System.Windows.Forms.CheckBox();
            this.chkRange = new System.Windows.Forms.CheckBox();
            this.chkOutliers = new System.Windows.Forms.CheckBox();
            this.chkCount = new System.Windows.Forms.CheckBox();
            this.chkSum = new System.Windows.Forms.CheckBox();
            this.chkMean = new System.Windows.Forms.CheckBox();
            this.chkVariance = new System.Windows.Forms.CheckBox();
            this.chkStandardDeviation = new System.Windows.Forms.CheckBox();
            this.chkMinimum = new System.Windows.Forms.CheckBox();
            this.chkQuartile1 = new System.Windows.Forms.CheckBox();
            this.chkMedian = new System.Windows.Forms.CheckBox();
            this.chkQuartile3 = new System.Windows.Forms.CheckBox();
            this.chkMaximum = new System.Windows.Forms.CheckBox();
            this.chkInterquartileRange = new System.Windows.Forms.CheckBox();
            this.chkSkewness = new System.Windows.Forms.CheckBox();
            this.chkKurtosis = new System.Windows.Forms.CheckBox();
            this.chkMeanAbsoluteDeviation = new System.Windows.Forms.CheckBox();
            this.chkCheckAllOptions = new System.Windows.Forms.CheckBox();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.chkPerCategorie = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            this.tlpForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(325, 433);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // dgvDataSet
            // 
            this.dgvDataSet.AllowUserToAddRows = false;
            this.dgvDataSet.AllowUserToDeleteRows = false;
            this.dgvDataSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpForm.SetColumnSpan(this.dgvDataSet, 3);
            this.dgvDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataSet.Location = new System.Drawing.Point(3, 101);
            this.dgvDataSet.MinimumSize = new System.Drawing.Size(300, 0);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.RowHeadersVisible = false;
            this.dgvDataSet.Size = new System.Drawing.Size(478, 158);
            this.dgvDataSet.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(406, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lstDataSets
            // 
            this.tlpForm.SetColumnSpan(this.lstDataSets, 3);
            this.lstDataSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataSets.FormattingEnabled = true;
            this.lstDataSets.Location = new System.Drawing.Point(3, 3);
            this.lstDataSets.Name = "lstDataSets";
            this.lstDataSets.Size = new System.Drawing.Size(478, 69);
            this.lstDataSets.TabIndex = 15;
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.AutoSize = true;
            this.grpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.SetColumnSpan(this.grpOptions, 3);
            this.grpOptions.Controls.Add(this.tlpOptions);
            this.grpOptions.Controls.Add(this.chkCheckAllOptions);
            this.grpOptions.Location = new System.Drawing.Point(3, 265);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(478, 162);
            this.grpOptions.TabIndex = 18;
            this.grpOptions.TabStop = false;
            // 
            // tlpOptions
            // 
            this.tlpOptions.AutoSize = true;
            this.tlpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptions.ColumnCount = 3;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpOptions.Controls.Add(this.chkMode, 2, 0);
            this.tlpOptions.Controls.Add(this.chkRange, 2, 1);
            this.tlpOptions.Controls.Add(this.chkOutliers, 2, 5);
            this.tlpOptions.Controls.Add(this.chkCount, 2, 2);
            this.tlpOptions.Controls.Add(this.chkSum, 2, 3);
            this.tlpOptions.Controls.Add(this.chkMean, 0, 0);
            this.tlpOptions.Controls.Add(this.chkVariance, 0, 1);
            this.tlpOptions.Controls.Add(this.chkStandardDeviation, 0, 2);
            this.tlpOptions.Controls.Add(this.chkMinimum, 0, 3);
            this.tlpOptions.Controls.Add(this.chkQuartile1, 0, 4);
            this.tlpOptions.Controls.Add(this.chkMedian, 0, 5);
            this.tlpOptions.Controls.Add(this.chkQuartile3, 1, 0);
            this.tlpOptions.Controls.Add(this.chkMaximum, 1, 1);
            this.tlpOptions.Controls.Add(this.chkInterquartileRange, 1, 2);
            this.tlpOptions.Controls.Add(this.chkSkewness, 1, 3);
            this.tlpOptions.Controls.Add(this.chkKurtosis, 1, 4);
            this.tlpOptions.Controls.Add(this.chkMeanAbsoluteDeviation, 1, 5);
            this.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpOptions.Location = new System.Drawing.Point(3, 16);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tlpOptions.RowCount = 6;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpOptions.Size = new System.Drawing.Size(472, 143);
            this.tlpOptions.TabIndex = 32;
            // 
            // chkMode
            // 
            this.chkMode.AutoSize = true;
            this.chkMode.Location = new System.Drawing.Point(317, 8);
            this.chkMode.Name = "chkMode";
            this.chkMode.Size = new System.Drawing.Size(53, 17);
            this.chkMode.TabIndex = 28;
            this.chkMode.Text = "Mode";
            this.chkMode.UseVisualStyleBackColor = true;
            // 
            // chkRange
            // 
            this.chkRange.AutoSize = true;
            this.chkRange.Location = new System.Drawing.Point(317, 31);
            this.chkRange.Name = "chkRange";
            this.chkRange.Size = new System.Drawing.Size(58, 17);
            this.chkRange.TabIndex = 29;
            this.chkRange.Text = "Range";
            this.chkRange.UseVisualStyleBackColor = true;
            // 
            // chkOutliers
            // 
            this.chkOutliers.AutoSize = true;
            this.chkOutliers.Location = new System.Drawing.Point(317, 123);
            this.chkOutliers.Name = "chkOutliers";
            this.chkOutliers.Size = new System.Drawing.Size(61, 17);
            this.chkOutliers.TabIndex = 32;
            this.chkOutliers.Text = "Outliers";
            this.chkOutliers.UseVisualStyleBackColor = true;
            // 
            // chkCount
            // 
            this.chkCount.AutoSize = true;
            this.chkCount.Location = new System.Drawing.Point(317, 54);
            this.chkCount.Name = "chkCount";
            this.chkCount.Size = new System.Drawing.Size(54, 17);
            this.chkCount.TabIndex = 30;
            this.chkCount.Text = "Count";
            this.chkCount.UseVisualStyleBackColor = true;
            // 
            // chkSum
            // 
            this.chkSum.AutoSize = true;
            this.chkSum.Location = new System.Drawing.Point(317, 77);
            this.chkSum.Name = "chkSum";
            this.chkSum.Size = new System.Drawing.Size(47, 17);
            this.chkSum.TabIndex = 31;
            this.chkSum.Text = "Sum";
            this.chkSum.UseVisualStyleBackColor = true;
            // 
            // chkMean
            // 
            this.chkMean.AutoSize = true;
            this.chkMean.Checked = true;
            this.chkMean.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMean.Location = new System.Drawing.Point(3, 8);
            this.chkMean.Name = "chkMean";
            this.chkMean.Size = new System.Drawing.Size(53, 17);
            this.chkMean.TabIndex = 16;
            this.chkMean.Text = "Mean";
            this.chkMean.UseVisualStyleBackColor = true;
            // 
            // chkVariance
            // 
            this.chkVariance.AutoSize = true;
            this.chkVariance.Checked = true;
            this.chkVariance.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVariance.Location = new System.Drawing.Point(3, 31);
            this.chkVariance.Name = "chkVariance";
            this.chkVariance.Size = new System.Drawing.Size(68, 17);
            this.chkVariance.TabIndex = 17;
            this.chkVariance.Text = "Variance";
            this.chkVariance.UseVisualStyleBackColor = true;
            // 
            // chkStandardDeviation
            // 
            this.chkStandardDeviation.AutoSize = true;
            this.chkStandardDeviation.Checked = true;
            this.chkStandardDeviation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStandardDeviation.Location = new System.Drawing.Point(3, 54);
            this.chkStandardDeviation.Name = "chkStandardDeviation";
            this.chkStandardDeviation.Size = new System.Drawing.Size(117, 17);
            this.chkStandardDeviation.TabIndex = 18;
            this.chkStandardDeviation.Text = "Standard Deviation";
            this.chkStandardDeviation.UseVisualStyleBackColor = true;
            // 
            // chkMinimum
            // 
            this.chkMinimum.AutoSize = true;
            this.chkMinimum.Checked = true;
            this.chkMinimum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMinimum.Location = new System.Drawing.Point(3, 77);
            this.chkMinimum.Name = "chkMinimum";
            this.chkMinimum.Size = new System.Drawing.Size(67, 17);
            this.chkMinimum.TabIndex = 19;
            this.chkMinimum.Text = "Minimum";
            this.chkMinimum.UseVisualStyleBackColor = true;
            // 
            // chkQuartile1
            // 
            this.chkQuartile1.AutoSize = true;
            this.chkQuartile1.Checked = true;
            this.chkQuartile1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuartile1.Location = new System.Drawing.Point(3, 100);
            this.chkQuartile1.Name = "chkQuartile1";
            this.chkQuartile1.Size = new System.Drawing.Size(71, 17);
            this.chkQuartile1.TabIndex = 20;
            this.chkQuartile1.Text = "Quartile 1";
            this.chkQuartile1.UseVisualStyleBackColor = true;
            // 
            // chkMedian
            // 
            this.chkMedian.AutoSize = true;
            this.chkMedian.Checked = true;
            this.chkMedian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMedian.Location = new System.Drawing.Point(3, 123);
            this.chkMedian.Name = "chkMedian";
            this.chkMedian.Size = new System.Drawing.Size(61, 17);
            this.chkMedian.TabIndex = 21;
            this.chkMedian.Text = "Median";
            this.chkMedian.UseVisualStyleBackColor = true;
            // 
            // chkQuartile3
            // 
            this.chkQuartile3.AutoSize = true;
            this.chkQuartile3.Checked = true;
            this.chkQuartile3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkQuartile3.Location = new System.Drawing.Point(160, 8);
            this.chkQuartile3.Name = "chkQuartile3";
            this.chkQuartile3.Size = new System.Drawing.Size(71, 17);
            this.chkQuartile3.TabIndex = 22;
            this.chkQuartile3.Text = "Quartile 3";
            this.chkQuartile3.UseVisualStyleBackColor = true;
            // 
            // chkMaximum
            // 
            this.chkMaximum.AutoSize = true;
            this.chkMaximum.Checked = true;
            this.chkMaximum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaximum.Location = new System.Drawing.Point(160, 31);
            this.chkMaximum.Name = "chkMaximum";
            this.chkMaximum.Size = new System.Drawing.Size(70, 17);
            this.chkMaximum.TabIndex = 23;
            this.chkMaximum.Text = "Maximum";
            this.chkMaximum.UseVisualStyleBackColor = true;
            // 
            // chkInterquartileRange
            // 
            this.chkInterquartileRange.AutoSize = true;
            this.chkInterquartileRange.Checked = true;
            this.chkInterquartileRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInterquartileRange.Location = new System.Drawing.Point(160, 54);
            this.chkInterquartileRange.Name = "chkInterquartileRange";
            this.chkInterquartileRange.Size = new System.Drawing.Size(116, 17);
            this.chkInterquartileRange.TabIndex = 24;
            this.chkInterquartileRange.Text = "Interquartile Range";
            this.chkInterquartileRange.UseVisualStyleBackColor = true;
            // 
            // chkSkewness
            // 
            this.chkSkewness.AutoSize = true;
            this.chkSkewness.Location = new System.Drawing.Point(160, 77);
            this.chkSkewness.Name = "chkSkewness";
            this.chkSkewness.Size = new System.Drawing.Size(75, 17);
            this.chkSkewness.TabIndex = 25;
            this.chkSkewness.Text = "Skewness";
            this.chkSkewness.UseVisualStyleBackColor = true;
            // 
            // chkKurtosis
            // 
            this.chkKurtosis.AutoSize = true;
            this.chkKurtosis.Location = new System.Drawing.Point(160, 100);
            this.chkKurtosis.Name = "chkKurtosis";
            this.chkKurtosis.Size = new System.Drawing.Size(63, 17);
            this.chkKurtosis.TabIndex = 26;
            this.chkKurtosis.Text = "Kurtosis";
            this.chkKurtosis.UseVisualStyleBackColor = true;
            // 
            // chkMeanAbsoluteDeviation
            // 
            this.chkMeanAbsoluteDeviation.AutoSize = true;
            this.chkMeanAbsoluteDeviation.Location = new System.Drawing.Point(160, 123);
            this.chkMeanAbsoluteDeviation.Name = "chkMeanAbsoluteDeviation";
            this.chkMeanAbsoluteDeviation.Size = new System.Drawing.Size(145, 17);
            this.chkMeanAbsoluteDeviation.TabIndex = 27;
            this.chkMeanAbsoluteDeviation.Text = "Mean Absolute Deviation";
            this.chkMeanAbsoluteDeviation.UseVisualStyleBackColor = true;
            // 
            // chkCheckAllOptions
            // 
            this.chkCheckAllOptions.AutoSize = true;
            this.chkCheckAllOptions.Checked = true;
            this.chkCheckAllOptions.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkCheckAllOptions.Location = new System.Drawing.Point(6, 0);
            this.chkCheckAllOptions.Name = "chkCheckAllOptions";
            this.chkCheckAllOptions.Size = new System.Drawing.Size(62, 17);
            this.chkCheckAllOptions.TabIndex = 33;
            this.chkCheckAllOptions.Text = "Options";
            this.chkCheckAllOptions.UseVisualStyleBackColor = true;
            // 
            // tlpForm
            // 
            this.tlpForm.AutoSize = true;
            this.tlpForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.ColumnCount = 3;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.Controls.Add(this.dgvDataSet, 0, 2);
            this.tlpForm.Controls.Add(this.grpOptions, 0, 3);
            this.tlpForm.Controls.Add(this.lstDataSets, 0, 0);
            this.tlpForm.Controls.Add(this.btnOk, 1, 4);
            this.tlpForm.Controls.Add(this.btnCancel, 2, 4);
            this.tlpForm.Controls.Add(this.chkPerCategorie, 0, 1);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 5;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.Size = new System.Drawing.Size(484, 461);
            this.tlpForm.TabIndex = 20;
            // 
            // chkPerCategorie
            // 
            this.chkPerCategorie.AutoSize = true;
            this.tlpForm.SetColumnSpan(this.chkPerCategorie, 3);
            this.chkPerCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkPerCategorie.Location = new System.Drawing.Point(3, 78);
            this.chkPerCategorie.Name = "chkPerCategorie";
            this.chkPerCategorie.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPerCategorie.Size = new System.Drawing.Size(478, 17);
            this.chkPerCategorie.TabIndex = 19;
            this.chkPerCategorie.Text = "Per Category";
            this.chkPerCategorie.UseVisualStyleBackColor = true;
            // 
            // OneVariableSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tlpForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "OneVariableSummaryForm";
            this.Text = "NoruST - One-Variable Summary";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstDataSets;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkMean;
        private System.Windows.Forms.CheckBox chkVariance;
        private System.Windows.Forms.CheckBox chkStandardDeviation;
        private System.Windows.Forms.CheckBox chkMinimum;
        private System.Windows.Forms.CheckBox chkQuartile1;
        private System.Windows.Forms.CheckBox chkMedian;
        private System.Windows.Forms.CheckBox chkQuartile3;
        private System.Windows.Forms.CheckBox chkMaximum;
        private System.Windows.Forms.CheckBox chkInterquartileRange;
        private System.Windows.Forms.CheckBox chkSkewness;
        private System.Windows.Forms.CheckBox chkKurtosis;
        private System.Windows.Forms.CheckBox chkMeanAbsoluteDeviation;
        private System.Windows.Forms.CheckBox chkMode;
        private System.Windows.Forms.CheckBox chkRange;
        private System.Windows.Forms.CheckBox chkCount;
        private System.Windows.Forms.CheckBox chkSum;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.CheckBox chkOutliers;
        private System.Windows.Forms.CheckBox chkPerCategorie;
        private System.Windows.Forms.CheckBox chkCheckAllOptions;
    }
}
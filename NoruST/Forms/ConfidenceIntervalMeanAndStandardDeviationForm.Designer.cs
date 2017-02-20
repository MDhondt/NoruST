namespace NoruST.Forms
{
    partial class ConfidenceIntervalMeanAndStandardDeviationForm
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
            this.chkMean = new System.Windows.Forms.CheckBox();
            this.chkStandardDeviation = new System.Windows.Forms.CheckBox();
            this.lblMean = new System.Windows.Forms.Label();
            this.lblStandardDiviation = new System.Windows.Forms.Label();
            this.nudMean = new NoruST.Controls.PercentageNumericUpDown();
            this.nudStandardDeviation = new NoruST.Controls.PercentageNumericUpDown();
            this.chkCheckAllOptions = new System.Windows.Forms.CheckBox();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.chkPerCategorie = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStandardDeviation)).BeginInit();
            this.tlpForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(225, 333);
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
            this.dgvDataSet.Size = new System.Drawing.Size(378, 144);
            this.dgvDataSet.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(306, 333);
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
            this.lstDataSets.Size = new System.Drawing.Size(378, 69);
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
            this.grpOptions.Location = new System.Drawing.Point(3, 251);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(378, 76);
            this.grpOptions.TabIndex = 18;
            this.grpOptions.TabStop = false;
            // 
            // tlpOptions
            // 
            this.tlpOptions.AutoSize = true;
            this.tlpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptions.ColumnCount = 4;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.Controls.Add(this.chkMean, 0, 0);
            this.tlpOptions.Controls.Add(this.chkStandardDeviation, 0, 1);
            this.tlpOptions.Controls.Add(this.lblMean, 1, 0);
            this.tlpOptions.Controls.Add(this.lblStandardDiviation, 1, 1);
            this.tlpOptions.Controls.Add(this.nudMean, 2, 0);
            this.tlpOptions.Controls.Add(this.nudStandardDeviation, 2, 1);
            this.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpOptions.Location = new System.Drawing.Point(3, 16);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tlpOptions.RowCount = 2;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.Size = new System.Drawing.Size(372, 57);
            this.tlpOptions.TabIndex = 32;
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
            // chkStandardDeviation
            // 
            this.chkStandardDeviation.AutoSize = true;
            this.chkStandardDeviation.Checked = true;
            this.chkStandardDeviation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStandardDeviation.Location = new System.Drawing.Point(3, 34);
            this.chkStandardDeviation.Name = "chkStandardDeviation";
            this.chkStandardDeviation.Size = new System.Drawing.Size(117, 17);
            this.chkStandardDeviation.TabIndex = 18;
            this.chkStandardDeviation.Text = "Standard Deviation";
            this.chkStandardDeviation.UseVisualStyleBackColor = true;
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMean.Location = new System.Drawing.Point(126, 5);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(90, 26);
            this.lblMean.TabIndex = 19;
            this.lblMean.Text = "Confidence Level";
            this.lblMean.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStandardDiviation
            // 
            this.lblStandardDiviation.AutoSize = true;
            this.lblStandardDiviation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStandardDiviation.Location = new System.Drawing.Point(126, 31);
            this.lblStandardDiviation.Name = "lblStandardDiviation";
            this.lblStandardDiviation.Size = new System.Drawing.Size(90, 26);
            this.lblStandardDiviation.TabIndex = 20;
            this.lblStandardDiviation.Text = "Confidence Level";
            this.lblStandardDiviation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMean
            // 
            this.nudMean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMean.Location = new System.Drawing.Point(222, 8);
            this.nudMean.Name = "nudMean";
            this.nudMean.Size = new System.Drawing.Size(50, 20);
            this.nudMean.TabIndex = 21;
            this.nudMean.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // nudStandardDeviation
            // 
            this.nudStandardDeviation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudStandardDeviation.Location = new System.Drawing.Point(222, 34);
            this.nudStandardDeviation.Name = "nudStandardDeviation";
            this.nudStandardDeviation.Size = new System.Drawing.Size(50, 20);
            this.nudStandardDeviation.TabIndex = 22;
            this.nudStandardDeviation.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // chkCheckAllOptions
            // 
            this.chkCheckAllOptions.AutoSize = true;
            this.chkCheckAllOptions.Checked = true;
            this.chkCheckAllOptions.CheckState = System.Windows.Forms.CheckState.Checked;
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
            this.tlpForm.Size = new System.Drawing.Size(384, 361);
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
            this.chkPerCategorie.Size = new System.Drawing.Size(378, 17);
            this.chkPerCategorie.TabIndex = 19;
            this.chkPerCategorie.Text = "Per Category";
            this.chkPerCategorie.UseVisualStyleBackColor = true;
            // 
            // ConfidenceIntervalMeanAndStandardDeviationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tlpForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "ConfidenceIntervalMeanAndStandardDeviationForm";
            this.Text = "NoruST - Confidence Interval - Mean & Standard Deviation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStandardDeviation)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.CheckBox chkPerCategorie;
        private System.Windows.Forms.CheckBox chkCheckAllOptions;
        private System.Windows.Forms.CheckBox chkStandardDeviation;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.Label lblStandardDiviation;
        private Controls.PercentageNumericUpDown nudMean;
        private Controls.PercentageNumericUpDown nudStandardDeviation;
    }
}
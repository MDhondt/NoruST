namespace NoruST.Forms
{
    partial class HistogramForm
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
            this.chkNumberOfBins = new System.Windows.Forms.CheckBox();
            this.nudNumberOfBins = new System.Windows.Forms.NumericUpDown();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.chkPerCategorie = new System.Windows.Forms.CheckBox();
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.chkCheckAllOptions = new System.Windows.Forms.CheckBox();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.lstDataSets = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfBins)).BeginInit();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.grpOptions.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkNumberOfBins
            // 
            this.chkNumberOfBins.AutoSize = true;
            this.chkNumberOfBins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkNumberOfBins.Location = new System.Drawing.Point(3, 8);
            this.chkNumberOfBins.Name = "chkNumberOfBins";
            this.chkNumberOfBins.Size = new System.Drawing.Size(98, 20);
            this.chkNumberOfBins.TabIndex = 9;
            this.chkNumberOfBins.Text = "Number of Bins";
            this.chkNumberOfBins.UseVisualStyleBackColor = true;
            // 
            // nudNumberOfBins
            // 
            this.nudNumberOfBins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudNumberOfBins.Location = new System.Drawing.Point(107, 8);
            this.nudNumberOfBins.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfBins.Name = "nudNumberOfBins";
            this.nudNumberOfBins.Size = new System.Drawing.Size(50, 20);
            this.nudNumberOfBins.TabIndex = 8;
            this.nudNumberOfBins.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfBins.ValueChanged += new System.EventHandler(this.nudNumberOfBins_ValueChanged);
            // 
            // tlpForm
            // 
            this.tlpForm.AutoSize = true;
            this.tlpForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.ColumnCount = 3;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.Controls.Add(this.chkPerCategorie, 0, 1);
            this.tlpForm.Controls.Add(this.dgvDataSet, 0, 2);
            this.tlpForm.Controls.Add(this.grpOptions, 0, 3);
            this.tlpForm.Controls.Add(this.lstDataSets, 0, 0);
            this.tlpForm.Controls.Add(this.btnOk, 1, 4);
            this.tlpForm.Controls.Add(this.btnCancel, 2, 4);
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
            this.tlpForm.TabIndex = 21;
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
            this.dgvDataSet.Size = new System.Drawing.Size(378, 170);
            this.dgvDataSet.TabIndex = 14;
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.AutoSize = true;
            this.grpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.SetColumnSpan(this.grpOptions, 3);
            this.grpOptions.Controls.Add(this.chkCheckAllOptions);
            this.grpOptions.Controls.Add(this.tlpOptions);
            this.grpOptions.Location = new System.Drawing.Point(3, 277);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(378, 50);
            this.grpOptions.TabIndex = 18;
            this.grpOptions.TabStop = false;
            // 
            // chkCheckAllOptions
            // 
            this.chkCheckAllOptions.AutoSize = true;
            this.chkCheckAllOptions.Location = new System.Drawing.Point(6, 0);
            this.chkCheckAllOptions.Name = "chkCheckAllOptions";
            this.chkCheckAllOptions.Size = new System.Drawing.Size(62, 17);
            this.chkCheckAllOptions.TabIndex = 34;
            this.chkCheckAllOptions.Text = "Options";
            this.chkCheckAllOptions.UseVisualStyleBackColor = true;
            // 
            // tlpOptions
            // 
            this.tlpOptions.AutoSize = true;
            this.tlpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptions.ColumnCount = 3;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.Controls.Add(this.nudNumberOfBins, 1, 0);
            this.tlpOptions.Controls.Add(this.chkNumberOfBins, 0, 0);
            this.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpOptions.Location = new System.Drawing.Point(3, 16);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tlpOptions.RowCount = 1;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.Size = new System.Drawing.Size(372, 31);
            this.tlpOptions.TabIndex = 32;
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
            // HistogramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tlpForm);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "HistogramForm";
            this.Text = "HistogramForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfBins)).EndInit();
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkNumberOfBins;
        private System.Windows.Forms.NumericUpDown nudNumberOfBins;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.CheckBox chkCheckAllOptions;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.ListBox lstDataSets;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkPerCategorie;
    }
}
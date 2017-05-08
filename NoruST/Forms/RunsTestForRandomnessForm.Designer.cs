namespace NoruST.Forms
{
    partial class RunsTestForRandomnessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunsTestForRandomnessForm));
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.grpCutoffValue = new System.Windows.Forms.GroupBox();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.rdbCustomCutoffValue = new System.Windows.Forms.RadioButton();
            this.rdbMeanOfData = new System.Windows.Forms.RadioButton();
            this.rdbMedianOfData = new System.Windows.Forms.RadioButton();
            this.txtCustomCutoffValue = new System.Windows.Forms.TextBox();
            this.lstDataSets = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.grpCutoffValue.SuspendLayout();
            this.tlpOptions.SuspendLayout();
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
            this.tlpForm.Controls.Add(this.grpCutoffValue, 0, 2);
            this.tlpForm.Controls.Add(this.lstDataSets, 0, 0);
            this.tlpForm.Controls.Add(this.btnOk, 1, 3);
            this.tlpForm.Controls.Add(this.btnCancel, 2, 3);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 4;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpForm.Size = new System.Drawing.Size(384, 362);
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
            this.dgvDataSet.Location = new System.Drawing.Point(3, 78);
            this.dgvDataSet.MinimumSize = new System.Drawing.Size(300, 0);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.RowHeadersVisible = false;
            this.dgvDataSet.Size = new System.Drawing.Size(378, 148);
            this.dgvDataSet.TabIndex = 14;
            // 
            // grpCutoffValue
            // 
            this.grpCutoffValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCutoffValue.AutoSize = true;
            this.grpCutoffValue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.SetColumnSpan(this.grpCutoffValue, 3);
            this.grpCutoffValue.Controls.Add(this.tlpOptions);
            this.grpCutoffValue.Location = new System.Drawing.Point(3, 232);
            this.grpCutoffValue.Name = "grpCutoffValue";
            this.grpCutoffValue.Size = new System.Drawing.Size(378, 96);
            this.grpCutoffValue.TabIndex = 18;
            this.grpCutoffValue.TabStop = false;
            this.grpCutoffValue.Text = "Cutoff Value";
            // 
            // tlpOptions
            // 
            this.tlpOptions.AutoSize = true;
            this.tlpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptions.ColumnCount = 3;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.Controls.Add(this.rdbCustomCutoffValue, 0, 2);
            this.tlpOptions.Controls.Add(this.rdbMeanOfData, 0, 0);
            this.tlpOptions.Controls.Add(this.rdbMedianOfData, 0, 1);
            this.tlpOptions.Controls.Add(this.txtCustomCutoffValue, 1, 2);
            this.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpOptions.Location = new System.Drawing.Point(3, 16);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tlpOptions.RowCount = 3;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.Size = new System.Drawing.Size(372, 77);
            this.tlpOptions.TabIndex = 32;
            // 
            // rdbCustomCutoffValue
            // 
            this.rdbCustomCutoffValue.AutoSize = true;
            this.rdbCustomCutoffValue.Location = new System.Drawing.Point(3, 54);
            this.rdbCustomCutoffValue.Name = "rdbCustomCutoffValue";
            this.rdbCustomCutoffValue.Size = new System.Drawing.Size(121, 17);
            this.rdbCustomCutoffValue.TabIndex = 22;
            this.rdbCustomCutoffValue.TabStop = true;
            this.rdbCustomCutoffValue.Text = "Custom Cutoff Value";
            this.rdbCustomCutoffValue.UseVisualStyleBackColor = true;
            this.rdbCustomCutoffValue.Visible = false;
            // 
            // rdbMeanOfData
            // 
            this.rdbMeanOfData.AutoSize = true;
            this.rdbMeanOfData.Checked = true;
            this.rdbMeanOfData.Location = new System.Drawing.Point(3, 8);
            this.rdbMeanOfData.Name = "rdbMeanOfData";
            this.rdbMeanOfData.Size = new System.Drawing.Size(90, 17);
            this.rdbMeanOfData.TabIndex = 23;
            this.rdbMeanOfData.TabStop = true;
            this.rdbMeanOfData.Text = "Mean of Data";
            this.rdbMeanOfData.UseVisualStyleBackColor = true;
            // 
            // rdbMedianOfData
            // 
            this.rdbMedianOfData.AutoSize = true;
            this.rdbMedianOfData.Location = new System.Drawing.Point(3, 31);
            this.rdbMedianOfData.Name = "rdbMedianOfData";
            this.rdbMedianOfData.Size = new System.Drawing.Size(98, 17);
            this.rdbMedianOfData.TabIndex = 24;
            this.rdbMedianOfData.Text = "Median of Data";
            this.rdbMedianOfData.UseVisualStyleBackColor = true;
            // 
            // txtCustomCutoffValue
            // 
            this.txtCustomCutoffValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustomCutoffValue.Location = new System.Drawing.Point(130, 54);
            this.txtCustomCutoffValue.Name = "txtCustomCutoffValue";
            this.txtCustomCutoffValue.Size = new System.Drawing.Size(50, 20);
            this.txtCustomCutoffValue.TabIndex = 25;
            this.txtCustomCutoffValue.Text = "0";
            this.txtCustomCutoffValue.Visible = false;
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
            this.btnOk.Location = new System.Drawing.Point(225, 334);
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
            this.btnCancel.Location = new System.Drawing.Point(306, 334);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // RunsTestForRandomnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tlpForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "RunsTestForRandomnessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoruST - Runs Test for Randomness";
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.grpCutoffValue.ResumeLayout(false);
            this.grpCutoffValue.PerformLayout();
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.GroupBox grpCutoffValue;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.ListBox lstDataSets;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdbCustomCutoffValue;
        private System.Windows.Forms.RadioButton rdbMeanOfData;
        private System.Windows.Forms.RadioButton rdbMedianOfData;
        private System.Windows.Forms.TextBox txtCustomCutoffValue;
    }
}
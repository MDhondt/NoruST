namespace NoruST.Forms
{
    partial class LagForm
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
            this.grpCheckBoxes = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLag = new System.Windows.Forms.NumericUpDown();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.grpCheckBoxes.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLag)).BeginInit();
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
            this.dgvDataSet.Location = new System.Drawing.Point(3, 78);
            this.dgvDataSet.MinimumSize = new System.Drawing.Size(300, 0);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.RowHeadersVisible = false;
            this.dgvDataSet.Size = new System.Drawing.Size(378, 198);
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
            // grpCheckBoxes
            // 
            this.grpCheckBoxes.AutoSize = true;
            this.grpCheckBoxes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.SetColumnSpan(this.grpCheckBoxes, 3);
            this.grpCheckBoxes.Controls.Add(this.tableLayoutPanel1);
            this.grpCheckBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCheckBoxes.Location = new System.Drawing.Point(3, 282);
            this.grpCheckBoxes.Name = "grpCheckBoxes";
            this.grpCheckBoxes.Size = new System.Drawing.Size(378, 45);
            this.grpCheckBoxes.TabIndex = 18;
            this.grpCheckBoxes.TabStop = false;
            this.grpCheckBoxes.Text = "Options";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudLag, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 26);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Number of Lags";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudLag
            // 
            this.nudLag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudLag.Location = new System.Drawing.Point(91, 3);
            this.nudLag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLag.Name = "nudLag";
            this.nudLag.Size = new System.Drawing.Size(50, 20);
            this.nudLag.TabIndex = 23;
            this.nudLag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.tlpForm.Controls.Add(this.grpCheckBoxes, 0, 2);
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
            this.tlpForm.Size = new System.Drawing.Size(384, 361);
            this.tlpForm.TabIndex = 20;
            // 
            // LagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tlpForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "LagForm";
            this.Text = "NoruST - Lag";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.grpCheckBoxes.ResumeLayout(false);
            this.grpCheckBoxes.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLag)).EndInit();
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
        private System.Windows.Forms.GroupBox grpCheckBoxes;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLag;
    }
}
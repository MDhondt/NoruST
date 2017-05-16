﻿namespace NoruST.Forms
{
    partial class LogisticRegressionForm
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
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_VariablesX = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_VariablesY = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.tlpForm.SuspendLayout();
            this.SuspendLayout();
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
            // dgvDataSet
            // 
            this.dgvDataSet.AllowUserToAddRows = false;
            this.dgvDataSet.AllowUserToDeleteRows = false;
            this.dgvDataSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_VariablesX,
            this.dgv_VariablesY});
            this.tlpForm.SetColumnSpan(this.dgvDataSet, 3);
            this.dgvDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataSet.Location = new System.Drawing.Point(3, 78);
            this.dgvDataSet.MinimumSize = new System.Drawing.Size(300, 0);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.RowHeadersVisible = false;
            this.dgvDataSet.Size = new System.Drawing.Size(378, 250);
            this.dgvDataSet.TabIndex = 14;
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
            // tlpForm
            // 
            this.tlpForm.AutoSize = true;
            this.tlpForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.ColumnCount = 3;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.Controls.Add(this.lstDataSets, 0, 0);
            this.tlpForm.Controls.Add(this.btnOk, 1, 2);
            this.tlpForm.Controls.Add(this.dgvDataSet, 0, 1);
            this.tlpForm.Controls.Add(this.btnCancel, 2, 2);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 3;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.Size = new System.Drawing.Size(384, 362);
            this.tlpForm.TabIndex = 18;
            // 
            // dgv_VariablesX
            // 
            this.dgv_VariablesX.HeaderText = "X";
            this.dgv_VariablesX.Name = "dgv_VariablesX";
            this.dgv_VariablesX.Width = 20;
            // 
            // dgv_VariablesY
            // 
            this.dgv_VariablesY.HeaderText = "Y";
            this.dgv_VariablesY.Name = "dgv_VariablesY";
            this.dgv_VariablesY.Width = 20;
            // 
            // LogisticRegressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tlpForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "LogisticRegressionForm";
            this.Text = "NoruST - Logistic Regression";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.tlpForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstDataSets;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_VariablesX;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_VariablesY;
    }
}
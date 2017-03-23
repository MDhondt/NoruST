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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LagForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.uiDataGridView_Variables = new System.Windows.Forms.DataGridView();
            this.uiDataGridViewColumn_CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uiDataGridViewColumn_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiDataGridViewColumn_Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiButton_Cancel = new System.Windows.Forms.Button();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.uiComboBox_DataSets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uiNumericUpDown_Lag = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Variables)).BeginInit();
            this.tlpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiNumericUpDown_Lag)).BeginInit();
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
            // uiDataGridView_Variables
            // 
            this.uiDataGridView_Variables.AllowUserToAddRows = false;
            this.uiDataGridView_Variables.AllowUserToDeleteRows = false;
            this.uiDataGridView_Variables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.uiDataGridView_Variables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDataGridView_Variables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uiDataGridViewColumn_CheckBox,
            this.uiDataGridViewColumn_Name,
            this.uiDataGridViewColumn_Range});
            this.tlpForm.SetColumnSpan(this.uiDataGridView_Variables, 4);
            this.uiDataGridView_Variables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView_Variables.Location = new System.Drawing.Point(3, 30);
            this.uiDataGridView_Variables.MinimumSize = new System.Drawing.Size(300, 0);
            this.uiDataGridView_Variables.Name = "uiDataGridView_Variables";
            this.uiDataGridView_Variables.RowHeadersVisible = false;
            this.uiDataGridView_Variables.Size = new System.Drawing.Size(378, 297);
            this.uiDataGridView_Variables.TabIndex = 14;
            this.uiDataGridView_Variables.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView_Variables_CellValueChanged);
            // 
            // uiDataGridViewColumn_CheckBox
            // 
            this.uiDataGridViewColumn_CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.uiDataGridViewColumn_CheckBox.HeaderText = "Lag";
            this.uiDataGridViewColumn_CheckBox.Name = "uiDataGridViewColumn_CheckBox";
            this.uiDataGridViewColumn_CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridViewColumn_CheckBox.Width = 31;
            // 
            // uiDataGridViewColumn_Name
            // 
            this.uiDataGridViewColumn_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uiDataGridViewColumn_Name.HeaderText = "Variabele";
            this.uiDataGridViewColumn_Name.Name = "uiDataGridViewColumn_Name";
            this.uiDataGridViewColumn_Name.ReadOnly = true;
            // 
            // uiDataGridViewColumn_Range
            // 
            this.uiDataGridViewColumn_Range.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.uiDataGridViewColumn_Range.HeaderText = "Range";
            this.uiDataGridViewColumn_Range.Name = "uiDataGridViewColumn_Range";
            this.uiDataGridViewColumn_Range.ReadOnly = true;
            // 
            // uiButton_Cancel
            // 
            this.uiButton_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiButton_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton_Cancel.Location = new System.Drawing.Point(306, 333);
            this.uiButton_Cancel.Name = "uiButton_Cancel";
            this.uiButton_Cancel.Size = new System.Drawing.Size(75, 25);
            this.uiButton_Cancel.TabIndex = 16;
            this.uiButton_Cancel.Text = "Annuleren";
            this.uiButton_Cancel.UseVisualStyleBackColor = true;
            this.uiButton_Cancel.Click += new System.EventHandler(this.uiButton_Cancel_Click);
            // 
            // tlpForm
            // 
            this.tlpForm.AutoSize = true;
            this.tlpForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.ColumnCount = 4;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.Controls.Add(this.uiDataGridView_Variables, 0, 1);
            this.tlpForm.Controls.Add(this.btnOk, 2, 2);
            this.tlpForm.Controls.Add(this.uiButton_Cancel, 3, 2);
            this.tlpForm.Controls.Add(this.uiComboBox_DataSets, 1, 0);
            this.tlpForm.Controls.Add(this.label2, 0, 0);
            this.tlpForm.Controls.Add(this.label1, 0, 2);
            this.tlpForm.Controls.Add(this.uiNumericUpDown_Lag, 1, 2);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 3;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.Size = new System.Drawing.Size(384, 361);
            this.tlpForm.TabIndex = 20;
            // 
            // uiComboBox_DataSets
            // 
            this.tlpForm.SetColumnSpan(this.uiComboBox_DataSets, 3);
            this.uiComboBox_DataSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiComboBox_DataSets.FormattingEnabled = true;
            this.uiComboBox_DataSets.Location = new System.Drawing.Point(64, 3);
            this.uiComboBox_DataSets.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.uiComboBox_DataSets.Name = "uiComboBox_DataSets";
            this.uiComboBox_DataSets.Size = new System.Drawing.Size(317, 21);
            this.uiComboBox_DataSets.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data set";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Aantal lags";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiNumericUpDown_Lag
            // 
            this.uiNumericUpDown_Lag.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.uiNumericUpDown_Lag.Location = new System.Drawing.Point(64, 335);
            this.uiNumericUpDown_Lag.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiNumericUpDown_Lag.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uiNumericUpDown_Lag.Name = "uiNumericUpDown_Lag";
            this.uiNumericUpDown_Lag.Size = new System.Drawing.Size(50, 20);
            this.uiNumericUpDown_Lag.TabIndex = 22;
            this.uiNumericUpDown_Lag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiNumericUpDown_Lag.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uiButton_Cancel;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tlpForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "LagForm";
            this.Text = "NoruST - Lag";
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Variables)).EndInit();
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiNumericUpDown_Lag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView uiDataGridView_Variables;
        private System.Windows.Forms.Button uiButton_Cancel;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.ComboBox uiComboBox_DataSets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown uiNumericUpDown_Lag;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uiDataGridViewColumn_CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiDataGridViewColumn_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn uiDataGridViewColumn_Range;
    }
}
namespace NoruST.Forms
{
    partial class DataSetManagerForm
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
            this.gbxDataSet = new System.Windows.Forms.GroupBox();
            this.tlpDataSet = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDataIn = new System.Windows.Forms.Label();
            this.rdbColumns = new System.Windows.Forms.RadioButton();
            this.rdbRows = new System.Windows.Forms.RadioButton();
            this.chkHasHeaders = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.lstDataSets = new System.Windows.Forms.ListBox();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteDataSet = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbxDataSet.SuspendLayout();
            this.tlpDataSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.tlpForm.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDataSet
            // 
            this.gbxDataSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.SetColumnSpan(this.gbxDataSet, 3);
            this.gbxDataSet.Controls.Add(this.tlpDataSet);
            this.gbxDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxDataSet.Location = new System.Drawing.Point(3, 78);
            this.gbxDataSet.Name = "gbxDataSet";
            this.gbxDataSet.Size = new System.Drawing.Size(378, 249);
            this.gbxDataSet.TabIndex = 1;
            this.gbxDataSet.TabStop = false;
            this.gbxDataSet.Text = "Data Set";
            // 
            // tlpDataSet
            // 
            this.tlpDataSet.AutoSize = true;
            this.tlpDataSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpDataSet.ColumnCount = 4;
            this.tlpDataSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDataSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDataSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDataSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpDataSet.Controls.Add(this.dgvDataSet, 0, 2);
            this.tlpDataSet.Controls.Add(this.lblName, 0, 0);
            this.tlpDataSet.Controls.Add(this.txtName, 1, 0);
            this.tlpDataSet.Controls.Add(this.lblDataIn, 0, 1);
            this.tlpDataSet.Controls.Add(this.rdbColumns, 1, 1);
            this.tlpDataSet.Controls.Add(this.rdbRows, 2, 1);
            this.tlpDataSet.Controls.Add(this.chkHasHeaders, 3, 1);
            this.tlpDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDataSet.Location = new System.Drawing.Point(3, 16);
            this.tlpDataSet.Name = "tlpDataSet";
            this.tlpDataSet.RowCount = 3;
            this.tlpDataSet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDataSet.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDataSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataSet.Size = new System.Drawing.Size(372, 230);
            this.tlpDataSet.TabIndex = 7;
            // 
            // dgvDataSet
            // 
            this.dgvDataSet.AllowUserToAddRows = false;
            this.dgvDataSet.AllowUserToDeleteRows = false;
            this.dgvDataSet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpDataSet.SetColumnSpan(this.dgvDataSet, 4);
            this.dgvDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataSet.Location = new System.Drawing.Point(3, 52);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.RowHeadersVisible = false;
            this.dgvDataSet.Size = new System.Drawing.Size(366, 175);
            this.dgvDataSet.TabIndex = 0;
            this.dgvDataSet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataSet_CellValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.tlpDataSet.SetColumnSpan(this.txtName, 3);
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(53, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(316, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblDataIn
            // 
            this.lblDataIn.AutoSize = true;
            this.lblDataIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataIn.Location = new System.Drawing.Point(3, 29);
            this.lblDataIn.Margin = new System.Windows.Forms.Padding(3);
            this.lblDataIn.Name = "lblDataIn";
            this.lblDataIn.Size = new System.Drawing.Size(44, 17);
            this.lblDataIn.TabIndex = 2;
            this.lblDataIn.Text = "Data in:";
            this.lblDataIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdbColumns
            // 
            this.rdbColumns.AutoSize = true;
            this.rdbColumns.Checked = true;
            this.rdbColumns.Location = new System.Drawing.Point(53, 29);
            this.rdbColumns.Name = "rdbColumns";
            this.rdbColumns.Size = new System.Drawing.Size(65, 17);
            this.rdbColumns.TabIndex = 2;
            this.rdbColumns.TabStop = true;
            this.rdbColumns.Text = "Columns";
            this.rdbColumns.UseVisualStyleBackColor = true;
            this.rdbColumns.CheckedChanged += new System.EventHandler(this.rdbColumns_rdbRows_CheckedChanged);
            // 
            // rdbRows
            // 
            this.rdbRows.AutoSize = true;
            this.rdbRows.Location = new System.Drawing.Point(124, 29);
            this.rdbRows.Name = "rdbRows";
            this.rdbRows.Size = new System.Drawing.Size(52, 17);
            this.rdbRows.TabIndex = 3;
            this.rdbRows.Text = "Rows";
            this.rdbRows.UseVisualStyleBackColor = true;
            this.rdbRows.CheckedChanged += new System.EventHandler(this.rdbColumns_rdbRows_CheckedChanged);
            // 
            // chkHasHeaders
            // 
            this.chkHasHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHasHeaders.AutoSize = true;
            this.chkHasHeaders.Checked = true;
            this.chkHasHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHasHeaders.Location = new System.Drawing.Point(255, 29);
            this.chkHasHeaders.Name = "chkHasHeaders";
            this.chkHasHeaders.Size = new System.Drawing.Size(114, 17);
            this.chkHasHeaders.TabIndex = 4;
            this.chkHasHeaders.TabStop = false;
            this.chkHasHeaders.Text = "Table has headers";
            this.chkHasHeaders.UseVisualStyleBackColor = true;
            this.chkHasHeaders.CheckedChanged += new System.EventHandler(this.chkHasHeaders_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(300, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(81, 25);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            this.btnUndo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUndo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUndo.Location = new System.Drawing.Point(219, 333);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 25);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // tlpForm
            // 
            this.tlpForm.AutoSize = true;
            this.tlpForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpForm.ColumnCount = 3;
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpForm.Controls.Add(this.btnUndo, 1, 2);
            this.tlpForm.Controls.Add(this.gbxDataSet, 0, 1);
            this.tlpForm.Controls.Add(this.btnClose, 2, 2);
            this.tlpForm.Controls.Add(this.lstDataSets, 0, 0);
            this.tlpForm.Controls.Add(this.tlpButtons, 2, 0);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 3;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.Size = new System.Drawing.Size(384, 361);
            this.tlpForm.TabIndex = 8;
            // 
            // lstDataSets
            // 
            this.tlpForm.SetColumnSpan(this.lstDataSets, 2);
            this.lstDataSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstDataSets.FormattingEnabled = true;
            this.lstDataSets.Location = new System.Drawing.Point(3, 3);
            this.lstDataSets.Name = "lstDataSets";
            this.lstDataSets.Size = new System.Drawing.Size(291, 69);
            this.lstDataSets.TabIndex = 1;
            // 
            // tlpButtons
            // 
            this.tlpButtons.AutoSize = true;
            this.tlpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpButtons.ColumnCount = 1;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpButtons.Controls.Add(this.btnDeleteDataSet, 0, 1);
            this.tlpButtons.Controls.Add(this.btnNew, 0, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(300, 3);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 2;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(81, 69);
            this.tlpButtons.TabIndex = 10;
            // 
            // btnDeleteDataSet
            // 
            this.btnDeleteDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDataSet.Location = new System.Drawing.Point(3, 37);
            this.btnDeleteDataSet.Name = "btnDeleteDataSet";
            this.btnDeleteDataSet.Size = new System.Drawing.Size(75, 29);
            this.btnDeleteDataSet.TabIndex = 9;
            this.btnDeleteDataSet.Text = "Delete";
            this.btnDeleteDataSet.UseVisualStyleBackColor = true;
            this.btnDeleteDataSet.Click += new System.EventHandler(this.btnDeleteDataSet_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 28);
            this.btnNew.TabIndex = 10;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // DataSetManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tlpForm);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "DataSetManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NoruST - Data Set Manager";
            this.gbxDataSet.ResumeLayout(false);
            this.gbxDataSet.PerformLayout();
            this.tlpDataSet.ResumeLayout(false);
            this.tlpDataSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxDataSet;
        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.CheckBox chkHasHeaders;
        private System.Windows.Forms.RadioButton rdbRows;
        private System.Windows.Forms.RadioButton rdbColumns;
        private System.Windows.Forms.Label lblDataIn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.TableLayoutPanel tlpDataSet;
        private System.Windows.Forms.ListBox lstDataSets;
        private System.Windows.Forms.Button btnDeleteDataSet;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnNew;
    }
}
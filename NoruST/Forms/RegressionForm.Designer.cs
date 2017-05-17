namespace NoruST.Forms
{
    partial class RegressionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegressionForm));
            this.tlpForm = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVariable = new System.Windows.Forms.Label();
            this.lblDataSet = new System.Windows.Forms.Label();
            this.uiComboBox_DataSets = new System.Windows.Forms.ComboBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.tlpOptions = new System.Windows.Forms.TableLayoutPanel();
            this.chkResidualsVsXValues = new System.Windows.Forms.CheckBox();
            this.chkFittedValuesVsActualYValues = new System.Windows.Forms.CheckBox();
            this.chkResidualsVsFittedValues = new System.Windows.Forms.CheckBox();
            this.chkDisplayRegressionEquation = new System.Windows.Forms.CheckBox();
            this.lblConfidenceLevel = new System.Windows.Forms.Label();
            this.nudConfidenceLevel = new NoruST.Controls.PercentageNumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.uiDataGridView_Variables = new System.Windows.Forms.DataGridView();
            this.uiDataGridViewColumn_VariableCheckX = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uiDataGridViewColumn_VariableCheckY = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tlpForm.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.tlpOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidenceLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Variables)).BeginInit();
            this.SuspendLayout();
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
            this.tlpForm.Controls.Add(this.uiDataGridView_Variables, 1, 1);
            this.tlpForm.Controls.Add(this.label1, 0, 2);
            this.tlpForm.Controls.Add(this.lblVariable, 0, 1);
            this.tlpForm.Controls.Add(this.lblDataSet, 0, 0);
            this.tlpForm.Controls.Add(this.uiComboBox_DataSets, 1, 0);
            this.tlpForm.Controls.Add(this.grpOptions, 1, 2);
            this.tlpForm.Controls.Add(this.btnOk, 2, 3);
            this.tlpForm.Controls.Add(this.btnCancel, 3, 3);
            this.tlpForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpForm.Location = new System.Drawing.Point(0, 0);
            this.tlpForm.Name = "tlpForm";
            this.tlpForm.RowCount = 4;
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpForm.Size = new System.Drawing.Size(594, 301);
            this.tlpForm.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVariable
            // 
            this.lblVariable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVariable.AutoSize = true;
            this.lblVariable.Location = new System.Drawing.Point(5, 32);
            this.lblVariable.Margin = new System.Windows.Forms.Padding(5);
            this.lblVariable.Name = "lblVariable";
            this.lblVariable.Size = new System.Drawing.Size(50, 13);
            this.lblVariable.TabIndex = 32;
            this.lblVariable.Text = "Variables";
            this.lblVariable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataSet
            // 
            this.lblDataSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDataSet.AutoSize = true;
            this.lblDataSet.Location = new System.Drawing.Point(5, 5);
            this.lblDataSet.Margin = new System.Windows.Forms.Padding(5);
            this.lblDataSet.Name = "lblDataSet";
            this.lblDataSet.Size = new System.Drawing.Size(50, 17);
            this.lblDataSet.TabIndex = 31;
            this.lblDataSet.Text = "Data set";
            this.lblDataSet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox_DataSets
            // 
            this.tlpForm.SetColumnSpan(this.uiComboBox_DataSets, 3);
            this.uiComboBox_DataSets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiComboBox_DataSets.FormattingEnabled = true;
            this.uiComboBox_DataSets.Location = new System.Drawing.Point(65, 3);
            this.uiComboBox_DataSets.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.uiComboBox_DataSets.Name = "uiComboBox_DataSets";
            this.uiComboBox_DataSets.Size = new System.Drawing.Size(526, 21);
            this.uiComboBox_DataSets.TabIndex = 28;
            // 
            // grpOptions
            // 
            this.grpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOptions.AutoSize = true;
            this.grpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpOptions.Controls.Add(this.tlpOptions);
            this.grpOptions.Location = new System.Drawing.Point(63, 168);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(366, 96);
            this.grpOptions.TabIndex = 18;
            this.grpOptions.TabStop = false;
            // 
            // tlpOptions
            // 
            this.tlpOptions.AutoSize = true;
            this.tlpOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOptions.ColumnCount = 3;
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOptions.Controls.Add(this.chkResidualsVsXValues, 1, 0);
            this.tlpOptions.Controls.Add(this.chkFittedValuesVsActualYValues, 0, 0);
            this.tlpOptions.Controls.Add(this.chkResidualsVsFittedValues, 0, 1);
            this.tlpOptions.Controls.Add(this.chkDisplayRegressionEquation, 1, 1);
            this.tlpOptions.Controls.Add(this.lblConfidenceLevel, 0, 2);
            this.tlpOptions.Controls.Add(this.nudConfidenceLevel, 1, 2);
            this.tlpOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOptions.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpOptions.Location = new System.Drawing.Point(3, 16);
            this.tlpOptions.Name = "tlpOptions";
            this.tlpOptions.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.tlpOptions.RowCount = 3;
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOptions.Size = new System.Drawing.Size(360, 77);
            this.tlpOptions.TabIndex = 32;
            // 
            // chkResidualsVsXValues
            // 
            this.chkResidualsVsXValues.AutoSize = true;
            this.tlpOptions.SetColumnSpan(this.chkResidualsVsXValues, 2);
            this.chkResidualsVsXValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkResidualsVsXValues.Location = new System.Drawing.Point(188, 8);
            this.chkResidualsVsXValues.Name = "chkResidualsVsXValues";
            this.chkResidualsVsXValues.Size = new System.Drawing.Size(169, 17);
            this.chkResidualsVsXValues.TabIndex = 16;
            this.chkResidualsVsXValues.Text = "Residuals vs X-Values";
            this.chkResidualsVsXValues.UseVisualStyleBackColor = true;
            // 
            // chkFittedValuesVsActualYValues
            // 
            this.chkFittedValuesVsActualYValues.AutoSize = true;
            this.chkFittedValuesVsActualYValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkFittedValuesVsActualYValues.Location = new System.Drawing.Point(3, 8);
            this.chkFittedValuesVsActualYValues.Name = "chkFittedValuesVsActualYValues";
            this.chkFittedValuesVsActualYValues.Size = new System.Drawing.Size(179, 17);
            this.chkFittedValuesVsActualYValues.TabIndex = 15;
            this.chkFittedValuesVsActualYValues.Text = "Fitted Values vs Actual Y-Values";
            this.chkFittedValuesVsActualYValues.UseVisualStyleBackColor = true;
            // 
            // chkResidualsVsFittedValues
            // 
            this.chkResidualsVsFittedValues.AutoSize = true;
            this.chkResidualsVsFittedValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkResidualsVsFittedValues.Location = new System.Drawing.Point(3, 31);
            this.chkResidualsVsFittedValues.Name = "chkResidualsVsFittedValues";
            this.chkResidualsVsFittedValues.Size = new System.Drawing.Size(179, 17);
            this.chkResidualsVsFittedValues.TabIndex = 17;
            this.chkResidualsVsFittedValues.Text = "Residuals vs Fitted Values";
            this.chkResidualsVsFittedValues.UseVisualStyleBackColor = true;
            // 
            // chkDisplayRegressionEquation
            // 
            this.chkDisplayRegressionEquation.AutoSize = true;
            this.tlpOptions.SetColumnSpan(this.chkDisplayRegressionEquation, 2);
            this.chkDisplayRegressionEquation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkDisplayRegressionEquation.Location = new System.Drawing.Point(188, 31);
            this.chkDisplayRegressionEquation.Name = "chkDisplayRegressionEquation";
            this.chkDisplayRegressionEquation.Size = new System.Drawing.Size(169, 17);
            this.chkDisplayRegressionEquation.TabIndex = 18;
            this.chkDisplayRegressionEquation.Text = "Display Regression Equation";
            this.chkDisplayRegressionEquation.UseVisualStyleBackColor = true;
            // 
            // lblConfidenceLevel
            // 
            this.lblConfidenceLevel.AutoSize = true;
            this.lblConfidenceLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConfidenceLevel.Location = new System.Drawing.Point(3, 51);
            this.lblConfidenceLevel.Name = "lblConfidenceLevel";
            this.lblConfidenceLevel.Size = new System.Drawing.Size(179, 26);
            this.lblConfidenceLevel.TabIndex = 20;
            this.lblConfidenceLevel.Text = "Confidence level (%)";
            this.lblConfidenceLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudConfidenceLevel
            // 
            this.nudConfidenceLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudConfidenceLevel.Location = new System.Drawing.Point(188, 54);
            this.nudConfidenceLevel.Name = "nudConfidenceLevel";
            this.nudConfidenceLevel.Size = new System.Drawing.Size(50, 20);
            this.nudConfidenceLevel.TabIndex = 21;
            this.nudConfidenceLevel.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(435, 270);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 28);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(516, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // uiDataGridView_Variables
            // 
            this.uiDataGridView_Variables.AllowUserToAddRows = false;
            this.uiDataGridView_Variables.AllowUserToDeleteRows = false;
            this.uiDataGridView_Variables.AllowUserToResizeColumns = false;
            this.uiDataGridView_Variables.AllowUserToResizeRows = false;
            this.uiDataGridView_Variables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDataGridView_Variables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiDataGridView_Variables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uiDataGridViewColumn_VariableCheckX,
            this.uiDataGridViewColumn_VariableCheckY});
            this.tlpForm.SetColumnSpan(this.uiDataGridView_Variables, 3);
            this.uiDataGridView_Variables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDataGridView_Variables.Location = new System.Drawing.Point(63, 30);
            this.uiDataGridView_Variables.Name = "uiDataGridView_Variables";
            this.uiDataGridView_Variables.RowHeadersVisible = false;
            this.uiDataGridView_Variables.Size = new System.Drawing.Size(528, 132);
            this.uiDataGridView_Variables.TabIndex = 38;
            // 
            // uiDataGridViewColumn_VariableCheckX
            // 
            this.uiDataGridViewColumn_VariableCheckX.HeaderText = "I";
            this.uiDataGridViewColumn_VariableCheckX.Name = "uiDataGridViewColumn_VariableCheckX";
            this.uiDataGridViewColumn_VariableCheckX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uiDataGridViewColumn_VariableCheckY
            // 
            this.uiDataGridViewColumn_VariableCheckY.HeaderText = "D";
            this.uiDataGridViewColumn_VariableCheckY.Name = "uiDataGridViewColumn_VariableCheckY";
            this.uiDataGridViewColumn_VariableCheckY.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridViewColumn_VariableCheckY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // RegressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 301);
            this.Controls.Add(this.tlpForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(610, 340);
            this.MinimumSize = new System.Drawing.Size(610, 340);
            this.Name = "RegressionForm";
            this.Text = "NoruST - Regression";
            this.tlpForm.ResumeLayout(false);
            this.tlpForm.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.tlpOptions.ResumeLayout(false);
            this.tlpOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConfidenceLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView_Variables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpForm;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TableLayoutPanel tlpOptions;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkResidualsVsXValues;
        private System.Windows.Forms.CheckBox chkFittedValuesVsActualYValues;
        private System.Windows.Forms.CheckBox chkResidualsVsFittedValues;
        private System.Windows.Forms.CheckBox chkDisplayRegressionEquation;
        private System.Windows.Forms.Label lblConfidenceLevel;
        private Controls.PercentageNumericUpDown nudConfidenceLevel;
        private System.Windows.Forms.ComboBox uiComboBox_DataSets;
        private System.Windows.Forms.Label lblDataSet;
        private System.Windows.Forms.Label lblVariable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uiDataGridView_Variables;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uiDataGridViewColumn_VariableCheckX;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uiDataGridViewColumn_VariableCheckY;
    }
}
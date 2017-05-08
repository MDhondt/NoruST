namespace NoruST.Forms
{
    partial class TimeSeriesGraphForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeSeriesGraphForm));
            this.ui_Button_Cancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.variableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlotStopIndex = new System.Windows.Forms.Label();
            this.lblPlotStartIndex = new System.Windows.Forms.Label();
            this.uiTextbox_PlotStopIndex = new System.Windows.Forms.TextBox();
            this.uiTextbox_PlotStartIndex = new System.Windows.Forms.TextBox();
            this.rdbPlotOnlyObservationsWithin = new System.Windows.Forms.RadioButton();
            this.rdbPlotAllObservations = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uiDataGridViewColumn_Checked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_ComboBox_SelectDataSets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ui_Button_Cancel
            // 
            this.ui_Button_Cancel.Location = new System.Drawing.Point(331, 323);
            this.ui_Button_Cancel.Name = "ui_Button_Cancel";
            this.ui_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.ui_Button_Cancel.TabIndex = 3;
            this.ui_Button_Cancel.Text = "Cancel";
            this.ui_Button_Cancel.UseVisualStyleBackColor = true;
            this.ui_Button_Cancel.Click += new System.EventHandler(this.Cancelbutton_clicked);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(250, 323);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.uiButton_Ok_Click);
            // 
            // variableBindingSource
            // 
            this.variableBindingSource.DataSource = typeof(NoruST.Domain.Variable);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlotStopIndex);
            this.groupBox1.Controls.Add(this.lblPlotStartIndex);
            this.groupBox1.Controls.Add(this.uiTextbox_PlotStopIndex);
            this.groupBox1.Controls.Add(this.uiTextbox_PlotStartIndex);
            this.groupBox1.Controls.Add(this.rdbPlotOnlyObservationsWithin);
            this.groupBox1.Controls.Add(this.rdbPlotAllObservations);
            this.groupBox1.Location = new System.Drawing.Point(6, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 73);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observations";
            // 
            // lblPlotStopIndex
            // 
            this.lblPlotStopIndex.AutoSize = true;
            this.lblPlotStopIndex.Location = new System.Drawing.Point(200, 46);
            this.lblPlotStopIndex.Name = "lblPlotStopIndex";
            this.lblPlotStopIndex.Size = new System.Drawing.Size(58, 13);
            this.lblPlotStopIndex.TabIndex = 5;
            this.lblPlotStopIndex.Text = "Stop Index";
            this.lblPlotStopIndex.Visible = false;
            // 
            // lblPlotStartIndex
            // 
            this.lblPlotStartIndex.AutoSize = true;
            this.lblPlotStartIndex.Location = new System.Drawing.Point(200, 21);
            this.lblPlotStartIndex.Name = "lblPlotStartIndex";
            this.lblPlotStartIndex.Size = new System.Drawing.Size(58, 13);
            this.lblPlotStartIndex.TabIndex = 4;
            this.lblPlotStartIndex.Text = "Start Index";
            this.lblPlotStartIndex.Visible = false;
            // 
            // uiTextbox_PlotStopIndex
            // 
            this.uiTextbox_PlotStopIndex.Location = new System.Drawing.Point(285, 42);
            this.uiTextbox_PlotStopIndex.Name = "uiTextbox_PlotStopIndex";
            this.uiTextbox_PlotStopIndex.Size = new System.Drawing.Size(91, 20);
            this.uiTextbox_PlotStopIndex.TabIndex = 3;
            this.uiTextbox_PlotStopIndex.Text = "0";
            this.uiTextbox_PlotStopIndex.Visible = false;
            // 
            // uiTextbox_PlotStartIndex
            // 
            this.uiTextbox_PlotStartIndex.Location = new System.Drawing.Point(285, 16);
            this.uiTextbox_PlotStartIndex.Name = "uiTextbox_PlotStartIndex";
            this.uiTextbox_PlotStartIndex.Size = new System.Drawing.Size(91, 20);
            this.uiTextbox_PlotStartIndex.TabIndex = 2;
            this.uiTextbox_PlotStartIndex.Text = "0";
            this.uiTextbox_PlotStartIndex.Visible = false;
            // 
            // rdbPlotOnlyObservationsWithin
            // 
            this.rdbPlotOnlyObservationsWithin.AutoSize = true;
            this.rdbPlotOnlyObservationsWithin.Location = new System.Drawing.Point(17, 42);
            this.rdbPlotOnlyObservationsWithin.Name = "rdbPlotOnlyObservationsWithin";
            this.rdbPlotOnlyObservationsWithin.Size = new System.Drawing.Size(149, 17);
            this.rdbPlotOnlyObservationsWithin.TabIndex = 1;
            this.rdbPlotOnlyObservationsWithin.Text = "Plot only those within limits";
            this.rdbPlotOnlyObservationsWithin.UseVisualStyleBackColor = true;
            this.rdbPlotOnlyObservationsWithin.CheckedChanged += new System.EventHandler(this.rdbPlotOnlyObservationsWithin_CheckedChanged);
            // 
            // rdbPlotAllObservations
            // 
            this.rdbPlotAllObservations.AutoSize = true;
            this.rdbPlotAllObservations.Checked = true;
            this.rdbPlotAllObservations.Location = new System.Drawing.Point(17, 19);
            this.rdbPlotAllObservations.Name = "rdbPlotAllObservations";
            this.rdbPlotAllObservations.Size = new System.Drawing.Size(119, 17);
            this.rdbPlotAllObservations.TabIndex = 0;
            this.rdbPlotAllObservations.TabStop = true;
            this.rdbPlotAllObservations.Text = "Plot all observations";
            this.rdbPlotAllObservations.UseVisualStyleBackColor = true;
            this.rdbPlotAllObservations.CheckedChanged += new System.EventHandler(this.rdbPlotAllObservations_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uiDataGridViewColumn_Checked,
            this.nameDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.variableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(107, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 185);
            this.dataGridView1.TabIndex = 13;
            // 
            // uiDataGridViewColumn_Checked
            // 
            this.uiDataGridViewColumn_Checked.HeaderText = "";
            this.uiDataGridViewColumn_Checked.Name = "uiDataGridViewColumn_Checked";
            this.uiDataGridViewColumn_Checked.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rangeDataGridViewTextBoxColumn
            // 
            this.rangeDataGridViewTextBoxColumn.DataPropertyName = "Range";
            this.rangeDataGridViewTextBoxColumn.HeaderText = "Range";
            this.rangeDataGridViewTextBoxColumn.Name = "rangeDataGridViewTextBoxColumn";
            this.rangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ui_ComboBox_SelectDataSets
            // 
            this.ui_ComboBox_SelectDataSets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ui_ComboBox_SelectDataSets.FormattingEnabled = true;
            this.ui_ComboBox_SelectDataSets.Location = new System.Drawing.Point(107, 26);
            this.ui_ComboBox_SelectDataSets.Name = "ui_ComboBox_SelectDataSets";
            this.ui_ComboBox_SelectDataSets.Size = new System.Drawing.Size(300, 21);
            this.ui_ComboBox_SelectDataSets.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select Dataset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Data";
            // 
            // TimeSeriesGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ui_ComboBox_SelectDataSets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ui_Button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeSeriesGraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Series Graph";
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ui_Button_Cancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.BindingSource variableBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlotStopIndex;
        private System.Windows.Forms.Label lblPlotStartIndex;
        private System.Windows.Forms.TextBox uiTextbox_PlotStopIndex;
        private System.Windows.Forms.TextBox uiTextbox_PlotStartIndex;
        private System.Windows.Forms.RadioButton rdbPlotOnlyObservationsWithin;
        private System.Windows.Forms.RadioButton rdbPlotAllObservations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ui_ComboBox_SelectDataSets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn uiDataGridViewColumn_Checked;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
    }
}
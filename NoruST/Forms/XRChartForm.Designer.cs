namespace NoruST.Forms
{
    partial class XRChartForm
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
            this.Xbar = new System.Windows.Forms.CheckBox();
            this.Rchart = new System.Windows.Forms.CheckBox();
            this.ui_Button_Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_Button_Ok = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStopIndex = new System.Windows.Forms.Label();
            this.lblStartIndex = new System.Windows.Forms.Label();
            this.uiTextBox_StopIndex = new System.Windows.Forms.TextBox();
            this.uiTextBox_StartIndex = new System.Windows.Forms.TextBox();
            this.rdbPreviousData = new System.Windows.Forms.RadioButton();
            this.rdbObservationsInRange = new System.Windows.Forms.RadioButton();
            this.rdbAllObservations = new System.Windows.Forms.RadioButton();
            this.ui_ComboBox_SelectDataSets = new System.Windows.Forms.ComboBox();
            this.variableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Xbar
            // 
            this.Xbar.AutoSize = true;
            this.Xbar.Location = new System.Drawing.Point(312, 50);
            this.Xbar.Name = "Xbar";
            this.Xbar.Size = new System.Drawing.Size(57, 17);
            this.Xbar.TabIndex = 0;
            this.Xbar.Text = "X - bar";
            this.Xbar.UseVisualStyleBackColor = true;
            // 
            // Rchart
            // 
            this.Rchart.AutoSize = true;
            this.Rchart.Location = new System.Drawing.Point(312, 16);
            this.Rchart.Name = "Rchart";
            this.Rchart.Size = new System.Drawing.Size(68, 17);
            this.Rchart.TabIndex = 1;
            this.Rchart.Text = "R - Chart";
            this.Rchart.UseVisualStyleBackColor = true;
            // 
            // ui_Button_Cancel
            // 
            this.ui_Button_Cancel.Location = new System.Drawing.Point(348, 397);
            this.ui_Button_Cancel.Name = "ui_Button_Cancel";
            this.ui_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.ui_Button_Cancel.TabIndex = 3;
            this.ui_Button_Cancel.Text = "Cancel";
            this.ui_Button_Cancel.UseVisualStyleBackColor = true;
            this.ui_Button_Cancel.Click += new System.EventHandler(this.Cancelbutton_clicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Rchart);
            this.groupBox1.Controls.Add(this.Xbar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chart type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select one or more graphs";
            // 
            // ui_Button_Ok
            // 
            this.ui_Button_Ok.Location = new System.Drawing.Point(267, 397);
            this.ui_Button_Ok.Name = "ui_Button_Ok";
            this.ui_Button_Ok.Size = new System.Drawing.Size(75, 23);
            this.ui_Button_Ok.TabIndex = 5;
            this.ui_Button_Ok.Text = "Ok";
            this.ui_Button_Ok.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStopIndex);
            this.groupBox2.Controls.Add(this.lblStartIndex);
            this.groupBox2.Controls.Add(this.uiTextBox_StopIndex);
            this.groupBox2.Controls.Add(this.uiTextBox_StartIndex);
            this.groupBox2.Controls.Add(this.rdbPreviousData);
            this.groupBox2.Controls.Add(this.rdbObservationsInRange);
            this.groupBox2.Controls.Add(this.rdbAllObservations);
            this.groupBox2.Location = new System.Drawing.Point(12, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control limits based on";
            // 
            // lblStopIndex
            // 
            this.lblStopIndex.AutoSize = true;
            this.lblStopIndex.Location = new System.Drawing.Point(217, 67);
            this.lblStopIndex.Name = "lblStopIndex";
            this.lblStopIndex.Size = new System.Drawing.Size(58, 13);
            this.lblStopIndex.TabIndex = 6;
            this.lblStopIndex.Text = "Stop Index";
            this.lblStopIndex.Visible = false;
            // 
            // lblStartIndex
            // 
            this.lblStartIndex.AutoSize = true;
            this.lblStartIndex.Location = new System.Drawing.Point(217, 24);
            this.lblStartIndex.Name = "lblStartIndex";
            this.lblStartIndex.Size = new System.Drawing.Size(58, 13);
            this.lblStartIndex.TabIndex = 5;
            this.lblStartIndex.Text = "Start Index";
            this.lblStartIndex.Visible = false;
            // 
            // uiTextBox_StopIndex
            // 
            this.uiTextBox_StopIndex.Location = new System.Drawing.Point(302, 64);
            this.uiTextBox_StopIndex.Name = "uiTextBox_StopIndex";
            this.uiTextBox_StopIndex.Size = new System.Drawing.Size(91, 20);
            this.uiTextBox_StopIndex.TabIndex = 4;
            this.uiTextBox_StopIndex.Visible = false;
            // 
            // uiTextBox_StartIndex
            // 
            this.uiTextBox_StartIndex.Location = new System.Drawing.Point(302, 21);
            this.uiTextBox_StartIndex.Name = "uiTextBox_StartIndex";
            this.uiTextBox_StartIndex.Size = new System.Drawing.Size(91, 20);
            this.uiTextBox_StartIndex.TabIndex = 3;
            this.uiTextBox_StartIndex.Visible = false;
            // 
            // rdbPreviousData
            // 
            this.rdbPreviousData.AutoSize = true;
            this.rdbPreviousData.Location = new System.Drawing.Point(17, 67);
            this.rdbPreviousData.Name = "rdbPreviousData";
            this.rdbPreviousData.Size = new System.Drawing.Size(90, 17);
            this.rdbPreviousData.TabIndex = 2;
            this.rdbPreviousData.Text = "Previous data";
            this.rdbPreviousData.UseVisualStyleBackColor = true;
            // 
            // rdbObservationsInRange
            // 
            this.rdbObservationsInRange.AutoSize = true;
            this.rdbObservationsInRange.Location = new System.Drawing.Point(17, 43);
            this.rdbObservationsInRange.Name = "rdbObservationsInRange";
            this.rdbObservationsInRange.Size = new System.Drawing.Size(128, 17);
            this.rdbObservationsInRange.TabIndex = 1;
            this.rdbObservationsInRange.Text = "Observations in range";
            this.rdbObservationsInRange.UseVisualStyleBackColor = true;
            this.rdbObservationsInRange.CheckedChanged += new System.EventHandler(this.ObservationsInRange_CheckedChanged);
            // 
            // rdbAllObservations
            // 
            this.rdbAllObservations.AutoSize = true;
            this.rdbAllObservations.Checked = true;
            this.rdbAllObservations.Location = new System.Drawing.Point(17, 19);
            this.rdbAllObservations.Name = "rdbAllObservations";
            this.rdbAllObservations.Size = new System.Drawing.Size(101, 17);
            this.rdbAllObservations.TabIndex = 0;
            this.rdbAllObservations.TabStop = true;
            this.rdbAllObservations.Text = "All Observations";
            this.rdbAllObservations.UseVisualStyleBackColor = true;
            // 
            // ui_ComboBox_SelectDataSets
            // 
            this.ui_ComboBox_SelectDataSets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ui_ComboBox_SelectDataSets.FormattingEnabled = true;
            this.ui_ComboBox_SelectDataSets.Location = new System.Drawing.Point(116, 23);
            this.ui_ComboBox_SelectDataSets.Name = "ui_ComboBox_SelectDataSets";
            this.ui_ComboBox_SelectDataSets.Size = new System.Drawing.Size(300, 21);
            this.ui_ComboBox_SelectDataSets.TabIndex = 7;
            // 
            // variableBindingSource
            // 
            this.variableBindingSource.DataSource = typeof(NoruST.Domain.Variable);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Dataset";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.variableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 133);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.ui_ComboBox_SelectDataSets);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 194);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dataset";
            // 
            // XRChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 426);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ui_Button_Ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ui_Button_Cancel);
            this.Name = "XRChartForm";
            this.Text = "X/R Chart";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Xbar;
        private System.Windows.Forms.CheckBox Rchart;
        private System.Windows.Forms.Button ui_Button_Cancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ui_Button_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbAllObservations;
        private System.Windows.Forms.RadioButton rdbPreviousData;
        private System.Windows.Forms.RadioButton rdbObservationsInRange;
        private System.Windows.Forms.Label lblStartIndex;
        private System.Windows.Forms.TextBox uiTextBox_StopIndex;
        private System.Windows.Forms.TextBox uiTextBox_StartIndex;
        private System.Windows.Forms.Label lblStopIndex;
        private System.Windows.Forms.ComboBox ui_ComboBox_SelectDataSets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource variableBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
namespace NoruST.Forms
{
    partial class PChartForm
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
            this.ui_ComboBox_SelectDataSets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.variableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ui_Button_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStopIndex = new System.Windows.Forms.Label();
            this.lblStartIndex = new System.Windows.Forms.Label();
            this.ui_TextBox_StopIndex = new System.Windows.Forms.TextBox();
            this.ui_TextBox_StartIndex = new System.Windows.Forms.TextBox();
            this.ui_RadioButton_PreviousData = new System.Windows.Forms.RadioButton();
            this.ui_RadioButton_ObservationsInRange = new System.Windows.Forms.RadioButton();
            this.ui_RadioButton_AllObservations = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_ComboBox_SelectDataSets
            // 
            this.ui_ComboBox_SelectDataSets.FormattingEnabled = true;
            this.ui_ComboBox_SelectDataSets.Location = new System.Drawing.Point(169, 25);
            this.ui_ComboBox_SelectDataSets.Name = "ui_ComboBox_SelectDataSets";
            this.ui_ComboBox_SelectDataSets.Size = new System.Drawing.Size(277, 21);
            this.ui_ComboBox_SelectDataSets.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Dataset";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.variableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 140);
            this.dataGridView1.TabIndex = 2;
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
            // variableBindingSource
            // 
            this.variableBindingSource.DataSource = typeof(NoruST.Domain.Variable);
            // 
            // ui_Button_Cancel
            // 
            this.ui_Button_Cancel.Location = new System.Drawing.Point(389, 320);
            this.ui_Button_Cancel.Name = "ui_Button_Cancel";
            this.ui_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.ui_Button_Cancel.TabIndex = 3;
            this.ui_Button_Cancel.Text = "Cancel";
            this.ui_Button_Cancel.UseVisualStyleBackColor = true;
            this.ui_Button_Cancel.Click += new System.EventHandler(this.ui_Button_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(308, 320);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.uiButton_Ok_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ui_ComboBox_SelectDataSets);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 198);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dataset";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStopIndex);
            this.groupBox2.Controls.Add(this.lblStartIndex);
            this.groupBox2.Controls.Add(this.ui_TextBox_StopIndex);
            this.groupBox2.Controls.Add(this.ui_TextBox_StartIndex);
            this.groupBox2.Controls.Add(this.ui_RadioButton_PreviousData);
            this.groupBox2.Controls.Add(this.ui_RadioButton_ObservationsInRange);
            this.groupBox2.Controls.Add(this.ui_RadioButton_AllObservations);
            this.groupBox2.Location = new System.Drawing.Point(12, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 98);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control limits based on";
            // 
            // lblStopIndex
            // 
            this.lblStopIndex.AutoSize = true;
            this.lblStopIndex.Location = new System.Drawing.Point(245, 68);
            this.lblStopIndex.Name = "lblStopIndex";
            this.lblStopIndex.Size = new System.Drawing.Size(58, 13);
            this.lblStopIndex.TabIndex = 6;
            this.lblStopIndex.Text = "Stop Index";
            this.lblStopIndex.Visible = false;
            // 
            // lblStartIndex
            // 
            this.lblStartIndex.AutoSize = true;
            this.lblStartIndex.Location = new System.Drawing.Point(245, 23);
            this.lblStartIndex.Name = "lblStartIndex";
            this.lblStartIndex.Size = new System.Drawing.Size(58, 13);
            this.lblStartIndex.TabIndex = 5;
            this.lblStartIndex.Text = "Start Index";
            this.lblStartIndex.Visible = false;
            // 
            // ui_TextBox_StopIndex
            // 
            this.ui_TextBox_StopIndex.Location = new System.Drawing.Point(336, 65);
            this.ui_TextBox_StopIndex.Name = "ui_TextBox_StopIndex";
            this.ui_TextBox_StopIndex.Size = new System.Drawing.Size(100, 20);
            this.ui_TextBox_StopIndex.TabIndex = 4;
            this.ui_TextBox_StopIndex.Text = "0";
            this.ui_TextBox_StopIndex.Visible = false;
            // 
            // ui_TextBox_StartIndex
            // 
            this.ui_TextBox_StartIndex.Location = new System.Drawing.Point(336, 20);
            this.ui_TextBox_StartIndex.Name = "ui_TextBox_StartIndex";
            this.ui_TextBox_StartIndex.Size = new System.Drawing.Size(100, 20);
            this.ui_TextBox_StartIndex.TabIndex = 3;
            this.ui_TextBox_StartIndex.Text = "0";
            this.ui_TextBox_StartIndex.Visible = false;
            // 
            // ui_RadioButton_PreviousData
            // 
            this.ui_RadioButton_PreviousData.AutoSize = true;
            this.ui_RadioButton_PreviousData.Location = new System.Drawing.Point(7, 68);
            this.ui_RadioButton_PreviousData.Name = "ui_RadioButton_PreviousData";
            this.ui_RadioButton_PreviousData.Size = new System.Drawing.Size(90, 17);
            this.ui_RadioButton_PreviousData.TabIndex = 2;
            this.ui_RadioButton_PreviousData.Text = "Previous data";
            this.ui_RadioButton_PreviousData.UseVisualStyleBackColor = true;
            // 
            // ui_RadioButton_ObservationsInRange
            // 
            this.ui_RadioButton_ObservationsInRange.AutoSize = true;
            this.ui_RadioButton_ObservationsInRange.Location = new System.Drawing.Point(7, 44);
            this.ui_RadioButton_ObservationsInRange.Name = "ui_RadioButton_ObservationsInRange";
            this.ui_RadioButton_ObservationsInRange.Size = new System.Drawing.Size(128, 17);
            this.ui_RadioButton_ObservationsInRange.TabIndex = 1;
            this.ui_RadioButton_ObservationsInRange.Text = "Observations in range";
            this.ui_RadioButton_ObservationsInRange.UseVisualStyleBackColor = true;
            this.ui_RadioButton_ObservationsInRange.CheckedChanged += new System.EventHandler(this.RB_Observationsinrange_CheckedChanged);
            // 
            // ui_RadioButton_AllObservations
            // 
            this.ui_RadioButton_AllObservations.AutoSize = true;
            this.ui_RadioButton_AllObservations.Checked = true;
            this.ui_RadioButton_AllObservations.Location = new System.Drawing.Point(7, 20);
            this.ui_RadioButton_AllObservations.Name = "ui_RadioButton_AllObservations";
            this.ui_RadioButton_AllObservations.Size = new System.Drawing.Size(101, 17);
            this.ui_RadioButton_AllObservations.TabIndex = 0;
            this.ui_RadioButton_AllObservations.TabStop = true;
            this.ui_RadioButton_AllObservations.Text = "All Observations";
            this.ui_RadioButton_AllObservations.UseVisualStyleBackColor = true;
            // 
            // PChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.ui_Button_Cancel);
            this.Name = "PChartForm";
            this.Text = "PChart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ui_ComboBox_SelectDataSets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource variableBindingSource;
        private System.Windows.Forms.Button ui_Button_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ui_TextBox_StopIndex;
        private System.Windows.Forms.TextBox ui_TextBox_StartIndex;
        private System.Windows.Forms.RadioButton ui_RadioButton_PreviousData;
        private System.Windows.Forms.RadioButton ui_RadioButton_ObservationsInRange;
        private System.Windows.Forms.RadioButton ui_RadioButton_AllObservations;
        private System.Windows.Forms.Label lblStopIndex;
        private System.Windows.Forms.Label lblStartIndex;
    }
}
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
            this.ui_Button_Cancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.ui_ComboBox_SelectDataSets = new System.Windows.Forms.ComboBox();
            this.variableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPlotStopIndex = new System.Windows.Forms.Label();
            this.lblPlotStartIndex = new System.Windows.Forms.Label();
            this.uiTextbox_PlotStopIndex = new System.Windows.Forms.TextBox();
            this.uiTextbox_PlotStartIndex = new System.Windows.Forms.TextBox();
            this.rdbPlotOnlyObservationsWithin = new System.Windows.Forms.RadioButton();
            this.rdbPlotAllObservations = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_Button_Cancel
            // 
            this.ui_Button_Cancel.Location = new System.Drawing.Point(348, 405);
            this.ui_Button_Cancel.Name = "ui_Button_Cancel";
            this.ui_Button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.ui_Button_Cancel.TabIndex = 3;
            this.ui_Button_Cancel.Text = "Cancel";
            this.ui_Button_Cancel.UseVisualStyleBackColor = true;
            this.ui_Button_Cancel.Click += new System.EventHandler(this.Cancelbutton_clicked);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(267, 405);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.uiButton_Ok_Click);
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.rangeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.variableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(410, 212);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 273);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dataset";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlotStopIndex);
            this.groupBox1.Controls.Add(this.lblPlotStartIndex);
            this.groupBox1.Controls.Add(this.uiTextbox_PlotStopIndex);
            this.groupBox1.Controls.Add(this.uiTextbox_PlotStartIndex);
            this.groupBox1.Controls.Add(this.rdbPlotOnlyObservationsWithin);
            this.groupBox1.Controls.Add(this.rdbPlotAllObservations);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 89);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observations";
            // 
            // lblPlotStopIndex
            // 
            this.lblPlotStopIndex.AutoSize = true;
            this.lblPlotStopIndex.Location = new System.Drawing.Point(218, 58);
            this.lblPlotStopIndex.Name = "lblPlotStopIndex";
            this.lblPlotStopIndex.Size = new System.Drawing.Size(58, 13);
            this.lblPlotStopIndex.TabIndex = 5;
            this.lblPlotStopIndex.Text = "Stop Index";
            this.lblPlotStopIndex.Visible = false;
            // 
            // lblPlotStartIndex
            // 
            this.lblPlotStartIndex.AutoSize = true;
            this.lblPlotStartIndex.Location = new System.Drawing.Point(218, 21);
            this.lblPlotStartIndex.Name = "lblPlotStartIndex";
            this.lblPlotStartIndex.Size = new System.Drawing.Size(58, 13);
            this.lblPlotStartIndex.TabIndex = 4;
            this.lblPlotStartIndex.Text = "Start Index";
            this.lblPlotStartIndex.Visible = false;
            // 
            // uiTextbox_PlotStopIndex
            // 
            this.uiTextbox_PlotStopIndex.Location = new System.Drawing.Point(303, 54);
            this.uiTextbox_PlotStopIndex.Name = "uiTextbox_PlotStopIndex";
            this.uiTextbox_PlotStopIndex.Size = new System.Drawing.Size(91, 20);
            this.uiTextbox_PlotStopIndex.TabIndex = 3;
            this.uiTextbox_PlotStopIndex.Text = "0";
            this.uiTextbox_PlotStopIndex.Visible = false;
            // 
            // uiTextbox_PlotStartIndex
            // 
            this.uiTextbox_PlotStartIndex.Location = new System.Drawing.Point(303, 16);
            this.uiTextbox_PlotStartIndex.Name = "uiTextbox_PlotStartIndex";
            this.uiTextbox_PlotStartIndex.Size = new System.Drawing.Size(91, 20);
            this.uiTextbox_PlotStartIndex.TabIndex = 2;
            this.uiTextbox_PlotStartIndex.Text = "0";
            this.uiTextbox_PlotStartIndex.Visible = false;
            // 
            // rdbPlotOnlyObservationsWithin
            // 
            this.rdbPlotOnlyObservationsWithin.AutoSize = true;
            this.rdbPlotOnlyObservationsWithin.Location = new System.Drawing.Point(17, 54);
            this.rdbPlotOnlyObservationsWithin.Name = "rdbPlotOnlyObservationsWithin";
            this.rdbPlotOnlyObservationsWithin.Size = new System.Drawing.Size(170, 17);
            this.rdbPlotOnlyObservationsWithin.TabIndex = 1;
            this.rdbPlotOnlyObservationsWithin.Text = "Plot only those within the limits:";
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
            // TimeSeriesGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.ui_Button_Cancel);
            this.Name = "TimeSeriesGraphForm";
            this.Text = "Time Series Graph";
            ((System.ComponentModel.ISupportInitialize)(this.variableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ui_Button_Cancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox ui_ComboBox_SelectDataSets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource variableBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlotStopIndex;
        private System.Windows.Forms.Label lblPlotStartIndex;
        private System.Windows.Forms.TextBox uiTextbox_PlotStopIndex;
        private System.Windows.Forms.TextBox uiTextbox_PlotStartIndex;
        private System.Windows.Forms.RadioButton rdbPlotOnlyObservationsWithin;
        private System.Windows.Forms.RadioButton rdbPlotAllObservations;
    }
}
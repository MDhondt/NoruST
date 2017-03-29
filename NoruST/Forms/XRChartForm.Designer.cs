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
            this.Xbar = new System.Windows.Forms.CheckBox();
            this.Rchart = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStopIndex = new System.Windows.Forms.Label();
            this.lblStartIndex = new System.Windows.Forms.Label();
            this.uiTextBox_StopIndex = new System.Windows.Forms.TextBox();
            this.uiTextBox_StartIndex = new System.Windows.Forms.TextBox();
            this.rdbPreviousData = new System.Windows.Forms.RadioButton();
            this.rdbObservationsInRange = new System.Windows.Forms.RadioButton();
            this.rdbAllObservations = new System.Windows.Forms.RadioButton();
            this.ui_ComboBox_SelectDataSets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(348, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
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
            this.rdbPreviousData.TabStop = true;
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
            this.rdbObservationsInRange.TabStop = true;
            this.rdbObservationsInRange.Text = "Observations in range";
            this.rdbObservationsInRange.UseVisualStyleBackColor = true;
            this.rdbObservationsInRange.CheckedChanged += new System.EventHandler(this.ObservationsInRange_CheckedChanged);
            // 
            // rdbAllObservations
            // 
            this.rdbAllObservations.AutoSize = true;
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
            this.ui_ComboBox_SelectDataSets.FormattingEnabled = true;
            this.ui_ComboBox_SelectDataSets.Location = new System.Drawing.Point(122, 107);
            this.ui_ComboBox_SelectDataSets.Name = "ui_ComboBox_SelectDataSets";
            this.ui_ComboBox_SelectDataSets.Size = new System.Drawing.Size(312, 21);
            this.ui_ComboBox_SelectDataSets.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Dataset";
            // 
            // XRChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ui_ComboBox_SelectDataSets);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Name = "XRChartForm";
            this.Text = "X/R Chart";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Xbar;
        private System.Windows.Forms.CheckBox Rchart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
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
    }
}
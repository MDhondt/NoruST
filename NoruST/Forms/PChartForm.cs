using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoruST.Forms
{
    public partial class PChartForm : Form
    {
        public PChartForm()
        {
            InitializeComponent();
        }

        private void ui_Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RB_Observationsinrange_CheckedChanged(object sender, EventArgs e)
        {
            ui_TextBox_StartIndex.Visible = ui_RadioButton_ObservationsInRange.Checked;
            ui_TextBox_StopIndex.Visible = ui_RadioButton_ObservationsInRange.Checked;
            lblStartIndex.Visible = ui_RadioButton_ObservationsInRange.Checked;
            lblStopIndex.Visible = ui_RadioButton_ObservationsInRange.Checked;
        }
    }
}

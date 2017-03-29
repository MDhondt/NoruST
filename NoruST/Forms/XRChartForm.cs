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
    public partial class XRChartForm : Form
    {
        public XRChartForm()
        {
            InitializeComponent();
        }
        private void ObservationsInRange_CheckedChanged(object sender, EventArgs e)
        {
            uiTextBox_StartIndex.Visible = rdbObservationsInRange.Checked;
            uiTextBox_StopIndex.Visible = rdbObservationsInRange.Checked;
            lblStartIndex.Visible = rdbObservationsInRange.Checked;
            lblStopIndex.Visible = rdbObservationsInRange.Checked;
        }

        private void Cancelbutton_clicked(object sender, EventArgs e)
        {
            Close();
        }
    }

}

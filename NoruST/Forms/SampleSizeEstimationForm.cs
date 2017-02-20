using NoruST.Analyses;
using NoruST.Models;

// ReSharper disable InvertIf
// ReSharper disable LocalizableElement

namespace NoruST.Forms
{
    /// <summary>
    /// <para>The Sample Size Estimation Form.</para>
    /// <para>Version: 1.0</para>
    /// <para>&#160;</para>
    /// <para>Author: Frederik Van de Velde</para>
    /// <para>&#160;</para>
    /// <para>Last Updated: Apr 24, 2016</para>
    /// </summary>
    public partial class SampleSizeEstimationForm : ExtendedForm
    {
        #region Constructors

        /// <summary>
        /// Constructor of the <see cref="SampleSizeEstimationForm"/> <see cref="System.Windows.Forms.Form"/>.
        /// </summary>
        public SampleSizeEstimationForm()
        {
            InitializeComponent();

            InitializeView(btnOk, btnCancel);
        }

        #endregion

        #region Interaction Methods

        /// <summary>
        /// Fired when the <see cref="System.Windows.Forms.RadioButton.Checked"/> for the estimate <see cref="System.Windows.Forms.RadioButton"/>s changes from true to false or vice versa.
        /// </summary>
        private void EstimateCheckedChanged(object sender, System.EventArgs e)
        {
            nudConfidenceLevel.Value = 95;
            txtMarginOfError.Text = "0.1";

            if (rdbMean.Checked)
            {
                lblEstimate1.Text = "Estimated Standard Deviation";
                txtEstimate1.Text = "1";
                lblEstimate2.Visible = false;
                txtEstimate2.Visible = false;
            }
            if (rdbProportion.Checked)
            {
                lblEstimate1.Text = "Estimated Proportion";
                txtEstimate1.Text = "0.1";
                lblEstimate2.Visible = false;
                txtEstimate2.Visible = false;
            }
            if (rdbDifferenceOfMeans.Checked)
            {
                lblEstimate1.Text = "Estimated Common Standard Deviation";
                txtEstimate1.Text = "1";
                lblEstimate2.Visible = false;
                txtEstimate2.Visible = false;
            }
            if (rdbDifferenceOfProportions.Checked)
            {
                lblEstimate1.Text = "Estimated Proportion 1";
                txtEstimate1.Text = "0.1";
                lblEstimate2.Visible = true;
                txtEstimate2.Visible = true;
                txtEstimate2.Text = "0.1";
            }
        }

        #endregion

        #region Overwritten Methods

        /// <summary>
        /// This adds extra functionality to the Ok <see cref="System.Windows.Forms.Button"/>
        /// </summary>
        public override bool OkButtonClick()
        {
            var doCalculate = new SummaryStatisticsBool(meanSampleSize: rdbMean.Checked, proportionSampleSize: rdbProportion.Checked, differenceOfMeansSampleSize: rdbDifferenceOfMeans.Checked, differenceOfProportionsSampleSize: rdbDifferenceOfProportions.Checked);

            return new SampleSize().Print(doCalculate, (int)nudConfidenceLevel.Value, txtMarginOfError.Text, txtEstimate1.Text, txtEstimate2.Text);
        }

        #endregion
    }
}
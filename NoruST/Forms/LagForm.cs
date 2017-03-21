using System.Windows.Forms;
using NoruST.Data;
using NoruST.Presenters;

namespace NoruST.Forms
{
    public partial class LagForm : Form
    {
        private LagPresenter presenter;

        public LagForm()
        {
            InitializeComponent();
        }

        public void setPresenter(LagPresenter lagPresenter)
        {
            this.presenter = lagPresenter;
        }
    }
}
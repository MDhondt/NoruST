using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoruST.Forms;
using NoruST.Models;

namespace NoruST.Presenters
{
    public class LagPresenter
    {
        private LagForm view;
        private LagModel model;
        private DataSetManagerPresenter dataSetPresenter;

        public LagPresenter(DataSetManagerPresenter dataSetPresenter)
        {
            this.dataSetPresenter = dataSetPresenter;
            this.model = new LagModel();
        }

        public void openView()
        {
            view = view.createAndOrShowForm();
            view.setPresenter(this);
        }
    }
}

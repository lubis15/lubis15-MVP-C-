using SQLITE_TEST.Models;
using SQLITE_TEST.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLITE_TEST.Presenters
{
    internal class LoadTokoPresenter
    {
        Toko toko = new Toko();
        private ILoadToko loadTokoView;

        public LoadTokoPresenter(ILoadToko view)
        {
            loadTokoView = view;
        }

        public void DisplayTokoToDGV()
        {
            loadTokoView.DGVToko.DataSource = toko.LoadTokoList();
        }
    }
}

using SQLITE_TEST.Models;
using SQLITE_TEST.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SQLITE_TEST.Presenters
{
    internal class DeleteTokoPresenter
    {
        Toko toko = new Toko();
        private IDeleteToko deleteView;

        public DeleteTokoPresenter(IDeleteToko view)
        {
            deleteView = view;
        }

        public void DeleteToko(int tokoId)
        {
            toko.TokoId = tokoId;
            toko.DeleteTokoById();

        }
    }
}

using SQLITE_TEST.Models;
using SQLITE_TEST.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLITE_TEST.Presenters
{
    internal class AddTokoPresenter
    {
        Toko toko = new Toko();
        private IAddToko addTokoView;

        public AddTokoPresenter(IAddToko view)
        {
            addTokoView = view;
        }

        public void AddToko()
        {
            toko.Name = addTokoView.TbName;
            toko.Harga = addTokoView.TbHarga;
            toko.AddTokoToDatabase();
        }
    }
}

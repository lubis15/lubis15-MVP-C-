using SQLITE_TEST.Models;
using SQLITE_TEST.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLITE_TEST.Presenters
{
    internal class EditTokoPresenter
    {
        Toko toko = new Toko();
        private IEditToko editTokoView;

        public EditTokoPresenter(IEditToko view)
        {
            editTokoView = view;
        }

        public void LoadTokoInfo(int tokoId)
        {
            toko.TokoId = tokoId;

            DataTable dt = toko.LoadTokoById();

            editTokoView.TbName = dt.Rows[0]["name"].ToString();
            editTokoView.TbHarga = dt.Rows[0]["harga"].ToString();

        }

        public void EditToko()
        {
            toko.Name = editTokoView.TbName;
            toko.Harga = editTokoView.TbHarga;
            toko.EditTokoById();
        }
    }
}

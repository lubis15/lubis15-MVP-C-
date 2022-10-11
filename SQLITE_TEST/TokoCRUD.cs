using PeopleCRUD;
using SQLITE_TEST.Presenters;
using SQLITE_TEST.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLITE_TEST
{
    public partial class TokoCRUD : Form,ILoadToko,IDeleteToko
    {
        private LoadTokoPresenter loadPresenter;
        private DeleteTokoPresenter deleteTokoPresenter;

        private int tokoId;
        public TokoCRUD()
        {
            InitializeComponent();
        }

        public DataGridView DGVToko { get => dgvToko; set => dgvToko.DataSource = value; }
        string IDeleteToko.tokoId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        private void TokoCRUDForm_Load(object sender, EventArgs e)
        {
            LoadTokoList();
        }
        

        private void LoadTokoList()
        {
            loadPresenter = new LoadTokoPresenter(this);
            loadPresenter.DisplayTokoToDGV();
        }


        private void btnAddToko_Click(object sender, EventArgs e)
        {
            //addTokoPresenter = new AddTokoPresenter(this);
            //addTokoPresenter.AddToko();
            //LoadTokoList();

            AddTokoForm addToko = new AddTokoForm
            {
               
            };
            addToko.ShowDialog();
            LoadTokoList();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kamu yakin mau hapus barang ini", "Delete Toko", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteTokoPresenter = new DeleteTokoPresenter(this);
                deleteTokoPresenter.DeleteToko(tokoId);
                LoadTokoList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
              EditTokoForm editToko = new EditTokoForm
            {
                tokoId = tokoId
            };
            editToko.ShowDialog();
            LoadTokoList();
        }

        private void dgvToko_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvToko.Rows[e.RowIndex];

                tokoId = int.Parse(row.Cells["id"].Value.ToString());

            }
        }

        private void dgvToko_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

using SQLITE_TEST.Presenters;
using SQLITE_TEST.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PeopleCRUD
{
    public partial class EditTokoForm : Form, IEditToko
    {
        public int tokoId;
        private EditTokoPresenter editTokoPresenter;
        public EditTokoForm()
        {
            InitializeComponent();
        }

        public string TbName { get => txtName.Text; set => txtName.Text = value; }
        public string TbHarga { get => txtHarga.Text; set => txtHarga.Text = value; }

        private void EditTokoForm_Load(object sender, EventArgs e)
        {
            editTokoPresenter = new EditTokoPresenter(this);
            editTokoPresenter.LoadTokoInfo(tokoId);

        }



        private void btnEditToko_Click(object sender, EventArgs e)
        {
            editTokoPresenter.EditToko();
            this.Close();
        }


        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void EditTokoForm_Load_1(object sender, EventArgs e)
        {

        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 48)
            {
                e.Handled = true;
            }

            if (txtHarga.Text == "" && e.KeyChar == '0')
            {
                e.Handled = true;
                return;
            }

        }

       
    }
}

using SQLITE_TEST.Views;
using SQLITE_TEST.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLITE_TEST
{
    public partial class AddTokoForm : Form, IAddToko
    {
        public string TbName { get => txtName.Text; set => throw new NotImplementedException(); }
        public string TbHarga { get => txtHarga.Text; set => throw new NotImplementedException(); }

        private AddTokoPresenter addTokoPresenter;
        public AddTokoForm()
        {
            InitializeComponent();
        }

        private void AddTokoForm_Load(object sender, EventArgs e)
        {
            addTokoPresenter = new AddTokoPresenter(this);
            addTokoPresenter.AddToko();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addTokoPresenter.AddToko();
            this.Close();
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLITE_TEST.Models
{
    internal class Toko
    {
        public int TokoId { get; set; }
        public string Name { get; set; }
        public string Harga { get; set; }

        public DataTable LoadTokoList()
        {
            Connection con = new Connection();
            con.Query("Select * from toko");
            return con.ExecuteSelectQuery();
        }

        public DataTable LoadTokoById()
        {
            Connection con = new Connection();
            con.Query($"Select * from toko where id = {TokoId}");
            return con.ExecuteSelectQuery();
        }

        public void AddTokoToDatabase()
        {
            Connection con = new Connection();
            con.Query("insert into toko (name,harga) values(@name,@harga)");
            con.cmd.Parameters.AddWithValue("@name", Name);
            con.cmd.Parameters.AddWithValue("@harga", Harga);
            con.ExecuteNonSelectQuery();
        }

        public void EditTokoById()
        {
            Connection con = new Connection();
            con.Query($"update toko set name = '{Name}', harga = '{Harga}' where id = {TokoId} ");
            con.ExecuteNonSelectQuery();
        }



        public void DeleteTokoById()
        {
            Connection con = new Connection();
            con.Query("delete from toko where id = @id");
            con.cmd.Parameters.AddWithValue("id", TokoId);
            con.ExecuteNonSelectQuery();
        }
    }
}

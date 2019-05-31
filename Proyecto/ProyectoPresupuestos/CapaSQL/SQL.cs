using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaSQL {
    public class SQL {
        SqlConnection cnx;
        public SqlDataAdapter dap;
        SqlDataReader dar;
        SqlCommand cmd;
        string err, name;
        
        public SQL() {
            cnx = new SqlConnection("Data Source=.;Initial Catalog=Presupuestos;Integrated Security=True");
            cnx.Open();
        }

        public string Comando(string a) {
            try {
                cmd = new SqlCommand(a, cnx);
                cmd.ExecuteNonQuery();
                err = "Completado";
            }
            catch (Exception ex) {
                err = "Error" + ex.ToString();
            }

            return err;
        }

        public void LlenarDataGrid(string a) {
            dap = new SqlDataAdapter(a, cnx);
        }

        public string LlenarTextBox(string a) {
            cmd = new SqlCommand(a, cnx);
            dar = cmd.ExecuteReader();

            if (dar.Read() == true) {
                name = dar["Nombre"].ToString();
            }

            return name;
        }
    }
}

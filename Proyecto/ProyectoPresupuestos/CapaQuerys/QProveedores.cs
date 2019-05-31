using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaSQL;

namespace CapaQuerys {
    public class QProveedores {
        SQL csql = new SQL();
        public DataTable dat;
        string query, err, name;

        public string InsertarProveedores(int a, string b) {
            query = "insert into Proveedores values(" + a + ",'" + b + "')";
            err = csql.Comando(query);

            return err;
        }

        public string ActualizarProveedores(int a, string b) {
            query = "update Proveedores set nombre = '" + b + "' where ProveedorId = " + a;
            err = csql.Comando(query);

            return err;
        }

        public string BorrarProveedores(int a) {
            query = "delete Proveedores where ProveedorId = " + a;
            err = csql.Comando(query);

            return err;
        }

        public void LlenarProveedores() {
            query = "select ProveedorId as Codigo, Nombre from Proveedores";
            csql.LlenarDataGrid(query);
            dat = new DataTable();
            csql.dap.Fill(dat);
        }

        public string LlenarNombre(int a) {
            query = "select Nombre from Proveedores where ProveedorId = " + a;
            name = csql.LlenarTextBox(query);

            return name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaSQL;

namespace CapaQuerys {
    public class QEmpresas {
        SQL csql = new SQL();
        public DataTable dat;
        string query, err, name;

        public string InsertarEmpresas(int a, string b) {
            query = "insert into Empresas values(" + a + ",'" + b + "')";
            err = csql.Comando(query);

            return err;
        }

        public string ActualizarEmpresas(int a, string b) {
            query = "update Empresas set nombre = '" + b + "' where EmpresaId = " + a;
            err = csql.Comando(query);

            return err;
        }

        public string BorrarEmpresas(int a) {
            query = "delete Empresas where EmpresaId = " + a;
            err = csql.Comando(query);

            return err;
        }

        public void LlenarEmpresas() {
            query = "select EmpresaId as Codigo, Nombre from Empresas";
            csql.LlenarDataGrid(query);
            dat = new DataTable();
            csql.dap.Fill(dat);
        }

        public string LlenarNombre(int a) {
            query = "select Nombre from Empresas where EmpresaId  = " + a;
            name = csql.LlenarTextBox(query);

            return name;
        }
    }
}

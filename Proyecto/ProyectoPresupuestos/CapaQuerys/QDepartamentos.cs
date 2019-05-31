using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaSQL;

namespace CapaQuerys {
    public class QDepartamentos {
        SQL csql = new SQL();
        public DataTable dat;
        string query, err, name;

        public string InsertarDepartamentos(int a, string b) {
            query = "insert into Departamentos values(" + a + ",'" + b + "')";
            err = csql.Comando(query);

            return err;
        }

        public string ActualizarDepartamentos(int a, string b) {
            query = "update Departamentos set nombre = '" + b + "' where DepartamentoId = " + a;
            err = csql.Comando(query);

            return err;
        }

        public string BorrarDepartamentos(int a) {
            query = "delete Departamentos where DepartamentoId = " + a;
            err = csql.Comando(query);

            return err;
        }

        public void LlenarDepartamentos() {
            query = "select DepartamentoId as Codigo, Nombre from Departamentos";
            csql.LlenarDataGrid(query);
            dat = new DataTable();
            csql.dap.Fill(dat);
        }
        
        public string LLenarNombre(int a) {
            query = "select Nombre from Departamentos where DepartamentoId = " + a;
            name = csql.LlenarTextBox(query);

            return name;
        }
    }
}

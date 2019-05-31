using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaSQL;

namespace CapaQuerys {
    public class QUsuarios {
        SQL csql = new SQL();
        public DataTable dat;
        string query, err, name;

        public string InsertarUsuarios(int a, string b) {
            query = "insert into Usuarios values(" + a + ",'" + b + "')";
            err = csql.Comando(query);

            return err;
        }

        public string ActualizarUsuarios(int a, string b) {
            query = "update Usuarios set nombre = '" + b + "' where UsuarioId = " + a;
            err = csql.Comando(query);

            return err;
        }

        public string BorrarUsuarios(int a) {
            query = "delete Usuarios where UsuarioId = " + a;
            err = csql.Comando(query);

            return err;
        }

        public void LlenarUsuarios() {
            query = "select UsuarioId as Codigo, Nombre from Usuarios";
            csql.LlenarDataGrid(query);
            dat = new DataTable();
            csql.dap.Fill(dat);
        }

        public string LlenarNombre(int a) {
            query = "select Nombre from Usuarios where UsuarioId = " + a;
            name = csql.LlenarTextBox(query);

            return name;
        }
    }
}

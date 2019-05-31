using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaQuerys;

namespace CapaPresupuestos {
    public partial class Presupuestos : Form {
        public Presupuestos() {
            InitializeComponent();
        }

        private void UsuarioId_TextChanged(object sender, EventArgs e) {
            QUsuarios qus = new QUsuarios();

            try {
                int a = int.Parse(UsuarioId.Text);
                UsuarioNombre.Text = qus.LlenarNombre(a);
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }

        private void DepartamentoId_TextChanged(object sender, EventArgs e) {
            QDepartamentos qdp = new QDepartamentos();

            int a = int.Parse(DepartamentoId.Text);
            DepartamentoNombre.Text = qdp.LLenarNombre(a);
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void EmpresaId_TextChanged(object sender, EventArgs e) {
            QEmpresas qem = new QEmpresas();

            int a = int.Parse(EmpresaId.Text);
            EmpresaNombre.Text = qem.LlenarNombre(a);
        }

        private void ProveedorId_TextChanged(object sender, EventArgs e) {
            QProveedores qpr = new QProveedores();

            int a = int.Parse(ProveedorId.Text);
            ProveedorNombre.Text = qpr.LlenarNombre(a);
        }
    }
}

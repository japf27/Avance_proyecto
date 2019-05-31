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
    public partial class Empresas : Form {
        public Empresas() {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e) {
            try {
                QEmpresas qem = new QEmpresas();

                int a = int.Parse(EmpresaId.Text);
                string b = EmpresaNombre.Text;

                MessageBox.Show(qem.InsertarEmpresas(a, b));
                qem.LlenarEmpresas();
                EmpresasData.DataSource = qem.dat;

                EmpresaId.Clear();
                EmpresaNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }

        private void Empresas_Load(object sender, EventArgs e) {
            QEmpresas qem = new QEmpresas();

            qem.LlenarEmpresas();
            EmpresasData.DataSource = qem.dat;
        }

        private void Actualizar_Click(object sender, EventArgs e) {
            try {
                QEmpresas qem = new QEmpresas();

                int a = int.Parse(EmpresaId.Text);
                string b = EmpresaNombre.Text;

                MessageBox.Show(qem.ActualizarEmpresas(a, b));
                qem.LlenarEmpresas();
                EmpresasData.DataSource = qem.dat;

                EmpresaId.Clear();
                EmpresaNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }

        private void Borrar_Click(object sender, EventArgs e) {
            try {
                QEmpresas qem = new QEmpresas();

                int a = int.Parse(EmpresaId.Text);
                string b = EmpresaNombre.Text;

                MessageBox.Show(qem.BorrarEmpresas(a));
                qem.LlenarEmpresas();
                EmpresasData.DataSource = qem.dat;

                EmpresaId.Clear();
                EmpresaNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }
    }
}

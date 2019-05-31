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
    public partial class Departamentos : Form {
        public Departamentos() {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e) {
            try {
                QDepartamentos qdp = new QDepartamentos();

                int a = int.Parse(DepartamentoId.Text);
                string b = DepartamentoNombre.Text;

                MessageBox.Show(qdp.InsertarDepartamentos(a, b));
                qdp.LlenarDepartamentos();
                DepartamentosData.DataSource = qdp.dat;

                DepartamentoId.Clear();
                DepartamentoNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }

        private void Departamentos_Load(object sender, EventArgs e) {
            QDepartamentos qdp = new QDepartamentos();

            qdp.LlenarDepartamentos();
            DepartamentosData.DataSource = qdp.dat;
        }

        private void Actualizar_Click(object sender, EventArgs e) {
            try {
                QDepartamentos qdp = new QDepartamentos();

                int a = int.Parse(DepartamentoId.Text);
                string b = DepartamentoNombre.Text;

                MessageBox.Show(qdp.ActualizarDepartamentos(a, b));
                qdp.LlenarDepartamentos();
                DepartamentosData.DataSource = qdp.dat;

                DepartamentoId.Clear();
                DepartamentoNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }

        private void Borrar_Click(object sender, EventArgs e) {
            try {
                QDepartamentos qdp = new QDepartamentos();

                int a = int.Parse(DepartamentoId.Text);
                string b = DepartamentoNombre.Text;

                MessageBox.Show(qdp.BorrarDepartamentos(a));
                qdp.LlenarDepartamentos();
                DepartamentosData.DataSource = qdp.dat;

                DepartamentoId.Clear();
                DepartamentoNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }
    }
}

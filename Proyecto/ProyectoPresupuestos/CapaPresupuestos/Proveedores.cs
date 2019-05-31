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
    public partial class Proveedores : Form {
        public Proveedores() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                QProveedores qpr = new QProveedores();

                int a = int.Parse(ProveedorId.Text);
                string b = ProveedorNombre.Text;

                MessageBox.Show(qpr.InsertarProveedores(a, b));
                qpr.LlenarProveedores();
                ProveedoresData.DataSource = qpr.dat;

                ProveedorId.Clear();
                ProveedorNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }

        private void Proveedores_Load(object sender, EventArgs e) {
            QProveedores qpr = new QProveedores();

            qpr.LlenarProveedores();
            ProveedoresData.DataSource = qpr.dat;
        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void Borrar_Click(object sender, EventArgs e) {
            try {
                QProveedores qpr = new QProveedores();

                int a = int.Parse(ProveedorId.Text);
                string b = ProveedorNombre.Text;

                MessageBox.Show(qpr.BorrarProveedores(a));
                qpr.LlenarProveedores();
                ProveedoresData.DataSource = qpr.dat;

                ProveedorId.Clear();
                ProveedorNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }

        private void Actualizar_Click(object sender, EventArgs e) {
            try {
                QProveedores qpr = new QProveedores();

                int a = int.Parse(ProveedorId.Text);
                string b = ProveedorNombre.Text;

                MessageBox.Show(qpr.ActualizarProveedores(a, b));
                qpr.LlenarProveedores();
                ProveedoresData.DataSource = qpr.dat;

                ProveedorId.Clear();
                ProveedorNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }
    }
}

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
    public partial class Usuarios : Form {
        public Usuarios() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void UsuariosIngresar_Click(object sender, EventArgs e) {
            try {
                QUsuarios qus = new QUsuarios();

                int a = int.Parse(UsuarioId.Text);
                string b = UsuarioNombre.Text;

                MessageBox.Show(qus.InsertarUsuarios(a, b));
                qus.LlenarUsuarios();
                UsuariosData.DataSource = qus.dat;

                UsuarioId.Clear();
                UsuarioNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }

        private void Usuarios_Load(object sender, EventArgs e) {
            QUsuarios qus = new QUsuarios();

            qus.LlenarUsuarios();
            UsuariosData.DataSource = qus.dat;
        }

        private void Actualizar_Click(object sender, EventArgs e) {
            try {
                QUsuarios qus = new QUsuarios();

                int a = int.Parse(UsuarioId.Text);
                string b = UsuarioNombre.Text;

                MessageBox.Show(qus.ActualizarUsuarios(a, b));
                qus.LlenarUsuarios();
                UsuariosData.DataSource = qus.dat;

                UsuarioId.Clear();
                UsuarioNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }

        private void Borrar_Click(object sender, EventArgs e) {
            try {
                QUsuarios qus = new QUsuarios();

                int a = int.Parse(UsuarioId.Text);
                string b = UsuarioNombre.Text;

                MessageBox.Show(qus.BorrarUsuarios(a));
                qus.LlenarUsuarios();
                UsuariosData.DataSource = qus.dat;

                UsuarioId.Clear();
                UsuarioNombre.Clear();
            }
            catch (Exception ex) {
                string err = "Error " + ex.ToString();
                MessageBox.Show(err);
            }
        }
    }
}

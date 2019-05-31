using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresupuestos {
    public partial class iPresupuestos : Form {
        private int childFormNumber = 0;

        public iPresupuestos() {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e) {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK) {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e) {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e) {
            foreach (Form childForm in MdiChildren) {
                childForm.Close();
            }
        }

        private void iPresupuestos_Load(object sender, EventArgs e) {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e) {
            Usuarios us = new Usuarios();
            us.MdiParent = this;
            us.Show();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void borrarProveedorToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e) {
            Proveedores pr = new Proveedores();
            pr.MdiParent = this;
            pr.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e) {
            Departamentos dp = new Departamentos();
            dp.MdiParent = this;
            dp.Show();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e) {
            Empresas em = new Empresas();
            em.MdiParent = this;
            em.Show();
        }

        private void presupuestosToolStripMenuItem_Click(object sender, EventArgs e) {
            Presupuestos ps = new Presupuestos();
            ps.MdiParent = this;
            ps.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

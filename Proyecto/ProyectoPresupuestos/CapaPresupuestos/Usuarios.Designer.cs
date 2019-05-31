namespace CapaPresupuestos {
    partial class Usuarios {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.UsuariosData = new System.Windows.Forms.DataGridView();
            this.UsuariosRegistros = new System.Windows.Forms.GroupBox();
            this.Borrar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Ingresar = new System.Windows.Forms.Button();
            this.UsuarioNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UsuarioId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosData)).BeginInit();
            this.UsuariosRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsuariosData
            // 
            this.UsuariosData.AllowUserToAddRows = false;
            this.UsuariosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosData.Location = new System.Drawing.Point(12, 12);
            this.UsuariosData.Name = "UsuariosData";
            this.UsuariosData.RowHeadersVisible = false;
            this.UsuariosData.Size = new System.Drawing.Size(310, 206);
            this.UsuariosData.TabIndex = 0;
            // 
            // UsuariosRegistros
            // 
            this.UsuariosRegistros.Controls.Add(this.Borrar);
            this.UsuariosRegistros.Controls.Add(this.Actualizar);
            this.UsuariosRegistros.Controls.Add(this.Ingresar);
            this.UsuariosRegistros.Location = new System.Drawing.Point(328, 12);
            this.UsuariosRegistros.Name = "UsuariosRegistros";
            this.UsuariosRegistros.Size = new System.Drawing.Size(87, 107);
            this.UsuariosRegistros.TabIndex = 1;
            this.UsuariosRegistros.TabStop = false;
            this.UsuariosRegistros.Text = "Acciones";
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(6, 77);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 4;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(5, 48);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 3;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(5, 19);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Ingresar.TabIndex = 2;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.UsuariosIngresar_Click);
            // 
            // UsuarioNombre
            // 
            this.UsuarioNombre.Location = new System.Drawing.Point(67, 250);
            this.UsuarioNombre.Name = "UsuarioNombre";
            this.UsuarioNombre.Size = new System.Drawing.Size(255, 20);
            this.UsuarioNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // UsuarioId
            // 
            this.UsuarioId.Location = new System.Drawing.Point(67, 224);
            this.UsuarioId.Name = "UsuarioId";
            this.UsuarioId.Size = new System.Drawing.Size(65, 20);
            this.UsuarioId.TabIndex = 1;
            this.UsuarioId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UsuarioId";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsuarioId);
            this.Controls.Add(this.UsuariosRegistros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuarioNombre);
            this.Controls.Add(this.UsuariosData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosData)).EndInit();
            this.UsuariosRegistros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsuariosData;
        private System.Windows.Forms.GroupBox UsuariosRegistros;
        private System.Windows.Forms.TextBox UsuarioId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.TextBox UsuarioNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Actualizar;
    }
}


namespace CapaPresupuestos {
    partial class Empresas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresas));
            this.EmpresasData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Borrar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.Ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpresaId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpresaNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpresasData
            // 
            this.EmpresasData.AllowUserToAddRows = false;
            this.EmpresasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpresasData.Location = new System.Drawing.Point(12, 12);
            this.EmpresasData.Name = "EmpresasData";
            this.EmpresasData.RowHeadersVisible = false;
            this.EmpresasData.Size = new System.Drawing.Size(310, 206);
            this.EmpresasData.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Borrar);
            this.groupBox1.Controls.Add(this.Actualizar);
            this.groupBox1.Controls.Add(this.Ingresar);
            this.groupBox1.Location = new System.Drawing.Point(328, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 107);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(6, 77);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 2;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(6, 48);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 1;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Ingresar
            // 
            this.Ingresar.Location = new System.Drawing.Point(6, 19);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(75, 23);
            this.Ingresar.TabIndex = 0;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "EmpresaId";
            // 
            // EmpresaId
            // 
            this.EmpresaId.Location = new System.Drawing.Point(72, 224);
            this.EmpresaId.Name = "EmpresaId";
            this.EmpresaId.Size = new System.Drawing.Size(65, 20);
            this.EmpresaId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // EmpresaNombre
            // 
            this.EmpresaNombre.Location = new System.Drawing.Point(72, 250);
            this.EmpresaNombre.Name = "EmpresaNombre";
            this.EmpresaNombre.Size = new System.Drawing.Size(250, 20);
            this.EmpresaNombre.TabIndex = 6;
            // 
            // Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 282);
            this.Controls.Add(this.EmpresaNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmpresaId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EmpresasData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Empresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Empresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpresasData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmpresasData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpresaId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmpresaNombre;
    }
}
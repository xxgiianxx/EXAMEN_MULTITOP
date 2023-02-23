
namespace CapaPresentacion
{
    partial class FrmModulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminaEmpresa = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgDatos = new System.Windows.Forms.DataGridView();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarDireccion = new System.Windows.Forms.Button();
            this.btnEliminaDireccion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.icons8_por_nueva_copia_25;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(12, 35);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 38);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.BackColor = System.Drawing.Color.Transparent;
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabar.Image = global::CapaPresentacion.Properties.Resources.icons8_floppy_disk_25;
            this.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrabar.Location = new System.Drawing.Point(164, 35);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(115, 38);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGrabar.UseVisualStyleBackColor = false;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEliminaEmpresa
            // 
            this.btnEliminaEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminaEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminaEmpresa.Image = global::CapaPresentacion.Properties.Resources.icons8_remove_properties_25;
            this.btnEliminaEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminaEmpresa.Location = new System.Drawing.Point(335, 35);
            this.btnEliminaEmpresa.Name = "btnEliminaEmpresa";
            this.btnEliminaEmpresa.Size = new System.Drawing.Size(141, 38);
            this.btnEliminaEmpresa.TabIndex = 2;
            this.btnEliminaEmpresa.Text = "Eliminar Empresa";
            this.btnEliminaEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminaEmpresa.UseVisualStyleBackColor = false;
            this.btnEliminaEmpresa.Click += new System.EventHandler(this.btnEliminaEmpresa_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsulta.Image = global::CapaPresentacion.Properties.Resources.icons8_search_file_25;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(524, 35);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(132, 38);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Modo Consulta";
            this.btnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = global::CapaPresentacion.Properties.Resources.icons8_cerrar_ventana_35;
            this.btnSalir.Location = new System.Drawing.Point(636, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(29, 25);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbInactivo);
            this.groupBox1.Controls.Add(this.rbActivo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRuc);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 161);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de una Empresa";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(240, 115);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(78, 19);
            this.rbInactivo.TabIndex = 8;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "INACTIVO";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Location = new System.Drawing.Point(144, 117);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(66, 19);
            this.rbActivo.TabIndex = 7;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "ACTIVO";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "ESTADO:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(144, 52);
            this.txtRuc.MaxLength = 11;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(138, 23);
            this.txtRuc.TabIndex = 5;
            this.txtRuc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuc_KeyPress);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(144, 78);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(500, 23);
            this.txtRazonSocial.TabIndex = 4;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(144, 23);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAZON SOCIAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgDatos);
            this.groupBox2.Location = new System.Drawing.Point(12, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 230);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direccion de la empresa";
            // 
            // DgDatos
            // 
            this.DgDatos.AllowUserToAddRows = false;
            this.DgDatos.AllowUserToDeleteRows = false;
            this.DgDatos.AllowUserToResizeColumns = false;
            this.DgDatos.AllowUserToResizeRows = false;
            this.DgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Direccion,
            this.Dirección});
            this.DgDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgDatos.Location = new System.Drawing.Point(3, 19);
            this.DgDatos.Name = "DgDatos";
            this.DgDatos.RowHeadersVisible = false;
            this.DgDatos.RowTemplate.Height = 25;
            this.DgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgDatos.Size = new System.Drawing.Size(650, 208);
            this.DgDatos.TabIndex = 0;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "#";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 50;
            // 
            // Dirección
            // 
            this.Dirección.DataPropertyName = "DIRECCION";
            this.Dirección.HeaderText = "DIRECCION";
            this.Dirección.Name = "Dirección";
            this.Dirección.Width = 596;
            // 
            // btnAgregarDireccion
            // 
            this.btnAgregarDireccion.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarDireccion.Image = global::CapaPresentacion.Properties.Resources.icons8_añadir_18;
            this.btnAgregarDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarDireccion.Location = new System.Drawing.Point(15, 255);
            this.btnAgregarDireccion.Name = "btnAgregarDireccion";
            this.btnAgregarDireccion.Size = new System.Drawing.Size(134, 29);
            this.btnAgregarDireccion.TabIndex = 7;
            this.btnAgregarDireccion.Text = "Agregar Dirección";
            this.btnAgregarDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarDireccion.UseVisualStyleBackColor = false;
            this.btnAgregarDireccion.Click += new System.EventHandler(this.btnAgregarDireccion_Click);
            // 
            // btnEliminaDireccion
            // 
            this.btnEliminaDireccion.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminaDireccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminaDireccion.Image = global::CapaPresentacion.Properties.Resources.icons8_menos_18;
            this.btnEliminaDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminaDireccion.Location = new System.Drawing.Point(164, 255);
            this.btnEliminaDireccion.Name = "btnEliminaDireccion";
            this.btnEliminaDireccion.Size = new System.Drawing.Size(134, 29);
            this.btnEliminaDireccion.TabIndex = 8;
            this.btnEliminaDireccion.Text = "Eliminar Dirección";
            this.btnEliminaDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminaDireccion.UseVisualStyleBackColor = false;
            this.btnEliminaDireccion.Click += new System.EventHandler(this.btnEliminaDireccion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 29);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(4, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "REGISTRO EMPRESAS";
            // 
            // FrmModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 538);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminaDireccion);
            this.Controls.Add(this.btnAgregarDireccion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnEliminaEmpresa);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModulo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminaEmpresa;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgDatos;
        private System.Windows.Forms.Button btnAgregarDireccion;
        private System.Windows.Forms.Button btnEliminaDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dirección;
    }
}
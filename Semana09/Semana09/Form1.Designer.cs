namespace Semana09
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnCargaMasiva = new System.Windows.Forms.Button();
            this.ofdCargaMasiva = new System.Windows.Forms.OpenFileDialog();
            this.btnCargaMasivaLocal = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAccesoAleatorio = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAmaterno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApaterno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(149, 261);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 26);
            this.txtTelefono.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Telefono";
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Location = new System.Drawing.Point(149, 204);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(401, 26);
            this.txtAmaterno.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "A. Materno";
            // 
            // txtApaterno
            // 
            this.txtApaterno.Location = new System.Drawing.Point(149, 153);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(401, 26);
            this.txtApaterno.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "A. Paterno";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(149, 101);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(401, 26);
            this.txtNombres.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombres";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(149, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRES,
            this.A_PATERNO,
            this.A_MATERNO,
            this.TELEFONO});
            this.dgvLista.Location = new System.Drawing.Point(47, 369);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowTemplate.Height = 28;
            this.dgvLista.Size = new System.Drawing.Size(569, 293);
            this.dgvLista.TabIndex = 1;
            this.dgvLista.DoubleClick += new System.EventHandler(this.dgvLista_DoubleClick);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            // 
            // A_PATERNO
            // 
            this.A_PATERNO.HeaderText = "A_PATERNO";
            this.A_PATERNO.Name = "A_PATERNO";
            this.A_PATERNO.ReadOnly = true;
            // 
            // A_MATERNO
            // 
            this.A_MATERNO.HeaderText = "A_MATERNO";
            this.A_MATERNO.Name = "A_MATERNO";
            this.A_MATERNO.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(637, 36);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(171, 29);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(637, 78);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(171, 29);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCargaMasiva
            // 
            this.btnCargaMasiva.Location = new System.Drawing.Point(637, 128);
            this.btnCargaMasiva.Name = "btnCargaMasiva";
            this.btnCargaMasiva.Size = new System.Drawing.Size(171, 29);
            this.btnCargaMasiva.TabIndex = 2;
            this.btnCargaMasiva.Text = "Carga Masiva";
            this.btnCargaMasiva.UseVisualStyleBackColor = true;
            this.btnCargaMasiva.Click += new System.EventHandler(this.btnCargaMasiva_Click);
            // 
            // ofdCargaMasiva
            // 
            this.ofdCargaMasiva.FileName = "openFileDialog1";
            // 
            // btnCargaMasivaLocal
            // 
            this.btnCargaMasivaLocal.Location = new System.Drawing.Point(637, 189);
            this.btnCargaMasivaLocal.Name = "btnCargaMasivaLocal";
            this.btnCargaMasivaLocal.Size = new System.Drawing.Size(171, 29);
            this.btnCargaMasivaLocal.TabIndex = 3;
            this.btnCargaMasivaLocal.Text = "Carga Masiva Local";
            this.btnCargaMasivaLocal.UseVisualStyleBackColor = true;
            this.btnCargaMasivaLocal.Click += new System.EventHandler(this.btnCargaMasivaLocal_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(637, 249);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(171, 29);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(637, 297);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 29);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAccesoAleatorio
            // 
            this.btnAccesoAleatorio.Location = new System.Drawing.Point(637, 353);
            this.btnAccesoAleatorio.Name = "btnAccesoAleatorio";
            this.btnAccesoAleatorio.Size = new System.Drawing.Size(171, 29);
            this.btnAccesoAleatorio.TabIndex = 4;
            this.btnAccesoAleatorio.Text = "STOP";
            this.btnAccesoAleatorio.UseVisualStyleBackColor = true;
            this.btnAccesoAleatorio.Click += new System.EventHandler(this.btnAccesoAleatorio_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(637, 406);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(171, 220);
            this.txtResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 683);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnAccesoAleatorio);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargaMasivaLocal);
            this.Controls.Add(this.btnCargaMasiva);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Semana09";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnCargaMasiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.OpenFileDialog ofdCargaMasiva;
        private System.Windows.Forms.Button btnCargaMasivaLocal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAccesoAleatorio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtResultado;
    }
}


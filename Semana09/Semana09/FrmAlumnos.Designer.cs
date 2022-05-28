namespace Semana09
{
    partial class FrmAlumnos
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.A_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
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
            this.dgvLista.Location = new System.Drawing.Point(39, 59);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowTemplate.Height = 28;
            this.dgvLista.Size = new System.Drawing.Size(569, 293);
            this.dgvLista.TabIndex = 2;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvLista);
            this.Name = "FrmAlumnos";
            this.Text = "FrmAlumnos";
            this.Load += new System.EventHandler(this.FrmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn A_MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.Button button1;
    }
}
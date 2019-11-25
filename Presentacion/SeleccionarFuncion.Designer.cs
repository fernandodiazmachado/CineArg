namespace Presentacion
{
    partial class SeleccionarFuncion
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
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.comprar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombrePelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaProy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asientosDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboTipoSala = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comprar,
            this.nombrePelicula,
            this.tipoSala,
            this.costo,
            this.idioma,
            this.fechaProy,
            this.asientosDisp});
            this.dgvFunciones.Location = new System.Drawing.Point(31, 135);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.Size = new System.Drawing.Size(728, 262);
            this.dgvFunciones.TabIndex = 0;
            // 
            // comprar
            // 
            this.comprar.DataPropertyName = "comprar";
            this.comprar.HeaderText = "Comprar";
            this.comprar.Name = "comprar";
            this.comprar.Width = 70;
            // 
            // nombrePelicula
            // 
            this.nombrePelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrePelicula.DataPropertyName = "nombrePelicula";
            this.nombrePelicula.HeaderText = "Pelicula";
            this.nombrePelicula.Name = "nombrePelicula";
            this.nombrePelicula.ReadOnly = true;
            this.nombrePelicula.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombrePelicula.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tipoSala
            // 
            this.tipoSala.DataPropertyName = "tipoSala";
            this.tipoSala.HeaderText = "Tipo Sala";
            this.tipoSala.Name = "tipoSala";
            this.tipoSala.ReadOnly = true;
            this.tipoSala.Width = 80;
            // 
            // costo
            // 
            this.costo.DataPropertyName = "costo";
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            this.costo.Width = 70;
            // 
            // idioma
            // 
            this.idioma.DataPropertyName = "idioma";
            this.idioma.HeaderText = "Idioma";
            this.idioma.Name = "idioma";
            this.idioma.ReadOnly = true;
            // 
            // fechaProy
            // 
            this.fechaProy.DataPropertyName = "fechaProy";
            this.fechaProy.HeaderText = "Fecha";
            this.fechaProy.Name = "fechaProy";
            this.fechaProy.ReadOnly = true;
            // 
            // asientosDisp
            // 
            this.asientosDisp.DataPropertyName = "asientosDisp";
            this.asientosDisp.HeaderText = "Asientos Disp.";
            this.asientosDisp.Name = "asientosDisp";
            this.asientosDisp.ReadOnly = true;
            // 
            // cboPelicula
            // 
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(87, 12);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(244, 21);
            this.cboPelicula.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(87, 49);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 2;
            // 
            // cboTipoSala
            // 
            this.cboTipoSala.FormattingEnabled = true;
            this.cboTipoSala.Location = new System.Drawing.Point(87, 86);
            this.cboTipoSala.Name = "cboTipoSala";
            this.cboTipoSala.Size = new System.Drawing.Size(121, 21);
            this.cboTipoSala.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo Sala";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(256, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(676, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(83, 28);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.Location = new System.Drawing.Point(224, 51);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(107, 17);
            this.chkFecha.TabIndex = 9;
            this.chkFecha.Text = "Todas las fechas";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // SeleccionarFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoSala);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.dgvFunciones);
            this.Name = "SeleccionarFuncion";
            this.Text = "Comprar";
            this.Load += new System.EventHandler(this.SeleccionarFuncion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunciones;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboTipoSala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn comprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSala;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaProy;
        private System.Windows.Forms.DataGridViewTextBoxColumn asientosDisp;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox chkFecha;
    }
}
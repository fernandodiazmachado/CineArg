namespace Presentacion
{
    partial class AltaFuncion
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPelicula = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboIdioma = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pelicula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sala";
            // 
            // cboPelicula
            // 
            this.cboPelicula.FormattingEnabled = true;
            this.cboPelicula.Location = new System.Drawing.Point(117, 33);
            this.cboPelicula.Name = "cboPelicula";
            this.cboPelicula.Size = new System.Drawing.Size(229, 21);
            this.cboPelicula.TabIndex = 3;
            this.cboPelicula.SelectedIndexChanged += new System.EventHandler(this.cboPelicula_SelectedIndexChanged);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(238, 211);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(108, 28);
            this.btnGrabar.TabIndex = 6;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd-MM-yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(117, 142);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(99, 20);
            this.dtpFecha.TabIndex = 8;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cboSala
            // 
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(117, 73);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(229, 21);
            this.cboSala.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Idioma";
            // 
            // cboIdioma
            // 
            this.cboIdioma.FormattingEnabled = true;
            this.cboIdioma.Location = new System.Drawing.Point(117, 110);
            this.cboIdioma.Name = "cboIdioma";
            this.cboIdioma.Size = new System.Drawing.Size(229, 21);
            this.cboIdioma.TabIndex = 11;
            this.cboIdioma.SelectedIndexChanged += new System.EventHandler(this.cboIdioma_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hora";
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "HH:mm";
            this.dtpHora.DataBindings.Add(new System.Windows.Forms.Binding("ShowUpDown", global::Presentacion.Properties.Settings.Default, "HoraBoton", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHora.Location = new System.Drawing.Point(117, 174);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = global::Presentacion.Properties.Settings.Default.HoraBoton;
            this.dtpHora.Size = new System.Drawing.Size(99, 20);
            this.dtpHora.TabIndex = 12;
            this.dtpHora.ValueChanged += new System.EventHandler(this.dtpHora_ValueChanged);
            // 
            // AltaFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 251);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.cboIdioma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.cboPelicula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "AltaFuncion";
            this.Text = "AltaFuncion";
            this.Load += new System.EventHandler(this.AltaFuncion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPelicula;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboSala;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboIdioma;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label5;
    }
}
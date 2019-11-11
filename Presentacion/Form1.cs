﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Pelicula pelicula = new Pelicula();
                pelicula.Nombre = txtNombre.Text;
                pelicula.TiempoDesde = dtpDesde.Value;
                pelicula.TiempoHasta = dtpHasta.Value;

                string mensaje = Pelicula.Agregar(pelicula);
                MessageBox.Show(mensaje);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Validar()
        {
            bool ok = true;

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El nombre de la pelicula no puede estar vacio.");
                ok = false;
            }

            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta.");
                ok = false;
            }

            return ok;

        }
    }
}
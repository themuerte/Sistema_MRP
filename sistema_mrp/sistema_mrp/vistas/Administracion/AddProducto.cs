﻿using sistema_mrp.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace sistema_mrp.vistas.Administracion
{
    public partial class AddProducto : Form
    {
        Administracion padre;
        public AddProducto(Administracion padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void AddProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if(mtbPrecio.Text == "" || mtbUnidades.Text == "" || tbNombre.Text == "")
            {
                MessageBox.Show(this, "Campos Vacíos");
            }
            else
            {
                try
                {
                    double precio = double.Parse(mtbPrecio.Text);
                    int unidades = int.Parse(mtbUnidades.Text);
                    string nombre = tbNombre.Text;
                    string descripcion = tbDescripcion.Text;
                    Producto.AddProducto(new Producto(nombre, descripcion, precio, unidades));
                    padre.recargarTablaProductos();
                    this.Dispose();
                }
                catch (Exception except)
                {
                    MessageBox.Show(this,"" + except.Message);

                }
                


            }
            
        }

    }
}

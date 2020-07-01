﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_mrp.controlador;

namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    public partial class modelo_P : Form
    {
        Producto productoSeleccionado;
        public modelo_P()
        {
            InitializeComponent();
            cargarProductosTabla();
        }

        private void cargarProductosTabla()
        {
            Trucazos.vaciarDataGridView(dgvProductos);
            List<Object[]> productos = Producto.GetProductosCorto();
            if (productos.Count > 0)
            {
                foreach (Object[] producto in productos)
                {
                    dgvProductos.Rows.Add(producto);
                }
            }

        }

        void getSelectedRB_Click(object sender, EventArgs e)
        {
            if (rdr_dias.Checked == true)
            {
                lbl_demanda.Text = "Demanda Diaria:";
            }
            else if (rdr_mensual.Checked == true)
            {
                lbl_demanda.Text = "Demanda Mensual:";
            }
            else if (rdr_semanal.Checked == true)
            {
                lbl_demanda.Text = "Demanda Semanal:";
            }
            else if (rdr_anual.Checked == true)
            {
                lbl_demanda.Text = "Demanda Anual:";
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            txt_z.Enabled = true;
            txt_cantidadOptima.Enabled = true;
            txt_desvEstandarDem.Enabled = true;

            if (txt_demandaP.Text == "" || txt_plazoEntrega.Text == "" || txt_periodoRevi.Text == "" || txt_desviacion.Text==""||txt_probabilidadDemanda.Text==""||txt_inventarioAct.Text=="")
            {
                MessageBox.Show("Verifique los datos", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                if (rdr_dias.Checked == true)
                {
                    //Diaria
                    lbl_demanda.Text = "Demanda Diaria:";
                    Modelo_P modelo = new Modelo_P(Convert.ToInt32(txt_demandaP.Text), Convert.ToDouble(txt_plazoEntrega.Text), Convert.ToDouble(txt_periodoRevi.Text),
                    Convert.ToDouble(txt_desviacion.Text), Convert.ToDouble(txt_probabilidadDemanda.Text), Convert.ToInt32(txt_inventarioAct.Text), Convert.ToDouble(txt_demandaP.Text));

                    txt_z.Text = modelo.get_z();
                    txt_desvEstandarDem.Text = modelo.get_desviacionDemanda();
                    txt_cantidadOptima.Text = modelo.get_cantidadOptima();

                }
                else if (rdr_mensual.Checked == true)
                {
                    //Mensual
                    lbl_demanda.Text = "Demanda Mensual:";
                    Modelo_P modelo = new Modelo_P(Convert.ToInt32(txt_demandaP.Text) / 30, Convert.ToDouble(txt_plazoEntrega.Text), Convert.ToDouble(txt_periodoRevi.Text),
                    Convert.ToDouble(txt_desviacion.Text), Convert.ToDouble(txt_probabilidadDemanda.Text), Convert.ToInt32(txt_inventarioAct.Text), Convert.ToDouble(txt_demandaP.Text));

                    txt_z.Text = modelo.get_z();
                    txt_desvEstandarDem.Text = modelo.get_desviacionDemanda();
                    txt_cantidadOptima.Text = modelo.get_cantidadOptima();
                }
                else if (rdr_semanal.Checked == true)
                {
                    //Semanal
                    lbl_demanda.Text = "Demanda Semanal:";
                    Modelo_P modelo = new Modelo_P(Convert.ToInt32(txt_demandaP.Text) / 7, Convert.ToDouble(txt_plazoEntrega.Text), Convert.ToDouble(txt_periodoRevi.Text),
                    Convert.ToDouble(txt_desviacion.Text), Convert.ToDouble(txt_probabilidadDemanda.Text), Convert.ToInt32(txt_inventarioAct.Text), Convert.ToDouble(txt_demandaP.Text));

                    txt_z.Text = modelo.get_z();
                    txt_desvEstandarDem.Text = modelo.get_desviacionDemanda();
                    txt_cantidadOptima.Text = modelo.get_cantidadOptima();
                }
                else if (rdr_anual.Checked == true)
                {
                    //Anual
                    Modelo_P modelo = new Modelo_P(Convert.ToInt32(txt_demandaP.Text) / 360, Convert.ToDouble(txt_plazoEntrega.Text), Convert.ToDouble(txt_periodoRevi.Text),
                    Convert.ToDouble(txt_desviacion.Text), Convert.ToDouble(txt_probabilidadDemanda.Text), Convert.ToInt32(txt_inventarioAct.Text), Convert.ToDouble(txt_demandaP.Text));

                    txt_z.Text = modelo.get_z();
                    txt_desvEstandarDem.Text = modelo.get_desviacionDemanda();
                    txt_cantidadOptima.Text = modelo.get_cantidadOptima();
                }
            }
            



        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                try
                {
                    int index = dgvProductos.SelectedRows[0].Index;
                    int idProducto = int.Parse(dgvProductos.Rows[index].Cells[0].Value.ToString());
                    productoSeleccionado = Producto.GetProductoById(idProducto);
                    if (productoSeleccionado.isValid())
                    {
                        
                        Modelo_P modelo = new Modelo_P((int)productoSeleccionado.DemandaDiaria, productoSeleccionado.PlazoEntregaDias, productoSeleccionado.PeriodoRevision, productoSeleccionado.DesviacionDemanda, productoSeleccionado.ProbabilidadDemanda, (int)productoSeleccionado.InventarioInicial, productoSeleccionado.DemandaDiaria);

                        txt_z.Text = modelo.get_z();
                        txt_desvEstandarDem.Text = modelo.get_desviacionDemanda();
                        txt_cantidadOptima.Text = modelo.get_cantidadOptima();
                    }
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            // seleccionar un producto
        }
    }
}

﻿namespace sistema_mrp.vistas.Administracion
{
    partial class AddProducto
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
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lNombreComponente = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(88, 133);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(169, 20);
            this.tbDescripcion.TabIndex = 33;
            this.tbDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescripcion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Descripción:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(88, 95);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(169, 20);
            this.tbNombre.TabIndex = 30;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // lNombreComponente
            // 
            this.lNombreComponente.AutoSize = true;
            this.lNombreComponente.Location = new System.Drawing.Point(12, 98);
            this.lNombreComponente.Name = "lNombreComponente";
            this.lNombreComponente.Size = new System.Drawing.Size(50, 13);
            this.lNombreComponente.TabIndex = 28;
            this.lNombreComponente.Text = "Nombre: ";
            this.lNombreComponente.Click += new System.EventHandler(this.lNombreComponente_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(78, 184);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 23);
            this.btnAddProduct.TabIndex = 34;
            this.btnAddProduct.Text = "Nuevo Producto";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ingrese el nuevo producto:";
            // 
            // AddProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lNombreComponente);
            this.Name = "AddProducto";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lNombreComponente;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label2;
    }
}
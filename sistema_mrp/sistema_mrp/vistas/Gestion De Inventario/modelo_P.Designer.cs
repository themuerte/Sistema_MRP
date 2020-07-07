﻿namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    partial class modelo_P
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_demanda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_demandaP = new System.Windows.Forms.TextBox();
            this.txt_plazoEntrega = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cantidadOptima = new System.Windows.Forms.TextBox();
            this.txt_desvEstandarDem = new System.Windows.Forms.TextBox();
            this.txt_z = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_periodoRevi = new System.Windows.Forms.TextBox();
            this.rdr_dias = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdr_semanal = new System.Windows.Forms.RadioButton();
            this.rdr_mensual = new System.Windows.Forms.RadioButton();
            this.rdr_anual = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_desviacion = new System.Windows.Forms.TextBox();
            this.txt_probabilidadDemanda = new System.Windows.Forms.TextBox();
            this.txt_inventarioAct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbModeloP = new System.Windows.Forms.TabControl();
            this.tpDatosNuevos = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpProducto = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModeloP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbNumeroPeriodos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bUpdateChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tbModeloP.SuspendLayout();
            this.tpDatosNuevos.SuspendLayout();
            this.tpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cModeloP)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos";
            // 
            // lbl_demanda
            // 
            this.lbl_demanda.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_demanda.Location = new System.Drawing.Point(24, 110);
            this.lbl_demanda.Name = "lbl_demanda";
            this.lbl_demanda.Size = new System.Drawing.Size(200, 21);
            this.lbl_demanda.TabIndex = 3;
            this.lbl_demanda.Text = "Demanda:";
            this.lbl_demanda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plazo de entrega(días):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Desviación:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Probabilidad de cumplir la demanda:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_demandaP
            // 
            this.txt_demandaP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_demandaP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_demandaP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_demandaP.Location = new System.Drawing.Point(229, 111);
            this.txt_demandaP.Name = "txt_demandaP";
            this.txt_demandaP.Size = new System.Drawing.Size(100, 14);
            this.txt_demandaP.TabIndex = 8;
            // 
            // txt_plazoEntrega
            // 
            this.txt_plazoEntrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_plazoEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_plazoEntrega.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plazoEntrega.Location = new System.Drawing.Point(229, 145);
            this.txt_plazoEntrega.Name = "txt_plazoEntrega";
            this.txt_plazoEntrega.Size = new System.Drawing.Size(100, 14);
            this.txt_plazoEntrega.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(616, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cantidad óptima de pedir:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(874, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 14);
            this.label10.TabIndex = 14;
            this.label10.Text = "Desviación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(475, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 14);
            this.label11.TabIndex = 13;
            this.label11.Text = "Z:";
            // 
            // txt_cantidadOptima
            // 
            this.txt_cantidadOptima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_cantidadOptima.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cantidadOptima.Enabled = false;
            this.txt_cantidadOptima.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadOptima.Location = new System.Drawing.Point(765, 49);
            this.txt_cantidadOptima.Name = "txt_cantidadOptima";
            this.txt_cantidadOptima.Size = new System.Drawing.Size(100, 14);
            this.txt_cantidadOptima.TabIndex = 18;
            // 
            // txt_desvEstandarDem
            // 
            this.txt_desvEstandarDem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_desvEstandarDem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_desvEstandarDem.Enabled = false;
            this.txt_desvEstandarDem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desvEstandarDem.Location = new System.Drawing.Point(946, 49);
            this.txt_desvEstandarDem.Name = "txt_desvEstandarDem";
            this.txt_desvEstandarDem.Size = new System.Drawing.Size(100, 14);
            this.txt_desvEstandarDem.TabIndex = 17;
            // 
            // txt_z
            // 
            this.txt_z.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_z.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_z.Enabled = false;
            this.txt_z.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_z.Location = new System.Drawing.Point(498, 49);
            this.txt_z.Name = "txt_z";
            this.txt_z.Size = new System.Drawing.Size(100, 14);
            this.txt_z.TabIndex = 16;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btn_calcular.FlatAppearance.BorderSize = 0;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(114, 298);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 25);
            this.btn_calcular.TabIndex = 19;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(218, 298);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_limpiar.Size = new System.Drawing.Size(75, 25);
            this.btn_limpiar.TabIndex = 20;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Periodo de revisión (días):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_periodoRevi
            // 
            this.txt_periodoRevi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_periodoRevi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_periodoRevi.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_periodoRevi.Location = new System.Drawing.Point(228, 179);
            this.txt_periodoRevi.Name = "txt_periodoRevi";
            this.txt_periodoRevi.Size = new System.Drawing.Size(100, 14);
            this.txt_periodoRevi.TabIndex = 10;
            // 
            // rdr_dias
            // 
            this.rdr_dias.AutoSize = true;
            this.rdr_dias.Location = new System.Drawing.Point(18, 19);
            this.rdr_dias.Name = "rdr_dias";
            this.rdr_dias.Size = new System.Drawing.Size(52, 17);
            this.rdr_dias.TabIndex = 24;
            this.rdr_dias.TabStop = true;
            this.rdr_dias.Text = "Diaria";
            this.rdr_dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdr_dias.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(-15, -15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdr_semanal
            // 
            this.rdr_semanal.AutoSize = true;
            this.rdr_semanal.Location = new System.Drawing.Point(76, 19);
            this.rdr_semanal.Name = "rdr_semanal";
            this.rdr_semanal.Size = new System.Drawing.Size(66, 17);
            this.rdr_semanal.TabIndex = 26;
            this.rdr_semanal.TabStop = true;
            this.rdr_semanal.Text = "Semanal";
            this.rdr_semanal.UseVisualStyleBackColor = true;
            // 
            // rdr_mensual
            // 
            this.rdr_mensual.AutoSize = true;
            this.rdr_mensual.Location = new System.Drawing.Point(157, 21);
            this.rdr_mensual.Name = "rdr_mensual";
            this.rdr_mensual.Size = new System.Drawing.Size(65, 17);
            this.rdr_mensual.TabIndex = 27;
            this.rdr_mensual.TabStop = true;
            this.rdr_mensual.Text = "Mensual";
            this.rdr_mensual.UseVisualStyleBackColor = true;
            // 
            // rdr_anual
            // 
            this.rdr_anual.AutoSize = true;
            this.rdr_anual.Location = new System.Drawing.Point(233, 20);
            this.rdr_anual.Name = "rdr_anual";
            this.rdr_anual.Size = new System.Drawing.Size(52, 17);
            this.rdr_anual.TabIndex = 28;
            this.rdr_anual.TabStop = true;
            this.rdr_anual.Text = "Anual";
            this.rdr_anual.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdr_dias);
            this.groupBox1.Controls.Add(this.rdr_anual);
            this.groupBox1.Controls.Add(this.rdr_semanal);
            this.groupBox1.Controls.Add(this.rdr_mensual);
            this.groupBox1.Location = new System.Drawing.Point(71, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 50);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de demanda";
            // 
            // txt_desviacion
            // 
            this.txt_desviacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_desviacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_desviacion.Location = new System.Drawing.Point(229, 232);
            this.txt_desviacion.Name = "txt_desviacion";
            this.txt_desviacion.Size = new System.Drawing.Size(100, 13);
            this.txt_desviacion.TabIndex = 30;
            // 
            // txt_probabilidadDemanda
            // 
            this.txt_probabilidadDemanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_probabilidadDemanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_probabilidadDemanda.Location = new System.Drawing.Point(229, 262);
            this.txt_probabilidadDemanda.Name = "txt_probabilidadDemanda";
            this.txt_probabilidadDemanda.Size = new System.Drawing.Size(100, 13);
            this.txt_probabilidadDemanda.TabIndex = 31;
            // 
            // txt_inventarioAct
            // 
            this.txt_inventarioAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_inventarioAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_inventarioAct.Location = new System.Drawing.Point(230, 205);
            this.txt_inventarioAct.Name = "txt_inventarioAct";
            this.txt_inventarioAct.Size = new System.Drawing.Size(100, 13);
            this.txt_inventarioAct.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Inventario actual:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbModeloP
            // 
            this.tbModeloP.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbModeloP.Controls.Add(this.tpDatosNuevos);
            this.tbModeloP.Controls.Add(this.tpProducto);
            this.tbModeloP.HotTrack = true;
            this.tbModeloP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbModeloP.Location = new System.Drawing.Point(28, 35);
            this.tbModeloP.Multiline = true;
            this.tbModeloP.Name = "tbModeloP";
            this.tbModeloP.SelectedIndex = 0;
            this.tbModeloP.Size = new System.Drawing.Size(406, 380);
            this.tbModeloP.TabIndex = 34;
            // 
            // tpDatosNuevos
            // 
            this.tpDatosNuevos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tpDatosNuevos.Controls.Add(this.label17);
            this.tpDatosNuevos.Controls.Add(this.label16);
            this.tpDatosNuevos.Controls.Add(this.label15);
            this.tpDatosNuevos.Controls.Add(this.label14);
            this.tpDatosNuevos.Controls.Add(this.label13);
            this.tpDatosNuevos.Controls.Add(this.label3);
            this.tpDatosNuevos.Controls.Add(this.txt_demandaP);
            this.tpDatosNuevos.Controls.Add(this.txt_inventarioAct);
            this.tpDatosNuevos.Controls.Add(this.label2);
            this.tpDatosNuevos.Controls.Add(this.label4);
            this.tpDatosNuevos.Controls.Add(this.lbl_demanda);
            this.tpDatosNuevos.Controls.Add(this.txt_probabilidadDemanda);
            this.tpDatosNuevos.Controls.Add(this.label5);
            this.tpDatosNuevos.Controls.Add(this.txt_desviacion);
            this.tpDatosNuevos.Controls.Add(this.label6);
            this.tpDatosNuevos.Controls.Add(this.groupBox1);
            this.tpDatosNuevos.Controls.Add(this.label7);
            this.tpDatosNuevos.Controls.Add(this.label8);
            this.tpDatosNuevos.Controls.Add(this.txt_plazoEntrega);
            this.tpDatosNuevos.Controls.Add(this.btn_limpiar);
            this.tpDatosNuevos.Controls.Add(this.txt_periodoRevi);
            this.tpDatosNuevos.Controls.Add(this.btn_calcular);
            this.tpDatosNuevos.Location = new System.Drawing.Point(23, 4);
            this.tpDatosNuevos.Name = "tpDatosNuevos";
            this.tpDatosNuevos.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosNuevos.Size = new System.Drawing.Size(379, 372);
            this.tpDatosNuevos.TabIndex = 0;
            this.tpDatosNuevos.Text = "Datos Nuevos";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Location = new System.Drawing.Point(227, 194);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 1);
            this.label17.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Location = new System.Drawing.Point(229, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 1);
            this.label16.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Location = new System.Drawing.Point(230, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 1);
            this.label15.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(230, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 1);
            this.label14.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Location = new System.Drawing.Point(230, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 1);
            this.label13.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(230, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 1);
            this.label3.TabIndex = 40;
            // 
            // tpProducto
            // 
            this.tpProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tpProducto.Controls.Add(this.dgvProductos);
            this.tpProducto.Location = new System.Drawing.Point(23, 4);
            this.tpProducto.Name = "tpProducto";
            this.tpProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducto.Size = new System.Drawing.Size(379, 372);
            this.tpProducto.TabIndex = 1;
            this.tpProducto.Text = "Producto Existente";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.descripcion});
            this.dgvProductos.Location = new System.Drawing.Point(21, 37);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(336, 264);
            this.dgvProductos.TabIndex = 2;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // cModeloP
            // 
            chartArea2.Name = "ChartArea1";
            this.cModeloP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cModeloP.Legends.Add(legend2);
            this.cModeloP.Location = new System.Drawing.Point(478, 96);
            this.cModeloP.Name = "cModeloP";
            this.cModeloP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.cModeloP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Inventario";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "QOptimo";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Inv, Prom.";
            this.cModeloP.Series.Add(series4);
            this.cModeloP.Series.Add(series5);
            this.cModeloP.Series.Add(series6);
            this.cModeloP.Size = new System.Drawing.Size(585, 370);
            this.cModeloP.TabIndex = 35;
            this.cModeloP.Text = "Modelo P";
            title2.Name = "Title1";
            title2.Text = "Modelo P";
            this.cModeloP.Titles.Add(title2);
            // 
            // tbNumeroPeriodos
            // 
            this.tbNumeroPeriodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbNumeroPeriodos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNumeroPeriodos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroPeriodos.Location = new System.Drawing.Point(179, 433);
            this.tbNumeroPeriodos.Name = "tbNumeroPeriodos";
            this.tbNumeroPeriodos.Size = new System.Drawing.Size(112, 14);
            this.tbNumeroPeriodos.TabIndex = 37;
            this.tbNumeroPeriodos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroPeriodos_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 14);
            this.label12.TabIndex = 36;
            this.label12.Text = "Número de períodos:";
            // 
            // bUpdateChart
            // 
            this.bUpdateChart.AutoSize = true;
            this.bUpdateChart.BackColor = System.Drawing.Color.Transparent;
            this.bUpdateChart.FlatAppearance.BorderSize = 0;
            this.bUpdateChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdateChart.Image = global::sistema_mrp.Properties.Resources.refresh;
            this.bUpdateChart.Location = new System.Drawing.Point(294, 427);
            this.bUpdateChart.Margin = new System.Windows.Forms.Padding(0);
            this.bUpdateChart.Name = "bUpdateChart";
            this.bUpdateChart.Size = new System.Drawing.Size(33, 24);
            this.bUpdateChart.TabIndex = 38;
            this.bUpdateChart.UseVisualStyleBackColor = false;
            this.bUpdateChart.Click += new System.EventHandler(this.bUpdateChart_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(179, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 1);
            this.label1.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Location = new System.Drawing.Point(765, 63);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 2);
            this.label18.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Location = new System.Drawing.Point(947, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 2);
            this.label19.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Location = new System.Drawing.Point(498, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 2);
            this.label20.TabIndex = 42;
            // 
            // modelo_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1075, 500);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bUpdateChart);
            this.Controls.Add(this.tbNumeroPeriodos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cModeloP);
            this.Controls.Add(this.tbModeloP);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.txt_cantidadOptima);
            this.Controls.Add(this.txt_desvEstandarDem);
            this.Controls.Add(this.txt_z);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modelo_P";
            this.Load += new System.EventHandler(this.modelo_P_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbModeloP.ResumeLayout(false);
            this.tpDatosNuevos.ResumeLayout(false);
            this.tpDatosNuevos.PerformLayout();
            this.tpProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cModeloP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_demanda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_demandaP;
        private System.Windows.Forms.TextBox txt_plazoEntrega;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cantidadOptima;
        private System.Windows.Forms.TextBox txt_desvEstandarDem;
        private System.Windows.Forms.TextBox txt_z;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_periodoRevi;
        private System.Windows.Forms.RadioButton rdr_dias;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdr_semanal;
        private System.Windows.Forms.RadioButton rdr_mensual;
        private System.Windows.Forms.RadioButton rdr_anual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_desviacion;
        private System.Windows.Forms.TextBox txt_probabilidadDemanda;
        private System.Windows.Forms.TextBox txt_inventarioAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tbModeloP;
        private System.Windows.Forms.TabPage tpDatosNuevos;
        private System.Windows.Forms.TabPage tpProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataVisualization.Charting.Chart cModeloP;
        private System.Windows.Forms.TextBox tbNumeroPeriodos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bUpdateChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}
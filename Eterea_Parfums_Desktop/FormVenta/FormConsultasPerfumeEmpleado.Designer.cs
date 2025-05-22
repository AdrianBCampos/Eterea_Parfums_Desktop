namespace Eterea_Parfums_Desktop
{
    partial class FormConsultasPerfumeEmpleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.txt_scan = new System.Windows.Forms.TextBox();
            this.lbl_codigoBarras = new System.Windows.Forms.Label();
            this.btn_escanear = new System.Windows.Forms.Button();
            this.dataGridViewConsultas = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_filtro_articulos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_filtro_aroma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_posterior = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.lbl_paginacion_Info = new System.Windows.Forms.Label();
            this.lbl_numero_pagina = new System.Windows.Forms.Label();
            this.lbl_filtro_genero = new System.Windows.Forms.Label();
            this.combo_filtro_genero = new System.Windows.Forms.ComboBox();
            this.lbl_filtro_marca = new System.Windows.Forms.Label();
            this.combo_filtro_marca = new System.Windows.Forms.ComboBox();
            this.lbl_filtro_nombre = new System.Windows.Forms.Label();
            this.txt_filtro_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            this.SuspendLayout();
            // 
            // img_logo
            // 
            this.img_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.img_logo.Location = new System.Drawing.Point(13, 11);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(182, 195);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 375;
            this.img_logo.TabStop = false;
            // 
            // txt_scan
            // 
            this.txt_scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_scan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_scan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_scan.Location = new System.Drawing.Point(340, 641);
            this.txt_scan.Name = "txt_scan";
            this.txt_scan.Size = new System.Drawing.Size(219, 32);
            this.txt_scan.TabIndex = 393;
            // 
            // lbl_codigoBarras
            // 
            this.lbl_codigoBarras.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.lbl_codigoBarras.AutoSize = true;
            this.lbl_codigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_codigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_codigoBarras.Location = new System.Drawing.Point(55, 642);
            this.lbl_codigoBarras.Name = "lbl_codigoBarras";
            this.lbl_codigoBarras.Size = new System.Drawing.Size(246, 29);
            this.lbl_codigoBarras.TabIndex = 392;
            this.lbl_codigoBarras.Text = "ESCANEAR AHORA";
            // 
            // btn_escanear
            // 
            this.btn_escanear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_escanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_escanear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_escanear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_escanear.Location = new System.Drawing.Point(194, 638);
            this.btn_escanear.Name = "btn_escanear";
            this.btn_escanear.Size = new System.Drawing.Size(241, 37);
            this.btn_escanear.TabIndex = 400;
            this.btn_escanear.Text = "Escanear";
            this.btn_escanear.UseVisualStyleBackColor = false;
            this.btn_escanear.Click += new System.EventHandler(this.btn_escanear_Click);
            // 
            // dataGridViewConsultas
            // 
            this.dataGridViewConsultas.AllowUserToAddRows = false;
            this.dataGridViewConsultas.AllowUserToDeleteRows = false;
            this.dataGridViewConsultas.AllowUserToResizeColumns = false;
            this.dataGridViewConsultas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dataGridViewConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewConsultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewConsultas.ColumnHeadersHeight = 40;
            this.dataGridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.marca,
            this.Genero,
            this.precio,
            this.ver,
            this.agregar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConsultas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewConsultas.EnableHeadersVisualStyles = false;
            this.dataGridViewConsultas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dataGridViewConsultas.Location = new System.Drawing.Point(22, 220);
            this.dataGridViewConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewConsultas.Name = "dataGridViewConsultas";
            this.dataGridViewConsultas.ReadOnly = true;
            this.dataGridViewConsultas.RowHeadersWidth = 51;
            this.dataGridViewConsultas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewConsultas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewConsultas.RowTemplate.Height = 35;
            this.dataGridViewConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultas.Size = new System.Drawing.Size(1105, 387);
            this.dataGridViewConsultas.TabIndex = 384;
            this.dataGridViewConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsultas_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombre.FillWeight = 125F;
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre del perfume";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.Width = 469;
            // 
            // marca
            // 
            this.marca.FillWeight = 125F;
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            this.marca.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Genero
            // 
            this.Genero.FillWeight = 50F;
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.precio.FillWeight = 50F;
            this.precio.HeaderText = "Precio ($)";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.precio.Width = 109;
            // 
            // ver
            // 
            this.ver.FillWeight = 50F;
            this.ver.HeaderText = "";
            this.ver.MinimumWidth = 6;
            this.ver.Name = "ver";
            this.ver.ReadOnly = true;
            this.ver.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // agregar
            // 
            this.agregar.HeaderText = "";
            this.agregar.Name = "agregar";
            this.agregar.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.label3.Location = new System.Drawing.Point(829, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 398;
            this.label3.Text = "Mostrar:";
            // 
            // combo_filtro_articulos
            // 
            this.combo_filtro_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.combo_filtro_articulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_filtro_articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_filtro_articulos.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_filtro_articulos.FormattingEnabled = true;
            this.combo_filtro_articulos.Location = new System.Drawing.Point(901, 86);
            this.combo_filtro_articulos.Name = "combo_filtro_articulos";
            this.combo_filtro_articulos.Size = new System.Drawing.Size(214, 28);
            this.combo_filtro_articulos.TabIndex = 397;
            this.combo_filtro_articulos.SelectedIndexChanged += new System.EventHandler(this.combo_filtro_articulos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(852, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 396;
            this.label2.Text = "Filtrar por Aroma:";
            // 
            // combo_filtro_aroma
            // 
            this.combo_filtro_aroma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.combo_filtro_aroma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_filtro_aroma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_filtro_aroma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_filtro_aroma.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_filtro_aroma.FormattingEnabled = true;
            this.combo_filtro_aroma.Location = new System.Drawing.Point(856, 166);
            this.combo_filtro_aroma.Name = "combo_filtro_aroma";
            this.combo_filtro_aroma.Size = new System.Drawing.Size(250, 27);
            this.combo_filtro_aroma.TabIndex = 395;
            this.combo_filtro_aroma.SelectedIndexChanged += new System.EventHandler(this.combo_filtro_aroma_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(478, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 39);
            this.label1.TabIndex = 390;
            this.label1.Text = "Catálogo de Perfumes";
            // 
            // btn_posterior
            // 
            this.btn_posterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_posterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_posterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_posterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_posterior.Location = new System.Drawing.Point(1045, 639);
            this.btn_posterior.Name = "btn_posterior";
            this.btn_posterior.Size = new System.Drawing.Size(53, 33);
            this.btn_posterior.TabIndex = 388;
            this.btn_posterior.Text = ">>";
            this.btn_posterior.UseVisualStyleBackColor = false;
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_anterior.Location = new System.Drawing.Point(903, 639);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(53, 33);
            this.btn_anterior.TabIndex = 387;
            this.btn_anterior.Text = "<<";
            this.btn_anterior.UseVisualStyleBackColor = false;
            // 
            // lbl_paginacion_Info
            // 
            this.lbl_paginacion_Info.AutoSize = true;
            this.lbl_paginacion_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_paginacion_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paginacion_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_paginacion_Info.Location = new System.Drawing.Point(669, 646);
            this.lbl_paginacion_Info.Name = "lbl_paginacion_Info";
            this.lbl_paginacion_Info.Size = new System.Drawing.Size(134, 20);
            this.lbl_paginacion_Info.TabIndex = 386;
            this.lbl_paginacion_Info.Text = "Paginación Info";
            // 
            // lbl_numero_pagina
            // 
            this.lbl_numero_pagina.AutoSize = true;
            this.lbl_numero_pagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_numero_pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_pagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_numero_pagina.Location = new System.Drawing.Point(988, 644);
            this.lbl_numero_pagina.Name = "lbl_numero_pagina";
            this.lbl_numero_pagina.Size = new System.Drawing.Size(21, 24);
            this.lbl_numero_pagina.TabIndex = 385;
            this.lbl_numero_pagina.Text = "1";
            // 
            // lbl_filtro_genero
            // 
            this.lbl_filtro_genero.AutoSize = true;
            this.lbl_filtro_genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_filtro_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_filtro_genero.Location = new System.Drawing.Point(553, 144);
            this.lbl_filtro_genero.Name = "lbl_filtro_genero";
            this.lbl_filtro_genero.Size = new System.Drawing.Size(138, 20);
            this.lbl_filtro_genero.TabIndex = 382;
            this.lbl_filtro_genero.Text = "Filtrar por Género:";
            // 
            // combo_filtro_genero
            // 
            this.combo_filtro_genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.combo_filtro_genero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_filtro_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_filtro_genero.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_filtro_genero.FormattingEnabled = true;
            this.combo_filtro_genero.Location = new System.Drawing.Point(556, 166);
            this.combo_filtro_genero.Name = "combo_filtro_genero";
            this.combo_filtro_genero.Size = new System.Drawing.Size(250, 28);
            this.combo_filtro_genero.TabIndex = 381;
            this.combo_filtro_genero.SelectedIndexChanged += new System.EventHandler(this.combo_filtro_genero_SelectedIndexChanged);
            // 
            // lbl_filtro_marca
            // 
            this.lbl_filtro_marca.AutoSize = true;
            this.lbl_filtro_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_filtro_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_filtro_marca.Location = new System.Drawing.Point(230, 144);
            this.lbl_filtro_marca.Name = "lbl_filtro_marca";
            this.lbl_filtro_marca.Size = new System.Drawing.Size(128, 20);
            this.lbl_filtro_marca.TabIndex = 380;
            this.lbl_filtro_marca.Text = "Filtrar por Marca:";
            // 
            // combo_filtro_marca
            // 
            this.combo_filtro_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.combo_filtro_marca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_filtro_marca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_filtro_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_filtro_marca.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_filtro_marca.FormattingEnabled = true;
            this.combo_filtro_marca.Location = new System.Drawing.Point(233, 167);
            this.combo_filtro_marca.Name = "combo_filtro_marca";
            this.combo_filtro_marca.Size = new System.Drawing.Size(250, 27);
            this.combo_filtro_marca.TabIndex = 379;
            this.combo_filtro_marca.SelectedIndexChanged += new System.EventHandler(this.combo_filtro_marca_SelectedIndexChanged);
            // 
            // lbl_filtro_nombre
            // 
            this.lbl_filtro_nombre.AutoSize = true;
            this.lbl_filtro_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_filtro_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_filtro_nombre.Location = new System.Drawing.Point(232, 91);
            this.lbl_filtro_nombre.Name = "lbl_filtro_nombre";
            this.lbl_filtro_nombre.Size = new System.Drawing.Size(150, 20);
            this.lbl_filtro_nombre.TabIndex = 378;
            this.lbl_filtro_nombre.Text = "Buscar por Nombre:";
            // 
            // txt_filtro_nombre
            // 
            this.txt_filtro_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_filtro_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_filtro_nombre.Location = new System.Drawing.Point(388, 89);
            this.txt_filtro_nombre.Name = "txt_filtro_nombre";
            this.txt_filtro_nombre.Size = new System.Drawing.Size(312, 26);
            this.txt_filtro_nombre.TabIndex = 377;
            this.txt_filtro_nombre.TextChanged += new System.EventHandler(this.txt_filtro_nombre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(200, 132);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 75);
            this.pictureBox1.TabIndex = 376;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(200, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(872, 56);
            this.pictureBox3.TabIndex = 394;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(200, 71);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(934, 58);
            this.pictureBox4.TabIndex = 389;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(13, 623);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(601, 62);
            this.pictureBox5.TabIndex = 391;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(13, 211);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1122, 406);
            this.pictureBox2.TabIndex = 383;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Location = new System.Drawing.Point(618, 623);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(517, 62);
            this.pictureBox6.TabIndex = 399;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.pictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox17.Location = new System.Drawing.Point(4, 4);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(1142, 690);
            this.pictureBox17.TabIndex = 401;
            this.pictureBox17.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1078, 11);
            this.btn_close.Name = "btn_close";
            this.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_close.Size = new System.Drawing.Size(57, 56);
            this.btn_close.TabIndex = 402;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FormConsultasPerfumeEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1154, 700);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.txt_scan);
            this.Controls.Add(this.lbl_codigoBarras);
            this.Controls.Add(this.btn_escanear);
            this.Controls.Add(this.dataGridViewConsultas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_filtro_articulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_filtro_aroma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_posterior);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.lbl_paginacion_Info);
            this.Controls.Add(this.lbl_numero_pagina);
            this.Controls.Add(this.lbl_filtro_genero);
            this.Controls.Add(this.combo_filtro_genero);
            this.Controls.Add(this.lbl_filtro_marca);
            this.Controls.Add(this.combo_filtro_marca);
            this.Controls.Add(this.lbl_filtro_nombre);
            this.Controls.Add(this.txt_filtro_nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox17);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormConsultasPerfumeEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultasPerfumeEmpleado";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_logo;
        public System.Windows.Forms.TextBox txt_scan;
        public System.Windows.Forms.Label lbl_codigoBarras;
        public System.Windows.Forms.Button btn_escanear;
        private System.Windows.Forms.DataGridView dataGridViewConsultas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_filtro_articulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_filtro_aroma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_posterior;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Label lbl_paginacion_Info;
        private System.Windows.Forms.Label lbl_numero_pagina;
        private System.Windows.Forms.Label lbl_filtro_genero;
        private System.Windows.Forms.ComboBox combo_filtro_genero;
        private System.Windows.Forms.Label lbl_filtro_marca;
        private System.Windows.Forms.ComboBox combo_filtro_marca;
        private System.Windows.Forms.Label lbl_filtro_nombre;
        private System.Windows.Forms.TextBox txt_filtro_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewButtonColumn ver;
        private System.Windows.Forms.DataGridViewButtonColumn agregar;
    }
}
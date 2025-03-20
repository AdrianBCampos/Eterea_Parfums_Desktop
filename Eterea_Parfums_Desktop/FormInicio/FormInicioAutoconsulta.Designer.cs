namespace Eterea_Parfums_Desktop
{
    partial class FormInicioAutoconsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_filtro_genero = new System.Windows.Forms.Label();
            this.combo_filtro_genero = new System.Windows.Forms.ComboBox();
            this.lbl_filtro_marca = new System.Windows.Forms.Label();
            this.combo_filtro_marca = new System.Windows.Forms.ComboBox();
            this.lbl_filtro_nombre = new System.Windows.Forms.Label();
            this.txt_filtro_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_paginacion_Info = new System.Windows.Forms.Label();
            this.lbl_numero_pagina = new System.Windows.Forms.Label();
            this.dataGridViewConsultas = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_posterior = new System.Windows.Forms.Button();
            this.btn_escanear = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_codigoBarras = new System.Windows.Forms.Label();
            this.txt_scan = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_filtro_aroma = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_filtro_articulos = new System.Windows.Forms.ComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // img_logo
            // 
            this.img_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.img_logo.Location = new System.Drawing.Point(11, 6);
            this.img_logo.Margin = new System.Windows.Forms.Padding(4);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(275, 256);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 98;
            this.img_logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(293, 181);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1743, 81);
            this.pictureBox1.TabIndex = 280;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_filtro_genero
            // 
            this.lbl_filtro_genero.AutoSize = true;
            this.lbl_filtro_genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_filtro_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_genero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_filtro_genero.Location = new System.Drawing.Point(937, 190);
            this.lbl_filtro_genero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filtro_genero.Name = "lbl_filtro_genero";
            this.lbl_filtro_genero.Size = new System.Drawing.Size(169, 25);
            this.lbl_filtro_genero.TabIndex = 286;
            this.lbl_filtro_genero.Text = "Filtrar por Género:";
            // 
            // combo_filtro_genero
            // 
            this.combo_filtro_genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.combo_filtro_genero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_filtro_genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_filtro_genero.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_filtro_genero.FormattingEnabled = true;
            this.combo_filtro_genero.Location = new System.Drawing.Point(943, 219);
            this.combo_filtro_genero.Margin = new System.Windows.Forms.Padding(4);
            this.combo_filtro_genero.Name = "combo_filtro_genero";
            this.combo_filtro_genero.Size = new System.Drawing.Size(415, 33);
            this.combo_filtro_genero.TabIndex = 285;
            this.combo_filtro_genero.SelectedIndexChanged += new System.EventHandler(this.combo_filtro_genero_SelectedIndexChanged);
            // 
            // lbl_filtro_marca
            // 
            this.lbl_filtro_marca.AutoSize = true;
            this.lbl_filtro_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_filtro_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_marca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_filtro_marca.Location = new System.Drawing.Point(354, 190);
            this.lbl_filtro_marca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filtro_marca.Name = "lbl_filtro_marca";
            this.lbl_filtro_marca.Size = new System.Drawing.Size(159, 25);
            this.lbl_filtro_marca.TabIndex = 284;
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
            this.combo_filtro_marca.Location = new System.Drawing.Point(359, 219);
            this.combo_filtro_marca.Margin = new System.Windows.Forms.Padding(4);
            this.combo_filtro_marca.Name = "combo_filtro_marca";
            this.combo_filtro_marca.Size = new System.Drawing.Size(415, 31);
            this.combo_filtro_marca.TabIndex = 283;
            this.combo_filtro_marca.SelectedIndexChanged += new System.EventHandler(this.combo_filtro_marca_SelectedIndexChanged);
            // 
            // lbl_filtro_nombre
            // 
            this.lbl_filtro_nombre.AutoSize = true;
            this.lbl_filtro_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_filtro_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtro_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_filtro_nombre.Location = new System.Drawing.Point(378, 124);
            this.lbl_filtro_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_filtro_nombre.Name = "lbl_filtro_nombre";
            this.lbl_filtro_nombre.Size = new System.Drawing.Size(186, 25);
            this.lbl_filtro_nombre.TabIndex = 282;
            this.lbl_filtro_nombre.Text = "Buscar por Nombre:";
            // 
            // txt_filtro_nombre
            // 
            this.txt_filtro_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_filtro_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_filtro_nombre.Location = new System.Drawing.Point(593, 121);
            this.txt_filtro_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtro_nombre.Name = "txt_filtro_nombre";
            this.txt_filtro_nombre.Size = new System.Drawing.Size(534, 30);
            this.txt_filtro_nombre.TabIndex = 281;
            this.txt_filtro_nombre.TextChanged += new System.EventHandler(this.txt_filtro_nombre_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(11, 268);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2025, 663);
            this.pictureBox2.TabIndex = 287;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_paginacion_Info
            // 
            this.lbl_paginacion_Info.AutoSize = true;
            this.lbl_paginacion_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_paginacion_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paginacion_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_paginacion_Info.Location = new System.Drawing.Point(1110, 983);
            this.lbl_paginacion_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_paginacion_Info.Name = "lbl_paginacion_Info";
            this.lbl_paginacion_Info.Size = new System.Drawing.Size(161, 25);
            this.lbl_paginacion_Info.TabIndex = 292;
            this.lbl_paginacion_Info.Text = "Paginación Info";
            // 
            // lbl_numero_pagina
            // 
            this.lbl_numero_pagina.AutoSize = true;
            this.lbl_numero_pagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_numero_pagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_pagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_numero_pagina.Location = new System.Drawing.Point(1867, 982);
            this.lbl_numero_pagina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero_pagina.Name = "lbl_numero_pagina";
            this.lbl_numero_pagina.Size = new System.Drawing.Size(27, 29);
            this.lbl_numero_pagina.TabIndex = 291;
            this.lbl_numero_pagina.Text = "1";
            // 
            // dataGridViewConsultas
            // 
            this.dataGridViewConsultas.AllowUserToAddRows = false;
            this.dataGridViewConsultas.AllowUserToDeleteRows = false;
            this.dataGridViewConsultas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
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
            this.dataGridViewConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.marca,
            this.Genero,
            this.precio,
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
            this.dataGridViewConsultas.Location = new System.Drawing.Point(23, 280);
            this.dataGridViewConsultas.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewConsultas.Name = "dataGridViewConsultas";
            this.dataGridViewConsultas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewConsultas.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewConsultas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewConsultas.RowTemplate.Height = 35;
            this.dataGridViewConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsultas.Size = new System.Drawing.Size(2002, 640);
            this.dataGridViewConsultas.TabIndex = 288;
            this.dataGridViewConsultas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsultas_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.FillWeight = 125F;
            this.nombre.HeaderText = "Nombre del perfume";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.FillWeight = 125F;
            this.marca.HeaderText = "Marca";
            this.marca.MinimumWidth = 6;
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.FillWeight = 50F;
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.precio.FillWeight = 50F;
            this.precio.HeaderText = "Precio ($)";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 134;
            // 
            // agregar
            // 
            this.agregar.FillWeight = 50F;
            this.agregar.HeaderText = "";
            this.agregar.MinimumWidth = 6;
            this.agregar.Name = "agregar";
            this.agregar.ReadOnly = true;
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_anterior.Location = new System.Drawing.Point(1753, 976);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(71, 41);
            this.btn_anterior.TabIndex = 293;
            this.btn_anterior.Text = "<<";
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click);
            // 
            // btn_posterior
            // 
            this.btn_posterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_posterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_posterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_posterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_posterior.Location = new System.Drawing.Point(1942, 976);
            this.btn_posterior.Margin = new System.Windows.Forms.Padding(4);
            this.btn_posterior.Name = "btn_posterior";
            this.btn_posterior.Size = new System.Drawing.Size(71, 41);
            this.btn_posterior.TabIndex = 294;
            this.btn_posterior.Text = ">>";
            this.btn_posterior.UseVisualStyleBackColor = false;
            this.btn_posterior.Click += new System.EventHandler(this.btn_posterior_Click);
            // 
            // btn_escanear
            // 
            this.btn_escanear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_escanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_escanear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_escanear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_escanear.Location = new System.Drawing.Point(272, 966);
            this.btn_escanear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_escanear.Name = "btn_escanear";
            this.btn_escanear.Size = new System.Drawing.Size(509, 55);
            this.btn_escanear.TabIndex = 295;
            this.btn_escanear.Text = "Escanear";
            this.btn_escanear.UseVisualStyleBackColor = false;
            this.btn_escanear.Click += new System.EventHandler(this.btn_escanear_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(293, 94);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1743, 81);
            this.pictureBox4.TabIndex = 297;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.label1.Location = new System.Drawing.Point(923, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 51);
            this.label1.TabIndex = 298;
            this.label1.Text = "Catálogo de Perfumes";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(11, 937);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1010, 115);
            this.pictureBox5.TabIndex = 299;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_codigoBarras
            // 
            this.lbl_codigoBarras.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.lbl_codigoBarras.AutoSize = true;
            this.lbl_codigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_codigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_codigoBarras.Location = new System.Drawing.Point(102, 977);
            this.lbl_codigoBarras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigoBarras.Name = "lbl_codigoBarras";
            this.lbl_codigoBarras.Size = new System.Drawing.Size(311, 36);
            this.lbl_codigoBarras.TabIndex = 303;
            this.lbl_codigoBarras.Text = "ESCANEAR AHORA";
            // 
            // txt_scan
            // 
            this.txt_scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_scan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_scan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_scan.Location = new System.Drawing.Point(483, 976);
            this.txt_scan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_scan.Name = "txt_scan";
            this.txt_scan.Size = new System.Drawing.Size(479, 38);
            this.txt_scan.TabIndex = 304;
            this.txt_scan.TextChanged += new System.EventHandler(this.txt_scan_TextChanged);
            this.txt_scan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_scan_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(293, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1743, 81);
            this.pictureBox3.TabIndex = 305;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(1551, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 307;
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
            this.combo_filtro_aroma.Location = new System.Drawing.Point(1556, 221);
            this.combo_filtro_aroma.Margin = new System.Windows.Forms.Padding(4);
            this.combo_filtro_aroma.Name = "combo_filtro_aroma";
            this.combo_filtro_aroma.Size = new System.Drawing.Size(415, 31);
            this.combo_filtro_aroma.TabIndex = 306;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.label3.Location = new System.Drawing.Point(1306, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 25);
            this.label3.TabIndex = 309;
            this.label3.Text = "Mostrar todos los Articulos:";
            // 
            // combo_filtro_articulos
            // 
            this.combo_filtro_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.combo_filtro_articulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combo_filtro_articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_filtro_articulos.ForeColor = System.Drawing.SystemColors.Window;
            this.combo_filtro_articulos.FormattingEnabled = true;
            this.combo_filtro_articulos.Location = new System.Drawing.Point(1581, 121);
            this.combo_filtro_articulos.Margin = new System.Windows.Forms.Padding(4);
            this.combo_filtro_articulos.Name = "combo_filtro_articulos";
            this.combo_filtro_articulos.Size = new System.Drawing.Size(340, 33);
            this.combo_filtro_articulos.TabIndex = 308;
            this.combo_filtro_articulos.SelectedIndexChanged += new System.EventHandler(this.combo_filtro_articulos_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Location = new System.Drawing.Point(1026, 937);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1010, 115);
            this.pictureBox6.TabIndex = 310;
            this.pictureBox6.TabStop = false;
            // 
            // FormInicioAutoconsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(2048, 1063);
            this.Controls.Add(this.dataGridViewConsultas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combo_filtro_articulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_filtro_aroma);
            this.Controls.Add(this.txt_scan);
            this.Controls.Add(this.lbl_codigoBarras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_escanear);
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
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormInicioAutoconsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InicioAutoConsultas_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_filtro_genero;
        private System.Windows.Forms.ComboBox combo_filtro_genero;
        private System.Windows.Forms.Label lbl_filtro_marca;
        private System.Windows.Forms.ComboBox combo_filtro_marca;
        private System.Windows.Forms.Label lbl_filtro_nombre;
        private System.Windows.Forms.TextBox txt_filtro_nombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_paginacion_Info;
        private System.Windows.Forms.Label lbl_numero_pagina;
        private System.Windows.Forms.DataGridView dataGridViewConsultas;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_posterior;
        public System.Windows.Forms.Button btn_escanear;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.Label lbl_codigoBarras;
        public System.Windows.Forms.TextBox txt_scan;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_filtro_aroma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_filtro_articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewButtonColumn agregar;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}


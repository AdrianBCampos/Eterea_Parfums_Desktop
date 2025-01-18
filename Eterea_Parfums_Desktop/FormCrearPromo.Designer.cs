namespace Eterea_Parfums_Desktop
{
    partial class FormCrearPromo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_crear_promo = new System.Windows.Forms.Label();
            this.lbl_tipo_promo = new System.Windows.Forms.Label();
            this.lbl_nombre_promo = new System.Windows.Forms.Label();
            this.lbl_fecha_ini_promo = new System.Windows.Forms.Label();
            this.lbl_fecha_fin_promo = new System.Windows.Forms.Label();
            this.lbl_activo_promo = new System.Windows.Forms.Label();
            this.combo_tipo_promo = new System.Windows.Forms.ComboBox();
            this.combo_fecha_ini_promo = new System.Windows.Forms.ComboBox();
            this.combo_fecha_fin_promo = new System.Windows.Forms.ComboBox();
            this.combo_activo_promo = new System.Windows.Forms.ComboBox();
            this.txt_nomb_promo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_buscar_nomb = new System.Windows.Forms.Label();
            this.txt_buscar_nomb = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGrid_perfumes_agregados = new System.Windows.Forms.DataGridView();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion_ml = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_buscar_marca = new System.Windows.Forms.TextBox();
            this.lbl_buscar_marca = new System.Windows.Forms.Label();
            this.txt_buscar_genero = new System.Windows.Forms.TextBox();
            this.lbl_buscar_genero = new System.Windows.Forms.Label();
            this.btn_crear_promo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_titulo_agregar_perfume_a_promo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_perfumes_agregados)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(36, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 391);
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_crear_promo
            // 
            this.lbl_crear_promo.AutoSize = true;
            this.lbl_crear_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_crear_promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crear_promo.ForeColor = System.Drawing.Color.Black;
            this.lbl_crear_promo.Location = new System.Drawing.Point(31, 19);
            this.lbl_crear_promo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_crear_promo.Name = "lbl_crear_promo";
            this.lbl_crear_promo.Size = new System.Drawing.Size(218, 29);
            this.lbl_crear_promo.TabIndex = 101;
            this.lbl_crear_promo.Text = "Crear Promoción:";
            // 
            // lbl_tipo_promo
            // 
            this.lbl_tipo_promo.AutoSize = true;
            this.lbl_tipo_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_tipo_promo.Location = new System.Drawing.Point(44, 95);
            this.lbl_tipo_promo.Name = "lbl_tipo_promo";
            this.lbl_tipo_promo.Size = new System.Drawing.Size(143, 20);
            this.lbl_tipo_promo.TabIndex = 102;
            this.lbl_tipo_promo.Text = "Tipo de promoción:";
            // 
            // lbl_nombre_promo
            // 
            this.lbl_nombre_promo.AutoSize = true;
            this.lbl_nombre_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre_promo.Location = new System.Drawing.Point(44, 164);
            this.lbl_nombre_promo.Name = "lbl_nombre_promo";
            this.lbl_nombre_promo.Size = new System.Drawing.Size(69, 20);
            this.lbl_nombre_promo.TabIndex = 103;
            this.lbl_nombre_promo.Text = "Nombre:";
            // 
            // lbl_fecha_ini_promo
            // 
            this.lbl_fecha_ini_promo.AutoSize = true;
            this.lbl_fecha_ini_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_fecha_ini_promo.Location = new System.Drawing.Point(44, 238);
            this.lbl_fecha_ini_promo.Name = "lbl_fecha_ini_promo";
            this.lbl_fecha_ini_promo.Size = new System.Drawing.Size(119, 20);
            this.lbl_fecha_ini_promo.TabIndex = 104;
            this.lbl_fecha_ini_promo.Text = "Fecha de inicio:";
            // 
            // lbl_fecha_fin_promo
            // 
            this.lbl_fecha_fin_promo.AutoSize = true;
            this.lbl_fecha_fin_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_fecha_fin_promo.Location = new System.Drawing.Point(44, 324);
            this.lbl_fecha_fin_promo.Name = "lbl_fecha_fin_promo";
            this.lbl_fecha_fin_promo.Size = new System.Drawing.Size(162, 20);
            this.lbl_fecha_fin_promo.TabIndex = 105;
            this.lbl_fecha_fin_promo.Text = "Fecha de finalización:";
            // 
            // lbl_activo_promo
            // 
            this.lbl_activo_promo.AutoSize = true;
            this.lbl_activo_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_activo_promo.Location = new System.Drawing.Point(44, 403);
            this.lbl_activo_promo.Name = "lbl_activo_promo";
            this.lbl_activo_promo.Size = new System.Drawing.Size(52, 20);
            this.lbl_activo_promo.TabIndex = 106;
            this.lbl_activo_promo.Text = "Activo";
            // 
            // combo_tipo_promo
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(216, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 107;
            // 
            // combo_fecha_ini_promo
            // 
            this.combo_fecha_ini_promo.FormattingEnabled = true;
            this.combo_fecha_ini_promo.Location = new System.Drawing.Point(216, 238);
            this.combo_fecha_ini_promo.Name = "combo_fecha_ini_promo";
            this.combo_fecha_ini_promo.Size = new System.Drawing.Size(180, 28);
            this.combo_fecha_ini_promo.TabIndex = 108;
            // 
            // combo_fecha_fin_promo
            // 
            this.combo_fecha_fin_promo.FormattingEnabled = true;
            this.combo_fecha_fin_promo.Location = new System.Drawing.Point(216, 316);
            this.combo_fecha_fin_promo.Name = "combo_fecha_fin_promo";
            this.combo_fecha_fin_promo.Size = new System.Drawing.Size(180, 28);
            this.combo_fecha_fin_promo.TabIndex = 109;
            // 
            // combo_activo_promo
            // 
            this.combo_activo_promo.FormattingEnabled = true;
            this.combo_activo_promo.Location = new System.Drawing.Point(216, 395);
            this.combo_activo_promo.Name = "combo_activo_promo";
            this.combo_activo_promo.Size = new System.Drawing.Size(180, 28);
            this.combo_activo_promo.TabIndex = 110;
            // 
            // txt_nomb_promo
            // 
            this.txt_nomb_promo.Location = new System.Drawing.Point(216, 164);
            this.txt_nomb_promo.Name = "txt_nomb_promo";
            this.txt_nomb_promo.Size = new System.Drawing.Size(180, 26);
            this.txt_nomb_promo.TabIndex = 111;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(429, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 391);
            this.pictureBox2.TabIndex = 112;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_buscar_nomb
            // 
            this.lbl_buscar_nomb.AutoSize = true;
            this.lbl_buscar_nomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_buscar_nomb.Location = new System.Drawing.Point(444, 252);
            this.lbl_buscar_nomb.Name = "lbl_buscar_nomb";
            this.lbl_buscar_nomb.Size = new System.Drawing.Size(117, 20);
            this.lbl_buscar_nomb.TabIndex = 115;
            this.lbl_buscar_nomb.Text = "Buscar nombre";
            // 
            // txt_buscar_nomb
            // 
            this.txt_buscar_nomb.Location = new System.Drawing.Point(448, 290);
            this.txt_buscar_nomb.Name = "txt_buscar_nomb";
            this.txt_buscar_nomb.Size = new System.Drawing.Size(199, 26);
            this.txt_buscar_nomb.TabIndex = 116;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(682, 64);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(655, 391);
            this.pictureBox3.TabIndex = 119;
            this.pictureBox3.TabStop = false;
            // 
            // dataGrid_perfumes_agregados
            // 
            this.dataGrid_perfumes_agregados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_perfumes_agregados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_perfumes_agregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_perfumes_agregados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dataGrid_perfumes_agregados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_perfumes_agregados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_perfumes_agregados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_perfumes_agregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_perfumes_agregados.ColumnHeadersHeight = 24;
            this.dataGrid_perfumes_agregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Nombre,
            this.Presentacion_ml,
            this.Genero,
            this.Eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_perfumes_agregados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_perfumes_agregados.EnableHeadersVisualStyles = false;
            this.dataGrid_perfumes_agregados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dataGrid_perfumes_agregados.Location = new System.Drawing.Point(695, 77);
            this.dataGrid_perfumes_agregados.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_perfumes_agregados.Name = "dataGrid_perfumes_agregados";
            this.dataGrid_perfumes_agregados.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_perfumes_agregados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_perfumes_agregados.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid_perfumes_agregados.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_perfumes_agregados.RowTemplate.Height = 28;
            this.dataGrid_perfumes_agregados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid_perfumes_agregados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_perfumes_agregados.Size = new System.Drawing.Size(627, 366);
            this.dataGrid_perfumes_agregados.TabIndex = 222;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 8;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Presentacion_ml
            // 
            this.Presentacion_ml.HeaderText = "ml";
            this.Presentacion_ml.MinimumWidth = 8;
            this.Presentacion_ml.Name = "Presentacion_ml";
            this.Presentacion_ml.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 8;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 8;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // txt_buscar_marca
            // 
            this.txt_buscar_marca.Location = new System.Drawing.Point(448, 191);
            this.txt_buscar_marca.Name = "txt_buscar_marca";
            this.txt_buscar_marca.Size = new System.Drawing.Size(199, 26);
            this.txt_buscar_marca.TabIndex = 280;
            // 
            // lbl_buscar_marca
            // 
            this.lbl_buscar_marca.AutoSize = true;
            this.lbl_buscar_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_buscar_marca.Location = new System.Drawing.Point(444, 153);
            this.lbl_buscar_marca.Name = "lbl_buscar_marca";
            this.lbl_buscar_marca.Size = new System.Drawing.Size(107, 20);
            this.lbl_buscar_marca.TabIndex = 279;
            this.lbl_buscar_marca.Text = "Buscar marca";
            // 
            // txt_buscar_genero
            // 
            this.txt_buscar_genero.Location = new System.Drawing.Point(448, 396);
            this.txt_buscar_genero.Name = "txt_buscar_genero";
            this.txt_buscar_genero.Size = new System.Drawing.Size(199, 26);
            this.txt_buscar_genero.TabIndex = 282;
            // 
            // lbl_buscar_genero
            // 
            this.lbl_buscar_genero.AutoSize = true;
            this.lbl_buscar_genero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_buscar_genero.Location = new System.Drawing.Point(444, 358);
            this.lbl_buscar_genero.Name = "lbl_buscar_genero";
            this.lbl_buscar_genero.Size = new System.Drawing.Size(113, 20);
            this.lbl_buscar_genero.TabIndex = 281;
            this.lbl_buscar_genero.Text = "Buscar género";
            // 
            // btn_crear_promo
            // 
            this.btn_crear_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_crear_promo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_promo.Location = new System.Drawing.Point(1213, 472);
            this.btn_crear_promo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_crear_promo.Name = "btn_crear_promo";
            this.btn_crear_promo.Size = new System.Drawing.Size(124, 39);
            this.btn_crear_promo.TabIndex = 283;
            this.btn_crear_promo.Text = "Crear";
            this.btn_crear_promo.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1285, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(52, 49);
            this.button1.TabIndex = 295;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_titulo_agregar_perfume_a_promo
            // 
            this.lbl_titulo_agregar_perfume_a_promo.AutoSize = true;
            this.lbl_titulo_agregar_perfume_a_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_titulo_agregar_perfume_a_promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_agregar_perfume_a_promo.Location = new System.Drawing.Point(444, 85);
            this.lbl_titulo_agregar_perfume_a_promo.MaximumSize = new System.Drawing.Size(215, 50);
            this.lbl_titulo_agregar_perfume_a_promo.Name = "lbl_titulo_agregar_perfume_a_promo";
            this.lbl_titulo_agregar_perfume_a_promo.Size = new System.Drawing.Size(203, 40);
            this.lbl_titulo_agregar_perfume_a_promo.TabIndex = 296;
            this.lbl_titulo_agregar_perfume_a_promo.Text = "Asignar los perfumes de la promoción";
            this.lbl_titulo_agregar_perfume_a_promo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCrearPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1362, 525);
            this.Controls.Add(this.lbl_titulo_agregar_perfume_a_promo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_crear_promo);
            this.Controls.Add(this.txt_buscar_genero);
            this.Controls.Add(this.lbl_buscar_genero);
            this.Controls.Add(this.txt_buscar_marca);
            this.Controls.Add(this.lbl_buscar_marca);
            this.Controls.Add(this.dataGrid_perfumes_agregados);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_buscar_nomb);
            this.Controls.Add(this.lbl_buscar_nomb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_nomb_promo);
            this.Controls.Add(this.combo_activo_promo);
            this.Controls.Add(this.combo_fecha_fin_promo);
            this.Controls.Add(this.combo_fecha_ini_promo);
            this.Controls.Add(this.combo_tipo_promo);
            this.Controls.Add(this.lbl_activo_promo);
            this.Controls.Add(this.lbl_fecha_fin_promo);
            this.Controls.Add(this.lbl_fecha_ini_promo);
            this.Controls.Add(this.lbl_nombre_promo);
            this.Controls.Add(this.lbl_tipo_promo);
            this.Controls.Add(this.lbl_crear_promo);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FormCrearPromo";
            this.Text = "FormCrearPromo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_perfumes_agregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_crear_promo;
        private System.Windows.Forms.Label lbl_tipo_promo;
        private System.Windows.Forms.Label lbl_nombre_promo;
        private System.Windows.Forms.Label lbl_fecha_ini_promo;
        private System.Windows.Forms.Label lbl_fecha_fin_promo;
        private System.Windows.Forms.Label lbl_activo_promo;
        private System.Windows.Forms.ComboBox combo_tipo_promo;
        private System.Windows.Forms.ComboBox combo_fecha_ini_promo;
        private System.Windows.Forms.ComboBox combo_fecha_fin_promo;
        private System.Windows.Forms.ComboBox combo_activo_promo;
        private System.Windows.Forms.TextBox txt_nomb_promo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_buscar_nomb;
        private System.Windows.Forms.TextBox txt_buscar_nomb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGrid_perfumes_agregados;
        private System.Windows.Forms.TextBox txt_buscar_marca;
        private System.Windows.Forms.Label lbl_buscar_marca;
        private System.Windows.Forms.TextBox txt_buscar_genero;
        private System.Windows.Forms.Label lbl_buscar_genero;
        private System.Windows.Forms.Button btn_crear_promo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion_ml;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
        private System.Windows.Forms.Label lbl_titulo_agregar_perfume_a_promo;
    }
}
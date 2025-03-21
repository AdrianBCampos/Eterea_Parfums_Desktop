namespace Eterea_Parfums_Desktop
{
    partial class FormListaDeEnvios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.txt_nombre_empleado = new System.Windows.Forms.Label();
            this.lbl_responsable = new System.Windows.Forms.Label();
            this.lbl_lista_envios = new System.Windows.Forms.Label();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_cantitad_ordenes = new System.Windows.Forms.Label();
            this.lbl_cantidad_ordenes = new System.Windows.Forms.Label();
            this.lbl_numero_orden = new System.Windows.Forms.Label();
            this.txt_numero_orden = new System.Windows.Forms.Label();
            this.btn_imprimir_etiqueta = new System.Windows.Forms.Button();
            this.dataGridViewListaPedidos = new System.Windows.Forms.DataGridView();
            this.Norden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(796, 8);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(34, 32);
            this.button2.TabIndex = 93;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_consultas
            // 
            this.btn_consultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultas.Location = new System.Drawing.Point(644, 70);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(186, 32);
            this.btn_consultas.TabIndex = 299;
            this.btn_consultas.Text = "Ir a Consultas";
            this.btn_consultas.UseVisualStyleBackColor = false;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // txt_nombre_empleado
            // 
            this.txt_nombre_empleado.AutoSize = true;
            this.txt_nombre_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_nombre_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_empleado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nombre_empleado.Location = new System.Drawing.Point(206, 40);
            this.txt_nombre_empleado.Name = "txt_nombre_empleado";
            this.txt_nombre_empleado.Size = new System.Drawing.Size(243, 25);
            this.txt_nombre_empleado.TabIndex = 298;
            this.txt_nombre_empleado.Text = "Nombre del Empleado";
            // 
            // lbl_responsable
            // 
            this.lbl_responsable.AutoSize = true;
            this.lbl_responsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_responsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_responsable.ForeColor = System.Drawing.Color.Black;
            this.lbl_responsable.Location = new System.Drawing.Point(102, 46);
            this.lbl_responsable.Name = "lbl_responsable";
            this.lbl_responsable.Size = new System.Drawing.Size(111, 18);
            this.lbl_responsable.TabIndex = 297;
            this.lbl_responsable.Text = "Responsable:";
            // 
            // lbl_lista_envios
            // 
            this.lbl_lista_envios.AutoSize = true;
            this.lbl_lista_envios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_lista_envios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista_envios.ForeColor = System.Drawing.Color.Black;
            this.lbl_lista_envios.Location = new System.Drawing.Point(102, 15);
            this.lbl_lista_envios.Name = "lbl_lista_envios";
            this.lbl_lista_envios.Size = new System.Drawing.Size(218, 18);
            this.lbl_lista_envios.TabIndex = 296;
            this.lbl_lista_envios.Text = "Lista de envios a despachar";
            // 
            // img_logo
            // 
            this.img_logo.Location = new System.Drawing.Point(10, 8);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(86, 86);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 295;
            this.img_logo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(9, 115);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(822, 54);
            this.pictureBox3.TabIndex = 303;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(10, 174);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(695, 217);
            this.pictureBox1.TabIndex = 304;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(710, 173);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 217);
            this.pictureBox2.TabIndex = 305;
            this.pictureBox2.TabStop = false;
            // 
            // txt_cantitad_ordenes
            // 
            this.txt_cantitad_ordenes.AutoSize = true;
            this.txt_cantitad_ordenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_cantitad_ordenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantitad_ordenes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cantitad_ordenes.Location = new System.Drawing.Point(324, 82);
            this.txt_cantitad_ordenes.Name = "txt_cantitad_ordenes";
            this.txt_cantitad_ordenes.Size = new System.Drawing.Size(154, 20);
            this.txt_cantitad_ordenes.TabIndex = 307;
            this.txt_cantitad_ordenes.Text = "Cantidad Ordenes";
            // 
            // lbl_cantidad_ordenes
            // 
            this.lbl_cantidad_ordenes.AutoSize = true;
            this.lbl_cantidad_ordenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_cantidad_ordenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_ordenes.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantidad_ordenes.Location = new System.Drawing.Point(102, 85);
            this.lbl_cantidad_ordenes.Name = "lbl_cantidad_ordenes";
            this.lbl_cantidad_ordenes.Size = new System.Drawing.Size(259, 17);
            this.lbl_cantidad_ordenes.TabIndex = 306;
            this.lbl_cantidad_ordenes.Text = "Cantidad de ordenes a despachar:";
            // 
            // lbl_numero_orden
            // 
            this.lbl_numero_orden.AutoSize = true;
            this.lbl_numero_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_numero_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_orden.ForeColor = System.Drawing.Color.Black;
            this.lbl_numero_orden.Location = new System.Drawing.Point(24, 135);
            this.lbl_numero_orden.Name = "lbl_numero_orden";
            this.lbl_numero_orden.Size = new System.Drawing.Size(83, 18);
            this.lbl_numero_orden.TabIndex = 308;
            this.lbl_numero_orden.Text = "Orden N°:";
            // 
            // txt_numero_orden
            // 
            this.txt_numero_orden.AutoSize = true;
            this.txt_numero_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_numero_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_orden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_numero_orden.Location = new System.Drawing.Point(100, 129);
            this.txt_numero_orden.Name = "txt_numero_orden";
            this.txt_numero_orden.Size = new System.Drawing.Size(111, 26);
            this.txt_numero_orden.TabIndex = 309;
            this.txt_numero_orden.Text = "N° Orden";
            // 
            // btn_imprimir_etiqueta
            // 
            this.btn_imprimir_etiqueta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_imprimir_etiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir_etiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir_etiqueta.Location = new System.Drawing.Point(722, 245);
            this.btn_imprimir_etiqueta.Name = "btn_imprimir_etiqueta";
            this.btn_imprimir_etiqueta.Size = new System.Drawing.Size(98, 67);
            this.btn_imprimir_etiqueta.TabIndex = 310;
            this.btn_imprimir_etiqueta.Text = "Imprimir Etiqueta";
            this.btn_imprimir_etiqueta.UseVisualStyleBackColor = false;
            // 
            // dataGridViewListaPedidos
            // 
            this.dataGridViewListaPedidos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewListaPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dataGridViewListaPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListaPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewListaPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListaPedidos.ColumnHeadersHeight = 24;
            this.dataGridViewListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Norden,
            this.Marca,
            this.Nombre,
            this.Tipo,
            this.Genero,
            this.Presentacion});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListaPedidos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewListaPedidos.EnableHeadersVisualStyles = false;
            this.dataGridViewListaPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dataGridViewListaPedidos.Location = new System.Drawing.Point(21, 184);
            this.dataGridViewListaPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListaPedidos.Name = "dataGridViewListaPedidos";
            this.dataGridViewListaPedidos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewListaPedidos.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewListaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewListaPedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaPedidos.Size = new System.Drawing.Size(675, 192);
            this.dataGridViewListaPedidos.TabIndex = 311;
            // 
            // Norden
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Norden.DefaultCellStyle = dataGridViewCellStyle3;
            this.Norden.HeaderText = "Orden N°";
            this.Norden.MinimumWidth = 6;
            this.Norden.Name = "Norden";
            this.Norden.ReadOnly = true;
            // 
            // Marca
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Marca.DefaultCellStyle = dataGridViewCellStyle4;
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Perfume";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo de Perfume";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Género";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Presentacion
            // 
            this.Presentacion.HeaderText = "Presentación en ml";
            this.Presentacion.MinimumWidth = 6;
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            // 
            // FormListaDeEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(840, 400);
            this.Controls.Add(this.dataGridViewListaPedidos);
            this.Controls.Add(this.btn_imprimir_etiqueta);
            this.Controls.Add(this.txt_numero_orden);
            this.Controls.Add(this.lbl_numero_orden);
            this.Controls.Add(this.txt_cantitad_ordenes);
            this.Controls.Add(this.lbl_cantidad_ordenes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_consultas);
            this.Controls.Add(this.txt_nombre_empleado);
            this.Controls.Add(this.lbl_responsable);
            this.Controls.Add(this.lbl_lista_envios);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.button2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormListaDeEnvios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDeEnvios";
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Label txt_nombre_empleado;
        private System.Windows.Forms.Label lbl_responsable;
        private System.Windows.Forms.Label lbl_lista_envios;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txt_cantitad_ordenes;
        private System.Windows.Forms.Label lbl_cantidad_ordenes;
        private System.Windows.Forms.Label lbl_numero_orden;
        private System.Windows.Forms.Label txt_numero_orden;
        private System.Windows.Forms.Button btn_imprimir_etiqueta;
        private System.Windows.Forms.DataGridView dataGridViewListaPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
    }
}
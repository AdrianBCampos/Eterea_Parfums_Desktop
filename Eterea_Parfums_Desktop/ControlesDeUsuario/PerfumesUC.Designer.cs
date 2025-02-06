namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    partial class PerfumesUC
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

        #region Código generado por el Diseñador de componentes

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
            this.dataGridViewPerfumes = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_buscar_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_perfumes = new System.Windows.Forms.Label();
            this.btn_crear_perfume = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_del_Perfume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_de_Perfume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion_en_mi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pais_de_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.En_spray = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Es_recargable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerfumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPerfumes
            // 
            this.dataGridViewPerfumes.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.dataGridViewPerfumes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPerfumes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPerfumes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPerfumes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dataGridViewPerfumes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPerfumes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPerfumes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPerfumes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPerfumes.ColumnHeadersHeight = 30;
            this.dataGridViewPerfumes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Marca,
            this.Nombre_del_Perfume,
            this.Tipo_de_Perfume,
            this.Genero,
            this.Presentacion_en_mi,
            this.Pais_de_origen,
            this.En_spray,
            this.Es_recargable,
            this.Precio,
            this.Stock,
            this.Editar,
            this.Eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPerfumes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPerfumes.EnableHeadersVisualStyles = false;
            this.dataGridViewPerfumes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dataGridViewPerfumes.Location = new System.Drawing.Point(37, 148);
            this.dataGridViewPerfumes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPerfumes.Name = "dataGridViewPerfumes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPerfumes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPerfumes.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.dataGridViewPerfumes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPerfumes.Size = new System.Drawing.Size(1245, 327);
            this.dataGridViewPerfumes.TabIndex = 229;
            this.dataGridViewPerfumes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPerfumes_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(15, 128);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1289, 368);
            this.pictureBox2.TabIndex = 228;
            this.pictureBox2.TabStop = false;
            // 
            // txt_buscar_codigo
            // 
            this.txt_buscar_codigo.Location = new System.Drawing.Point(591, 89);
            this.txt_buscar_codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_buscar_codigo.Name = "txt_buscar_codigo";
            this.txt_buscar_codigo.Size = new System.Drawing.Size(265, 22);
            this.txt_buscar_codigo.TabIndex = 227;
            this.txt_buscar_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_codigo_KeyPress);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.Black;
            this.lbl_codigo.Location = new System.Drawing.Point(493, 91);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(83, 24);
            this.lbl_codigo.TabIndex = 226;
            this.lbl_codigo.Text = "Código:";
            // 
            // lbl_perfumes
            // 
            this.lbl_perfumes.AutoSize = true;
            this.lbl_perfumes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_perfumes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perfumes.ForeColor = System.Drawing.Color.Black;
            this.lbl_perfumes.Location = new System.Drawing.Point(24, 23);
            this.lbl_perfumes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_perfumes.Name = "lbl_perfumes";
            this.lbl_perfumes.Size = new System.Drawing.Size(98, 24);
            this.lbl_perfumes.TabIndex = 225;
            this.lbl_perfumes.Text = "Perfumes";
            // 
            // btn_crear_perfume
            // 
            this.btn_crear_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_crear_perfume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_perfume.Location = new System.Drawing.Point(28, 64);
            this.btn_crear_perfume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_crear_perfume.Name = "btn_crear_perfume";
            this.btn_crear_perfume.Size = new System.Drawing.Size(183, 46);
            this.btn_crear_perfume.TabIndex = 224;
            this.btn_crear_perfume.Text = "Crear";
            this.btn_crear_perfume.UseVisualStyleBackColor = false;
            this.btn_crear_perfume.Click += new System.EventHandler(this.btn_crear_perfume_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1289, 113);
            this.pictureBox1.TabIndex = 223;
            this.pictureBox1.TabStop = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            // 
            // Nombre_del_Perfume
            // 
            this.Nombre_del_Perfume.HeaderText = "Nombre del Perfume";
            this.Nombre_del_Perfume.MinimumWidth = 6;
            this.Nombre_del_Perfume.Name = "Nombre_del_Perfume";
            // 
            // Tipo_de_Perfume
            // 
            this.Tipo_de_Perfume.HeaderText = "Tipo de Perfume";
            this.Tipo_de_Perfume.MinimumWidth = 6;
            this.Tipo_de_Perfume.Name = "Tipo_de_Perfume";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.MinimumWidth = 6;
            this.Genero.Name = "Genero";
            // 
            // Presentacion_en_mi
            // 
            this.Presentacion_en_mi.HeaderText = "Presentación en mi ";
            this.Presentacion_en_mi.MinimumWidth = 6;
            this.Presentacion_en_mi.Name = "Presentacion_en_mi";
            // 
            // Pais_de_origen
            // 
            this.Pais_de_origen.HeaderText = " País de Origen";
            this.Pais_de_origen.MinimumWidth = 6;
            this.Pais_de_origen.Name = "Pais_de_origen";
            // 
            // En_spray
            // 
            this.En_spray.HeaderText = "En Spray";
            this.En_spray.MinimumWidth = 6;
            this.En_spray.Name = "En_spray";
            // 
            // Es_recargable
            // 
            this.Es_recargable.HeaderText = "Es Recargable";
            this.Es_recargable.MinimumWidth = 6;
            this.Es_recargable.Name = "Es_recargable";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio en $";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            // 
            // PerfumesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.dataGridViewPerfumes);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_buscar_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.lbl_perfumes);
            this.Controls.Add(this.btn_crear_perfume);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PerfumesUC";
            this.Size = new System.Drawing.Size(1312, 505);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerfumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPerfumes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_buscar_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_perfumes;
        private System.Windows.Forms.Button btn_crear_perfume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_del_Perfume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_de_Perfume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion_en_mi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pais_de_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn En_spray;
        private System.Windows.Forms.DataGridViewTextBoxColumn Es_recargable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}

namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    partial class Promos_UC
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
            this.pict_fondoInferior = new System.Windows.Forms.PictureBox();
            this.dataGridViewPromos = new System.Windows.Forms.DataGridView();
            this.Id_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_de_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar_promo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar_promo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_empleados = new System.Windows.Forms.Label();
            this.btn_crear_empleado = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_filtro_nombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pict_fondoInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pict_fondoInferior
            // 
            this.pict_fondoInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pict_fondoInferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pict_fondoInferior.Location = new System.Drawing.Point(0, 81);
            this.pict_fondoInferior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pict_fondoInferior.Name = "pict_fondoInferior";
            this.pict_fondoInferior.Size = new System.Drawing.Size(1317, 417);
            this.pict_fondoInferior.TabIndex = 223;
            this.pict_fondoInferior.TabStop = false;
            // 
            // dataGridViewPromos
            // 
            this.dataGridViewPromos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewPromos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPromos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPromos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dataGridViewPromos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPromos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPromos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPromos.ColumnHeadersHeight = 24;
            this.dataGridViewPromos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_promo,
            this.nombre_promo,
            this.tipo_de_promo,
            this.Inicio_promo,
            this.fin_promo,
            this.activo_promo,
            this.editar_promo,
            this.eliminar_promo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPromos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPromos.EnableHeadersVisualStyles = false;
            this.dataGridViewPromos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dataGridViewPromos.Location = new System.Drawing.Point(37, 216);
            this.dataGridViewPromos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPromos.Name = "dataGridViewPromos";
            this.dataGridViewPromos.ReadOnly = true;
            this.dataGridViewPromos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewPromos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPromos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPromos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewPromos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPromos.RowTemplate.Height = 28;
            this.dataGridViewPromos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPromos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPromos.Size = new System.Drawing.Size(1251, 153);
            this.dataGridViewPromos.TabIndex = 222;
            this.dataGridViewPromos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPromos_CellContentClick);
            // 
            // Id_promo
            // 
            this.Id_promo.HeaderText = "Id";
            this.Id_promo.MinimumWidth = 8;
            this.Id_promo.Name = "Id_promo";
            this.Id_promo.ReadOnly = true;
            // 
            // nombre_promo
            // 
            this.nombre_promo.HeaderText = "Nombre";
            this.nombre_promo.MinimumWidth = 8;
            this.nombre_promo.Name = "nombre_promo";
            this.nombre_promo.ReadOnly = true;
            // 
            // tipo_de_promo
            // 
            this.tipo_de_promo.HeaderText = "Tipo de Promoción";
            this.tipo_de_promo.MinimumWidth = 8;
            this.tipo_de_promo.Name = "tipo_de_promo";
            this.tipo_de_promo.ReadOnly = true;
            // 
            // Inicio_promo
            // 
            this.Inicio_promo.HeaderText = "Fecha de inicio";
            this.Inicio_promo.MinimumWidth = 8;
            this.Inicio_promo.Name = "Inicio_promo";
            this.Inicio_promo.ReadOnly = true;
            // 
            // fin_promo
            // 
            this.fin_promo.HeaderText = "Fecha de finalización";
            this.fin_promo.MinimumWidth = 8;
            this.fin_promo.Name = "fin_promo";
            this.fin_promo.ReadOnly = true;
            // 
            // activo_promo
            // 
            this.activo_promo.HeaderText = "Activo";
            this.activo_promo.MinimumWidth = 8;
            this.activo_promo.Name = "activo_promo";
            this.activo_promo.ReadOnly = true;
            // 
            // editar_promo
            // 
            this.editar_promo.HeaderText = "";
            this.editar_promo.MinimumWidth = 8;
            this.editar_promo.Name = "editar_promo";
            this.editar_promo.ReadOnly = true;
            this.editar_promo.Text = "";
            // 
            // eliminar_promo
            // 
            this.eliminar_promo.HeaderText = "";
            this.eliminar_promo.MinimumWidth = 8;
            this.eliminar_promo.Name = "eliminar_promo";
            this.eliminar_promo.ReadOnly = true;
            this.eliminar_promo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.label2.Location = new System.Drawing.Point(367, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 24);
            this.label2.TabIndex = 238;
            this.label2.Text = "Filtrar Promoción por Nombre:";
            // 
            // lbl_empleados
            // 
            this.lbl_empleados.AutoSize = true;
            this.lbl_empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_empleados.Location = new System.Drawing.Point(68, 24);
            this.lbl_empleados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_empleados.Name = "lbl_empleados";
            this.lbl_empleados.Size = new System.Drawing.Size(191, 32);
            this.lbl_empleados.TabIndex = 237;
            this.lbl_empleados.Text = "Promociones";
            // 
            // btn_crear_empleado
            // 
            this.btn_crear_empleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_crear_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_empleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_crear_empleado.Location = new System.Drawing.Point(1068, 17);
            this.btn_crear_empleado.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crear_empleado.Name = "btn_crear_empleado";
            this.btn_crear_empleado.Size = new System.Drawing.Size(183, 46);
            this.btn_crear_empleado.TabIndex = 236;
            this.btn_crear_empleado.Text = "Crear Promoción";
            this.btn_crear_empleado.UseVisualStyleBackColor = false;
            this.btn_crear_empleado.Click += new System.EventHandler(this.btn_crear_promo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(0, 5);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(327, 71);
            this.pictureBox3.TabIndex = 233;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(333, 5);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(651, 71);
            this.pictureBox4.TabIndex = 234;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(990, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 71);
            this.pictureBox2.TabIndex = 235;
            this.pictureBox2.TabStop = false;
            // 
            // txt_filtro_nombre
            // 
            this.txt_filtro_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_filtro_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_filtro_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filtro_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_filtro_nombre.Location = new System.Drawing.Point(682, 26);
            this.txt_filtro_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filtro_nombre.Name = "txt_filtro_nombre";
            this.txt_filtro_nombre.Size = new System.Drawing.Size(264, 27);
            this.txt_filtro_nombre.TabIndex = 282;
            this.txt_filtro_nombre.TextChanged += new System.EventHandler(this.txt_buscar_nombre_TextChanged);
            // 
            // Promos_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.Controls.Add(this.txt_filtro_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_empleados);
            this.Controls.Add(this.btn_crear_empleado);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridViewPromos);
            this.Controls.Add(this.pict_fondoInferior);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Promos_UC";
            this.Size = new System.Drawing.Size(1317, 505);
            ((System.ComponentModel.ISupportInitialize)(this.pict_fondoInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pict_fondoInferior;
        private System.Windows.Forms.DataGridView dataGridViewPromos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_de_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo_promo;
        private System.Windows.Forms.DataGridViewButtonColumn editar_promo;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar_promo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_empleados;
        private System.Windows.Forms.Button btn_crear_empleado;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_filtro_nombre;
    }
}

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
            this.btn_crear_cliente = new System.Windows.Forms.Button();
            this.pict_fondoSuperior = new System.Windows.Forms.PictureBox();
            this.lbl_promociones = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.textbox_nombrePromo = new System.Windows.Forms.TextBox();
            this.pict_fondoInferior = new System.Windows.Forms.PictureBox();
            this.dataGV_Promos = new System.Windows.Forms.DataGridView();
            this.Id_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_de_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar_promo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar_promo = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pict_fondoSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_fondoInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Promos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear_cliente
            // 
            this.btn_crear_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_crear_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_cliente.Location = new System.Drawing.Point(28, 86);
            this.btn_crear_cliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_crear_cliente.Name = "btn_crear_cliente";
            this.btn_crear_cliente.Size = new System.Drawing.Size(206, 58);
            this.btn_crear_cliente.TabIndex = 218;
            this.btn_crear_cliente.Text = "Crear";
            this.btn_crear_cliente.UseVisualStyleBackColor = false;
            this.btn_crear_cliente.Click += new System.EventHandler(this.btn_crear_promo_Click);
            // 
            // pict_fondoSuperior
            // 
            this.pict_fondoSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pict_fondoSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pict_fondoSuperior.Location = new System.Drawing.Point(14, 18);
            this.pict_fondoSuperior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pict_fondoSuperior.Name = "pict_fondoSuperior";
            this.pict_fondoSuperior.Size = new System.Drawing.Size(1450, 141);
            this.pict_fondoSuperior.TabIndex = 219;
            this.pict_fondoSuperior.TabStop = false;
            // 
            // lbl_promociones
            // 
            this.lbl_promociones.AutoSize = true;
            this.lbl_promociones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_promociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_promociones.ForeColor = System.Drawing.Color.Black;
            this.lbl_promociones.Location = new System.Drawing.Point(24, 35);
            this.lbl_promociones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_promociones.Name = "lbl_promociones";
            this.lbl_promociones.Size = new System.Drawing.Size(167, 29);
            this.lbl_promociones.TabIndex = 220;
            this.lbl_promociones.Text = "Promociones";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.lbl_nombre.Location = new System.Drawing.Point(596, 114);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(114, 29);
            this.lbl_nombre.TabIndex = 221;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // textbox_nombrePromo
            // 
            this.textbox_nombrePromo.Location = new System.Drawing.Point(712, 117);
            this.textbox_nombrePromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_nombrePromo.Name = "textbox_nombrePromo";
            this.textbox_nombrePromo.Size = new System.Drawing.Size(298, 26);
            this.textbox_nombrePromo.TabIndex = 222;
            this.textbox_nombrePromo.TextChanged += new System.EventHandler(this.txt_buscar_nombre_TextChanged);
            // 
            // pict_fondoInferior
            // 
            this.pict_fondoInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pict_fondoInferior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pict_fondoInferior.Location = new System.Drawing.Point(14, 166);
            this.pict_fondoInferior.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pict_fondoInferior.Name = "pict_fondoInferior";
            this.pict_fondoInferior.Size = new System.Drawing.Size(1450, 460);
            this.pict_fondoInferior.TabIndex = 223;
            this.pict_fondoInferior.TabStop = false;
            // 
            // dataGV_Promos
            // 
            this.dataGV_Promos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGV_Promos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGV_Promos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_Promos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dataGV_Promos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGV_Promos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGV_Promos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_Promos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGV_Promos.ColumnHeadersHeight = 24;
            this.dataGV_Promos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGV_Promos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGV_Promos.EnableHeadersVisualStyles = false;
            this.dataGV_Promos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dataGV_Promos.Location = new System.Drawing.Point(35, 191);
            this.dataGV_Promos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV_Promos.Name = "dataGV_Promos";
            this.dataGV_Promos.ReadOnly = true;
            this.dataGV_Promos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGV_Promos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGV_Promos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGV_Promos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGV_Promos.RowTemplate.Height = 28;
            this.dataGV_Promos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGV_Promos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Promos.Size = new System.Drawing.Size(1407, 409);
            this.dataGV_Promos.TabIndex = 222;
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
            // Promos_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGV_Promos);
            this.Controls.Add(this.pict_fondoInferior);
            this.Controls.Add(this.textbox_nombrePromo);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_promociones);
            this.Controls.Add(this.btn_crear_cliente);
            this.Controls.Add(this.pict_fondoSuperior);
            this.Name = "Promos_UC";
            this.Size = new System.Drawing.Size(1482, 630);
            ((System.ComponentModel.ISupportInitialize)(this.pict_fondoSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pict_fondoInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Promos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_cliente;
        private System.Windows.Forms.PictureBox pict_fondoSuperior;
        private System.Windows.Forms.Label lbl_promociones;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox textbox_nombrePromo;
        private System.Windows.Forms.PictureBox pict_fondoInferior;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_de_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo_promo;
        private System.Windows.Forms.DataGridViewButtonColumn editar_promo;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar_promo;
        private System.Windows.Forms.DataGridView dataGV_Promos;
    }
}

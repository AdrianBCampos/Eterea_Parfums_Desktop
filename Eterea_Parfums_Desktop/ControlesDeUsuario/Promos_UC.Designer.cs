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
            this.dataGV_Promos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Promos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_promo,
            this.nombre_promo,
            this.tipo_de_promo,
            this.Inicio_promo,
            this.fin_promo,
            this.activo_promo,
            this.editar_promo,
            this.eliminar_promo});
            this.dataGV_Promos.Location = new System.Drawing.Point(35, 191);
            this.dataGV_Promos.Name = "dataGV_Promos";
            this.dataGV_Promos.RowHeadersWidth = 62;
            this.dataGV_Promos.RowTemplate.Height = 28;
            this.dataGV_Promos.Size = new System.Drawing.Size(1407, 409);
            this.dataGV_Promos.TabIndex = 224;
            // 
            // Id_promo
            // 
            this.Id_promo.HeaderText = "Id";
            this.Id_promo.MinimumWidth = 8;
            this.Id_promo.Name = "Id_promo";
            this.Id_promo.Width = 150;
            // 
            // nombre_promo
            // 
            this.nombre_promo.HeaderText = "Nombre";
            this.nombre_promo.MinimumWidth = 8;
            this.nombre_promo.Name = "nombre_promo";
            this.nombre_promo.Width = 150;
            // 
            // tipo_de_promo
            // 
            this.tipo_de_promo.HeaderText = "Tipo de Promoción";
            this.tipo_de_promo.MinimumWidth = 8;
            this.tipo_de_promo.Name = "tipo_de_promo";
            this.tipo_de_promo.Width = 150;
            // 
            // Inicio_promo
            // 
            this.Inicio_promo.HeaderText = "Fecha de inicio";
            this.Inicio_promo.MinimumWidth = 8;
            this.Inicio_promo.Name = "Inicio_promo";
            this.Inicio_promo.Width = 150;
            // 
            // fin_promo
            // 
            this.fin_promo.HeaderText = "Fecha de finalización";
            this.fin_promo.MinimumWidth = 8;
            this.fin_promo.Name = "fin_promo";
            this.fin_promo.Width = 150;
            // 
            // activo_promo
            // 
            this.activo_promo.HeaderText = "Activo";
            this.activo_promo.MinimumWidth = 8;
            this.activo_promo.Name = "activo_promo";
            this.activo_promo.Width = 150;
            // 
            // editar_promo
            // 
            this.editar_promo.HeaderText = "Editar";
            this.editar_promo.MinimumWidth = 8;
            this.editar_promo.Name = "editar_promo";
            this.editar_promo.Text = "Editar";
            this.editar_promo.Width = 150;
            // 
            // eliminar_promo
            // 
            this.eliminar_promo.HeaderText = "Eliminar";
            this.eliminar_promo.MinimumWidth = 8;
            this.eliminar_promo.Name = "eliminar_promo";
            this.eliminar_promo.Text = "Eliminar";
            this.eliminar_promo.Width = 150;
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
        private System.Windows.Forms.DataGridView dataGV_Promos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_de_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo_promo;
        private System.Windows.Forms.DataGridViewButtonColumn editar_promo;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar_promo;
    }
}

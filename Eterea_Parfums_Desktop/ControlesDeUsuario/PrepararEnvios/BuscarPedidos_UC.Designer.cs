namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    partial class BuscarPedidos_UC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_preparar_envio = new System.Windows.Forms.Button();
            this.btn_buscar_orden = new System.Windows.Forms.Button();
            this.lbl_orden_error = new System.Windows.Forms.Label();
            this.lbl_orden_n = new System.Windows.Forms.Label();
            this.txt_orden_n = new System.Windows.Forms.TextBox();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.colOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_buscar_pedido = new System.Windows.Forms.Label();
            this.img_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_preparar_envio
            // 
            this.btn_preparar_envio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_preparar_envio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preparar_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preparar_envio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_preparar_envio.Location = new System.Drawing.Point(80, 226);
            this.btn_preparar_envio.Name = "btn_preparar_envio";
            this.btn_preparar_envio.Size = new System.Drawing.Size(306, 37);
            this.btn_preparar_envio.TabIndex = 318;
            this.btn_preparar_envio.Text = "VER DETALLES / PREPARAR ENVIO";
            this.btn_preparar_envio.UseVisualStyleBackColor = false;
            this.btn_preparar_envio.Click += new System.EventHandler(this.btn_preparar_envio_Click);
            // 
            // btn_buscar_orden
            // 
            this.btn_buscar_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_buscar_orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_orden.Location = new System.Drawing.Point(335, 71);
            this.btn_buscar_orden.Name = "btn_buscar_orden";
            this.btn_buscar_orden.Size = new System.Drawing.Size(113, 32);
            this.btn_buscar_orden.TabIndex = 317;
            this.btn_buscar_orden.Text = "Buscar";
            this.btn_buscar_orden.UseVisualStyleBackColor = false;
            this.btn_buscar_orden.Click += new System.EventHandler(this.btn_buscar_orden_Click);
            // 
            // lbl_orden_error
            // 
            this.lbl_orden_error.AutoSize = true;
            this.lbl_orden_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_orden_error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_orden_error.Location = new System.Drawing.Point(128, 101);
            this.lbl_orden_error.Name = "lbl_orden_error";
            this.lbl_orden_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_orden_error.TabIndex = 316;
            this.lbl_orden_error.Text = "Error";
            // 
            // lbl_orden_n
            // 
            this.lbl_orden_n.AutoSize = true;
            this.lbl_orden_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_orden_n.Location = new System.Drawing.Point(128, 80);
            this.lbl_orden_n.Name = "lbl_orden_n";
            this.lbl_orden_n.Size = new System.Drawing.Size(57, 13);
            this.lbl_orden_n.TabIndex = 315;
            this.lbl_orden_n.Text = "Orden N°: ";
            // 
            // txt_orden_n
            // 
            this.txt_orden_n.Location = new System.Drawing.Point(191, 77);
            this.txt_orden_n.Name = "txt_orden_n";
            this.txt_orden_n.Size = new System.Drawing.Size(124, 20);
            this.txt_orden_n.TabIndex = 314;
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_resultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_resultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgv_resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_resultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_resultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_resultado.ColumnHeadersHeight = 24;
            this.dgv_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrden,
            this.colEstado,
            this.colFecha});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_resultado.EnableHeadersVisualStyles = false;
            this.dgv_resultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dgv_resultado.Location = new System.Drawing.Point(32, 134);
            this.dgv_resultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_resultado.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_resultado.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_resultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado.Size = new System.Drawing.Size(406, 66);
            this.dgv_resultado.TabIndex = 313;
            // 
            // colOrden
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.colOrden.DefaultCellStyle = dataGridViewCellStyle3;
            this.colOrden.HeaderText = "Orden N°";
            this.colOrden.MinimumWidth = 6;
            this.colOrden.Name = "colOrden";
            this.colOrden.ReadOnly = true;
            // 
            // colEstado
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.colEstado.DefaultCellStyle = dataGridViewCellStyle4;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colFecha
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            this.colFecha.DefaultCellStyle = dataGridViewCellStyle5;
            this.colFecha.HeaderText = "Fecha de compra";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(22, 121);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(426, 92);
            this.pictureBox3.TabIndex = 312;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_buscar_pedido
            // 
            this.lbl_buscar_pedido.AutoSize = true;
            this.lbl_buscar_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_buscar_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_pedido.ForeColor = System.Drawing.Color.Black;
            this.lbl_buscar_pedido.Location = new System.Drawing.Point(115, 29);
            this.lbl_buscar_pedido.Name = "lbl_buscar_pedido";
            this.lbl_buscar_pedido.Size = new System.Drawing.Size(116, 18);
            this.lbl_buscar_pedido.TabIndex = 310;
            this.lbl_buscar_pedido.Text = "Buscar pedido";
            // 
            // img_logo
            // 
            this.img_logo.Location = new System.Drawing.Point(23, 22);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(86, 86);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 309;
            this.img_logo.TabStop = false;
            // 
            // BuscarPedidos_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_preparar_envio);
            this.Controls.Add(this.btn_buscar_orden);
            this.Controls.Add(this.lbl_orden_error);
            this.Controls.Add(this.lbl_orden_n);
            this.Controls.Add(this.txt_orden_n);
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_buscar_pedido);
            this.Controls.Add(this.img_logo);
            this.Name = "BuscarPedidos_UC";
            this.Size = new System.Drawing.Size(476, 285);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preparar_envio;
        private System.Windows.Forms.Button btn_buscar_orden;
        private System.Windows.Forms.Label lbl_orden_error;
        private System.Windows.Forms.Label lbl_orden_n;
        private System.Windows.Forms.TextBox txt_orden_n;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_buscar_pedido;
        private System.Windows.Forms.PictureBox img_logo;
    }
}

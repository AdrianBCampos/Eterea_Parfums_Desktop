namespace Eterea_Parfums_Desktop
{
    partial class FormBuscarPedidos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_buscar_pedido = new System.Windows.Forms.Label();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dgv_resultado = new System.Windows.Forms.DataGridView();
            this.btn_buscar_orden = new System.Windows.Forms.Button();
            this.lbl_orden_error = new System.Windows.Forms.Label();
            this.lbl_orden_n = new System.Windows.Forms.Label();
            this.txt_orden_n = new System.Windows.Forms.TextBox();
            this.btn_preparar_envio = new System.Windows.Forms.Button();
            this.colOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_buscar_pedido
            // 
            this.lbl_buscar_pedido.AutoSize = true;
            this.lbl_buscar_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_buscar_pedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_pedido.ForeColor = System.Drawing.Color.Black;
            this.lbl_buscar_pedido.Location = new System.Drawing.Point(102, 18);
            this.lbl_buscar_pedido.Name = "lbl_buscar_pedido";
            this.lbl_buscar_pedido.Size = new System.Drawing.Size(116, 18);
            this.lbl_buscar_pedido.TabIndex = 298;
            this.lbl_buscar_pedido.Text = "Buscar pedido";
            // 
            // img_logo
            // 
            this.img_logo.Location = new System.Drawing.Point(10, 11);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(86, 86);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 297;
            this.img_logo.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(400, 6);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(34, 32);
            this.button2.TabIndex = 300;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(9, 110);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(426, 92);
            this.pictureBox3.TabIndex = 302;
            this.pictureBox3.TabStop = false;
            // 
            // dgv_resultado
            // 
            this.dgv_resultado.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_resultado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_resultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_resultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgv_resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_resultado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_resultado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_resultado.ColumnHeadersHeight = 24;
            this.dgv_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrden,
            this.colEstado,
            this.colFecha});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_resultado.EnableHeadersVisualStyles = false;
            this.dgv_resultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dgv_resultado.Location = new System.Drawing.Point(19, 123);
            this.dgv_resultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_resultado.Name = "dgv_resultado";
            this.dgv_resultado.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_resultado.RowHeadersWidth = 51;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_resultado.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_resultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado.Size = new System.Drawing.Size(406, 66);
            this.dgv_resultado.TabIndex = 303;
            // 
            // btn_buscar_orden
            // 
            this.btn_buscar_orden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_buscar_orden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar_orden.Location = new System.Drawing.Point(322, 60);
            this.btn_buscar_orden.Name = "btn_buscar_orden";
            this.btn_buscar_orden.Size = new System.Drawing.Size(113, 32);
            this.btn_buscar_orden.TabIndex = 307;
            this.btn_buscar_orden.Text = "Buscar";
            this.btn_buscar_orden.UseVisualStyleBackColor = false;
            this.btn_buscar_orden.Click += new System.EventHandler(this.btn_buscar_orden_Click);
            // 
            // lbl_orden_error
            // 
            this.lbl_orden_error.AutoSize = true;
            this.lbl_orden_error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_orden_error.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_orden_error.Location = new System.Drawing.Point(115, 90);
            this.lbl_orden_error.Name = "lbl_orden_error";
            this.lbl_orden_error.Size = new System.Drawing.Size(29, 13);
            this.lbl_orden_error.TabIndex = 306;
            this.lbl_orden_error.Text = "Error";
            // 
            // lbl_orden_n
            // 
            this.lbl_orden_n.AutoSize = true;
            this.lbl_orden_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_orden_n.Location = new System.Drawing.Point(115, 69);
            this.lbl_orden_n.Name = "lbl_orden_n";
            this.lbl_orden_n.Size = new System.Drawing.Size(57, 13);
            this.lbl_orden_n.TabIndex = 305;
            this.lbl_orden_n.Text = "Orden N°: ";
            // 
            // txt_orden_n
            // 
            this.txt_orden_n.Location = new System.Drawing.Point(178, 66);
            this.txt_orden_n.Name = "txt_orden_n";
            this.txt_orden_n.Size = new System.Drawing.Size(124, 20);
            this.txt_orden_n.TabIndex = 304;
            // 
            // btn_preparar_envio
            // 
            this.btn_preparar_envio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_preparar_envio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preparar_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preparar_envio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_preparar_envio.Location = new System.Drawing.Point(67, 215);
            this.btn_preparar_envio.Name = "btn_preparar_envio";
            this.btn_preparar_envio.Size = new System.Drawing.Size(306, 37);
            this.btn_preparar_envio.TabIndex = 308;
            this.btn_preparar_envio.Text = "VER DETALLES / PREPARAR ENVIO";
            this.btn_preparar_envio.UseVisualStyleBackColor = false;
            this.btn_preparar_envio.Click += new System.EventHandler(this.btn_preparar_envio_Click);
            // 
            // colOrden
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.colOrden.DefaultCellStyle = dataGridViewCellStyle11;
            this.colOrden.HeaderText = "Orden N°";
            this.colOrden.MinimumWidth = 6;
            this.colOrden.Name = "colOrden";
            this.colOrden.ReadOnly = true;
            // 
            // colEstado
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.colEstado.DefaultCellStyle = dataGridViewCellStyle12;
            this.colEstado.HeaderText = "Estado";
            this.colEstado.MinimumWidth = 6;
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colFecha
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Blue;
            this.colFecha.DefaultCellStyle = dataGridViewCellStyle13;
            this.colFecha.HeaderText = "Fecha de compra";
            this.colFecha.MinimumWidth = 6;
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            this.colFecha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormBuscarPedidos
            // 
            this.AcceptButton = this.btn_buscar_orden;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(442, 270);
            this.Controls.Add(this.btn_preparar_envio);
            this.Controls.Add(this.btn_buscar_orden);
            this.Controls.Add(this.lbl_orden_error);
            this.Controls.Add(this.lbl_orden_n);
            this.Controls.Add(this.txt_orden_n);
            this.Controls.Add(this.dgv_resultado);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_buscar_pedido);
            this.Controls.Add(this.img_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBuscarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_buscar_pedido;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgv_resultado;
        private System.Windows.Forms.Button btn_buscar_orden;
        private System.Windows.Forms.Label lbl_orden_error;
        private System.Windows.Forms.Label lbl_orden_n;
        private System.Windows.Forms.TextBox txt_orden_n;
        private System.Windows.Forms.Button btn_preparar_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
    }
}
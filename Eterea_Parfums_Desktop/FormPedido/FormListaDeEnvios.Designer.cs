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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_nombre_empleado = new System.Windows.Forms.Label();
            this.lbl_responsable = new System.Windows.Forms.Label();
            this.lbl_lista_envios = new System.Windows.Forms.Label();
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_cantidad_ordenes = new System.Windows.Forms.Label();
            this.lbl_cantidad_ordenes = new System.Windows.Forms.Label();
            this.dataGridViewListaPedidos = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_pedido_buscado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(10, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 323);
            this.pictureBox1.TabIndex = 304;
            this.pictureBox1.TabStop = false;
            // 
            // txt_cantidad_ordenes
            // 
            this.txt_cantidad_ordenes.AutoSize = true;
            this.txt_cantidad_ordenes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_cantidad_ordenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_ordenes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cantidad_ordenes.Location = new System.Drawing.Point(367, 85);
            this.txt_cantidad_ordenes.Name = "txt_cantidad_ordenes";
            this.txt_cantidad_ordenes.Size = new System.Drawing.Size(154, 20);
            this.txt_cantidad_ordenes.TabIndex = 307;
            this.txt_cantidad_ordenes.Text = "Cantidad Ordenes";
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
            // dataGridViewListaPedidos
            // 
            this.dataGridViewListaPedidos.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewListaPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewListaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListaPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dataGridViewListaPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewListaPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewListaPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewListaPedidos.ColumnHeadersHeight = 24;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListaPedidos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewListaPedidos.EnableHeadersVisualStyles = false;
            this.dataGridViewListaPedidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dataGridViewListaPedidos.Location = new System.Drawing.Point(21, 127);
            this.dataGridViewListaPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListaPedidos.Name = "dataGridViewListaPedidos";
            this.dataGridViewListaPedidos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewListaPedidos.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewListaPedidos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewListaPedidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaPedidos.Size = new System.Drawing.Size(797, 298);
            this.dataGridViewListaPedidos.TabIndex = 311;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 142);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 257);
            this.flowLayoutPanel1.TabIndex = 312;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // lbl_pedido_buscado
            // 
            this.lbl_pedido_buscado.AutoSize = true;
            this.lbl_pedido_buscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pedido_buscado.Location = new System.Drawing.Point(102, 81);
            this.lbl_pedido_buscado.Name = "lbl_pedido_buscado";
            this.lbl_pedido_buscado.Size = new System.Drawing.Size(152, 24);
            this.lbl_pedido_buscado.TabIndex = 314;
            this.lbl_pedido_buscado.Text = "Pedido Filtrado";
            // 
            // FormListaDeEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(840, 451);
            this.Controls.Add(this.lbl_pedido_buscado);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridViewListaPedidos);
            this.Controls.Add(this.txt_cantidad_ordenes);
            this.Controls.Add(this.lbl_cantidad_ordenes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_nombre_empleado);
            this.Controls.Add(this.lbl_responsable);
            this.Controls.Add(this.lbl_lista_envios);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormListaDeEnvios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDeEnvios";
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txt_nombre_empleado;
        private System.Windows.Forms.Label lbl_responsable;
        private System.Windows.Forms.Label lbl_lista_envios;
        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_cantidad_ordenes;
        private System.Windows.Forms.Label lbl_cantidad_ordenes;
        private System.Windows.Forms.DataGridView dataGridViewListaPedidos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_pedido_buscado;
    }
}
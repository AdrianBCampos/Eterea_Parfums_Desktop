namespace Eterea_Parfums_Desktop
{
    partial class Stock
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
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_stock_sucursal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad_producto = new System.Windows.Forms.TextBox();
            this.txt_numero_sucursal = new System.Windows.Forms.Label();
            this.lbl_datos = new System.Windows.Forms.Label();
            this.txt_datos_producto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.ForeColor = System.Drawing.Color.Black;
            this.lbl_codigo.Location = new System.Drawing.Point(88, 131);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(168, 18);
            this.lbl_codigo.TabIndex = 92;
            this.lbl_codigo.Text = "Código del Producto:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(554, 11);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(34, 32);
            this.button2.TabIndex = 91;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_stock_sucursal
            // 
            this.lbl_stock_sucursal.AutoSize = true;
            this.lbl_stock_sucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_stock_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock_sucursal.ForeColor = System.Drawing.Color.Black;
            this.lbl_stock_sucursal.Location = new System.Drawing.Point(98, 58);
            this.lbl_stock_sucursal.Name = "lbl_stock_sucursal";
            this.lbl_stock_sucursal.Size = new System.Drawing.Size(241, 18);
            this.lbl_stock_sucursal.TabIndex = 88;
            this.lbl_stock_sucursal.Text = "Agregando Stock en Sucursal: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(58, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 117);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_confirmar.Location = new System.Drawing.Point(233, 302);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(137, 37);
            this.btn_confirmar.TabIndex = 89;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(58, 232);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 58);
            this.pictureBox2.TabIndex = 93;
            this.pictureBox2.TabStop = false;
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.Location = new System.Drawing.Point(271, 133);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.Size = new System.Drawing.Size(235, 20);
            this.txt_codigo_producto.TabIndex = 94;
            this.txt_codigo_producto.TextChanged += new System.EventHandler(this.txt_codigo_producto_TextChanged);
            this.txt_codigo_producto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_producto_KeyPress);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantidad.Location = new System.Drawing.Point(88, 250);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(176, 18);
            this.lbl_cantidad.TabIndex = 95;
            this.lbl_cantidad.Text = "Cantidad de Producto:";
            // 
            // txt_cantidad_producto
            // 
            this.txt_cantidad_producto.Location = new System.Drawing.Point(313, 250);
            this.txt_cantidad_producto.Name = "txt_cantidad_producto";
            this.txt_cantidad_producto.Size = new System.Drawing.Size(158, 20);
            this.txt_cantidad_producto.TabIndex = 96;
            // 
            // txt_numero_sucursal
            // 
            this.txt_numero_sucursal.AutoSize = true;
            this.txt_numero_sucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_numero_sucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero_sucursal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_numero_sucursal.Location = new System.Drawing.Point(333, 53);
            this.txt_numero_sucursal.Name = "txt_numero_sucursal";
            this.txt_numero_sucursal.Size = new System.Drawing.Size(192, 25);
            this.txt_numero_sucursal.TabIndex = 97;
            this.txt_numero_sucursal.Text = "Número Sucursal";
            // 
            // lbl_datos
            // 
            this.lbl_datos.AutoSize = true;
            this.lbl_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datos.ForeColor = System.Drawing.Color.Black;
            this.lbl_datos.Location = new System.Drawing.Point(88, 188);
            this.lbl_datos.Name = "lbl_datos";
            this.lbl_datos.Size = new System.Drawing.Size(159, 18);
            this.lbl_datos.TabIndex = 98;
            this.lbl_datos.Text = "Datos del Producto:";
            // 
            // txt_datos_producto
            // 
            this.txt_datos_producto.AutoSize = true;
            this.txt_datos_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_datos_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datos_producto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_datos_producto.Location = new System.Drawing.Point(238, 182);
            this.txt_datos_producto.Name = "txt_datos_producto";
            this.txt_datos_producto.Size = new System.Drawing.Size(0, 25);
            this.txt_datos_producto.TabIndex = 99;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(599, 363);
            this.Controls.Add(this.txt_datos_producto);
            this.Controls.Add(this.lbl_datos);
            this.Controls.Add(this.txt_numero_sucursal);
            this.Controls.Add(this.txt_cantidad_producto);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_codigo_producto);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_stock_sucursal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_confirmar);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stock";
            this.Text = "AgregarStock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_stock_sucursal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_codigo_producto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad_producto;
        private System.Windows.Forms.Label txt_numero_sucursal;
        private System.Windows.Forms.Label lbl_datos;
        private System.Windows.Forms.Label txt_datos_producto;
    }
}
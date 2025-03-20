namespace Eterea_Parfums_Desktop.ControlesDeUsuario.GenerarInformes
{
    partial class InformesDeVentas1_UC
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
            this.lbl_error_fecha_final = new System.Windows.Forms.Label();
            this.lbl_error_fecha_inicio = new System.Windows.Forms.Label();
            this.txt_fecha_final = new System.Windows.Forms.TextBox();
            this.txt_fecha_inicial = new System.Windows.Forms.TextBox();
            this.txt_menos_vendido = new System.Windows.Forms.Label();
            this.txt_mas_vendido = new System.Windows.Forms.Label();
            this.txt_monto_total = new System.Windows.Forms.Label();
            this.txt_cantidad_ventas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_producto_menos_vendido = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_producto_mas_vendido = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_monto_total_ventas = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_cantidad_ventas = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_fin = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_fecha_final = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_fecha_inicial = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_informe_general = new System.Windows.Forms.Label();
            this.btn_exportar_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_error_fecha_final
            // 
            this.lbl_error_fecha_final.AutoSize = true;
            this.lbl_error_fecha_final.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_fecha_final.Location = new System.Drawing.Point(1109, 222);
            this.lbl_error_fecha_final.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error_fecha_final.Name = "lbl_error_fecha_final";
            this.lbl_error_fecha_final.Size = new System.Drawing.Size(36, 16);
            this.lbl_error_fecha_final.TabIndex = 190;
            this.lbl_error_fecha_final.Text = "Error";
            // 
            // lbl_error_fecha_inicio
            // 
            this.lbl_error_fecha_inicio.AutoSize = true;
            this.lbl_error_fecha_inicio.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_fecha_inicio.Location = new System.Drawing.Point(801, 222);
            this.lbl_error_fecha_inicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error_fecha_inicio.Name = "lbl_error_fecha_inicio";
            this.lbl_error_fecha_inicio.Size = new System.Drawing.Size(36, 16);
            this.lbl_error_fecha_inicio.TabIndex = 189;
            this.lbl_error_fecha_inicio.Text = "Error";
            // 
            // txt_fecha_final
            // 
            this.txt_fecha_final.Location = new System.Drawing.Point(1231, 192);
            this.txt_fecha_final.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_final.Name = "txt_fecha_final";
            this.txt_fecha_final.Size = new System.Drawing.Size(160, 22);
            this.txt_fecha_final.TabIndex = 188;
            this.txt_fecha_final.TextChanged += new System.EventHandler(this.txt_fecha_final_TextChanged);
            this.txt_fecha_final.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fecha_final_KeyDown);
            // 
            // txt_fecha_inicial
            // 
            this.txt_fecha_inicial.Location = new System.Drawing.Point(934, 192);
            this.txt_fecha_inicial.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fecha_inicial.Name = "txt_fecha_inicial";
            this.txt_fecha_inicial.Size = new System.Drawing.Size(160, 22);
            this.txt_fecha_inicial.TabIndex = 187;
            this.txt_fecha_inicial.TextChanged += new System.EventHandler(this.txt_fecha_inicial_TextChanged);
            this.txt_fecha_inicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_fecha_inicial_KeyDown);
            // 
            // txt_menos_vendido
            // 
            this.txt_menos_vendido.AutoSize = true;
            this.txt_menos_vendido.BackColor = System.Drawing.Color.White;
            this.txt_menos_vendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_menos_vendido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_menos_vendido.Location = new System.Drawing.Point(1098, 540);
            this.txt_menos_vendido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_menos_vendido.Name = "txt_menos_vendido";
            this.txt_menos_vendido.Size = new System.Drawing.Size(182, 29);
            this.txt_menos_vendido.TabIndex = 186;
            this.txt_menos_vendido.Text = "Menos Vendido";
            // 
            // txt_mas_vendido
            // 
            this.txt_mas_vendido.AutoSize = true;
            this.txt_mas_vendido.BackColor = System.Drawing.Color.White;
            this.txt_mas_vendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mas_vendido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mas_vendido.Location = new System.Drawing.Point(1098, 473);
            this.txt_mas_vendido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_mas_vendido.Name = "txt_mas_vendido";
            this.txt_mas_vendido.Size = new System.Drawing.Size(154, 29);
            this.txt_mas_vendido.TabIndex = 185;
            this.txt_mas_vendido.Text = "Mas Vendido";
            // 
            // txt_monto_total
            // 
            this.txt_monto_total.AutoSize = true;
            this.txt_monto_total.BackColor = System.Drawing.Color.White;
            this.txt_monto_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_monto_total.Location = new System.Drawing.Point(1098, 405);
            this.txt_monto_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_monto_total.Name = "txt_monto_total";
            this.txt_monto_total.Size = new System.Drawing.Size(141, 29);
            this.txt_monto_total.TabIndex = 184;
            this.txt_monto_total.Text = "Monto Total";
            // 
            // txt_cantidad_ventas
            // 
            this.txt_cantidad_ventas.AutoSize = true;
            this.txt_cantidad_ventas.BackColor = System.Drawing.Color.White;
            this.txt_cantidad_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_ventas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cantidad_ventas.Location = new System.Drawing.Point(1098, 341);
            this.txt_cantidad_ventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_cantidad_ventas.Name = "txt_cantidad_ventas";
            this.txt_cantidad_ventas.Size = new System.Drawing.Size(188, 29);
            this.txt_cantidad_ventas.TabIndex = 183;
            this.txt_cantidad_ventas.Text = "Cantidad Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1245, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 24);
            this.label1.TabIndex = 182;
            this.label1.Text = ":";
            // 
            // lbl_producto_menos_vendido
            // 
            this.lbl_producto_menos_vendido.AutoSize = true;
            this.lbl_producto_menos_vendido.BackColor = System.Drawing.Color.White;
            this.lbl_producto_menos_vendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto_menos_vendido.ForeColor = System.Drawing.Color.Black;
            this.lbl_producto_menos_vendido.Location = new System.Drawing.Point(741, 540);
            this.lbl_producto_menos_vendido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_producto_menos_vendido.Name = "lbl_producto_menos_vendido";
            this.lbl_producto_menos_vendido.Size = new System.Drawing.Size(340, 29);
            this.lbl_producto_menos_vendido.TabIndex = 181;
            this.lbl_producto_menos_vendido.Text = "Productos menos Vendidos:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Location = new System.Drawing.Point(733, 524);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(733, 60);
            this.pictureBox6.TabIndex = 180;
            this.pictureBox6.TabStop = false;
            // 
            // lbl_producto_mas_vendido
            // 
            this.lbl_producto_mas_vendido.AutoSize = true;
            this.lbl_producto_mas_vendido.BackColor = System.Drawing.Color.White;
            this.lbl_producto_mas_vendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto_mas_vendido.ForeColor = System.Drawing.Color.Black;
            this.lbl_producto_mas_vendido.Location = new System.Drawing.Point(741, 473);
            this.lbl_producto_mas_vendido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_producto_mas_vendido.Name = "lbl_producto_mas_vendido";
            this.lbl_producto_mas_vendido.Size = new System.Drawing.Size(310, 29);
            this.lbl_producto_mas_vendido.TabIndex = 179;
            this.lbl_producto_mas_vendido.Text = "Productos más Vendidos:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(733, 457);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(733, 60);
            this.pictureBox5.TabIndex = 178;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_monto_total_ventas
            // 
            this.lbl_monto_total_ventas.AutoSize = true;
            this.lbl_monto_total_ventas.BackColor = System.Drawing.Color.White;
            this.lbl_monto_total_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto_total_ventas.ForeColor = System.Drawing.Color.Black;
            this.lbl_monto_total_ventas.Location = new System.Drawing.Point(741, 407);
            this.lbl_monto_total_ventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_monto_total_ventas.Name = "lbl_monto_total_ventas";
            this.lbl_monto_total_ventas.Size = new System.Drawing.Size(282, 29);
            this.lbl_monto_total_ventas.TabIndex = 177;
            this.lbl_monto_total_ventas.Text = "Monto Total de Ventas:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(733, 391);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(733, 60);
            this.pictureBox4.TabIndex = 176;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_cantidad_ventas
            // 
            this.lbl_cantidad_ventas.AutoSize = true;
            this.lbl_cantidad_ventas.BackColor = System.Drawing.Color.White;
            this.lbl_cantidad_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_ventas.ForeColor = System.Drawing.Color.Black;
            this.lbl_cantidad_ventas.Location = new System.Drawing.Point(741, 341);
            this.lbl_cantidad_ventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidad_ventas.Name = "lbl_cantidad_ventas";
            this.lbl_cantidad_ventas.Size = new System.Drawing.Size(247, 29);
            this.lbl_cantidad_ventas.TabIndex = 175;
            this.lbl_cantidad_ventas.Text = "Cantidad de Ventas:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(733, 325);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(733, 60);
            this.pictureBox3.TabIndex = 174;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_fin
            // 
            this.lbl_fin.AutoSize = true;
            this.lbl_fin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_fin.Location = new System.Drawing.Point(1139, 282);
            this.lbl_fin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fin.Name = "lbl_fin";
            this.lbl_fin.Size = new System.Drawing.Size(91, 31);
            this.lbl_fin.TabIndex = 173;
            this.lbl_fin.Text = "Hasta";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.ForeColor = System.Drawing.Color.Black;
            this.lbl_hasta.Location = new System.Drawing.Point(1078, 288);
            this.lbl_hasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(59, 24);
            this.lbl_hasta.TabIndex = 172;
            this.lbl_hasta.Text = "hasta";
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_inicio.Location = new System.Drawing.Point(973, 281);
            this.lbl_inicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(98, 31);
            this.lbl_inicio.TabIndex = 171;
            this.lbl_inicio.Text = "Desde";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.ForeColor = System.Drawing.Color.Black;
            this.lbl_desde.Location = new System.Drawing.Point(725, 288);
            this.lbl_desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(240, 24);
            this.lbl_desde.TabIndex = 170;
            this.lbl_desde.Text = "Informe de ventas desde";
            // 
            // lbl_fecha_final
            // 
            this.lbl_fecha_final.AutoSize = true;
            this.lbl_fecha_final.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_fecha_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_final.ForeColor = System.Drawing.Color.Black;
            this.lbl_fecha_final.Location = new System.Drawing.Point(1103, 195);
            this.lbl_fecha_final.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_final.Name = "lbl_fecha_final";
            this.lbl_fecha_final.Size = new System.Drawing.Size(127, 24);
            this.lbl_fecha_final.TabIndex = 169;
            this.lbl_fecha_final.Text = "Fecha Final:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(713, 271);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(773, 329);
            this.pictureBox2.TabIndex = 167;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_fecha_inicial
            // 
            this.lbl_fecha_inicial.AutoSize = true;
            this.lbl_fecha_inicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_fecha_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicial.ForeColor = System.Drawing.Color.Black;
            this.lbl_fecha_inicial.Location = new System.Drawing.Point(795, 195);
            this.lbl_fecha_inicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_inicial.Name = "lbl_fecha_inicial";
            this.lbl_fecha_inicial.Size = new System.Drawing.Size(135, 24);
            this.lbl_fecha_inicial.TabIndex = 166;
            this.lbl_fecha_inicial.Text = "Fecha Inicial:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(713, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 96);
            this.pictureBox1.TabIndex = 165;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_informe_general
            // 
            this.lbl_informe_general.AutoSize = true;
            this.lbl_informe_general.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_informe_general.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informe_general.ForeColor = System.Drawing.Color.Black;
            this.lbl_informe_general.Location = new System.Drawing.Point(973, 111);
            this.lbl_informe_general.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_informe_general.Name = "lbl_informe_general";
            this.lbl_informe_general.Size = new System.Drawing.Size(260, 24);
            this.lbl_informe_general.TabIndex = 163;
            this.lbl_informe_general.Text = "Informe General de Ventas";
            // 
            // btn_exportar_pdf
            // 
            this.btn_exportar_pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_exportar_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar_pdf.Location = new System.Drawing.Point(1021, 616);
            this.btn_exportar_pdf.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exportar_pdf.Name = "btn_exportar_pdf";
            this.btn_exportar_pdf.Size = new System.Drawing.Size(183, 46);
            this.btn_exportar_pdf.TabIndex = 164;
            this.btn_exportar_pdf.Text = "Exportar PDF";
            this.btn_exportar_pdf.UseVisualStyleBackColor = false;
            this.btn_exportar_pdf.Click += new System.EventHandler(this.btn_exportar_pdf_Click);
            // 
            // InformesDeVentas1_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.Controls.Add(this.lbl_error_fecha_final);
            this.Controls.Add(this.lbl_error_fecha_inicio);
            this.Controls.Add(this.txt_fecha_final);
            this.Controls.Add(this.txt_fecha_inicial);
            this.Controls.Add(this.txt_menos_vendido);
            this.Controls.Add(this.txt_mas_vendido);
            this.Controls.Add(this.txt_monto_total);
            this.Controls.Add(this.txt_cantidad_ventas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_producto_menos_vendido);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lbl_producto_mas_vendido);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbl_monto_total_ventas);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_cantidad_ventas);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_fin);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.lbl_inicio);
            this.Controls.Add(this.lbl_desde);
            this.Controls.Add(this.lbl_fecha_final);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_fecha_inicial);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_informe_general);
            this.Controls.Add(this.btn_exportar_pdf);
            this.Name = "InformesDeVentas1_UC";
            this.Size = new System.Drawing.Size(2023, 745);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_error_fecha_final;
        private System.Windows.Forms.Label lbl_error_fecha_inicio;
        private System.Windows.Forms.TextBox txt_fecha_final;
        private System.Windows.Forms.TextBox txt_fecha_inicial;
        private System.Windows.Forms.Label txt_menos_vendido;
        private System.Windows.Forms.Label txt_mas_vendido;
        private System.Windows.Forms.Label txt_monto_total;
        private System.Windows.Forms.Label txt_cantidad_ventas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_producto_menos_vendido;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbl_producto_mas_vendido;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbl_monto_total_ventas;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_cantidad_ventas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_fin;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.Label lbl_fecha_final;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_fecha_inicial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_informe_general;
        private System.Windows.Forms.Button btn_exportar_pdf;
    }
}

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
            this.dateTimeFinal = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
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
            this.lbl_fecha_Fin = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.lbl_fecha_Inicio = new System.Windows.Forms.Label();
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_fecha_final = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbl_fecha_inicial = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_facturacion = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_exportar_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeFinal
            // 
            this.dateTimeFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeFinal.Location = new System.Drawing.Point(1479, 133);
            this.dateTimeFinal.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFinal.Name = "dateTimeFinal";
            this.dateTimeFinal.Size = new System.Drawing.Size(357, 27);
            this.dateTimeFinal.TabIndex = 462;
            this.dateTimeFinal.ValueChanged += new System.EventHandler(this.dateTimeFinal_ValueChanged);
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dateTimeInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeInicio.Location = new System.Drawing.Point(599, 133);
            this.dateTimeInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(358, 27);
            this.dateTimeInicio.TabIndex = 461;
            this.dateTimeInicio.Value = new System.DateTime(2025, 3, 18, 0, 0, 0, 0);
            this.dateTimeInicio.ValueChanged += new System.EventHandler(this.dateTimeInicio_ValueChanged);
            // 
            // txt_menos_vendido
            // 
            this.txt_menos_vendido.AutoSize = true;
            this.txt_menos_vendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.txt_menos_vendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_menos_vendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_menos_vendido.Location = new System.Drawing.Point(1587, 344);
            this.txt_menos_vendido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_menos_vendido.Name = "txt_menos_vendido";
            this.txt_menos_vendido.Size = new System.Drawing.Size(212, 32);
            this.txt_menos_vendido.TabIndex = 460;
            this.txt_menos_vendido.Text = "Menos Vendido";
            // 
            // txt_mas_vendido
            // 
            this.txt_mas_vendido.AutoSize = true;
            this.txt_mas_vendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.txt_mas_vendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mas_vendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_mas_vendido.Location = new System.Drawing.Point(1587, 275);
            this.txt_mas_vendido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_mas_vendido.Name = "txt_mas_vendido";
            this.txt_mas_vendido.Size = new System.Drawing.Size(180, 32);
            this.txt_mas_vendido.TabIndex = 459;
            this.txt_mas_vendido.Text = "Mas Vendido";
            // 
            // txt_monto_total
            // 
            this.txt_monto_total.AutoSize = true;
            this.txt_monto_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.txt_monto_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_monto_total.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_monto_total.Location = new System.Drawing.Point(577, 344);
            this.txt_monto_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_monto_total.Name = "txt_monto_total";
            this.txt_monto_total.Size = new System.Drawing.Size(164, 32);
            this.txt_monto_total.TabIndex = 458;
            this.txt_monto_total.Text = "Monto Total";
            // 
            // txt_cantidad_ventas
            // 
            this.txt_cantidad_ventas.AutoSize = true;
            this.txt_cantidad_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.txt_cantidad_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad_ventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_cantidad_ventas.Location = new System.Drawing.Point(577, 275);
            this.txt_cantidad_ventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_cantidad_ventas.Name = "txt_cantidad_ventas";
            this.txt_cantidad_ventas.Size = new System.Drawing.Size(225, 32);
            this.txt_cantidad_ventas.TabIndex = 457;
            this.txt_cantidad_ventas.Text = "Cantidad Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label1.Location = new System.Drawing.Point(1561, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 32);
            this.label1.TabIndex = 456;
            this.label1.Text = ":";
            // 
            // lbl_producto_menos_vendido
            // 
            this.lbl_producto_menos_vendido.AutoSize = true;
            this.lbl_producto_menos_vendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.lbl_producto_menos_vendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto_menos_vendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_producto_menos_vendido.Location = new System.Drawing.Point(1089, 345);
            this.lbl_producto_menos_vendido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_producto_menos_vendido.Name = "lbl_producto_menos_vendido";
            this.lbl_producto_menos_vendido.Size = new System.Drawing.Size(394, 32);
            this.lbl_producto_menos_vendido.TabIndex = 455;
            this.lbl_producto_menos_vendido.Text = "Productos menos Vendidos:";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Location = new System.Drawing.Point(995, 331);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(953, 60);
            this.pictureBox6.TabIndex = 454;
            this.pictureBox6.TabStop = false;
            // 
            // lbl_producto_mas_vendido
            // 
            this.lbl_producto_mas_vendido.AutoSize = true;
            this.lbl_producto_mas_vendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.lbl_producto_mas_vendido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_producto_mas_vendido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_producto_mas_vendido.Location = new System.Drawing.Point(1089, 275);
            this.lbl_producto_mas_vendido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_producto_mas_vendido.Name = "lbl_producto_mas_vendido";
            this.lbl_producto_mas_vendido.Size = new System.Drawing.Size(360, 32);
            this.lbl_producto_mas_vendido.TabIndex = 453;
            this.lbl_producto_mas_vendido.Text = "Productos más Vendidos:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(995, 261);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(953, 60);
            this.pictureBox5.TabIndex = 452;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_monto_total_ventas
            // 
            this.lbl_monto_total_ventas.AutoSize = true;
            this.lbl_monto_total_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.lbl_monto_total_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monto_total_ventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_monto_total_ventas.Location = new System.Drawing.Point(157, 345);
            this.lbl_monto_total_ventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_monto_total_ventas.Name = "lbl_monto_total_ventas";
            this.lbl_monto_total_ventas.Size = new System.Drawing.Size(329, 32);
            this.lbl_monto_total_ventas.TabIndex = 451;
            this.lbl_monto_total_ventas.Text = "Monto Total de Ventas:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(50, 331);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(939, 60);
            this.pictureBox4.TabIndex = 450;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_cantidad_ventas
            // 
            this.lbl_cantidad_ventas.AutoSize = true;
            this.lbl_cantidad_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.lbl_cantidad_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad_ventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_cantidad_ventas.Location = new System.Drawing.Point(157, 275);
            this.lbl_cantidad_ventas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cantidad_ventas.Name = "lbl_cantidad_ventas";
            this.lbl_cantidad_ventas.Size = new System.Drawing.Size(291, 32);
            this.lbl_cantidad_ventas.TabIndex = 449;
            this.lbl_cantidad_ventas.Text = "Cantidad de Ventas:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(50, 261);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(939, 60);
            this.pictureBox3.TabIndex = 448;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_fecha_Fin
            // 
            this.lbl_fecha_Fin.AutoSize = true;
            this.lbl_fecha_Fin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.lbl_fecha_Fin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_Fin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_fecha_Fin.Location = new System.Drawing.Point(1209, 207);
            this.lbl_fecha_Fin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_Fin.Name = "lbl_fecha_Fin";
            this.lbl_fecha_Fin.Size = new System.Drawing.Size(329, 32);
            this.lbl_fecha_Fin.TabIndex = 447;
            this.lbl_fecha_Fin.Text = "...................................";
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.lbl_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_hasta.Location = new System.Drawing.Point(1087, 208);
            this.lbl_hasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(84, 32);
            this.lbl_hasta.TabIndex = 446;
            this.lbl_hasta.Text = "hasta";
            // 
            // lbl_fecha_Inicio
            // 
            this.lbl_fecha_Inicio.AutoSize = true;
            this.lbl_fecha_Inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.lbl_fecha_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_Inicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_fecha_Inicio.Location = new System.Drawing.Point(717, 207);
            this.lbl_fecha_Inicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_Inicio.Name = "lbl_fecha_Inicio";
            this.lbl_fecha_Inicio.Size = new System.Drawing.Size(329, 32);
            this.lbl_fecha_Inicio.TabIndex = 445;
            this.lbl_fecha_Inicio.Text = "...................................";
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.lbl_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_desde.Location = new System.Drawing.Point(356, 207);
            this.lbl_desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(324, 32);
            this.lbl_desde.TabIndex = 444;
            this.lbl_desde.Text = "Informe de ventas desde";
            // 
            // lbl_fecha_final
            // 
            this.lbl_fecha_final.AutoSize = true;
            this.lbl_fecha_final.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_fecha_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_final.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_fecha_final.Location = new System.Drawing.Point(1079, 133);
            this.lbl_fecha_final.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_final.Name = "lbl_fecha_final";
            this.lbl_fecha_final.Size = new System.Drawing.Size(352, 29);
            this.lbl_fecha_final.TabIndex = 443;
            this.lbl_fecha_final.Text = "Seleccionar una Fecha Final:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox7.Location = new System.Drawing.Point(23, 196);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1954, 275);
            this.pictureBox7.TabIndex = 442;
            this.pictureBox7.TabStop = false;
            // 
            // lbl_fecha_inicial
            // 
            this.lbl_fecha_inicial.AutoSize = true;
            this.lbl_fecha_inicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_fecha_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_fecha_inicial.Location = new System.Drawing.Point(191, 133);
            this.lbl_fecha_inicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fecha_inicial.Name = "lbl_fecha_inicial";
            this.lbl_fecha_inicial.Size = new System.Drawing.Size(363, 29);
            this.lbl_fecha_inicial.TabIndex = 441;
            this.lbl_fecha_inicial.Text = "Seleccionar una Fecha Inicial:";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox8.Location = new System.Drawing.Point(23, 96);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1954, 96);
            this.pictureBox8.TabIndex = 440;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(10, 88);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1979, 392);
            this.pictureBox1.TabIndex = 439;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_facturacion
            // 
            this.lbl_facturacion.AutoSize = true;
            this.lbl_facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_facturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_facturacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.lbl_facturacion.Location = new System.Drawing.Point(878, 22);
            this.lbl_facturacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_facturacion.Name = "lbl_facturacion";
            this.lbl_facturacion.Size = new System.Drawing.Size(317, 38);
            this.lbl_facturacion.TabIndex = 437;
            this.lbl_facturacion.Text = "Informes de Ventas";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox9.Location = new System.Drawing.Point(11, 7);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(1978, 74);
            this.pictureBox9.TabIndex = 438;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(37, 250);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1925, 153);
            this.pictureBox2.TabIndex = 464;
            this.pictureBox2.TabStop = false;
            // 
            // btn_exportar_pdf
            // 
            this.btn_exportar_pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_exportar_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exportar_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exportar_pdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_exportar_pdf.Location = new System.Drawing.Point(855, 413);
            this.btn_exportar_pdf.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exportar_pdf.Name = "btn_exportar_pdf";
            this.btn_exportar_pdf.Size = new System.Drawing.Size(279, 49);
            this.btn_exportar_pdf.TabIndex = 465;
            this.btn_exportar_pdf.Text = "Exportar PDF";
            this.btn_exportar_pdf.UseVisualStyleBackColor = false;
            this.btn_exportar_pdf.Click += new System.EventHandler(this.btn_exportar_pdf_Click);
            // 
            // InformesDeVentas1_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.btn_exportar_pdf);
            this.Controls.Add(this.txt_menos_vendido);
            this.Controls.Add(this.txt_mas_vendido);
            this.Controls.Add(this.txt_monto_total);
            this.Controls.Add(this.txt_cantidad_ventas);
            this.Controls.Add(this.lbl_producto_menos_vendido);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lbl_producto_mas_vendido);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbl_monto_total_ventas);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbl_cantidad_ventas);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dateTimeFinal);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fecha_Fin);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.lbl_fecha_Inicio);
            this.Controls.Add(this.lbl_desde);
            this.Controls.Add(this.lbl_fecha_final);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lbl_fecha_inicial);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_facturacion);
            this.Controls.Add(this.pictureBox9);
            this.Name = "InformesDeVentas1_UC";
            this.Size = new System.Drawing.Size(2000, 492);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeFinal;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
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
        private System.Windows.Forms.Label lbl_fecha_Fin;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.Label lbl_fecha_Inicio;
        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.Label lbl_fecha_final;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbl_fecha_inicial;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_facturacion;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_exportar_pdf;
    }
}

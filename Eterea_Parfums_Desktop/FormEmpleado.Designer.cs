namespace Eterea_Parfums_Desktop
{
    partial class FormEmpleado
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
            this.btn_crear = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTime_ing = new System.Windows.Forms.DateTimePicker();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_activo = new System.Windows.Forms.ComboBox();
            this.combo_sucursal = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_comentarios_domicilio = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_departamento = new System.Windows.Forms.TextBox();
            this.combo_rol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTime_nac = new System.Windows.Forms.DateTimePicker();
            this.txt_cp = new System.Windows.Forms.TextBox();
            this.combo_calle = new System.Windows.Forms.ComboBox();
            this.combo_localidad = new System.Windows.Forms.ComboBox();
            this.combo_provincia = new System.Windows.Forms.ComboBox();
            this.combo_pais = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_num_calle = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_e_mail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_sucursalE = new System.Windows.Forms.PictureBox();
            this.lbl_usuarioE = new System.Windows.Forms.Label();
            this.lbl_claveE = new System.Windows.Forms.Label();
            this.lbl_nombreE = new System.Windows.Forms.Label();
            this.lbl_apellidoE = new System.Windows.Forms.Label();
            this.lbl_dniE = new System.Windows.Forms.Label();
            this.lbl_nacE = new System.Windows.Forms.Label();
            this.lbl_celularE = new System.Windows.Forms.Label();
            this.lbl_e_mailE = new System.Windows.Forms.Label();
            this.lbl_paisE = new System.Windows.Forms.Label();
            this.lbl_provinciaE = new System.Windows.Forms.Label();
            this.lbl_localidadE = new System.Windows.Forms.Label();
            this.lbl_cpE = new System.Windows.Forms.Label();
            this.lbl_calleE = new System.Windows.Forms.Label();
            this.lbl_num_calleE = new System.Windows.Forms.Label();
            this.lbl_pisoE = new System.Windows.Forms.Label();
            this.lbl_departamentoE = new System.Windows.Forms.Label();
            this.lbl_comentarios_domicilioE = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lbl_ingE = new System.Windows.Forms.Label();
            this.lbl_sueldoE = new System.Windows.Forms.Label();
            this.lbl_activoE = new System.Windows.Forms.Label();
            this.lbl_rolE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_sucursalE)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.Pink;
            this.btn_crear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.Location = new System.Drawing.Point(310, 633);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(151, 37);
            this.btn_crear.TabIndex = 158;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label17.Location = new System.Drawing.Point(434, 413);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 157;
            this.label17.Text = "Fecha de ingreso";
            // 
            // dateTime_ing
            // 
            this.dateTime_ing.Location = new System.Drawing.Point(583, 405);
            this.dateTime_ing.Name = "dateTime_ing";
            this.dateTime_ing.Size = new System.Drawing.Size(150, 20);
            this.dateTime_ing.TabIndex = 156;
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Location = new System.Drawing.Point(583, 453);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(150, 20);
            this.txt_sueldo.TabIndex = 155;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label8.Location = new System.Drawing.Point(435, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 154;
            this.label8.Text = "Sueldo";
            // 
            // combo_activo
            // 
            this.combo_activo.FormattingEnabled = true;
            this.combo_activo.Location = new System.Drawing.Point(583, 502);
            this.combo_activo.Name = "combo_activo";
            this.combo_activo.Size = new System.Drawing.Size(150, 21);
            this.combo_activo.TabIndex = 153;
            // 
            // combo_sucursal
            // 
            this.combo_sucursal.FormattingEnabled = true;
            this.combo_sucursal.Location = new System.Drawing.Point(583, 356);
            this.combo_sucursal.Name = "combo_sucursal";
            this.combo_sucursal.Size = new System.Drawing.Size(150, 21);
            this.combo_sucursal.TabIndex = 152;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label15.Location = new System.Drawing.Point(435, 505);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 151;
            this.label15.Text = "Activo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label16.Location = new System.Drawing.Point(434, 359);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 150;
            this.label16.Text = "Sucursal";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label19.Location = new System.Drawing.Point(433, 310);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 13);
            this.label19.TabIndex = 149;
            this.label19.Text = "Comentarios de domicilio";
            // 
            // txt_comentarios_domicilio
            // 
            this.txt_comentarios_domicilio.Location = new System.Drawing.Point(583, 306);
            this.txt_comentarios_domicilio.Name = "txt_comentarios_domicilio";
            this.txt_comentarios_domicilio.Size = new System.Drawing.Size(150, 20);
            this.txt_comentarios_domicilio.TabIndex = 148;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label20.Location = new System.Drawing.Point(434, 260);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 147;
            this.label20.Text = "Departamento";
            // 
            // txt_departamento
            // 
            this.txt_departamento.Location = new System.Drawing.Point(583, 257);
            this.txt_departamento.Name = "txt_departamento";
            this.txt_departamento.Size = new System.Drawing.Size(150, 20);
            this.txt_departamento.TabIndex = 146;
            // 
            // combo_rol
            // 
            this.combo_rol.FormattingEnabled = true;
            this.combo_rol.Location = new System.Drawing.Point(583, 550);
            this.combo_rol.Name = "combo_rol";
            this.combo_rol.Size = new System.Drawing.Size(150, 21);
            this.combo_rol.TabIndex = 145;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(438, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 144;
            this.label5.Text = "Rol";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(720, 7);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(34, 32);
            this.btn_cancelar.TabIndex = 143;
            this.btn_cancelar.Text = "X";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label14.Location = new System.Drawing.Point(43, 301);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 142;
            this.label14.Text = "Fecha de nacimiento";
            // 
            // dateTime_nac
            // 
            this.dateTime_nac.Location = new System.Drawing.Point(158, 300);
            this.dateTime_nac.Name = "dateTime_nac";
            this.dateTime_nac.Size = new System.Drawing.Size(150, 20);
            this.dateTime_nac.TabIndex = 141;
            // 
            // txt_cp
            // 
            this.txt_cp.Location = new System.Drawing.Point(583, 64);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(150, 20);
            this.txt_cp.TabIndex = 140;
            // 
            // combo_calle
            // 
            this.combo_calle.FormattingEnabled = true;
            this.combo_calle.Location = new System.Drawing.Point(583, 109);
            this.combo_calle.Name = "combo_calle";
            this.combo_calle.Size = new System.Drawing.Size(150, 21);
            this.combo_calle.TabIndex = 139;
            // 
            // combo_localidad
            // 
            this.combo_localidad.FormattingEnabled = true;
            this.combo_localidad.Location = new System.Drawing.Point(158, 533);
            this.combo_localidad.Name = "combo_localidad";
            this.combo_localidad.Size = new System.Drawing.Size(150, 21);
            this.combo_localidad.TabIndex = 138;
            // 
            // combo_provincia
            // 
            this.combo_provincia.FormattingEnabled = true;
            this.combo_provincia.Location = new System.Drawing.Point(158, 485);
            this.combo_provincia.Name = "combo_provincia";
            this.combo_provincia.Size = new System.Drawing.Size(150, 21);
            this.combo_provincia.TabIndex = 137;
            // 
            // combo_pais
            // 
            this.combo_pais.FormattingEnabled = true;
            this.combo_pais.Location = new System.Drawing.Point(158, 438);
            this.combo_pais.Name = "combo_pais";
            this.combo_pais.Size = new System.Drawing.Size(150, 21);
            this.combo_pais.TabIndex = 136;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label21.Location = new System.Drawing.Point(434, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(27, 13);
            this.label21.TabIndex = 135;
            this.label21.Text = "Piso";
            // 
            // txt_piso
            // 
            this.txt_piso.Location = new System.Drawing.Point(583, 206);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(150, 20);
            this.txt_piso.TabIndex = 134;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label22.Location = new System.Drawing.Point(433, 161);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(84, 13);
            this.label22.TabIndex = 133;
            this.label22.Text = "Numero de calle";
            // 
            // txt_num_calle
            // 
            this.txt_num_calle.Location = new System.Drawing.Point(583, 157);
            this.txt_num_calle.Name = "txt_num_calle";
            this.txt_num_calle.Size = new System.Drawing.Size(150, 20);
            this.txt_num_calle.TabIndex = 132;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label23.Location = new System.Drawing.Point(433, 113);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 131;
            this.label23.Text = "Calle";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label24.Location = new System.Drawing.Point(433, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 13);
            this.label24.TabIndex = 130;
            this.label24.Text = "Codigo postal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label13.Location = new System.Drawing.Point(43, 536);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 129;
            this.label13.Text = "Localidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label12.Location = new System.Drawing.Point(43, 487);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 128;
            this.label12.Text = "Provincia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label11.Location = new System.Drawing.Point(44, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 127;
            this.label11.Text = "Pais";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label10.Location = new System.Drawing.Point(43, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 126;
            this.label10.Text = "Email";
            // 
            // txt_e_mail
            // 
            this.txt_e_mail.Location = new System.Drawing.Point(158, 393);
            this.txt_e_mail.Name = "txt_e_mail";
            this.txt_e_mail.Size = new System.Drawing.Size(150, 20);
            this.txt_e_mail.TabIndex = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label9.Location = new System.Drawing.Point(43, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "Celular";
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(158, 346);
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(150, 20);
            this.txt_celular.TabIndex = 123;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label7.Location = new System.Drawing.Point(44, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 122;
            this.label7.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(158, 253);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(150, 20);
            this.txt_dni.TabIndex = 121;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(44, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 120;
            this.label6.Text = "Apellido";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(158, 205);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(150, 20);
            this.txt_apellido.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label2.Location = new System.Drawing.Point(43, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(158, 158);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(150, 20);
            this.txt_nombre.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(44, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 116;
            this.label4.Text = "Clave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(43, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 115;
            this.label3.Text = "Usuario";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(158, 66);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(150, 20);
            this.txt_usuario.TabIndex = 114;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(158, 111);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(150, 20);
            this.txt_contraseña.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(282, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 47);
            this.label1.TabIndex = 112;
            this.label1.Text = "Crear Empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(26, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 559);
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_sucursalE
            // 
            this.lbl_sucursalE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_sucursalE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbl_sucursalE.Location = new System.Drawing.Point(418, 49);
            this.lbl_sucursalE.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_sucursalE.Name = "lbl_sucursalE";
            this.lbl_sucursalE.Size = new System.Drawing.Size(336, 559);
            this.lbl_sucursalE.TabIndex = 160;
            this.lbl_sucursalE.TabStop = false;
            // 
            // lbl_usuarioE
            // 
            this.lbl_usuarioE.AutoSize = true;
            this.lbl_usuarioE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_usuarioE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_usuarioE.Location = new System.Drawing.Point(156, 93);
            this.lbl_usuarioE.Name = "lbl_usuarioE";
            this.lbl_usuarioE.Size = new System.Drawing.Size(29, 13);
            this.lbl_usuarioE.TabIndex = 161;
            this.lbl_usuarioE.Text = "Error";
            // 
            // lbl_claveE
            // 
            this.lbl_claveE.AutoSize = true;
            this.lbl_claveE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_claveE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_claveE.Location = new System.Drawing.Point(156, 138);
            this.lbl_claveE.Name = "lbl_claveE";
            this.lbl_claveE.Size = new System.Drawing.Size(29, 13);
            this.lbl_claveE.TabIndex = 162;
            this.lbl_claveE.Text = "Error";
            // 
            // lbl_nombreE
            // 
            this.lbl_nombreE.AutoSize = true;
            this.lbl_nombreE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombreE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_nombreE.Location = new System.Drawing.Point(156, 184);
            this.lbl_nombreE.Name = "lbl_nombreE";
            this.lbl_nombreE.Size = new System.Drawing.Size(29, 13);
            this.lbl_nombreE.TabIndex = 163;
            this.lbl_nombreE.Text = "Error";
            // 
            // lbl_apellidoE
            // 
            this.lbl_apellidoE.AutoSize = true;
            this.lbl_apellidoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_apellidoE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_apellidoE.Location = new System.Drawing.Point(156, 232);
            this.lbl_apellidoE.Name = "lbl_apellidoE";
            this.lbl_apellidoE.Size = new System.Drawing.Size(29, 13);
            this.lbl_apellidoE.TabIndex = 164;
            this.lbl_apellidoE.Text = "Error";
            // 
            // lbl_dniE
            // 
            this.lbl_dniE.AutoSize = true;
            this.lbl_dniE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_dniE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_dniE.Location = new System.Drawing.Point(156, 280);
            this.lbl_dniE.Name = "lbl_dniE";
            this.lbl_dniE.Size = new System.Drawing.Size(29, 13);
            this.lbl_dniE.TabIndex = 165;
            this.lbl_dniE.Text = "Error";
            // 
            // lbl_nacE
            // 
            this.lbl_nacE.AutoSize = true;
            this.lbl_nacE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nacE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_nacE.Location = new System.Drawing.Point(156, 327);
            this.lbl_nacE.Name = "lbl_nacE";
            this.lbl_nacE.Size = new System.Drawing.Size(29, 13);
            this.lbl_nacE.TabIndex = 166;
            this.lbl_nacE.Text = "Error";
            // 
            // lbl_celularE
            // 
            this.lbl_celularE.AutoSize = true;
            this.lbl_celularE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_celularE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_celularE.Location = new System.Drawing.Point(156, 373);
            this.lbl_celularE.Name = "lbl_celularE";
            this.lbl_celularE.Size = new System.Drawing.Size(29, 13);
            this.lbl_celularE.TabIndex = 167;
            this.lbl_celularE.Text = "Error";
            // 
            // lbl_e_mailE
            // 
            this.lbl_e_mailE.AutoSize = true;
            this.lbl_e_mailE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_e_mailE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_e_mailE.Location = new System.Drawing.Point(156, 420);
            this.lbl_e_mailE.Name = "lbl_e_mailE";
            this.lbl_e_mailE.Size = new System.Drawing.Size(29, 13);
            this.lbl_e_mailE.TabIndex = 168;
            this.lbl_e_mailE.Text = "Error";
            // 
            // lbl_paisE
            // 
            this.lbl_paisE.AutoSize = true;
            this.lbl_paisE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_paisE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_paisE.Location = new System.Drawing.Point(156, 466);
            this.lbl_paisE.Name = "lbl_paisE";
            this.lbl_paisE.Size = new System.Drawing.Size(29, 13);
            this.lbl_paisE.TabIndex = 169;
            this.lbl_paisE.Text = "Error";
            // 
            // lbl_provinciaE
            // 
            this.lbl_provinciaE.AutoSize = true;
            this.lbl_provinciaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_provinciaE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_provinciaE.Location = new System.Drawing.Point(156, 513);
            this.lbl_provinciaE.Name = "lbl_provinciaE";
            this.lbl_provinciaE.Size = new System.Drawing.Size(29, 13);
            this.lbl_provinciaE.TabIndex = 170;
            this.lbl_provinciaE.Text = "Error";
            // 
            // lbl_localidadE
            // 
            this.lbl_localidadE.AutoSize = true;
            this.lbl_localidadE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_localidadE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_localidadE.Location = new System.Drawing.Point(156, 561);
            this.lbl_localidadE.Name = "lbl_localidadE";
            this.lbl_localidadE.Size = new System.Drawing.Size(29, 13);
            this.lbl_localidadE.TabIndex = 171;
            this.lbl_localidadE.Text = "Error";
            // 
            // lbl_cpE
            // 
            this.lbl_cpE.AutoSize = true;
            this.lbl_cpE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_cpE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_cpE.Location = new System.Drawing.Point(584, 91);
            this.lbl_cpE.Name = "lbl_cpE";
            this.lbl_cpE.Size = new System.Drawing.Size(29, 13);
            this.lbl_cpE.TabIndex = 172;
            this.lbl_cpE.Text = "Error";
            // 
            // lbl_calleE
            // 
            this.lbl_calleE.AutoSize = true;
            this.lbl_calleE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_calleE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_calleE.Location = new System.Drawing.Point(584, 137);
            this.lbl_calleE.Name = "lbl_calleE";
            this.lbl_calleE.Size = new System.Drawing.Size(29, 13);
            this.lbl_calleE.TabIndex = 173;
            this.lbl_calleE.Text = "Error";
            // 
            // lbl_num_calleE
            // 
            this.lbl_num_calleE.AutoSize = true;
            this.lbl_num_calleE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_num_calleE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_num_calleE.Location = new System.Drawing.Point(584, 188);
            this.lbl_num_calleE.Name = "lbl_num_calleE";
            this.lbl_num_calleE.Size = new System.Drawing.Size(29, 13);
            this.lbl_num_calleE.TabIndex = 174;
            this.lbl_num_calleE.Text = "Error";
            // 
            // lbl_pisoE
            // 
            this.lbl_pisoE.AutoSize = true;
            this.lbl_pisoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_pisoE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_pisoE.Location = new System.Drawing.Point(584, 236);
            this.lbl_pisoE.Name = "lbl_pisoE";
            this.lbl_pisoE.Size = new System.Drawing.Size(29, 13);
            this.lbl_pisoE.TabIndex = 175;
            this.lbl_pisoE.Text = "Error";
            // 
            // lbl_departamentoE
            // 
            this.lbl_departamentoE.AutoSize = true;
            this.lbl_departamentoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_departamentoE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_departamentoE.Location = new System.Drawing.Point(584, 284);
            this.lbl_departamentoE.Name = "lbl_departamentoE";
            this.lbl_departamentoE.Size = new System.Drawing.Size(29, 13);
            this.lbl_departamentoE.TabIndex = 176;
            this.lbl_departamentoE.Text = "Error";
            // 
            // lbl_comentarios_domicilioE
            // 
            this.lbl_comentarios_domicilioE.AutoSize = true;
            this.lbl_comentarios_domicilioE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_comentarios_domicilioE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_comentarios_domicilioE.Location = new System.Drawing.Point(584, 333);
            this.lbl_comentarios_domicilioE.Name = "lbl_comentarios_domicilioE";
            this.lbl_comentarios_domicilioE.Size = new System.Drawing.Size(29, 13);
            this.lbl_comentarios_domicilioE.TabIndex = 177;
            this.lbl_comentarios_domicilioE.Text = "Error";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label40.ForeColor = System.Drawing.Color.Crimson;
            this.label40.Location = new System.Drawing.Point(584, 384);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(29, 13);
            this.label40.TabIndex = 178;
            this.label40.Text = "Error";
            // 
            // lbl_ingE
            // 
            this.lbl_ingE.AutoSize = true;
            this.lbl_ingE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_ingE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_ingE.Location = new System.Drawing.Point(584, 432);
            this.lbl_ingE.Name = "lbl_ingE";
            this.lbl_ingE.Size = new System.Drawing.Size(29, 13);
            this.lbl_ingE.TabIndex = 179;
            this.lbl_ingE.Text = "Error";
            // 
            // lbl_sueldoE
            // 
            this.lbl_sueldoE.AutoSize = true;
            this.lbl_sueldoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_sueldoE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_sueldoE.Location = new System.Drawing.Point(584, 480);
            this.lbl_sueldoE.Name = "lbl_sueldoE";
            this.lbl_sueldoE.Size = new System.Drawing.Size(29, 13);
            this.lbl_sueldoE.TabIndex = 180;
            this.lbl_sueldoE.Text = "Error";
            // 
            // lbl_activoE
            // 
            this.lbl_activoE.AutoSize = true;
            this.lbl_activoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_activoE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_activoE.Location = new System.Drawing.Point(584, 527);
            this.lbl_activoE.Name = "lbl_activoE";
            this.lbl_activoE.Size = new System.Drawing.Size(29, 13);
            this.lbl_activoE.TabIndex = 181;
            this.lbl_activoE.Text = "Error";
            // 
            // lbl_rolE
            // 
            this.lbl_rolE.AutoSize = true;
            this.lbl_rolE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_rolE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_rolE.Location = new System.Drawing.Point(584, 578);
            this.lbl_rolE.Name = "lbl_rolE";
            this.lbl_rolE.Size = new System.Drawing.Size(29, 13);
            this.lbl_rolE.TabIndex = 182;
            this.lbl_rolE.Text = "Error";
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(772, 694);
            this.Controls.Add(this.lbl_rolE);
            this.Controls.Add(this.lbl_activoE);
            this.Controls.Add(this.lbl_sueldoE);
            this.Controls.Add(this.lbl_ingE);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.lbl_comentarios_domicilioE);
            this.Controls.Add(this.lbl_departamentoE);
            this.Controls.Add(this.lbl_pisoE);
            this.Controls.Add(this.lbl_num_calleE);
            this.Controls.Add(this.lbl_calleE);
            this.Controls.Add(this.lbl_cpE);
            this.Controls.Add(this.lbl_localidadE);
            this.Controls.Add(this.lbl_provinciaE);
            this.Controls.Add(this.lbl_paisE);
            this.Controls.Add(this.lbl_e_mailE);
            this.Controls.Add(this.lbl_celularE);
            this.Controls.Add(this.lbl_nacE);
            this.Controls.Add(this.lbl_dniE);
            this.Controls.Add(this.lbl_apellidoE);
            this.Controls.Add(this.lbl_nombreE);
            this.Controls.Add(this.lbl_claveE);
            this.Controls.Add(this.lbl_usuarioE);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateTime_ing);
            this.Controls.Add(this.txt_sueldo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combo_activo);
            this.Controls.Add(this.combo_sucursal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_comentarios_domicilio);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_departamento);
            this.Controls.Add(this.combo_rol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTime_nac);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.combo_calle);
            this.Controls.Add(this.combo_localidad);
            this.Controls.Add(this.combo_provincia);
            this.Controls.Add(this.combo_pais);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txt_piso);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_num_calle);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_e_mail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_celular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_sucursalE);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_sucursalE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTime_ing;
        private System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_activo;
        private System.Windows.Forms.ComboBox combo_sucursal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_comentarios_domicilio;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_departamento;
        private System.Windows.Forms.ComboBox combo_rol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTime_nac;
        private System.Windows.Forms.TextBox txt_cp;
        private System.Windows.Forms.ComboBox combo_calle;
        private System.Windows.Forms.ComboBox combo_localidad;
        private System.Windows.Forms.ComboBox combo_provincia;
        private System.Windows.Forms.ComboBox combo_pais;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_num_calle;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_e_mail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_celular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lbl_sucursalE;
        private System.Windows.Forms.Label lbl_usuarioE;
        private System.Windows.Forms.Label lbl_claveE;
        private System.Windows.Forms.Label lbl_nombreE;
        private System.Windows.Forms.Label lbl_apellidoE;
        private System.Windows.Forms.Label lbl_dniE;
        private System.Windows.Forms.Label lbl_nacE;
        private System.Windows.Forms.Label lbl_celularE;
        private System.Windows.Forms.Label lbl_e_mailE;
        private System.Windows.Forms.Label lbl_paisE;
        private System.Windows.Forms.Label lbl_provinciaE;
        private System.Windows.Forms.Label lbl_localidadE;
        private System.Windows.Forms.Label lbl_cpE;
        private System.Windows.Forms.Label lbl_calleE;
        private System.Windows.Forms.Label lbl_num_calleE;
        private System.Windows.Forms.Label lbl_pisoE;
        private System.Windows.Forms.Label lbl_departamentoE;
        private System.Windows.Forms.Label lbl_comentarios_domicilioE;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label lbl_ingE;
        private System.Windows.Forms.Label lbl_sueldoE;
        private System.Windows.Forms.Label lbl_activoE;
        private System.Windows.Forms.Label lbl_rolE;
    }
}
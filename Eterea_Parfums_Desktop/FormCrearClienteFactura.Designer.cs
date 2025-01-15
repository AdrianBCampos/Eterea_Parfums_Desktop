namespace Eterea_Parfums_Desktop
{
    partial class FormCrearClienteFactura
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
            this.lbl_crear_clientes = new System.Windows.Forms.Label();
            this.btn_crear_cliente = new System.Windows.Forms.Button();
            this.combo_con_iva = new System.Windows.Forms.ComboBox();
            this.lbl_cond_ivaE = new System.Windows.Forms.Label();
            this.lbl_cond_iva = new System.Windows.Forms.Label();
            this.lbl_emailE = new System.Windows.Forms.Label();
            this.lbl_dniE = new System.Windows.Forms.Label();
            this.lbl_apellidoE = new System.Windows.Forms.Label();
            this.lbl_nombreE = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_crear_clientes
            // 
            this.lbl_crear_clientes.AutoSize = true;
            this.lbl_crear_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_crear_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crear_clientes.ForeColor = System.Drawing.Color.Black;
            this.lbl_crear_clientes.Location = new System.Drawing.Point(198, 20);
            this.lbl_crear_clientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_crear_clientes.Name = "lbl_crear_clientes";
            this.lbl_crear_clientes.Size = new System.Drawing.Size(132, 24);
            this.lbl_crear_clientes.TabIndex = 275;
            this.lbl_crear_clientes.Text = "Crear Cliente";
            // 
            // btn_crear_cliente
            // 
            this.btn_crear_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_crear_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_cliente.Location = new System.Drawing.Point(171, 380);
            this.btn_crear_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crear_cliente.Name = "btn_crear_cliente";
            this.btn_crear_cliente.Size = new System.Drawing.Size(183, 46);
            this.btn_crear_cliente.TabIndex = 277;
            this.btn_crear_cliente.Text = "Crear";
            this.btn_crear_cliente.UseVisualStyleBackColor = false;
            this.btn_crear_cliente.Click += new System.EventHandler(this.btn_crear_cliente_Click);
            // 
            // combo_con_iva
            // 
            this.combo_con_iva.FormattingEnabled = true;
            this.combo_con_iva.Location = new System.Drawing.Point(223, 245);
            this.combo_con_iva.Margin = new System.Windows.Forms.Padding(4);
            this.combo_con_iva.Name = "combo_con_iva";
            this.combo_con_iva.Size = new System.Drawing.Size(262, 24);
            this.combo_con_iva.TabIndex = 293;
            // 
            // lbl_cond_ivaE
            // 
            this.lbl_cond_ivaE.AutoSize = true;
            this.lbl_cond_ivaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_cond_ivaE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_cond_ivaE.Location = new System.Drawing.Point(220, 274);
            this.lbl_cond_ivaE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cond_ivaE.Name = "lbl_cond_ivaE";
            this.lbl_cond_ivaE.Size = new System.Drawing.Size(36, 16);
            this.lbl_cond_ivaE.TabIndex = 292;
            this.lbl_cond_ivaE.Text = "Error";
            // 
            // lbl_cond_iva
            // 
            this.lbl_cond_iva.AutoSize = true;
            this.lbl_cond_iva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_cond_iva.Location = new System.Drawing.Point(60, 251);
            this.lbl_cond_iva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cond_iva.Name = "lbl_cond_iva";
            this.lbl_cond_iva.Size = new System.Drawing.Size(146, 16);
            this.lbl_cond_iva.TabIndex = 291;
            this.lbl_cond_iva.Text = "Condición Frente al IVA";
            // 
            // lbl_emailE
            // 
            this.lbl_emailE.AutoSize = true;
            this.lbl_emailE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_emailE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_emailE.Location = new System.Drawing.Point(220, 327);
            this.lbl_emailE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emailE.Name = "lbl_emailE";
            this.lbl_emailE.Size = new System.Drawing.Size(36, 16);
            this.lbl_emailE.TabIndex = 290;
            this.lbl_emailE.Text = "Error";
            // 
            // lbl_dniE
            // 
            this.lbl_dniE.AutoSize = true;
            this.lbl_dniE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_dniE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_dniE.Location = new System.Drawing.Point(220, 104);
            this.lbl_dniE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dniE.Name = "lbl_dniE";
            this.lbl_dniE.Size = new System.Drawing.Size(36, 16);
            this.lbl_dniE.TabIndex = 289;
            this.lbl_dniE.Text = "Error";
            // 
            // lbl_apellidoE
            // 
            this.lbl_apellidoE.AutoSize = true;
            this.lbl_apellidoE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_apellidoE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_apellidoE.Location = new System.Drawing.Point(220, 215);
            this.lbl_apellidoE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apellidoE.Name = "lbl_apellidoE";
            this.lbl_apellidoE.Size = new System.Drawing.Size(36, 16);
            this.lbl_apellidoE.TabIndex = 288;
            this.lbl_apellidoE.Text = "Error";
            // 
            // lbl_nombreE
            // 
            this.lbl_nombreE.AutoSize = true;
            this.lbl_nombreE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombreE.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_nombreE.Location = new System.Drawing.Point(220, 160);
            this.lbl_nombreE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombreE.Name = "lbl_nombreE";
            this.lbl_nombreE.Size = new System.Drawing.Size(36, 16);
            this.lbl_nombreE.TabIndex = 287;
            this.lbl_nombreE.Text = "Error";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_email.Location = new System.Drawing.Point(60, 309);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(41, 16);
            this.lbl_email.TabIndex = 286;
            this.lbl_email.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(223, 300);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(262, 22);
            this.txt_email.TabIndex = 285;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_dni.Location = new System.Drawing.Point(60, 86);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(30, 16);
            this.lbl_dni.TabIndex = 284;
            this.lbl_dni.Text = "DNI";
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(223, 77);
            this.txt_dni.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(262, 22);
            this.txt_dni.TabIndex = 283;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_apellido.Location = new System.Drawing.Point(60, 197);
            this.lbl_apellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(57, 16);
            this.lbl_apellido.TabIndex = 282;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(223, 188);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(262, 22);
            this.txt_apellido.TabIndex = 281;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre.Location = new System.Drawing.Point(60, 142);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_nombre.TabIndex = 280;
            this.lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(223, 133);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(262, 22);
            this.txt_nombre.TabIndex = 279;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(15, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 303);
            this.pictureBox1.TabIndex = 278;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(495, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 294;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCrearClienteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_con_iva);
            this.Controls.Add(this.lbl_cond_ivaE);
            this.Controls.Add(this.lbl_cond_iva);
            this.Controls.Add(this.lbl_emailE);
            this.Controls.Add(this.lbl_dniE);
            this.Controls.Add(this.lbl_apellidoE);
            this.Controls.Add(this.lbl_nombreE);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_crear_cliente);
            this.Controls.Add(this.lbl_crear_clientes);
            this.Name = "FormCrearClienteFactura";
            this.Text = "FormCrearClienteFactura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_crear_clientes;
        private System.Windows.Forms.Button btn_crear_cliente;
        private System.Windows.Forms.ComboBox combo_con_iva;
        private System.Windows.Forms.Label lbl_cond_ivaE;
        private System.Windows.Forms.Label lbl_cond_iva;
        private System.Windows.Forms.Label lbl_emailE;
        private System.Windows.Forms.Label lbl_dniE;
        private System.Windows.Forms.Label lbl_apellidoE;
        private System.Windows.Forms.Label lbl_nombreE;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
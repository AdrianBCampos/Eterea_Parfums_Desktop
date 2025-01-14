namespace Eterea_Parfums_Desktop
{
    partial class FormEliminarClienteABM
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
            this.lbl_eliminar_clientes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_eliminar_cliente = new System.Windows.Forms.Button();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_dni_eliminar = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_eliminar_clientes
            // 
            this.lbl_eliminar_clientes.AutoSize = true;
            this.lbl_eliminar_clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_eliminar_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eliminar_clientes.ForeColor = System.Drawing.Color.Black;
            this.lbl_eliminar_clientes.Location = new System.Drawing.Point(186, 28);
            this.lbl_eliminar_clientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eliminar_clientes.Name = "lbl_eliminar_clientes";
            this.lbl_eliminar_clientes.Size = new System.Drawing.Size(157, 24);
            this.lbl_eliminar_clientes.TabIndex = 212;
            this.lbl_eliminar_clientes.Text = "Eliminar Cliente";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(16, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 183);
            this.pictureBox1.TabIndex = 214;
            this.pictureBox1.TabStop = false;
            // 
            // btn_eliminar_cliente
            // 
            this.btn_eliminar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_eliminar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_cliente.Location = new System.Drawing.Point(169, 285);
            this.btn_eliminar_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar_cliente.Name = "btn_eliminar_cliente";
            this.btn_eliminar_cliente.Size = new System.Drawing.Size(183, 46);
            this.btn_eliminar_cliente.TabIndex = 216;
            this.btn_eliminar_cliente.Text = "Eliminar";
            this.btn_eliminar_cliente.UseVisualStyleBackColor = false;
            this.btn_eliminar_cliente.Click += new System.EventHandler(this.btn_eliminar_cliente_Click);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_dni.Location = new System.Drawing.Point(90, 191);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(30, 16);
            this.lbl_dni.TabIndex = 221;
            this.lbl_dni.Text = "DNI";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre.Location = new System.Drawing.Point(90, 121);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(56, 16);
            this.lbl_nombre.TabIndex = 219;
            this.lbl_nombre.Text = "Nombre";
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
            this.button1.Location = new System.Drawing.Point(467, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 223;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_dni_eliminar
            // 
            this.txt_dni_eliminar.AutoSize = true;
            this.txt_dni_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_dni_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dni_eliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_dni_eliminar.Location = new System.Drawing.Point(215, 176);
            this.txt_dni_eliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_dni_eliminar.Name = "txt_dni_eliminar";
            this.txt_dni_eliminar.Size = new System.Drawing.Size(215, 31);
            this.txt_dni_eliminar.TabIndex = 224;
            this.txt_dni_eliminar.Text = "Numero de DNI";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.AutoSize = true;
            this.txt_nombre_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_cliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nombre_cliente.Location = new System.Drawing.Point(215, 106);
            this.txt_nombre_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(216, 31);
            this.txt_nombre_cliente.TabIndex = 225;
            this.txt_nombre_cliente.Text = "Nombre Cliente";
            // 
            // FormEliminarClienteABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(526, 355);
            this.Controls.Add(this.txt_nombre_cliente);
            this.Controls.Add(this.txt_dni_eliminar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.btn_eliminar_cliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_eliminar_clientes);
            this.Name = "FormEliminarClienteABM";
            this.Text = "FormEliminarClienteABM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_eliminar_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_eliminar_cliente;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_dni_eliminar;
        private System.Windows.Forms.Label txt_nombre_cliente;
    }
}
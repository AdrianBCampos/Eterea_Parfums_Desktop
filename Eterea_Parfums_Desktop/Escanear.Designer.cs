namespace Eterea_Parfums_Desktop
{
    partial class Escanear
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_volver_escanear = new System.Windows.Forms.Button();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_numero_codigo = new System.Windows.Forms.Label();
            this.txt_codigo_barras = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_lector = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(16, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 141);
            this.pictureBox1.TabIndex = 282;
            this.pictureBox1.TabStop = false;
            // 
            // btn_volver_escanear
            // 
            this.btn_volver_escanear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_volver_escanear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver_escanear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver_escanear.Location = new System.Drawing.Point(170, 263);
            this.btn_volver_escanear.Name = "btn_volver_escanear";
            this.btn_volver_escanear.Size = new System.Drawing.Size(172, 37);
            this.btn_volver_escanear.TabIndex = 298;
            this.btn_volver_escanear.Text = "Volver a Escanear";
            this.btn_volver_escanear.UseVisualStyleBackColor = false;
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.Location = new System.Drawing.Point(183, 191);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(137, 37);
            this.btn_enviar.TabIndex = 299;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(446, 11);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(34, 32);
            this.button2.TabIndex = 300;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_numero_codigo
            // 
            this.lbl_numero_codigo.AutoSize = true;
            this.lbl_numero_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_numero_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_codigo.Location = new System.Drawing.Point(100, 123);
            this.lbl_numero_codigo.Name = "lbl_numero_codigo";
            this.lbl_numero_codigo.Size = new System.Drawing.Size(347, 17);
            this.lbl_numero_codigo.TabIndex = 301;
            this.lbl_numero_codigo.Text = "Ingresar el número de código de barras manualmente";
            // 
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.BackColor = System.Drawing.Color.White;
            this.txt_codigo_barras.Location = new System.Drawing.Point(134, 158);
            this.txt_codigo_barras.Name = "txt_codigo_barras";
            this.txt_codigo_barras.Size = new System.Drawing.Size(232, 20);
            this.txt_codigo_barras.TabIndex = 302;
            this.txt_codigo_barras.Text = "N°_";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(16, 59);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 42);
            this.pictureBox2.TabIndex = 303;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_lector
            // 
            this.lbl_lector.AutoSize = true;
            this.lbl_lector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.lbl_lector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lector.Location = new System.Drawing.Point(26, 72);
            this.lbl_lector.Name = "lbl_lector";
            this.lbl_lector.Size = new System.Drawing.Size(456, 18);
            this.lbl_lector.TabIndex = 304;
            this.lbl_lector.Text = "El lector no funciona o no se pudo leer el código de barras.";
            // 
            // Escanear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(490, 312);
            this.Controls.Add(this.lbl_lector);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_codigo_barras);
            this.Controls.Add(this.lbl_numero_codigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.btn_volver_escanear);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Escanear";
            this.Text = "Escanear";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_volver_escanear;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_numero_codigo;
        private System.Windows.Forms.TextBox txt_codigo_barras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_lector;
    }
}
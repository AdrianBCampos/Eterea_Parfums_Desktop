namespace Eterea_Parfums_Desktop
{
    partial class FormEscanear
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
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_numero_codigo = new System.Windows.Forms.Label();
            this.txt_codigo_barras = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_lector = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(16, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 114);
            this.pictureBox1.TabIndex = 282;
            this.pictureBox1.TabStop = false;
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
            this.lbl_numero_codigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_numero_codigo.Location = new System.Drawing.Point(48, 120);
            this.lbl_numero_codigo.Name = "lbl_numero_codigo";
            this.lbl_numero_codigo.Size = new System.Drawing.Size(409, 17);
            this.lbl_numero_codigo.TabIndex = 301;
            this.lbl_numero_codigo.Text = "Vuelva a escanear o ingresar el código de barras manualmente";
            // 
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_codigo_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_barras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_codigo_barras.Location = new System.Drawing.Point(125, 174);
            this.txt_codigo_barras.Name = "txt_codigo_barras";
            this.txt_codigo_barras.Size = new System.Drawing.Size(232, 26);
            this.txt_codigo_barras.TabIndex = 302;
            this.txt_codigo_barras.TextChanged += new System.EventHandler(this.txt_codigo_barras_TextChanged);
            this.txt_codigo_barras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_barras_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(16, 59);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 42);
            this.pictureBox2.TabIndex = 303;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_lector
            // 
            this.lbl_lector.AutoSize = true;
            this.lbl_lector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(177)))), ((int)(((byte)(184)))));
            this.lbl_lector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lector.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_lector.Location = new System.Drawing.Point(130, 68);
            this.lbl_lector.Name = "lbl_lector";
            this.lbl_lector.Size = new System.Drawing.Size(236, 24);
            this.lbl_lector.TabIndex = 304;
            this.lbl_lector.Text = "Perfume no encontrado.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(73, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 17);
            this.label1.TabIndex = 305;
            this.label1.Text = "(si lo ingresa manualmente, presione \"Enter\" al finalizar)";
            // 
            // FormEscanear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(490, 246);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_lector);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_codigo_barras);
            this.Controls.Add(this.lbl_numero_codigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEscanear";
            this.Text = "Escanear";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_numero_codigo;
        private System.Windows.Forms.TextBox txt_codigo_barras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_lector;
        private System.Windows.Forms.Label label1;
    }
}
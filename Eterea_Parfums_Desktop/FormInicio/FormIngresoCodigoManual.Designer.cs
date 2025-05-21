namespace Eterea_Parfums_Desktop
{
    partial class FormIngresoCodigoManual
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
            this.lbl_numero_codigo = new System.Windows.Forms.Label();
            this.txt_codigo_barras = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_lector = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(13, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 105);
            this.pictureBox1.TabIndex = 282;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_numero_codigo
            // 
            this.lbl_numero_codigo.AutoSize = true;
            this.lbl_numero_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_numero_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_codigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_numero_codigo.Location = new System.Drawing.Point(94, 69);
            this.lbl_numero_codigo.Name = "lbl_numero_codigo";
            this.lbl_numero_codigo.Size = new System.Drawing.Size(306, 40);
            this.lbl_numero_codigo.TabIndex = 301;
            this.lbl_numero_codigo.Text = "Ingrese el código de barras manualmente.\r\nAl finalizar presione \"Enter\"\r\n";
            this.lbl_numero_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_codigo_barras
            // 
            this.txt_codigo_barras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_codigo_barras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_barras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_codigo_barras.Location = new System.Drawing.Point(130, 116);
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
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
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
            this.lbl_lector.Location = new System.Drawing.Point(127, 22);
            this.lbl_lector.Name = "lbl_lector";
            this.lbl_lector.Size = new System.Drawing.Size(236, 24);
            this.lbl_lector.TabIndex = 304;
            this.lbl_lector.Text = "Perfume no encontrado.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(488, 185);
            this.pictureBox3.TabIndex = 306;
            this.pictureBox3.TabStop = false;
            // 
            // FormIngresoCodigoManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(493, 190);
            this.Controls.Add(this.lbl_lector);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_codigo_barras);
            this.Controls.Add(this.lbl_numero_codigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormIngresoCodigoManual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Escanear";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_numero_codigo;
        private System.Windows.Forms.TextBox txt_codigo_barras;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_lector;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
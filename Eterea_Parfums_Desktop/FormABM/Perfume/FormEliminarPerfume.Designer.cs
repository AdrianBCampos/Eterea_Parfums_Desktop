namespace Eterea_Parfums_Desktop
{
    partial class FormEliminarPerfume
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
            this.lbl_eliminar_perfume = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_eliminar_perfume = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_nombre_perfume = new System.Windows.Forms.Label();
            this.txt_codigo_perfume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_eliminar_perfume
            // 
            this.lbl_eliminar_perfume.AutoSize = true;
            this.lbl_eliminar_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_eliminar_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eliminar_perfume.ForeColor = System.Drawing.Color.Black;
            this.lbl_eliminar_perfume.Location = new System.Drawing.Point(187, 28);
            this.lbl_eliminar_perfume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_eliminar_perfume.Name = "lbl_eliminar_perfume";
            this.lbl_eliminar_perfume.Size = new System.Drawing.Size(170, 24);
            this.lbl_eliminar_perfume.TabIndex = 212;
            this.lbl_eliminar_perfume.Text = "Eliminar Perfume";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(16, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 183);
            this.pictureBox1.TabIndex = 214;
            this.pictureBox1.TabStop = false;
            // 
            // btn_eliminar_perfume
            // 
            this.btn_eliminar_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_eliminar_perfume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_perfume.Location = new System.Drawing.Point(169, 286);
            this.btn_eliminar_perfume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar_perfume.Name = "btn_eliminar_perfume";
            this.btn_eliminar_perfume.Size = new System.Drawing.Size(183, 46);
            this.btn_eliminar_perfume.TabIndex = 216;
            this.btn_eliminar_perfume.Text = "Eliminar";
            this.btn_eliminar_perfume.UseVisualStyleBackColor = false;
            this.btn_eliminar_perfume.Click += new System.EventHandler(this.btn_eliminar_cliente_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre.Location = new System.Drawing.Point(91, 191);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(66, 16);
            this.lbl_nombre.TabIndex = 221;
            this.lbl_nombre.Text = "NOMBRE";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_codigo.Location = new System.Drawing.Point(91, 121);
            this.lbl_codigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(59, 16);
            this.lbl_codigo.TabIndex = 219;
            this.lbl_codigo.Text = "CODIGO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(467, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(55, 49);
            this.button1.TabIndex = 223;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_nombre_perfume
            // 
            this.txt_nombre_perfume.AutoSize = true;
            this.txt_nombre_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_nombre_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_perfume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_nombre_perfume.Location = new System.Drawing.Point(203, 176);
            this.txt_nombre_perfume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_nombre_perfume.Name = "txt_nombre_perfume";
            this.txt_nombre_perfume.Size = new System.Drawing.Size(286, 31);
            this.txt_nombre_perfume.TabIndex = 224;
            this.txt_nombre_perfume.Text = "Nombre De Producto";
            // 
            // txt_codigo_perfume
            // 
            this.txt_codigo_perfume.AutoSize = true;
            this.txt_codigo_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_codigo_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo_perfume.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_codigo_perfume.Location = new System.Drawing.Point(203, 106);
            this.txt_codigo_perfume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_codigo_perfume.Name = "txt_codigo_perfume";
            this.txt_codigo_perfume.Size = new System.Drawing.Size(276, 31);
            this.txt_codigo_perfume.TabIndex = 225;
            this.txt_codigo_perfume.Text = "Codigo De Producto";
            // 
            // FormEliminarPerfume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(538, 348);
            this.Controls.Add(this.txt_codigo_perfume);
            this.Controls.Add(this.txt_nombre_perfume);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.btn_eliminar_perfume);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_eliminar_perfume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEliminarPerfume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEliminarClienteABM";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_eliminar_perfume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_eliminar_perfume;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_nombre_perfume;
        private System.Windows.Forms.Label txt_codigo_perfume;
    }
}
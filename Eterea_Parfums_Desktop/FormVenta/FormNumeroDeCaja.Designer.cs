namespace Eterea_Parfums_Desktop
{
    partial class FormNumeroDeCaja
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
            this.img_logo = new System.Windows.Forms.PictureBox();
            this.lbl_numero_caja = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_continuar = new System.Windows.Forms.Button();
            this.txt_ing_numero_caja = new System.Windows.Forms.TextBox();
            this.lbl_error_caja = new System.Windows.Forms.Label();
            this.txt_nombre_suc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_logo
            // 
            this.img_logo.Location = new System.Drawing.Point(170, 28);
            this.img_logo.Name = "img_logo";
            this.img_logo.Size = new System.Drawing.Size(267, 144);
            this.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_logo.TabIndex = 95;
            this.img_logo.TabStop = false;
            // 
            // lbl_numero_caja
            // 
            this.lbl_numero_caja.AutoSize = true;
            this.lbl_numero_caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_numero_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numero_caja.ForeColor = System.Drawing.Color.Black;
            this.lbl_numero_caja.Location = new System.Drawing.Point(176, 230);
            this.lbl_numero_caja.Name = "lbl_numero_caja";
            this.lbl_numero_caja.Size = new System.Drawing.Size(135, 18);
            this.lbl_numero_caja.TabIndex = 93;
            this.lbl_numero_caja.Text = "Numero de Caja:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(556, 10);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(34, 32);
            this.button2.TabIndex = 92;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(72, 207);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 66);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.Location = new System.Drawing.Point(235, 302);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(137, 37);
            this.btn_continuar.TabIndex = 90;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // txt_ing_numero_caja
            // 
            this.txt_ing_numero_caja.Location = new System.Drawing.Point(321, 232);
            this.txt_ing_numero_caja.Name = "txt_ing_numero_caja";
            this.txt_ing_numero_caja.Size = new System.Drawing.Size(116, 20);
            this.txt_ing_numero_caja.TabIndex = 96;
            // 
            // lbl_error_caja
            // 
            this.lbl_error_caja.AutoSize = true;
            this.lbl_error_caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_error_caja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_caja.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_caja.Location = new System.Drawing.Point(152, 253);
            this.lbl_error_caja.Name = "lbl_error_caja";
            this.lbl_error_caja.Size = new System.Drawing.Size(44, 20);
            this.lbl_error_caja.TabIndex = 97;
            this.lbl_error_caja.Text = "Error";
            // 
            // txt_nombre_suc
            // 
            this.txt_nombre_suc.AutoSize = true;
            this.txt_nombre_suc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_suc.Location = new System.Drawing.Point(76, 181);
            this.txt_nombre_suc.Name = "txt_nombre_suc";
            this.txt_nombre_suc.Size = new System.Drawing.Size(60, 24);
            this.txt_nombre_suc.TabIndex = 98;
            this.txt_nombre_suc.Text = "label1";
            // 
            // FormNumeroDeCaja
            // 
            this.AcceptButton = this.btn_continuar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(600, 363);
            this.Controls.Add(this.txt_nombre_suc);
            this.Controls.Add(this.lbl_error_caja);
            this.Controls.Add(this.txt_ing_numero_caja);
            this.Controls.Add(this.img_logo);
            this.Controls.Add(this.lbl_numero_caja);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_continuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormNumeroDeCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumeroDeCaja";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormNumeroDeCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_logo;
        private System.Windows.Forms.Label lbl_numero_caja;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_continuar;
        private System.Windows.Forms.TextBox txt_ing_numero_caja;
        private System.Windows.Forms.Label lbl_error_caja;
        private System.Windows.Forms.Label txt_nombre_suc;
    }
}
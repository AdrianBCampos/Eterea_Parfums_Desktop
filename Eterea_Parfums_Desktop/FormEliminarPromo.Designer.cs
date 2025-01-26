namespace Eterea_Parfums_Desktop
{
    partial class FormEliminarPromo
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
            this.pic_fondo_promo_seleccionada_eliminar = new System.Windows.Forms.PictureBox();
            this.lbl_crear_promo = new System.Windows.Forms.Label();
            this.lbl_nomb_promo_eliminar = new System.Windows.Forms.Label();
            this.lbl_nombre_promo_seleccionada = new System.Windows.Forms.Label();
            this.btn_eliminar_promo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo_promo_seleccionada_eliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_fondo_promo_seleccionada_eliminar
            // 
            this.pic_fondo_promo_seleccionada_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pic_fondo_promo_seleccionada_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_fondo_promo_seleccionada_eliminar.Location = new System.Drawing.Point(11, 41);
            this.pic_fondo_promo_seleccionada_eliminar.Margin = new System.Windows.Forms.Padding(5);
            this.pic_fondo_promo_seleccionada_eliminar.Name = "pic_fondo_promo_seleccionada_eliminar";
            this.pic_fondo_promo_seleccionada_eliminar.Size = new System.Drawing.Size(392, 79);
            this.pic_fondo_promo_seleccionada_eliminar.TabIndex = 113;
            this.pic_fondo_promo_seleccionada_eliminar.TabStop = false;
            // 
            // lbl_crear_promo
            // 
            this.lbl_crear_promo.AutoSize = true;
            this.lbl_crear_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_crear_promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_crear_promo.ForeColor = System.Drawing.Color.Black;
            this.lbl_crear_promo.Location = new System.Drawing.Point(125, 9);
            this.lbl_crear_promo.Name = "lbl_crear_promo";
            this.lbl_crear_promo.Size = new System.Drawing.Size(162, 18);
            this.lbl_crear_promo.TabIndex = 114;
            this.lbl_crear_promo.Text = "Eliminar Promoción:";
            // 
            // lbl_nomb_promo_eliminar
            // 
            this.lbl_nomb_promo_eliminar.AutoSize = true;
            this.lbl_nomb_promo_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nomb_promo_eliminar.Location = new System.Drawing.Point(40, 74);
            this.lbl_nomb_promo_eliminar.Name = "lbl_nomb_promo_eliminar";
            this.lbl_nomb_promo_eliminar.Size = new System.Drawing.Size(47, 13);
            this.lbl_nomb_promo_eliminar.TabIndex = 115;
            this.lbl_nomb_promo_eliminar.Text = "Nombre:";
            // 
            // lbl_nombre_promo_seleccionada
            // 
            this.lbl_nombre_promo_seleccionada.AutoSize = true;
            this.lbl_nombre_promo_seleccionada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre_promo_seleccionada.Location = new System.Drawing.Point(128, 74);
            this.lbl_nombre_promo_seleccionada.Name = "lbl_nombre_promo_seleccionada";
            this.lbl_nombre_promo_seleccionada.Size = new System.Drawing.Size(137, 13);
            this.lbl_nombre_promo_seleccionada.TabIndex = 116;
            this.lbl_nombre_promo_seleccionada.Text = "nombrePromoSeleccionada";
            // 
            // btn_eliminar_promo
            // 
            this.btn_eliminar_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_eliminar_promo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_promo.Location = new System.Drawing.Point(150, 138);
            this.btn_eliminar_promo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_eliminar_promo.Name = "btn_eliminar_promo";
            this.btn_eliminar_promo.Size = new System.Drawing.Size(126, 24);
            this.btn_eliminar_promo.TabIndex = 284;
            this.btn_eliminar_promo.Text = "Eliminar Promoción";
            this.btn_eliminar_promo.UseVisualStyleBackColor = false;
            this.btn_eliminar_promo.Click += new System.EventHandler(this.btn_eliminar_promo_Click);
            // 
            // Form_eliminar_promo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(417, 179);
            this.Controls.Add(this.btn_eliminar_promo);
            this.Controls.Add(this.lbl_nombre_promo_seleccionada);
            this.Controls.Add(this.lbl_nomb_promo_eliminar);
            this.Controls.Add(this.lbl_crear_promo);
            this.Controls.Add(this.pic_fondo_promo_seleccionada_eliminar);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form_eliminar_promo";
            this.Text = "FormEliminarPromo";
            ((System.ComponentModel.ISupportInitialize)(this.pic_fondo_promo_seleccionada_eliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_fondo_promo_seleccionada_eliminar;
        private System.Windows.Forms.Label lbl_crear_promo;
        private System.Windows.Forms.Label lbl_nomb_promo_eliminar;
        private System.Windows.Forms.Label lbl_nombre_promo_seleccionada;
        private System.Windows.Forms.Button btn_eliminar_promo;
    }
}
namespace Eterea_Parfums_Desktop
{
    partial class FormSeleccionarInformeVenta
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
            this.combobox_informe = new System.Windows.Forms.ComboBox();
            this.lbl_tipo_informe = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_informe_ventas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_continuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_informe
            // 
            this.combobox_informe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.combobox_informe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combobox_informe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobox_informe.ForeColor = System.Drawing.SystemColors.Menu;
            this.combobox_informe.FormattingEnabled = true;
            this.combobox_informe.Items.AddRange(new object[] {
            "Ventas en un período",
            "Inventario"});
            this.combobox_informe.Location = new System.Drawing.Point(304, 157);
            this.combobox_informe.Name = "combobox_informe";
            this.combobox_informe.Size = new System.Drawing.Size(227, 21);
            this.combobox_informe.TabIndex = 94;
            this.combobox_informe.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxDiseño_DrawItem);
            // 
            // lbl_tipo_informe
            // 
            this.lbl_tipo_informe.AutoSize = true;
            this.lbl_tipo_informe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_tipo_informe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_informe.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipo_informe.Location = new System.Drawing.Point(80, 157);
            this.lbl_tipo_informe.Name = "lbl_tipo_informe";
            this.lbl_tipo_informe.Size = new System.Drawing.Size(225, 18);
            this.lbl_tipo_informe.TabIndex = 93;
            this.lbl_tipo_informe.Text = "Seleccionar Tipo de Informe:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(555, 11);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(34, 32);
            this.button2.TabIndex = 92;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_informe_ventas
            // 
            this.lbl_informe_ventas.AutoSize = true;
            this.lbl_informe_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_informe_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informe_ventas.ForeColor = System.Drawing.Color.Black;
            this.lbl_informe_ventas.Location = new System.Drawing.Point(205, 53);
            this.lbl_informe_ventas.Name = "lbl_informe_ventas";
            this.lbl_informe_ventas.Size = new System.Drawing.Size(210, 18);
            this.lbl_informe_ventas.TabIndex = 89;
            this.lbl_informe_ventas.Text = "Generar Informe de Ventas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(60, 98);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 137);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // btn_continuar
            // 
            this.btn_continuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_continuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continuar.Location = new System.Drawing.Point(234, 280);
            this.btn_continuar.Name = "btn_continuar";
            this.btn_continuar.Size = new System.Drawing.Size(137, 37);
            this.btn_continuar.TabIndex = 90;
            this.btn_continuar.Text = "Continuar";
            this.btn_continuar.UseVisualStyleBackColor = false;
            this.btn_continuar.Click += new System.EventHandler(this.btn_continuar_Click);
            // 
            // FormSeleccionarInformeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(600, 364);
            this.Controls.Add(this.combobox_informe);
            this.Controls.Add(this.lbl_tipo_informe);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_informe_ventas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_continuar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSeleccionarInformeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformesDeVentas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_informe;
        private System.Windows.Forms.Label lbl_tipo_informe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_informe_ventas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_continuar;
    }
}
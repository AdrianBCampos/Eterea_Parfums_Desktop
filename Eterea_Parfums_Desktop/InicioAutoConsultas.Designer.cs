namespace Eterea_Parfums_Desktop
{
    partial class InicioAutoConsultas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_iniciar_sesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_iniciar_sesion
            // 
            this.btn_iniciar_sesion.BackColor = System.Drawing.Color.Pink;
            this.btn_iniciar_sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciar_sesion.Location = new System.Drawing.Point(308, 298);
            this.btn_iniciar_sesion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_iniciar_sesion.Name = "btn_iniciar_sesion";
            this.btn_iniciar_sesion.Size = new System.Drawing.Size(183, 46);
            this.btn_iniciar_sesion.TabIndex = 79;
            this.btn_iniciar_sesion.Text = "Iniciar Sesión";
            this.btn_iniciar_sesion.UseVisualStyleBackColor = false;
            this.btn_iniciar_sesion.Click += new System.EventHandler(this.btn_iniciar_sesion_Click);
            // 
            // InicioAutoConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_iniciar_sesion);
            this.Name = "InicioAutoConsultas";
            this.Text = "InicioAutoConsultas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciar_sesion;
    }
}


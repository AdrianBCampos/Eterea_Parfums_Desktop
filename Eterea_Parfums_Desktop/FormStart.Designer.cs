namespace Eterea_Parfums_Desktop
{
    partial class FormStart
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
            this.btn_start = new System.Windows.Forms.Button();
            this.comboEscala = new System.Windows.Forms.ComboBox();
            this.lbl_escala = new System.Windows.Forms.Label();
            this.btn_escalar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_start.Location = new System.Drawing.Point(575, 419);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(241, 37);
            this.btn_start.TabIndex = 296;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // comboEscala
            // 
            this.comboEscala.FormattingEnabled = true;
            this.comboEscala.Location = new System.Drawing.Point(678, 356);
            this.comboEscala.Name = "comboEscala";
            this.comboEscala.Size = new System.Drawing.Size(121, 21);
            this.comboEscala.TabIndex = 297;
            // 
            // lbl_escala
            // 
            this.lbl_escala.AutoSize = true;
            this.lbl_escala.Location = new System.Drawing.Point(581, 359);
            this.lbl_escala.Name = "lbl_escala";
            this.lbl_escala.Size = new System.Drawing.Size(91, 13);
            this.lbl_escala.TabIndex = 298;
            this.lbl_escala.Text = "Escala de interfaz";
            // 
            // btn_escalar
            // 
            this.btn_escalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_escalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_escalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_escalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_escalar.Location = new System.Drawing.Point(575, 313);
            this.btn_escalar.Name = "btn_escalar";
            this.btn_escalar.Size = new System.Drawing.Size(241, 37);
            this.btn_escalar.TabIndex = 299;
            this.btn_escalar.Text = "Escalar interfaz";
            this.btn_escalar.UseVisualStyleBackColor = false;
            this.btn_escalar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_escalar);
            this.Controls.Add(this.lbl_escala);
            this.Controls.Add(this.comboEscala);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStart";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InicioAutoConsultas_KeyDown_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.ComboBox comboEscala;
        private System.Windows.Forms.Label lbl_escala;
        public System.Windows.Forms.Button btn_escalar;
    }
}
namespace Eterea_Parfums_Desktop
{
    partial class AromaNota
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
            this.lbl_tipo_aroma_nota = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_perfume = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.dataGridViewNotasDelPerfume = new System.Windows.Forms.DataGridView();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_seleccionar_aroma = new System.Windows.Forms.Label();
            this.lbl_seleccionar_tipo_nota = new System.Windows.Forms.Label();
            this.lbl_buscar_nota = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.checkedListBoxAroma = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxNota = new System.Windows.Forms.CheckedListBox();
            this.txt_nombre_perfume = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher3 = new System.DirectoryServices.DirectorySearcher();
            this.lbl_error_seleccion_aroma = new System.Windows.Forms.Label();
            this.lbl_error_seleccion_nota = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotasDelPerfume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tipo_aroma_nota
            // 
            this.lbl_tipo_aroma_nota.AutoSize = true;
            this.lbl_tipo_aroma_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_tipo_aroma_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_aroma_nota.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipo_aroma_nota.Location = new System.Drawing.Point(28, 27);
            this.lbl_tipo_aroma_nota.Name = "lbl_tipo_aroma_nota";
            this.lbl_tipo_aroma_nota.Size = new System.Drawing.Size(403, 18);
            this.lbl_tipo_aroma_nota.TabIndex = 142;
            this.lbl_tipo_aroma_nota.Text = "Asignar Tipo De Aroma y Notas Del Perfume Creado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(31, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 33);
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nombre_perfume
            // 
            this.lbl_nombre_perfume.AutoSize = true;
            this.lbl_nombre_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_perfume.Location = new System.Drawing.Point(43, 69);
            this.lbl_nombre_perfume.Name = "lbl_nombre_perfume";
            this.lbl_nombre_perfume.Size = new System.Drawing.Size(158, 20);
            this.lbl_nombre_perfume.TabIndex = 144;
            this.lbl_nombre_perfume.Text = "Nombre del Perfume:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(31, 114);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 337);
            this.pictureBox2.TabIndex = 145;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(256, 114);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 218);
            this.pictureBox3.TabIndex = 146;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(492, 114);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(315, 268);
            this.pictureBox4.TabIndex = 147;
            this.pictureBox4.TabStop = false;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.Location = new System.Drawing.Point(558, 387);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(137, 37);
            this.btn_finalizar.TabIndex = 148;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // dataGridViewNotasDelPerfume
            // 
            this.dataGridViewNotasDelPerfume.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dataGridViewNotasDelPerfume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotasDelPerfume.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Nota,
            this.Eliminar});
            this.dataGridViewNotasDelPerfume.Location = new System.Drawing.Point(503, 128);
            this.dataGridViewNotasDelPerfume.Name = "dataGridViewNotasDelPerfume";
            this.dataGridViewNotasDelPerfume.Size = new System.Drawing.Size(304, 244);
            this.dataGridViewNotasDelPerfume.TabIndex = 149;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(256, 336);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(212, 115);
            this.pictureBox5.TabIndex = 150;
            this.pictureBox5.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(304, 400);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(116, 31);
            this.btn_agregar.TabIndex = 151;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_seleccionar_aroma
            // 
            this.lbl_seleccionar_aroma.AutoSize = true;
            this.lbl_seleccionar_aroma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_seleccionar_aroma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionar_aroma.Location = new System.Drawing.Point(40, 128);
            this.lbl_seleccionar_aroma.Name = "lbl_seleccionar_aroma";
            this.lbl_seleccionar_aroma.Size = new System.Drawing.Size(147, 20);
            this.lbl_seleccionar_aroma.TabIndex = 152;
            this.lbl_seleccionar_aroma.Text = "Seleccionar Aroma:";
            // 
            // lbl_seleccionar_tipo_nota
            // 
            this.lbl_seleccionar_tipo_nota.AutoSize = true;
            this.lbl_seleccionar_tipo_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_seleccionar_tipo_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionar_tipo_nota.Location = new System.Drawing.Point(262, 128);
            this.lbl_seleccionar_tipo_nota.Name = "lbl_seleccionar_tipo_nota";
            this.lbl_seleccionar_tipo_nota.Size = new System.Drawing.Size(193, 20);
            this.lbl_seleccionar_tipo_nota.TabIndex = 153;
            this.lbl_seleccionar_tipo_nota.Text = "Seleccionar Tipo De Nota:";
            // 
            // lbl_buscar_nota
            // 
            this.lbl_buscar_nota.AutoSize = true;
            this.lbl_buscar_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_buscar_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_nota.Location = new System.Drawing.Point(262, 253);
            this.lbl_buscar_nota.Name = "lbl_buscar_nota";
            this.lbl_buscar_nota.Size = new System.Drawing.Size(101, 20);
            this.lbl_buscar_nota.TabIndex = 154;
            this.lbl_buscar_nota.Text = "Buscar Nota:";
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(278, 284);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(159, 20);
            this.txt_nota.TabIndex = 155;
            this.txt_nota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(292, 353);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(35, 13);
            this.lbl_nota.TabIndex = 156;
            this.lbl_nota.Text = "label1";
            // 
            // checkedListBoxAroma
            // 
            this.checkedListBoxAroma.FormattingEnabled = true;
            this.checkedListBoxAroma.Location = new System.Drawing.Point(47, 162);
            this.checkedListBoxAroma.Name = "checkedListBoxAroma";
            this.checkedListBoxAroma.Size = new System.Drawing.Size(169, 154);
            this.checkedListBoxAroma.TabIndex = 157;
            // 
            // checkedListBoxNota
            // 
            this.checkedListBoxNota.FormattingEnabled = true;
            this.checkedListBoxNota.Location = new System.Drawing.Point(278, 162);
            this.checkedListBoxNota.Name = "checkedListBoxNota";
            this.checkedListBoxNota.Size = new System.Drawing.Size(159, 49);
            this.checkedListBoxNota.TabIndex = 158;
            // 
            // txt_nombre_perfume
            // 
            this.txt_nombre_perfume.AutoSize = true;
            this.txt_nombre_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_nombre_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_perfume.Location = new System.Drawing.Point(206, 67);
            this.txt_nombre_perfume.Name = "txt_nombre_perfume";
            this.txt_nombre_perfume.Size = new System.Drawing.Size(187, 25);
            this.txt_nombre_perfume.TabIndex = 159;
            this.txt_nombre_perfume.Text = "Nombre Perfume";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher3
            // 
            this.directorySearcher3.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher3.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lbl_error_seleccion_aroma
            // 
            this.lbl_error_seleccion_aroma.AutoSize = true;
            this.lbl_error_seleccion_aroma.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_seleccion_aroma.Location = new System.Drawing.Point(49, 328);
            this.lbl_error_seleccion_aroma.Name = "lbl_error_seleccion_aroma";
            this.lbl_error_seleccion_aroma.Size = new System.Drawing.Size(29, 13);
            this.lbl_error_seleccion_aroma.TabIndex = 160;
            this.lbl_error_seleccion_aroma.Text = "Error";
            // 
            // lbl_error_seleccion_nota
            // 
            this.lbl_error_seleccion_nota.AutoSize = true;
            this.lbl_error_seleccion_nota.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_seleccion_nota.Location = new System.Drawing.Point(279, 225);
            this.lbl_error_seleccion_nota.Name = "lbl_error_seleccion_nota";
            this.lbl_error_seleccion_nota.Size = new System.Drawing.Size(29, 13);
            this.lbl_error_seleccion_nota.TabIndex = 161;
            this.lbl_error_seleccion_nota.Text = "Error";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AromaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(834, 488);
            this.Controls.Add(this.lbl_error_seleccion_nota);
            this.Controls.Add(this.lbl_error_seleccion_aroma);
            this.Controls.Add(this.txt_nombre_perfume);
            this.Controls.Add(this.checkedListBoxNota);
            this.Controls.Add(this.checkedListBoxAroma);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.lbl_buscar_nota);
            this.Controls.Add(this.lbl_seleccionar_tipo_nota);
            this.Controls.Add(this.lbl_seleccionar_aroma);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataGridViewNotasDelPerfume);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_nombre_perfume);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_tipo_aroma_nota);
            this.Name = "AromaNota";
            this.Text = "AromaNota";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotasDelPerfume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tipo_aroma_nota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_nombre_perfume;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.DataGridView dataGridViewNotasDelPerfume;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_seleccionar_aroma;
        private System.Windows.Forms.Label lbl_seleccionar_tipo_nota;
        private System.Windows.Forms.Label lbl_buscar_nota;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.CheckedListBox checkedListBoxAroma;
        private System.Windows.Forms.CheckedListBox checkedListBoxNota;
        private System.Windows.Forms.Label txt_nombre_perfume;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
        private System.DirectoryServices.DirectorySearcher directorySearcher3;
        private System.Windows.Forms.Label lbl_error_seleccion_aroma;
        private System.Windows.Forms.Label lbl_error_seleccion_nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
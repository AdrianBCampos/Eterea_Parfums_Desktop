namespace Eterea_Parfums_Desktop
{
    partial class EditarAromaNota
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxAroma = new System.Windows.Forms.CheckedListBox();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_buscar_nota = new System.Windows.Forms.Label();
            this.lbl_seleccionar_tipo_nota = new System.Windows.Forms.Label();
            this.lbl_seleccionar_aroma = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_perfume = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_editar_tipo_aroma_nota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Nota de Salida",
            "Nota de Corazon",
            "Nota de Fondo"});
            this.checkedListBox1.Location = new System.Drawing.Point(280, 162);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(159, 49);
            this.checkedListBox1.TabIndex = 175;
            // 
            // checkedListBoxAroma
            // 
            this.checkedListBoxAroma.FormattingEnabled = true;
            this.checkedListBoxAroma.Items.AddRange(new object[] {
            "Cítrico",
            "Floral",
            "Fougere",
            "Chipre",
            "Amaderado",
            "Ambarado",
            "Oriental"});
            this.checkedListBoxAroma.Location = new System.Drawing.Point(49, 162);
            this.checkedListBoxAroma.Name = "checkedListBoxAroma";
            this.checkedListBoxAroma.Size = new System.Drawing.Size(169, 154);
            this.checkedListBoxAroma.TabIndex = 174;
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(294, 326);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(35, 13);
            this.lbl_nota.TabIndex = 173;
            this.lbl_nota.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 172;
            // 
            // lbl_buscar_nota
            // 
            this.lbl_buscar_nota.AutoSize = true;
            this.lbl_buscar_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_buscar_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_nota.Location = new System.Drawing.Point(264, 217);
            this.lbl_buscar_nota.Name = "lbl_buscar_nota";
            this.lbl_buscar_nota.Size = new System.Drawing.Size(101, 20);
            this.lbl_buscar_nota.TabIndex = 171;
            this.lbl_buscar_nota.Text = "Buscar Nota:";
            // 
            // lbl_seleccionar_tipo_nota
            // 
            this.lbl_seleccionar_tipo_nota.AutoSize = true;
            this.lbl_seleccionar_tipo_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_seleccionar_tipo_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionar_tipo_nota.Location = new System.Drawing.Point(264, 128);
            this.lbl_seleccionar_tipo_nota.Name = "lbl_seleccionar_tipo_nota";
            this.lbl_seleccionar_tipo_nota.Size = new System.Drawing.Size(193, 20);
            this.lbl_seleccionar_tipo_nota.TabIndex = 170;
            this.lbl_seleccionar_tipo_nota.Text = "Seleccionar Tipo De Nota:";
            // 
            // lbl_seleccionar_aroma
            // 
            this.lbl_seleccionar_aroma.AutoSize = true;
            this.lbl_seleccionar_aroma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_seleccionar_aroma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionar_aroma.Location = new System.Drawing.Point(42, 128);
            this.lbl_seleccionar_aroma.Name = "lbl_seleccionar_aroma";
            this.lbl_seleccionar_aroma.Size = new System.Drawing.Size(147, 20);
            this.lbl_seleccionar_aroma.TabIndex = 169;
            this.lbl_seleccionar_aroma.Text = "Seleccionar Aroma:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(306, 373);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(116, 31);
            this.btn_agregar.TabIndex = 168;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(258, 294);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(212, 130);
            this.pictureBox5.TabIndex = 167;
            this.pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Nota,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(505, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 244);
            this.dataGridView1.TabIndex = 166;
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
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.Location = new System.Drawing.Point(560, 387);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(137, 37);
            this.btn_finalizar.TabIndex = 165;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(494, 114);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(315, 268);
            this.pictureBox4.TabIndex = 164;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(258, 114);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(212, 176);
            this.pictureBox3.TabIndex = 163;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(33, 114);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 310);
            this.pictureBox2.TabIndex = 162;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_nombre_perfume
            // 
            this.lbl_nombre_perfume.AutoSize = true;
            this.lbl_nombre_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_perfume.Location = new System.Drawing.Point(45, 69);
            this.lbl_nombre_perfume.Name = "lbl_nombre_perfume";
            this.lbl_nombre_perfume.Size = new System.Drawing.Size(158, 20);
            this.lbl_nombre_perfume.TabIndex = 161;
            this.lbl_nombre_perfume.Text = "Nombre del Perfume:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(33, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 33);
            this.pictureBox1.TabIndex = 160;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_editar_tipo_aroma_nota
            // 
            this.lbl_editar_tipo_aroma_nota.AutoSize = true;
            this.lbl_editar_tipo_aroma_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_editar_tipo_aroma_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editar_tipo_aroma_nota.ForeColor = System.Drawing.Color.Black;
            this.lbl_editar_tipo_aroma_nota.Location = new System.Drawing.Point(30, 27);
            this.lbl_editar_tipo_aroma_nota.Name = "lbl_editar_tipo_aroma_nota";
            this.lbl_editar_tipo_aroma_nota.Size = new System.Drawing.Size(311, 18);
            this.lbl_editar_tipo_aroma_nota.TabIndex = 159;
            this.lbl_editar_tipo_aroma_nota.Text = "Editar Tipo De Aroma y Perfume Creado";
            // 
            // EditarAromaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(832, 451);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.checkedListBoxAroma);
            this.Controls.Add(this.lbl_nota);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_buscar_nota);
            this.Controls.Add(this.lbl_seleccionar_tipo_nota);
            this.Controls.Add(this.lbl_seleccionar_aroma);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_nombre_perfume);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_editar_tipo_aroma_nota);
            this.Name = "EditarAromaNota";
            this.Text = "EditarAromaNota";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxAroma;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_buscar_nota;
        private System.Windows.Forms.Label lbl_seleccionar_tipo_nota;
        private System.Windows.Forms.Label lbl_seleccionar_aroma;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_nombre_perfume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_editar_tipo_aroma_nota;
    }
}
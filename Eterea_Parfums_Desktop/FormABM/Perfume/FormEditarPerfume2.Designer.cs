namespace Eterea_Parfums_Desktop
{
    partial class FormEditarPerfume2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkedListBoxNota = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxAroma = new System.Windows.Forms.CheckedListBox();
            this.lbl_nota = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.lbl_buscar_nota = new System.Windows.Forms.Label();
            this.lbl_seleccionar_tipo_nota = new System.Windows.Forms.Label();
            this.lbl_seleccionar_aroma = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridViewNotasDelPerfume = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_perfume = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_editar_tipo_aroma_nota = new System.Windows.Forms.Label();
            this.txt_nombre_perfume = new System.Windows.Forms.Label();
            this.lbl_error_seleccion_aroma = new System.Windows.Forms.Label();
            this.lbl_error_seleccion_nota = new System.Windows.Forms.Label();
            this.lbl_tipo_de_nota = new System.Windows.Forms.Label();
            this.btn_x_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotasDelPerfume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxNota
            // 
            this.checkedListBoxNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.checkedListBoxNota.CheckOnClick = true;
            this.checkedListBoxNota.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBoxNota.FormattingEnabled = true;
            this.checkedListBoxNota.Location = new System.Drawing.Point(373, 199);
            this.checkedListBoxNota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBoxNota.Name = "checkedListBoxNota";
            this.checkedListBoxNota.Size = new System.Drawing.Size(211, 55);
            this.checkedListBoxNota.TabIndex = 175;
            this.checkedListBoxNota.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxNota_ItemCheck);
            // 
            // checkedListBoxAroma
            // 
            this.checkedListBoxAroma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.checkedListBoxAroma.CheckOnClick = true;
            this.checkedListBoxAroma.FormattingEnabled = true;
            this.checkedListBoxAroma.Location = new System.Drawing.Point(65, 199);
            this.checkedListBoxAroma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkedListBoxAroma.Name = "checkedListBoxAroma";
            this.checkedListBoxAroma.Size = new System.Drawing.Size(224, 174);
            this.checkedListBoxAroma.TabIndex = 174;
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(392, 401);
            this.lbl_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(36, 16);
            this.lbl_nota.TabIndex = 173;
            this.lbl_nota.Text = "Nota";
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(373, 315);
            this.txt_nota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(211, 22);
            this.txt_nota.TabIndex = 172;
            this.txt_nota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_buscar_nota
            // 
            this.lbl_buscar_nota.AutoSize = true;
            this.lbl_buscar_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_buscar_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_nota.Location = new System.Drawing.Point(352, 274);
            this.lbl_buscar_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_buscar_nota.Name = "lbl_buscar_nota";
            this.lbl_buscar_nota.Size = new System.Drawing.Size(125, 25);
            this.lbl_buscar_nota.TabIndex = 171;
            this.lbl_buscar_nota.Text = "Buscar Nota:";
            // 
            // lbl_seleccionar_tipo_nota
            // 
            this.lbl_seleccionar_tipo_nota.AutoSize = true;
            this.lbl_seleccionar_tipo_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_seleccionar_tipo_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionar_tipo_nota.Location = new System.Drawing.Point(352, 158);
            this.lbl_seleccionar_tipo_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_seleccionar_tipo_nota.Name = "lbl_seleccionar_tipo_nota";
            this.lbl_seleccionar_tipo_nota.Size = new System.Drawing.Size(241, 25);
            this.lbl_seleccionar_tipo_nota.TabIndex = 170;
            this.lbl_seleccionar_tipo_nota.Text = "Seleccionar Tipo De Nota:";
            // 
            // lbl_seleccionar_aroma
            // 
            this.lbl_seleccionar_aroma.AutoSize = true;
            this.lbl_seleccionar_aroma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_seleccionar_aroma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionar_aroma.Location = new System.Drawing.Point(56, 158);
            this.lbl_seleccionar_aroma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_seleccionar_aroma.Name = "lbl_seleccionar_aroma";
            this.lbl_seleccionar_aroma.Size = new System.Drawing.Size(184, 25);
            this.lbl_seleccionar_aroma.TabIndex = 169;
            this.lbl_seleccionar_aroma.Text = "Seleccionar Aroma:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(408, 459);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(155, 38);
            this.btn_agregar.TabIndex = 168;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(344, 385);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(283, 137);
            this.pictureBox5.TabIndex = 167;
            this.pictureBox5.TabStop = false;
            // 
            // dataGridViewNotasDelPerfume
            // 
            this.dataGridViewNotasDelPerfume.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.dataGridViewNotasDelPerfume.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewNotasDelPerfume.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNotasDelPerfume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewNotasDelPerfume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotasDelPerfume.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tipo,
            this.Nota,
            this.Eliminar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNotasDelPerfume.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewNotasDelPerfume.EnableHeadersVisualStyles = false;
            this.dataGridViewNotasDelPerfume.Location = new System.Drawing.Point(673, 158);
            this.dataGridViewNotasDelPerfume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewNotasDelPerfume.Name = "dataGridViewNotasDelPerfume";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNotasDelPerfume.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewNotasDelPerfume.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.dataGridViewNotasDelPerfume.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewNotasDelPerfume.Size = new System.Drawing.Size(374, 275);
            this.dataGridViewNotasDelPerfume.TabIndex = 166;
            this.dataGridViewNotasDelPerfume.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNotasDelPerfume_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 125;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 125;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.Location = new System.Drawing.Point(767, 452);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(183, 46);
            this.btn_finalizar.TabIndex = 165;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(659, 140);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(401, 382);
            this.pictureBox4.TabIndex = 164;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(344, 140);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(283, 231);
            this.pictureBox3.TabIndex = 163;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(44, 140);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 382);
            this.pictureBox2.TabIndex = 162;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_nombre_perfume
            // 
            this.lbl_nombre_perfume.AutoSize = true;
            this.lbl_nombre_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_perfume.Location = new System.Drawing.Point(60, 85);
            this.lbl_nombre_perfume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre_perfume.Name = "lbl_nombre_perfume";
            this.lbl_nombre_perfume.Size = new System.Drawing.Size(196, 25);
            this.lbl_nombre_perfume.TabIndex = 161;
            this.lbl_nombre_perfume.Text = "Nombre del Perfume:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(44, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(971, 41);
            this.pictureBox1.TabIndex = 160;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_editar_tipo_aroma_nota
            // 
            this.lbl_editar_tipo_aroma_nota.AutoSize = true;
            this.lbl_editar_tipo_aroma_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.lbl_editar_tipo_aroma_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_editar_tipo_aroma_nota.ForeColor = System.Drawing.Color.Black;
            this.lbl_editar_tipo_aroma_nota.Location = new System.Drawing.Point(40, 33);
            this.lbl_editar_tipo_aroma_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_editar_tipo_aroma_nota.Name = "lbl_editar_tipo_aroma_nota";
            this.lbl_editar_tipo_aroma_nota.Size = new System.Drawing.Size(481, 24);
            this.lbl_editar_tipo_aroma_nota.TabIndex = 159;
            this.lbl_editar_tipo_aroma_nota.Text = "Editar Tipo De Aroma y Notas Del Perfume Creado";
            // 
            // txt_nombre_perfume
            // 
            this.txt_nombre_perfume.AutoSize = true;
            this.txt_nombre_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_nombre_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_perfume.Location = new System.Drawing.Point(289, 80);
            this.txt_nombre_perfume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_nombre_perfume.Name = "txt_nombre_perfume";
            this.txt_nombre_perfume.Size = new System.Drawing.Size(233, 31);
            this.txt_nombre_perfume.TabIndex = 176;
            this.txt_nombre_perfume.Text = "Nombre Perfume";
            // 
            // lbl_error_seleccion_aroma
            // 
            this.lbl_error_seleccion_aroma.AutoSize = true;
            this.lbl_error_seleccion_aroma.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_seleccion_aroma.Location = new System.Drawing.Point(73, 417);
            this.lbl_error_seleccion_aroma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error_seleccion_aroma.Name = "lbl_error_seleccion_aroma";
            this.lbl_error_seleccion_aroma.Size = new System.Drawing.Size(36, 16);
            this.lbl_error_seleccion_aroma.TabIndex = 177;
            this.lbl_error_seleccion_aroma.Text = "Error";
            // 
            // lbl_error_seleccion_nota
            // 
            this.lbl_error_seleccion_nota.AutoSize = true;
            this.lbl_error_seleccion_nota.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_seleccion_nota.Location = new System.Drawing.Point(392, 428);
            this.lbl_error_seleccion_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error_seleccion_nota.Name = "lbl_error_seleccion_nota";
            this.lbl_error_seleccion_nota.Size = new System.Drawing.Size(36, 16);
            this.lbl_error_seleccion_nota.TabIndex = 162;
            this.lbl_error_seleccion_nota.Text = "Error";
            // 
            // lbl_tipo_de_nota
            // 
            this.lbl_tipo_de_nota.AutoSize = true;
            this.lbl_tipo_de_nota.Location = new System.Drawing.Point(451, 401);
            this.lbl_tipo_de_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo_de_nota.Name = "lbl_tipo_de_nota";
            this.lbl_tipo_de_nota.Size = new System.Drawing.Size(86, 16);
            this.lbl_tipo_de_nota.TabIndex = 178;
            this.lbl_tipo_de_nota.Text = "Tipo de Nota";
            // 
            // btn_x_cerrar
            // 
            this.btn_x_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_x_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_x_cerrar.Location = new System.Drawing.Point(1015, 13);
            this.btn_x_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_x_cerrar.Name = "btn_x_cerrar";
            this.btn_x_cerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_x_cerrar.Size = new System.Drawing.Size(45, 39);
            this.btn_x_cerrar.TabIndex = 301;
            this.btn_x_cerrar.Text = "< Anterior";
            this.btn_x_cerrar.UseVisualStyleBackColor = false;
            this.btn_x_cerrar.Click += new System.EventHandler(this.btn_x_cerrar_Click);
            // 
            // FormEditarPerfume2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1079, 539);
            this.Controls.Add(this.btn_x_cerrar);
            this.Controls.Add(this.lbl_tipo_de_nota);
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
            this.Controls.Add(this.lbl_editar_tipo_aroma_nota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEditarPerfume2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarAromaNota";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotasDelPerfume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxNota;
        private System.Windows.Forms.CheckedListBox checkedListBoxAroma;
        private System.Windows.Forms.Label lbl_nota;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Label lbl_buscar_nota;
        private System.Windows.Forms.Label lbl_seleccionar_tipo_nota;
        private System.Windows.Forms.Label lbl_seleccionar_aroma;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridViewNotasDelPerfume;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_nombre_perfume;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_editar_tipo_aroma_nota;
        private System.Windows.Forms.Label txt_nombre_perfume;
        private System.Windows.Forms.Label lbl_error_seleccion_aroma;
        private System.Windows.Forms.Label lbl_error_seleccion_nota;
        private System.Windows.Forms.Label lbl_tipo_de_nota;
        private System.Windows.Forms.Button btn_x_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
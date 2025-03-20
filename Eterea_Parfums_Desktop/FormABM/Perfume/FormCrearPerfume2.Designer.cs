namespace Eterea_Parfums_Desktop
{
    partial class FormCrearPerfume2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_tipo_aroma_nota = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre_perfume = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.dataGridViewNotasDelPerfume = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.lbl_tipo_de_nota = new System.Windows.Forms.Label();
            this.btn_x_cerrar = new System.Windows.Forms.Button();
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
            this.lbl_tipo_aroma_nota.Location = new System.Drawing.Point(37, 33);
            this.lbl_tipo_aroma_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo_aroma_nota.Name = "lbl_tipo_aroma_nota";
            this.lbl_tipo_aroma_nota.Size = new System.Drawing.Size(498, 24);
            this.lbl_tipo_aroma_nota.TabIndex = 142;
            this.lbl_tipo_aroma_nota.Text = "Asignar Tipo De Aroma y Notas Del Perfume Creado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(41, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(971, 41);
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nombre_perfume
            // 
            this.lbl_nombre_perfume.AutoSize = true;
            this.lbl_nombre_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_nombre_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_perfume.Location = new System.Drawing.Point(57, 85);
            this.lbl_nombre_perfume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre_perfume.Name = "lbl_nombre_perfume";
            this.lbl_nombre_perfume.Size = new System.Drawing.Size(196, 25);
            this.lbl_nombre_perfume.TabIndex = 144;
            this.lbl_nombre_perfume.Text = "Nombre del Perfume:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(41, 140);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 415);
            this.pictureBox2.TabIndex = 145;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(341, 140);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(283, 249);
            this.pictureBox3.TabIndex = 146;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(656, 140);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(479, 415);
            this.pictureBox4.TabIndex = 147;
            this.pictureBox4.TabStop = false;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.Location = new System.Drawing.Point(803, 476);
            this.btn_finalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(183, 46);
            this.btn_finalizar.TabIndex = 148;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // dataGridViewNotasDelPerfume
            // 
            this.dataGridViewNotasDelPerfume.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.dataGridViewNotasDelPerfume.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewNotasDelPerfume.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNotasDelPerfume.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewNotasDelPerfume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotasDelPerfume.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tipo,
            this.Nota,
            this.Eliminar});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewNotasDelPerfume.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewNotasDelPerfume.EnableHeadersVisualStyles = false;
            this.dataGridViewNotasDelPerfume.Location = new System.Drawing.Point(671, 158);
            this.dataGridViewNotasDelPerfume.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNotasDelPerfume.Name = "dataGridViewNotasDelPerfume";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNotasDelPerfume.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewNotasDelPerfume.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.dataGridViewNotasDelPerfume.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewNotasDelPerfume.Size = new System.Drawing.Size(447, 289);
            this.dataGridViewNotasDelPerfume.TabIndex = 149;
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
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Location = new System.Drawing.Point(341, 404);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(283, 151);
            this.pictureBox5.TabIndex = 150;
            this.pictureBox5.TabStop = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(405, 492);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(155, 38);
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
            this.lbl_seleccionar_aroma.Location = new System.Drawing.Point(53, 158);
            this.lbl_seleccionar_aroma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_seleccionar_aroma.Name = "lbl_seleccionar_aroma";
            this.lbl_seleccionar_aroma.Size = new System.Drawing.Size(184, 25);
            this.lbl_seleccionar_aroma.TabIndex = 152;
            this.lbl_seleccionar_aroma.Text = "Seleccionar Aroma:";
            // 
            // lbl_seleccionar_tipo_nota
            // 
            this.lbl_seleccionar_tipo_nota.AutoSize = true;
            this.lbl_seleccionar_tipo_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_seleccionar_tipo_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccionar_tipo_nota.Location = new System.Drawing.Point(349, 158);
            this.lbl_seleccionar_tipo_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_seleccionar_tipo_nota.Name = "lbl_seleccionar_tipo_nota";
            this.lbl_seleccionar_tipo_nota.Size = new System.Drawing.Size(241, 25);
            this.lbl_seleccionar_tipo_nota.TabIndex = 153;
            this.lbl_seleccionar_tipo_nota.Text = "Seleccionar Tipo De Nota:";
            // 
            // lbl_buscar_nota
            // 
            this.lbl_buscar_nota.AutoSize = true;
            this.lbl_buscar_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_buscar_nota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_nota.Location = new System.Drawing.Point(363, 299);
            this.lbl_buscar_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_buscar_nota.Name = "lbl_buscar_nota";
            this.lbl_buscar_nota.Size = new System.Drawing.Size(125, 25);
            this.lbl_buscar_nota.TabIndex = 154;
            this.lbl_buscar_nota.Text = "Buscar Nota:";
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(371, 340);
            this.txt_nota.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(211, 22);
            this.txt_nota.TabIndex = 155;
            this.txt_nota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_nota
            // 
            this.lbl_nota.AutoSize = true;
            this.lbl_nota.Location = new System.Drawing.Point(389, 431);
            this.lbl_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nota.Name = "lbl_nota";
            this.lbl_nota.Size = new System.Drawing.Size(36, 16);
            this.lbl_nota.TabIndex = 156;
            this.lbl_nota.Text = "Nota";
            // 
            // checkedListBoxAroma
            // 
            this.checkedListBoxAroma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.checkedListBoxAroma.CheckOnClick = true;
            this.checkedListBoxAroma.FormattingEnabled = true;
            this.checkedListBoxAroma.Location = new System.Drawing.Point(63, 199);
            this.checkedListBoxAroma.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxAroma.Name = "checkedListBoxAroma";
            this.checkedListBoxAroma.Size = new System.Drawing.Size(224, 174);
            this.checkedListBoxAroma.TabIndex = 157;
            // 
            // checkedListBoxNota
            // 
            this.checkedListBoxNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.checkedListBoxNota.CheckOnClick = true;
            this.checkedListBoxNota.FormattingEnabled = true;
            this.checkedListBoxNota.Location = new System.Drawing.Point(371, 199);
            this.checkedListBoxNota.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxNota.Name = "checkedListBoxNota";
            this.checkedListBoxNota.Size = new System.Drawing.Size(211, 55);
            this.checkedListBoxNota.TabIndex = 158;
            this.checkedListBoxNota.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxNota_ItemCheck);
            // 
            // txt_nombre_perfume
            // 
            this.txt_nombre_perfume.AutoSize = true;
            this.txt_nombre_perfume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txt_nombre_perfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_perfume.Location = new System.Drawing.Point(275, 82);
            this.txt_nombre_perfume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_nombre_perfume.Name = "txt_nombre_perfume";
            this.txt_nombre_perfume.Size = new System.Drawing.Size(233, 31);
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
            this.lbl_error_seleccion_aroma.Location = new System.Drawing.Point(65, 404);
            this.lbl_error_seleccion_aroma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error_seleccion_aroma.Name = "lbl_error_seleccion_aroma";
            this.lbl_error_seleccion_aroma.Size = new System.Drawing.Size(36, 16);
            this.lbl_error_seleccion_aroma.TabIndex = 160;
            this.lbl_error_seleccion_aroma.Text = "Error";
            // 
            // lbl_error_seleccion_nota
            // 
            this.lbl_error_seleccion_nota.AutoSize = true;
            this.lbl_error_seleccion_nota.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_seleccion_nota.Location = new System.Drawing.Point(393, 458);
            this.lbl_error_seleccion_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error_seleccion_nota.Name = "lbl_error_seleccion_nota";
            this.lbl_error_seleccion_nota.Size = new System.Drawing.Size(36, 16);
            this.lbl_error_seleccion_nota.TabIndex = 161;
            this.lbl_error_seleccion_nota.Text = "Error";
            // 
            // lbl_tipo_de_nota
            // 
            this.lbl_tipo_de_nota.AutoSize = true;
            this.lbl_tipo_de_nota.Location = new System.Drawing.Point(449, 431);
            this.lbl_tipo_de_nota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipo_de_nota.Name = "lbl_tipo_de_nota";
            this.lbl_tipo_de_nota.Size = new System.Drawing.Size(86, 16);
            this.lbl_tipo_de_nota.TabIndex = 162;
            this.lbl_tipo_de_nota.Text = "Tipo de Nota";
            // 
            // btn_x_cerrar
            // 
            this.btn_x_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btn_x_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_x_cerrar.Location = new System.Drawing.Point(1054, 25);
            this.btn_x_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_x_cerrar.Name = "btn_x_cerrar";
            this.btn_x_cerrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_x_cerrar.Size = new System.Drawing.Size(45, 39);
            this.btn_x_cerrar.TabIndex = 300;
            this.btn_x_cerrar.Text = "X";
            this.btn_x_cerrar.UseVisualStyleBackColor = false;
            this.btn_x_cerrar.Click += new System.EventHandler(this.btn_x_cerrar_Click);
            // 
            // FormCrearPerfume2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1149, 574);
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
            this.Controls.Add(this.lbl_tipo_aroma_nota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCrearPerfume2";
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
        private System.Windows.Forms.Label lbl_tipo_de_nota;
        private System.Windows.Forms.Button btn_x_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
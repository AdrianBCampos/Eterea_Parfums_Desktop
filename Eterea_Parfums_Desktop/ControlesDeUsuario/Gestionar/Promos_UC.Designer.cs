﻿namespace Eterea_Parfums_Desktop.ControlesDeUsuario
{
    partial class Promos_UC
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPromos = new System.Windows.Forms.DataGridView();
            this.txt_buscar_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_empleados = new System.Windows.Forms.Label();
            this.btn_crear_promo = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Id_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_de_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fin_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo_promo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar_promo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar_promo = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPromos
            // 
            this.dataGridViewPromos.AllowUserToAddRows = false;
            this.dataGridViewPromos.AllowUserToDeleteRows = false;
            this.dataGridViewPromos.AllowUserToResizeColumns = false;
            this.dataGridViewPromos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewPromos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPromos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPromos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dataGridViewPromos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPromos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPromos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPromos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPromos.ColumnHeadersHeight = 45;
            this.dataGridViewPromos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPromos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_promo,
            this.nombre_promo,
            this.tipo_de_promo,
            this.Inicio_promo,
            this.fin_promo,
            this.activo_promo,
            this.editar_promo,
            this.eliminar_promo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPromos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPromos.EnableHeadersVisualStyles = false;
            this.dataGridViewPromos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.dataGridViewPromos.Location = new System.Drawing.Point(20, 134);
            this.dataGridViewPromos.Name = "dataGridViewPromos";
            this.dataGridViewPromos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPromos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPromos.RowHeadersWidth = 51;
            this.dataGridViewPromos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(217)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewPromos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPromos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPromos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPromos.Size = new System.Drawing.Size(1234, 393);
            this.dataGridViewPromos.TabIndex = 283;
            this.dataGridViewPromos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPromos_CellContentClick_1);
            // 
            // txt_buscar_nombre
            // 
            this.txt_buscar_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.txt_buscar_nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_buscar_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            this.txt_buscar_nombre.Location = new System.Drawing.Point(438, 89);
            this.txt_buscar_nombre.Name = "txt_buscar_nombre";
            this.txt_buscar_nombre.Size = new System.Drawing.Size(408, 28);
            this.txt_buscar_nombre.TabIndex = 314;
            this.txt_buscar_nombre.TextChanged += new System.EventHandler(this.txt_buscar_nombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(107, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 24);
            this.label2.TabIndex = 313;
            this.label2.Text = "Filtrar Promociones por Nombre:";
            // 
            // lbl_empleados
            // 
            this.lbl_empleados.AutoSize = true;
            this.lbl_empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.lbl_empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.lbl_empleados.Location = new System.Drawing.Point(506, 30);
            this.lbl_empleados.Name = "lbl_empleados";
            this.lbl_empleados.Size = new System.Drawing.Size(294, 31);
            this.lbl_empleados.TabIndex = 312;
            this.lbl_empleados.Text = "Lista de Promociones";
            // 
            // btn_crear_promo
            // 
            this.btn_crear_promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            this.btn_crear_promo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_promo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_promo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.btn_crear_promo.Location = new System.Drawing.Point(1042, 84);
            this.btn_crear_promo.Name = "btn_crear_promo";
            this.btn_crear_promo.Size = new System.Drawing.Size(170, 37);
            this.btn_crear_promo.TabIndex = 311;
            this.btn_crear_promo.Text = "Crear Promoción";
            this.btn_crear_promo.UseVisualStyleBackColor = false;
            this.btn_crear_promo.Click += new System.EventHandler(this.btn_crear_promo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Location = new System.Drawing.Point(20, 17);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1234, 58);
            this.pictureBox3.TabIndex = 308;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(20, 78);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(977, 50);
            this.pictureBox4.TabIndex = 309;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(1001, 78);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 50);
            this.pictureBox1.TabIndex = 310;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(150)))), ((int)(((byte)(170)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(8, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1258, 530);
            this.pictureBox2.TabIndex = 307;
            this.pictureBox2.TabStop = false;
            // 
            // Id_promo
            // 
            this.Id_promo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Id_promo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id_promo.HeaderText = "Id";
            this.Id_promo.MinimumWidth = 6;
            this.Id_promo.Name = "Id_promo";
            this.Id_promo.ReadOnly = true;
            this.Id_promo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id_promo.Width = 40;
            // 
            // nombre_promo
            // 
            this.nombre_promo.HeaderText = "Nombre";
            this.nombre_promo.MinimumWidth = 6;
            this.nombre_promo.Name = "nombre_promo";
            this.nombre_promo.ReadOnly = true;
            this.nombre_promo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tipo_de_promo
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tipo_de_promo.DefaultCellStyle = dataGridViewCellStyle4;
            this.tipo_de_promo.HeaderText = "Tipo de Promoción";
            this.tipo_de_promo.MinimumWidth = 6;
            this.tipo_de_promo.Name = "tipo_de_promo";
            this.tipo_de_promo.ReadOnly = true;
            this.tipo_de_promo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Inicio_promo
            // 
            this.Inicio_promo.HeaderText = "Fecha de Inicio";
            this.Inicio_promo.MinimumWidth = 6;
            this.Inicio_promo.Name = "Inicio_promo";
            this.Inicio_promo.ReadOnly = true;
            this.Inicio_promo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fin_promo
            // 
            this.fin_promo.HeaderText = "Fecha de Finalización";
            this.fin_promo.MinimumWidth = 6;
            this.fin_promo.Name = "fin_promo";
            this.fin_promo.ReadOnly = true;
            this.fin_promo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // activo_promo
            // 
            this.activo_promo.HeaderText = "Activo";
            this.activo_promo.MinimumWidth = 6;
            this.activo_promo.Name = "activo_promo";
            this.activo_promo.ReadOnly = true;
            this.activo_promo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // editar_promo
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(137)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            this.editar_promo.DefaultCellStyle = dataGridViewCellStyle5;
            this.editar_promo.HeaderText = "";
            this.editar_promo.MinimumWidth = 6;
            this.editar_promo.Name = "editar_promo";
            this.editar_promo.ReadOnly = true;
            this.editar_promo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar_promo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // eliminar_promo
            // 
            this.eliminar_promo.HeaderText = "";
            this.eliminar_promo.MinimumWidth = 6;
            this.eliminar_promo.Name = "eliminar_promo";
            this.eliminar_promo.ReadOnly = true;
            this.eliminar_promo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar_promo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Promos_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(167)))), ((int)(((byte)(180)))));
            this.Controls.Add(this.dataGridViewPromos);
            this.Controls.Add(this.txt_buscar_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_empleados);
            this.Controls.Add(this.btn_crear_promo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Promos_UC";
            this.Size = new System.Drawing.Size(1275, 551);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewPromos;
        private System.Windows.Forms.TextBox txt_buscar_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_empleados;
        private System.Windows.Forms.Button btn_crear_promo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_de_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fin_promo;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo_promo;
        private System.Windows.Forms.DataGridViewButtonColumn editar_promo;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar_promo;
    }
}

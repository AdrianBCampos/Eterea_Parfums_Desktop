namespace Eterea_Parfums_Desktop
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_error_auth = new System.Windows.Forms.Label();
            this.lbl_error_pass = new System.Windows.Forms.Label();
            this.lbl_error_user = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(667, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(73, 51);
            this.button1.TabIndex = 77;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_error_auth
            // 
            this.lbl_error_auth.AutoSize = true;
            this.lbl_error_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_auth.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_error_auth.Location = new System.Drawing.Point(124, 345);
            this.lbl_error_auth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error_auth.Name = "lbl_error_auth";
            this.lbl_error_auth.Size = new System.Drawing.Size(100, 25);
            this.lbl_error_auth.TabIndex = 75;
            this.lbl_error_auth.Text = "Error Auth";
            // 
            // lbl_error_pass
            // 
            this.lbl_error_pass.AutoSize = true;
            this.lbl_error_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_pass.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_error_pass.Location = new System.Drawing.Point(606, 280);
            this.lbl_error_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error_pass.Name = "lbl_error_pass";
            this.lbl_error_pass.Size = new System.Drawing.Size(54, 25);
            this.lbl_error_pass.TabIndex = 74;
            this.lbl_error_pass.Text = "Error";
            // 
            // lbl_error_user
            // 
            this.lbl_error_user.AutoSize = true;
            this.lbl_error_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_user.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_error_user.Location = new System.Drawing.Point(606, 205);
            this.lbl_error_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_error_user.Name = "lbl_error_user";
            this.lbl_error_user.Size = new System.Drawing.Size(54, 25);
            this.lbl_error_user.TabIndex = 73;
            this.lbl_error_user.Text = "Error";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(123, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 72;
            this.label2.Text = "Contraseña: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(123, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 71;
            this.label1.Text = "Usuario:";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(267, 279);
            this.txt_contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(329, 22);
            this.txt_contraseña.TabIndex = 70;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(267, 206);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(329, 22);
            this.txt_usuario.TabIndex = 69;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Pink;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(324, 399);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(183, 46);
            this.btn_login.TabIndex = 68;
            this.btn_login.Text = "Iniciar Sesión";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_error_auth);
            this.Controls.Add(this.lbl_error_pass);
            this.Controls.Add(this.lbl_error_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.btn_login);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_error_auth;
        private System.Windows.Forms.Label lbl_error_pass;
        private System.Windows.Forms.Label lbl_error_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_login;
    }
}
namespace RegistroAsistencia
{
    partial class loginAdministrativo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpleadoID = new System.Windows.Forms.TextBox();
            this.txtEmpleadoRut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtras3 = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar el ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar Rut";
         
            // 
            // txtEmpleadoID
            // 
            this.txtEmpleadoID.Location = new System.Drawing.Point(345, 350);
            this.txtEmpleadoID.Name = "txtEmpleadoID";
            this.txtEmpleadoID.Size = new System.Drawing.Size(169, 20);
            this.txtEmpleadoID.TabIndex = 3;
            // 
            // txtEmpleadoRut
            // 
            this.txtEmpleadoRut.Location = new System.Drawing.Point(345, 417);
            this.txtEmpleadoRut.Name = "txtEmpleadoRut";
            this.txtEmpleadoRut.Size = new System.Drawing.Size(169, 20);
            this.txtEmpleadoRut.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegistroAsistencia.Properties.Resources.contrasena2;
            this.pictureBox1.Location = new System.Drawing.Point(304, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 264);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtras3
            // 
            this.btnAtras3.Location = new System.Drawing.Point(0, 1);
            this.btnAtras3.Name = "btnAtras3";
            this.btnAtras3.Size = new System.Drawing.Size(79, 23);
            this.btnAtras3.TabIndex = 5;
            this.btnAtras3.Text = "Volever atras";
            this.btnAtras3.UseVisualStyleBackColor = true;
            this.btnAtras3.Click += new System.EventHandler(this.btnAtras3_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(384, 443);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(97, 23);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // loginAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnAtras3);
            this.Controls.Add(this.txtEmpleadoRut);
            this.Controls.Add(this.txtEmpleadoID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "loginAdministrativo";
            this.Text = "Bienvenido al Login Administrativo";
            this.Load += new System.EventHandler(this.loginAdministrativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtEmpleadoID;
        public System.Windows.Forms.TextBox txtEmpleadoRut;
        public System.Windows.Forms.Button btnAtras3;
        public System.Windows.Forms.Button btnIniciarSesion;
    }
}
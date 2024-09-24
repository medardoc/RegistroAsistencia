namespace RegistroAsistencia
{
    partial class MarcarSalida
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreSalida = new System.Windows.Forms.TextBox();
            this.txtRutSalida = new System.Windows.Forms.TextBox();
            this.btnConfirmarSalida = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtras2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estamos registrando tu salida";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresar Rut";
            // 
            // txtNombreSalida
            // 
            this.txtNombreSalida.Location = new System.Drawing.Point(555, 228);
            this.txtNombreSalida.Name = "txtNombreSalida";
            this.txtNombreSalida.Size = new System.Drawing.Size(150, 20);
            this.txtNombreSalida.TabIndex = 4;
            // 
            // txtRutSalida
            // 
            this.txtRutSalida.Location = new System.Drawing.Point(555, 308);
            this.txtRutSalida.Name = "txtRutSalida";
            this.txtRutSalida.Size = new System.Drawing.Size(150, 20);
            this.txtRutSalida.TabIndex = 5;
            // 
            // btnConfirmarSalida
            // 
            this.btnConfirmarSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSalida.Location = new System.Drawing.Point(555, 382);
            this.btnConfirmarSalida.Name = "btnConfirmarSalida";
            this.btnConfirmarSalida.Size = new System.Drawing.Size(150, 60);
            this.btnConfirmarSalida.TabIndex = 6;
            this.btnConfirmarSalida.Text = "Confirmar Salida";
            this.btnConfirmarSalida.UseVisualStyleBackColor = true;
            this.btnConfirmarSalida.Click += new System.EventHandler(this.btnConfirmarSalida_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegistroAsistencia.Properties.Resources.perfil2;
            this.pictureBox1.Location = new System.Drawing.Point(140, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAtras2
            // 
            this.btnAtras2.Location = new System.Drawing.Point(1, 0);
            this.btnAtras2.Name = "btnAtras2";
            this.btnAtras2.Size = new System.Drawing.Size(75, 23);
            this.btnAtras2.TabIndex = 7;
            this.btnAtras2.Text = "Volver atras";
            this.btnAtras2.UseVisualStyleBackColor = true;
            this.btnAtras2.Click += new System.EventHandler(this.btnAtras2_Click);
            // 
            // MarcarSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnAtras2);
            this.Controls.Add(this.btnConfirmarSalida);
            this.Controls.Add(this.txtRutSalida);
            this.Controls.Add(this.txtNombreSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MarcarSalida";
            this.Text = "MarcarSalida";
            this.Load += new System.EventHandler(this.MarcarSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnConfirmarSalida;
        public System.Windows.Forms.TextBox txtNombreSalida;
        public System.Windows.Forms.TextBox txtRutSalida;
        public System.Windows.Forms.Button btnAtras2;
    }
}
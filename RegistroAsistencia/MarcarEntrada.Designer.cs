namespace RegistroAsistencia
{
    partial class MarcarEntrada
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
            this.btnConfirmarEntrada = new System.Windows.Forms.Button();
            this.txtRutEntrada = new System.Windows.Forms.TextBox();
            this.txtNombreEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarEntrada
            // 
            this.btnConfirmarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEntrada.Location = new System.Drawing.Point(520, 378);
            this.btnConfirmarEntrada.Name = "btnConfirmarEntrada";
            this.btnConfirmarEntrada.Size = new System.Drawing.Size(150, 60);
            this.btnConfirmarEntrada.TabIndex = 1;
            this.btnConfirmarEntrada.Text = "Confirmar Entrada";
            this.btnConfirmarEntrada.UseVisualStyleBackColor = true;
            this.btnConfirmarEntrada.Click += new System.EventHandler(this.btnConfirmarEntrada_Click);
            // 
            // txtRutEntrada
            // 
            this.txtRutEntrada.Location = new System.Drawing.Point(520, 315);
            this.txtRutEntrada.Name = "txtRutEntrada";
            this.txtRutEntrada.Size = new System.Drawing.Size(149, 20);
            this.txtRutEntrada.TabIndex = 2;
            // 
            // txtNombreEntrada
            // 
            this.txtNombreEntrada.Location = new System.Drawing.Point(520, 237);
            this.txtNombreEntrada.Name = "txtNombreEntrada";
            this.txtNombreEntrada.Size = new System.Drawing.Size(149, 20);
            this.txtNombreEntrada.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estamos registrando tu entrada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(517, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingresar Rut";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingresar nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RegistroAsistencia.Properties.Resources.perfil2;
            this.pictureBox1.Location = new System.Drawing.Point(119, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 360);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(1, 1);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Volver atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // MarcarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEntrada);
            this.Controls.Add(this.txtRutEntrada);
            this.Controls.Add(this.btnConfirmarEntrada);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MarcarEntrada";
            this.Text = "Marcar Entrada";
            this.Load += new System.EventHandler(this.MarcarEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnConfirmarEntrada;
        public System.Windows.Forms.TextBox txtRutEntrada;
        public System.Windows.Forms.TextBox txtNombreEntrada;
        public System.Windows.Forms.Button btnAtras;
    }
}
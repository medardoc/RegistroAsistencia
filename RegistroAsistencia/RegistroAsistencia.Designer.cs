namespace RegistroAsistencia
{
    partial class RegistroAsistencia
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
            this.btnMostrarAsistencia = new System.Windows.Forms.Button();
            this.txtHoraSalidaA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoraEntradaA = new System.Windows.Forms.TextBox();
            this.EmailConsultar = new System.Windows.Forms.Label();
            this.txtFechaAsistencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpleadoIDAsistencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar6 = new System.Windows.Forms.Button();
            this.btnAgregarAsistencia = new System.Windows.Forms.Button();
            this.dataGridViewAsistencia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarAsistencia
            // 
            this.btnMostrarAsistencia.Location = new System.Drawing.Point(726, 439);
            this.btnMostrarAsistencia.Name = "btnMostrarAsistencia";
            this.btnMostrarAsistencia.Size = new System.Drawing.Size(75, 44);
            this.btnMostrarAsistencia.TabIndex = 68;
            this.btnMostrarAsistencia.Text = "Ver Reportes";
            this.btnMostrarAsistencia.UseVisualStyleBackColor = true;
            this.btnMostrarAsistencia.Click += new System.EventHandler(this.btnMostrarAsistencia_Click);
            // 
            // txtHoraSalidaA
            // 
            this.txtHoraSalidaA.Location = new System.Drawing.Point(121, 253);
            this.txtHoraSalidaA.Name = "txtHoraSalidaA";
            this.txtHoraSalidaA.Size = new System.Drawing.Size(100, 20);
            this.txtHoraSalidaA.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 65;
            this.label6.Text = "Hora de Salida";
            // 
            // txtHoraEntradaA
            // 
            this.txtHoraEntradaA.Location = new System.Drawing.Point(121, 211);
            this.txtHoraEntradaA.Name = "txtHoraEntradaA";
            this.txtHoraEntradaA.Size = new System.Drawing.Size(100, 20);
            this.txtHoraEntradaA.TabIndex = 64;
            // 
            // EmailConsultar
            // 
            this.EmailConsultar.AutoSize = true;
            this.EmailConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailConsultar.Location = new System.Drawing.Point(118, 192);
            this.EmailConsultar.Name = "EmailConsultar";
            this.EmailConsultar.Size = new System.Drawing.Size(121, 16);
            this.EmailConsultar.TabIndex = 63;
            this.EmailConsultar.Text = "Hora de Entrada";
            // 
            // txtFechaAsistencia
            // 
            this.txtFechaAsistencia.Location = new System.Drawing.Point(121, 172);
            this.txtFechaAsistencia.Name = "txtFechaAsistencia";
            this.txtFechaAsistencia.Size = new System.Drawing.Size(100, 20);
            this.txtFechaAsistencia.TabIndex = 62;
            this.txtFechaAsistencia.TextChanged += new System.EventHandler(this.tctFechaInicio_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Fecha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEmpleadoIDAsistencia
            // 
            this.txtEmpleadoIDAsistencia.Location = new System.Drawing.Point(121, 130);
            this.txtEmpleadoIDAsistencia.Name = "txtEmpleadoIDAsistencia";
            this.txtEmpleadoIDAsistencia.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleadoIDAsistencia.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "EmpleadoID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Agregar Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 56;
            // 
            // btnRegresar6
            // 
            this.btnRegresar6.Location = new System.Drawing.Point(0, 0);
            this.btnRegresar6.Name = "btnRegresar6";
            this.btnRegresar6.Size = new System.Drawing.Size(75, 37);
            this.btnRegresar6.TabIndex = 55;
            this.btnRegresar6.Text = "Volver al menu";
            this.btnRegresar6.UseVisualStyleBackColor = true;
            this.btnRegresar6.Click += new System.EventHandler(this.btnRegresar6_Click);
            // 
            // btnAgregarAsistencia
            // 
            this.btnAgregarAsistencia.Location = new System.Drawing.Point(409, 475);
            this.btnAgregarAsistencia.Name = "btnAgregarAsistencia";
            this.btnAgregarAsistencia.Size = new System.Drawing.Size(75, 21);
            this.btnAgregarAsistencia.TabIndex = 54;
            this.btnAgregarAsistencia.Text = "Agregar";
            this.btnAgregarAsistencia.UseVisualStyleBackColor = true;
            this.btnAgregarAsistencia.Click += new System.EventHandler(this.btnAgregarAsistencia_Click);
            // 
            // dataGridViewAsistencia
            // 
            this.dataGridViewAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAsistencia.Location = new System.Drawing.Point(253, 29);
            this.dataGridViewAsistencia.Name = "dataGridViewAsistencia";
            this.dataGridViewAsistencia.Size = new System.Drawing.Size(548, 404);
            this.dataGridViewAsistencia.TabIndex = 53;
            // 
            // RegistroAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnMostrarAsistencia);
            this.Controls.Add(this.txtHoraSalidaA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHoraEntradaA);
            this.Controls.Add(this.EmailConsultar);
            this.Controls.Add(this.txtFechaAsistencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpleadoIDAsistencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar6);
            this.Controls.Add(this.btnAgregarAsistencia);
            this.Controls.Add(this.dataGridViewAsistencia);
            this.Name = "RegistroAsistencia";
            this.Text = "Registro Asistencia";
            this.Load += new System.EventHandler(this.RegistroAsistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnMostrarAsistencia;
        public System.Windows.Forms.TextBox txtHoraSalidaA;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtHoraEntradaA;
        public System.Windows.Forms.Label EmailConsultar;
        public System.Windows.Forms.TextBox txtFechaAsistencia;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmpleadoIDAsistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnRegresar6;
        public System.Windows.Forms.Button btnAgregarAsistencia;
        public System.Windows.Forms.DataGridView dataGridViewAsistencia;
    }
}
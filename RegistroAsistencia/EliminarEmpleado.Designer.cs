namespace RegistroAsistencia
{
    partial class EliminarEmpleado
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
            this.dataGridViewEliminar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegresar1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConsultarEliminar = new System.Windows.Forms.TextBox();
            this.btnBuscarEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEliminar
            // 
            this.dataGridViewEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEliminar.Location = new System.Drawing.Point(181, 81);
            this.dataGridViewEliminar.Name = "dataGridViewEliminar";
            this.dataGridViewEliminar.Size = new System.Drawing.Size(461, 249);
            this.dataGridViewEliminar.TabIndex = 0;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona a colaborador a eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(190, 451);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 33);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegresar1
            // 
            this.btnRegresar1.Location = new System.Drawing.Point(0, 1);
            this.btnRegresar1.Name = "btnRegresar1";
            this.btnRegresar1.Size = new System.Drawing.Size(75, 37);
            this.btnRegresar1.TabIndex = 4;
            this.btnRegresar1.Text = "Volver al menu";
            this.btnRegresar1.UseVisualStyleBackColor = true;
            this.btnRegresar1.Click += new System.EventHandler(this.btnRegresar1_Click);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar Empleado";
            // 
            // txtConsultarEliminar
            // 
            this.txtConsultarEliminar.Location = new System.Drawing.Point(190, 386);
            this.txtConsultarEliminar.Name = "txtConsultarEliminar";
            this.txtConsultarEliminar.Size = new System.Drawing.Size(130, 20);
            this.txtConsultarEliminar.TabIndex = 6;
            // 
            // btnBuscarEliminar
            // 
            this.btnBuscarEliminar.Location = new System.Drawing.Point(190, 412);
            this.btnBuscarEliminar.Name = "btnBuscarEliminar";
            this.btnBuscarEliminar.Size = new System.Drawing.Size(101, 33);
            this.btnBuscarEliminar.TabIndex = 7;
            this.btnBuscarEliminar.Text = "Buscar Empleado";
            this.btnBuscarEliminar.UseVisualStyleBackColor = true;
            this.btnBuscarEliminar.Click += new System.EventHandler(this.btnBuscarEliminar_Click);
            // 
            // EliminarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.btnBuscarEliminar);
            this.Controls.Add(this.txtConsultarEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegresar1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEliminar);
            this.Name = "EliminarEmpleado";
            this.Text = "Eliminar Empleado";
            this.Load += new System.EventHandler(this.EliminarEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsultarEliminar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.DataGridView dataGridViewEliminar;
        public System.Windows.Forms.Button btnBuscarEliminar;
    }
}
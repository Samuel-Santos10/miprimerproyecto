namespace miprimerproyecto
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnprocesar = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.grboperaciones = new System.Windows.Forms.GroupBox();
            this.optsuma = new System.Windows.Forms.RadioButton();
            this.optresta = new System.Windows.Forms.RadioButton();
            this.optmultiplicacion = new System.Windows.Forms.RadioButton();
            this.optdivicion = new System.Windows.Forms.RadioButton();
            this.grboperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(97, 144);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(75, 28);
            this.btnprocesar.TabIndex = 0;
            this.btnprocesar.Text = "PROCESAR";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(53, 51);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(75, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(180, 51);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(75, 20);
            this.txtnum2.TabIndex = 2;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(12, 54);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(33, 13);
            this.lblnum1.TabIndex = 3;
            this.lblnum1.Text = "num1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(139, 54);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(33, 13);
            this.lblnum2.TabIndex = 4;
            this.lblnum2.Text = "num2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Respuesta:";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(161, 107);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(13, 13);
            this.lblrespuesta.TabIndex = 6;
            this.lblrespuesta.Text = "?";
            // 
            // grboperaciones
            // 
            this.grboperaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grboperaciones.Controls.Add(this.optdivicion);
            this.grboperaciones.Controls.Add(this.optmultiplicacion);
            this.grboperaciones.Controls.Add(this.optresta);
            this.grboperaciones.Controls.Add(this.optsuma);
            this.grboperaciones.Location = new System.Drawing.Point(300, 51);
            this.grboperaciones.Name = "grboperaciones";
            this.grboperaciones.Size = new System.Drawing.Size(104, 158);
            this.grboperaciones.TabIndex = 7;
            this.grboperaciones.TabStop = false;
            this.grboperaciones.Text = "Operaciones";
            // 
            // optsuma
            // 
            this.optsuma.AutoSize = true;
            this.optsuma.Checked = true;
            this.optsuma.Location = new System.Drawing.Point(6, 28);
            this.optsuma.Name = "optsuma";
            this.optsuma.Size = new System.Drawing.Size(50, 17);
            this.optsuma.TabIndex = 0;
            this.optsuma.TabStop = true;
            this.optsuma.Text = "suma";
            this.optsuma.UseVisualStyleBackColor = true;
            // 
            // optresta
            // 
            this.optresta.AutoSize = true;
            this.optresta.Location = new System.Drawing.Point(6, 56);
            this.optresta.Name = "optresta";
            this.optresta.Size = new System.Drawing.Size(48, 17);
            this.optresta.TabIndex = 1;
            this.optresta.Text = "resta";
            this.optresta.UseVisualStyleBackColor = true;
            // 
            // optmultiplicacion
            // 
            this.optmultiplicacion.AutoSize = true;
            this.optmultiplicacion.Location = new System.Drawing.Point(6, 93);
            this.optmultiplicacion.Name = "optmultiplicacion";
            this.optmultiplicacion.Size = new System.Drawing.Size(74, 17);
            this.optmultiplicacion.TabIndex = 2;
            this.optmultiplicacion.Text = "multiplicar ";
            this.optmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // optdivicion
            // 
            this.optdivicion.AutoSize = true;
            this.optdivicion.Location = new System.Drawing.Point(6, 128);
            this.optdivicion.Name = "optdivicion";
            this.optdivicion.Size = new System.Drawing.Size(61, 17);
            this.optdivicion.TabIndex = 3;
            this.optdivicion.Text = "divicion";
            this.optdivicion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 301);
            this.Controls.Add(this.grboperaciones);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btnprocesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grboperaciones.ResumeLayout(false);
            this.grboperaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.GroupBox grboperaciones;
        private System.Windows.Forms.RadioButton optdivicion;
        private System.Windows.Forms.RadioButton optmultiplicacion;
        private System.Windows.Forms.RadioButton optresta;
        private System.Windows.Forms.RadioButton optsuma;
    }
}


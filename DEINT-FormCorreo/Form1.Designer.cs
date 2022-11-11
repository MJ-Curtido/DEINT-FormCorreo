namespace DEINT_FormCorreo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDe = new System.Windows.Forms.TextBox();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.tbPara = new System.Windows.Forms.TextBox();
            this.tbAsunto = new System.Windows.Forms.TextBox();
            this.tbContenido = new System.Windows.Forms.TextBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Para:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asunto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contenido:";
            // 
            // tbDe
            // 
            this.tbDe.Location = new System.Drawing.Point(126, 19);
            this.tbDe.Name = "tbDe";
            this.tbDe.Size = new System.Drawing.Size(388, 20);
            this.tbDe.TabIndex = 5;
            this.tbDe.Text = "mcurros339@g.educaand.es";
            // 
            // tbContra
            // 
            this.tbContra.Location = new System.Drawing.Point(126, 63);
            this.tbContra.Name = "tbContra";
            this.tbContra.Size = new System.Drawing.Size(388, 20);
            this.tbContra.TabIndex = 6;
            this.tbContra.Text = "ufegijwhoovgzmmm";
            this.tbContra.UseSystemPasswordChar = true;
            // 
            // tbPara
            // 
            this.tbPara.Location = new System.Drawing.Point(126, 111);
            this.tbPara.Name = "tbPara";
            this.tbPara.Size = new System.Drawing.Size(388, 20);
            this.tbPara.TabIndex = 7;
            // 
            // tbAsunto
            // 
            this.tbAsunto.Location = new System.Drawing.Point(43, 187);
            this.tbAsunto.Name = "tbAsunto";
            this.tbAsunto.Size = new System.Drawing.Size(471, 20);
            this.tbAsunto.TabIndex = 8;
            // 
            // tbContenido
            // 
            this.tbContenido.Location = new System.Drawing.Point(45, 232);
            this.tbContenido.Multiline = true;
            this.tbContenido.Name = "tbContenido";
            this.tbContenido.Size = new System.Drawing.Size(469, 166);
            this.tbContenido.TabIndex = 9;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(224, 148);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(104, 23);
            this.btnAdjuntar.TabIndex = 10;
            this.btnAdjuntar.Text = "Archivo adjunto";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(440, 415);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(104, 23);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.tbContenido);
            this.Controls.Add(this.tbAsunto);
            this.Controls.Add(this.tbPara);
            this.Controls.Add(this.tbContra);
            this.Controls.Add(this.tbDe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDe;
        private System.Windows.Forms.TextBox tbContra;
        private System.Windows.Forms.TextBox tbPara;
        private System.Windows.Forms.TextBox tbAsunto;
        private System.Windows.Forms.TextBox tbContenido;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.Button btnEnviar;
    }
}


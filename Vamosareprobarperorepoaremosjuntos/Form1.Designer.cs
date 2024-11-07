
namespace Vamosareprobarperorepoaremosjuntos
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
            this.lbusuario = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbfecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblectem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdia = new System.Windows.Forms.TextBox();
            this.txtano = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Location = new System.Drawing.Point(12, 9);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(138, 17);
            this.lbusuario.TabIndex = 0;
            this.lbusuario.Text = "NOMBRE USUARIO:";
            this.lbusuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(156, 6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(147, 22);
            this.txtnombre.TabIndex = 1;
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(342, 9);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(57, 17);
            this.lbfecha.TabIndex = 2;
            this.lbfecha.Text = "FECHA:";
            this.lbfecha.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "TEMPERATURA EN CELCIUS:";
            // 
            // lblectem
            // 
            this.lblectem.AutoSize = true;
            this.lblectem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblectem.Location = new System.Drawing.Point(228, 100);
            this.lblectem.Name = "lblectem";
            this.lblectem.Size = new System.Drawing.Size(75, 46);
            this.lblectem.TabIndex = 7;
            this.lblectem.Text = "0.0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "ENCENDER VENTILADOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "APAGAR VENTILADOR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "/";
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(460, 9);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(23, 22);
            this.txtmes.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "/";
            // 
            // txtdia
            // 
            this.txtdia.Location = new System.Drawing.Point(405, 10);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(23, 22);
            this.txtdia.TabIndex = 14;
            // 
            // txtano
            // 
            this.txtano.Location = new System.Drawing.Point(515, 9);
            this.txtano.Name = "txtano";
            this.txtano.Size = new System.Drawing.Size(23, 22);
            this.txtano.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 48);
            this.button3.TabIndex = 18;
            this.button3.Text = "GUARDAR USUARIO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 315);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtano);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtdia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblectem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbusuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblectem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdia;
        private System.Windows.Forms.TextBox txtano;
        private System.Windows.Forms.Button button3;
    }
}


namespace CL19037Guia6Ejercicio6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroC = new System.Windows.Forms.TextBox();
            this.nudCambiar = new System.Windows.Forms.NumericUpDown();
            this.lblContador = new System.Windows.Forms.Label();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblNum10 = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum9 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblNum8 = new System.Windows.Forms.Label();
            this.lblNum3 = new System.Windows.Forms.Label();
            this.lblNum7 = new System.Windows.Forms.Label();
            this.lblNum4 = new System.Windows.Forms.Label();
            this.lblNum6 = new System.Windows.Forms.Label();
            this.lblNum5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbMult3 = new System.Windows.Forms.ComboBox();
            this.cbMult5 = new System.Windows.Forms.ComboBox();
            this.lblMult3 = new System.Windows.Forms.Label();
            this.lblMult5 = new System.Windows.Forms.Label();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCambiar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumeroC);
            this.groupBox1.Controls.Add(this.nudCambiar);
            this.groupBox1.Controls.Add(this.lblContador);
            this.groupBox1.Controls.Add(this.txtNumeros);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // txtNumeroC
            // 
            this.txtNumeroC.Location = new System.Drawing.Point(6, 92);
            this.txtNumeroC.Name = "txtNumeroC";
            this.txtNumeroC.Size = new System.Drawing.Size(85, 22);
            this.txtNumeroC.TabIndex = 5;
            this.txtNumeroC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroC_KeyPress);
            // 
            // nudCambiar
            // 
            this.nudCambiar.Location = new System.Drawing.Point(6, 131);
            this.nudCambiar.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCambiar.Name = "nudCambiar";
            this.nudCambiar.Size = new System.Drawing.Size(85, 22);
            this.nudCambiar.TabIndex = 4;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(6, 59);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(16, 17);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "0";
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(6, 26);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(85, 22);
            this.txtNumeros.TabIndex = 0;
            this.txtNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnCambiar);
            this.groupBox2.Controls.Add(this.btnProcesar);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(137, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Procesos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(7, 127);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(156, 29);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(7, 92);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(156, 29);
            this.btnCambiar.TabIndex = 2;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(7, 57);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(156, 29);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(7, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 28);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblNum10);
            this.groupBox3.Controls.Add(this.lblNum1);
            this.groupBox3.Controls.Add(this.lblNum9);
            this.groupBox3.Controls.Add(this.lblNum2);
            this.groupBox3.Controls.Add(this.lblNum8);
            this.groupBox3.Controls.Add(this.lblNum3);
            this.groupBox3.Controls.Add(this.lblNum7);
            this.groupBox3.Controls.Add(this.lblNum4);
            this.groupBox3.Controls.Add(this.lblNum6);
            this.groupBox3.Controls.Add(this.lblNum5);
            this.groupBox3.Location = new System.Drawing.Point(312, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 163);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Numeros Elegidos";
            // 
            // lblNum10
            // 
            this.lblNum10.AutoSize = true;
            this.lblNum10.Location = new System.Drawing.Point(230, 90);
            this.lblNum10.Name = "lblNum10";
            this.lblNum10.Size = new System.Drawing.Size(13, 17);
            this.lblNum10.TabIndex = 12;
            this.lblNum10.Text = "-";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(22, 31);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(13, 17);
            this.lblNum1.TabIndex = 3;
            this.lblNum1.Text = "-";
            // 
            // lblNum9
            // 
            this.lblNum9.AutoSize = true;
            this.lblNum9.Location = new System.Drawing.Point(230, 31);
            this.lblNum9.Name = "lblNum9";
            this.lblNum9.Size = new System.Drawing.Size(13, 17);
            this.lblNum9.TabIndex = 11;
            this.lblNum9.Text = "-";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(22, 90);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(13, 17);
            this.lblNum2.TabIndex = 4;
            this.lblNum2.Text = "-";
            // 
            // lblNum8
            // 
            this.lblNum8.AutoSize = true;
            this.lblNum8.Location = new System.Drawing.Point(178, 90);
            this.lblNum8.Name = "lblNum8";
            this.lblNum8.Size = new System.Drawing.Size(13, 17);
            this.lblNum8.TabIndex = 10;
            this.lblNum8.Text = "-";
            // 
            // lblNum3
            // 
            this.lblNum3.AutoSize = true;
            this.lblNum3.Location = new System.Drawing.Point(74, 31);
            this.lblNum3.Name = "lblNum3";
            this.lblNum3.Size = new System.Drawing.Size(13, 17);
            this.lblNum3.TabIndex = 5;
            this.lblNum3.Text = "-";
            // 
            // lblNum7
            // 
            this.lblNum7.AutoSize = true;
            this.lblNum7.Location = new System.Drawing.Point(178, 31);
            this.lblNum7.Name = "lblNum7";
            this.lblNum7.Size = new System.Drawing.Size(13, 17);
            this.lblNum7.TabIndex = 9;
            this.lblNum7.Text = "-";
            // 
            // lblNum4
            // 
            this.lblNum4.AutoSize = true;
            this.lblNum4.Location = new System.Drawing.Point(74, 90);
            this.lblNum4.Name = "lblNum4";
            this.lblNum4.Size = new System.Drawing.Size(13, 17);
            this.lblNum4.TabIndex = 6;
            this.lblNum4.Text = "-";
            // 
            // lblNum6
            // 
            this.lblNum6.AutoSize = true;
            this.lblNum6.Location = new System.Drawing.Point(126, 90);
            this.lblNum6.Name = "lblNum6";
            this.lblNum6.Size = new System.Drawing.Size(13, 17);
            this.lblNum6.TabIndex = 8;
            this.lblNum6.Text = "-";
            // 
            // lblNum5
            // 
            this.lblNum5.AutoSize = true;
            this.lblNum5.Location = new System.Drawing.Point(126, 31);
            this.lblNum5.Name = "lblNum5";
            this.lblNum5.Size = new System.Drawing.Size(13, 17);
            this.lblNum5.TabIndex = 7;
            this.lblNum5.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMult3);
            this.groupBox4.Controls.Add(this.cbMult3);
            this.groupBox4.Location = new System.Drawing.Point(12, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(272, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Multiplos de 3";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblMult5);
            this.groupBox5.Controls.Add(this.cbMult5);
            this.groupBox5.Location = new System.Drawing.Point(312, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(272, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Multiplos de 5";
            // 
            // cbMult3
            // 
            this.cbMult3.FormattingEnabled = true;
            this.cbMult3.Location = new System.Drawing.Point(9, 69);
            this.cbMult3.Name = "cbMult3";
            this.cbMult3.Size = new System.Drawing.Size(257, 24);
            this.cbMult3.TabIndex = 0;
            // 
            // cbMult5
            // 
            this.cbMult5.FormattingEnabled = true;
            this.cbMult5.Location = new System.Drawing.Point(6, 69);
            this.cbMult5.Name = "cbMult5";
            this.cbMult5.Size = new System.Drawing.Size(257, 24);
            this.cbMult5.TabIndex = 1;
            // 
            // lblMult3
            // 
            this.lblMult3.AutoSize = true;
            this.lblMult3.Location = new System.Drawing.Point(6, 35);
            this.lblMult3.Name = "lblMult3";
            this.lblMult3.Size = new System.Drawing.Size(13, 17);
            this.lblMult3.TabIndex = 1;
            this.lblMult3.Text = "-";
            // 
            // lblMult5
            // 
            this.lblMult5.AutoSize = true;
            this.lblMult5.Location = new System.Drawing.Point(6, 35);
            this.lblMult5.Name = "lblMult5";
            this.lblMult5.Size = new System.Drawing.Size(13, 17);
            this.lblMult5.TabIndex = 2;
            this.lblMult5.Text = "-";
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 316);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Multiplos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCambiar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblNum10;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum9;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblNum8;
        private System.Windows.Forms.Label lblNum3;
        private System.Windows.Forms.Label lblNum7;
        private System.Windows.Forms.Label lblNum4;
        private System.Windows.Forms.Label lblNum6;
        private System.Windows.Forms.Label lblNum5;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNumeroC;
        private System.Windows.Forms.NumericUpDown nudCambiar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblMult3;
        private System.Windows.Forms.ComboBox cbMult3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblMult5;
        private System.Windows.Forms.ComboBox cbMult5;
        private System.Windows.Forms.ErrorProvider epError;
        private System.Windows.Forms.ToolTip ttAyuda;
    }
}


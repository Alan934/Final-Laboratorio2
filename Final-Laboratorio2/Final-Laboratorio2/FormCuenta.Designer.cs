
namespace Final_Laboratorio2
{
    partial class FormCuenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.buttonPago = new System.Windows.Forms.Button();
            this.buttonRetirarDinero = new System.Windows.Forms.Button();
            this.buttonIngresarDinero = new System.Windows.Forms.Button();
            this.buttonCajaAhorro = new System.Windows.Forms.Button();
            this.labelCuentaUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelCuentaUsuario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuenta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCerrarSesion);
            this.groupBox2.Controls.Add(this.buttonPago);
            this.groupBox2.Controls.Add(this.buttonRetirarDinero);
            this.groupBox2.Controls.Add(this.buttonIngresarDinero);
            this.groupBox2.Controls.Add(this.buttonCajaAhorro);
            this.groupBox2.Location = new System.Drawing.Point(10, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 239);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(53, 198);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(115, 34);
            this.buttonCerrarSesion.TabIndex = 7;
            this.buttonCerrarSesion.Text = "Cerrar Sesion";
            this.buttonCerrarSesion.UseVisualStyleBackColor = true;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // buttonPago
            // 
            this.buttonPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPago.Location = new System.Drawing.Point(53, 158);
            this.buttonPago.Name = "buttonPago";
            this.buttonPago.Size = new System.Drawing.Size(115, 34);
            this.buttonPago.TabIndex = 6;
            this.buttonPago.Text = "Pago";
            this.buttonPago.UseVisualStyleBackColor = true;
            this.buttonPago.Click += new System.EventHandler(this.buttonPago_Click);
            // 
            // buttonRetirarDinero
            // 
            this.buttonRetirarDinero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRetirarDinero.Location = new System.Drawing.Point(53, 118);
            this.buttonRetirarDinero.Name = "buttonRetirarDinero";
            this.buttonRetirarDinero.Size = new System.Drawing.Size(115, 34);
            this.buttonRetirarDinero.TabIndex = 5;
            this.buttonRetirarDinero.Text = "Retirar Dinero";
            this.buttonRetirarDinero.UseVisualStyleBackColor = true;
            this.buttonRetirarDinero.Click += new System.EventHandler(this.buttonRetirarDinero_Click);
            // 
            // buttonIngresarDinero
            // 
            this.buttonIngresarDinero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIngresarDinero.Location = new System.Drawing.Point(53, 78);
            this.buttonIngresarDinero.Name = "buttonIngresarDinero";
            this.buttonIngresarDinero.Size = new System.Drawing.Size(115, 34);
            this.buttonIngresarDinero.TabIndex = 4;
            this.buttonIngresarDinero.Text = "Ingresar Dinero";
            this.buttonIngresarDinero.UseVisualStyleBackColor = true;
            this.buttonIngresarDinero.Click += new System.EventHandler(this.buttonIngresarDinero_Click);
            // 
            // buttonCajaAhorro
            // 
            this.buttonCajaAhorro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCajaAhorro.Location = new System.Drawing.Point(53, 38);
            this.buttonCajaAhorro.Name = "buttonCajaAhorro";
            this.buttonCajaAhorro.Size = new System.Drawing.Size(115, 34);
            this.buttonCajaAhorro.TabIndex = 3;
            this.buttonCajaAhorro.Text = "Caja de ahorro";
            this.buttonCajaAhorro.UseVisualStyleBackColor = true;
            this.buttonCajaAhorro.Click += new System.EventHandler(this.buttonCajaAhorro_Click);
            // 
            // labelCuentaUsuario
            // 
            this.labelCuentaUsuario.AutoSize = true;
            this.labelCuentaUsuario.Location = new System.Drawing.Point(78, 22);
            this.labelCuentaUsuario.Name = "labelCuentaUsuario";
            this.labelCuentaUsuario.Size = new System.Drawing.Size(0, 17);
            this.labelCuentaUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            // 
            // FormCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 328);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Banco INACION";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCuentaUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRetirarDinero;
        private System.Windows.Forms.Button buttonIngresarDinero;
        private System.Windows.Forms.Button buttonCajaAhorro;
        private System.Windows.Forms.Button buttonPago;
        private System.Windows.Forms.Button buttonCerrarSesion;
    }
}
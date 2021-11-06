
namespace Final_Laboratorio2
{
    partial class FormRegistro
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
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.txtRegistroUsuario = new System.Windows.Forms.TextBox();
            this.txtRegistroCorreo = new System.Windows.Forms.TextBox();
            this.txtRegistroNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.txtRegistroPostal = new System.Windows.Forms.TextBox();
            this.txtRegistroDireccion = new System.Windows.Forms.TextBox();
            this.txtRegistroDni = new System.Windows.Forms.TextBox();
            this.txtRegistroContraseña = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAtrasResgistro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAtrasResgistro);
            this.groupBox1.Controls.Add(this.txtConfirmarContra);
            this.groupBox1.Controls.Add(this.txtRegistroUsuario);
            this.groupBox1.Controls.Add(this.txtRegistroCorreo);
            this.groupBox1.Controls.Add(this.txtRegistroNumeroTarjeta);
            this.groupBox1.Controls.Add(this.txtRegistroPostal);
            this.groupBox1.Controls.Add(this.txtRegistroDireccion);
            this.groupBox1.Controls.Add(this.txtRegistroDni);
            this.groupBox1.Controls.Add(this.txtRegistroContraseña);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Location = new System.Drawing.Point(26, 105);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Size = new System.Drawing.Size(255, 22);
            this.txtConfirmarContra.TabIndex = 17;
            this.txtConfirmarContra.Text = "Confirmar Contraseña";
            this.txtConfirmarContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConfirmarContra.Enter += new System.EventHandler(this.txtConfirmarContra_Enter);
            // 
            // txtRegistroUsuario
            // 
            this.txtRegistroUsuario.Location = new System.Drawing.Point(26, 21);
            this.txtRegistroUsuario.Name = "txtRegistroUsuario";
            this.txtRegistroUsuario.Size = new System.Drawing.Size(255, 22);
            this.txtRegistroUsuario.TabIndex = 16;
            this.txtRegistroUsuario.Text = "Usuario";
            this.txtRegistroUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegistroUsuario.Enter += new System.EventHandler(this.txtRegistroUsuario_Enter);
            // 
            // txtRegistroCorreo
            // 
            this.txtRegistroCorreo.Location = new System.Drawing.Point(26, 49);
            this.txtRegistroCorreo.Name = "txtRegistroCorreo";
            this.txtRegistroCorreo.Size = new System.Drawing.Size(255, 22);
            this.txtRegistroCorreo.TabIndex = 15;
            this.txtRegistroCorreo.Text = "Correo Electronico";
            this.txtRegistroCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegistroCorreo.Enter += new System.EventHandler(this.txtRegistroCorreo_Enter);
            // 
            // txtRegistroNumeroTarjeta
            // 
            this.txtRegistroNumeroTarjeta.Location = new System.Drawing.Point(26, 217);
            this.txtRegistroNumeroTarjeta.Name = "txtRegistroNumeroTarjeta";
            this.txtRegistroNumeroTarjeta.Size = new System.Drawing.Size(255, 22);
            this.txtRegistroNumeroTarjeta.TabIndex = 14;
            this.txtRegistroNumeroTarjeta.Text = "Numero Tarjeta";
            this.txtRegistroNumeroTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegistroNumeroTarjeta.Enter += new System.EventHandler(this.txtRegistroNumeroTarjeta_Enter);
            // 
            // txtRegistroPostal
            // 
            this.txtRegistroPostal.Location = new System.Drawing.Point(26, 189);
            this.txtRegistroPostal.Name = "txtRegistroPostal";
            this.txtRegistroPostal.Size = new System.Drawing.Size(255, 22);
            this.txtRegistroPostal.TabIndex = 13;
            this.txtRegistroPostal.Text = "Codigo Postal";
            this.txtRegistroPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegistroPostal.Enter += new System.EventHandler(this.txtRegistroPostal_Enter);
            // 
            // txtRegistroDireccion
            // 
            this.txtRegistroDireccion.Location = new System.Drawing.Point(26, 161);
            this.txtRegistroDireccion.Name = "txtRegistroDireccion";
            this.txtRegistroDireccion.Size = new System.Drawing.Size(255, 22);
            this.txtRegistroDireccion.TabIndex = 10;
            this.txtRegistroDireccion.Text = "Direccion";
            this.txtRegistroDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegistroDireccion.Enter += new System.EventHandler(this.txtRegistroDireccion_Enter);
            // 
            // txtRegistroDni
            // 
            this.txtRegistroDni.Location = new System.Drawing.Point(26, 133);
            this.txtRegistroDni.Name = "txtRegistroDni";
            this.txtRegistroDni.Size = new System.Drawing.Size(255, 22);
            this.txtRegistroDni.TabIndex = 8;
            this.txtRegistroDni.Text = "DNI";
            this.txtRegistroDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegistroDni.Enter += new System.EventHandler(this.txtRegistroDni_Enter);
            // 
            // txtRegistroContraseña
            // 
            this.txtRegistroContraseña.Location = new System.Drawing.Point(26, 77);
            this.txtRegistroContraseña.Name = "txtRegistroContraseña";
            this.txtRegistroContraseña.Size = new System.Drawing.Size(255, 22);
            this.txtRegistroContraseña.TabIndex = 5;
            this.txtRegistroContraseña.Text = "Contraseña";
            this.txtRegistroContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegistroContraseña.Enter += new System.EventHandler(this.txtRegistroContraseña_Enter);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(26, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAtrasResgistro
            // 
            this.buttonAtrasResgistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtrasResgistro.Location = new System.Drawing.Point(200, 250);
            this.buttonAtrasResgistro.Name = "buttonAtrasResgistro";
            this.buttonAtrasResgistro.Size = new System.Drawing.Size(72, 33);
            this.buttonAtrasResgistro.TabIndex = 18;
            this.buttonAtrasResgistro.Text = "Atras";
            this.buttonAtrasResgistro.UseVisualStyleBackColor = true;
            this.buttonAtrasResgistro.Click += new System.EventHandler(this.buttonAtrasResgistro_Click);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 323);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrarse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRegistroContraseña;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRegistroPostal;
        private System.Windows.Forms.TextBox txtRegistroDireccion;
        private System.Windows.Forms.TextBox txtRegistroDni;
        private System.Windows.Forms.TextBox txtRegistroNumeroTarjeta;
        private System.Windows.Forms.TextBox txtRegistroCorreo;
        private System.Windows.Forms.TextBox txtRegistroUsuario;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.Button buttonAtrasResgistro;
    }
}
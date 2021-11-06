
namespace Final_Laboratorio2
{
    partial class FormOpciones
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
            this.txtMontoOpciones = new System.Windows.Forms.TextBox();
            this.buttonAceptarOpciones = new System.Windows.Forms.Button();
            this.labelOpciones = new System.Windows.Forms.Label();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMontoOpciones
            // 
            this.txtMontoOpciones.Location = new System.Drawing.Point(15, 40);
            this.txtMontoOpciones.Name = "txtMontoOpciones";
            this.txtMontoOpciones.Size = new System.Drawing.Size(278, 22);
            this.txtMontoOpciones.TabIndex = 0;
            // 
            // buttonAceptarOpciones
            // 
            this.buttonAceptarOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAceptarOpciones.Location = new System.Drawing.Point(176, 68);
            this.buttonAceptarOpciones.Name = "buttonAceptarOpciones";
            this.buttonAceptarOpciones.Size = new System.Drawing.Size(95, 39);
            this.buttonAceptarOpciones.TabIndex = 1;
            this.buttonAceptarOpciones.Text = "Aceptar";
            this.buttonAceptarOpciones.UseVisualStyleBackColor = true;
            this.buttonAceptarOpciones.Click += new System.EventHandler(this.buttonAceptarIngresar_Click);
            // 
            // labelOpciones
            // 
            this.labelOpciones.AutoSize = true;
            this.labelOpciones.Location = new System.Drawing.Point(12, 9);
            this.labelOpciones.Name = "labelOpciones";
            this.labelOpciones.Size = new System.Drawing.Size(11, 17);
            this.labelOpciones.TabIndex = 2;
            this.labelOpciones.Text = "i";
            // 
            // buttonAtras
            // 
            this.buttonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAtras.Location = new System.Drawing.Point(40, 68);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(95, 39);
            this.buttonAtras.TabIndex = 3;
            this.buttonAtras.Text = "Atras";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.buttonAtras_Click);
            // 
            // FormOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 206);
            this.Controls.Add(this.buttonAtras);
            this.Controls.Add(this.labelOpciones);
            this.Controls.Add(this.buttonAceptarOpciones);
            this.Controls.Add(this.txtMontoOpciones);
            this.Name = "FormOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontoOpciones;
        private System.Windows.Forms.Button buttonAceptarOpciones;
        private System.Windows.Forms.Label labelOpciones;
        private System.Windows.Forms.Button buttonAtras;
    }
}
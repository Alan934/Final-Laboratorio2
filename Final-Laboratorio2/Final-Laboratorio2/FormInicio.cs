using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Laboratorio2
{
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
            Persona persona = new Persona("Alan", "43749627", "1234", "123456", "Felix Araujo", "sanjurjoalan77@gmail.com", "5535");
            Cuenta cuenta = new Cuenta(persona, 2500);
            Banco.agregar(cuenta);
        }

        private void button2_Click(object sender, EventArgs e)// boton registro
        {
            this.Hide();
            FormRegistro form1 = new FormRegistro();
            form1.ShowDialog();
            this.Close();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtInicioUsuario.Text;
            string contraseña = txtInicioContraseña.Text;
            try
            {
                if (!String.IsNullOrEmpty(usuario) || !String.IsNullOrEmpty(contraseña) )
                {
                    if (Persona.Validar(usuario, contraseña) != null)
                    {
                        FormCuenta form = new FormCuenta(Persona.Validar(usuario, contraseña));
                        this.Hide();
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecto.");
                    }
                }
                else
                {
                    MessageBox.Show("Complete todos los campos.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en el formato ingresado. Descripción" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

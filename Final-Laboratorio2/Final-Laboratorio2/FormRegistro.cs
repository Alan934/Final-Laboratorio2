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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string usuario = txtRegistroUsuario.Text;
                string contraseña = txtRegistroContraseña.Text;
                string confirmarContraseña = txtConfirmarContra.Text;
                string direccion = txtRegistroDireccion.Text;
                string correo = txtRegistroCorreo.Text;
                string dni = txtRegistroDni.Text;
                string codigoPostal = txtRegistroPostal.Text;
                string numeroTarjeta = txtRegistroNumeroTarjeta.Text;

                if (String.IsNullOrEmpty(usuario) || String.IsNullOrEmpty(contraseña) || String.IsNullOrEmpty(confirmarContraseña) || String.IsNullOrEmpty(direccion) || String.IsNullOrEmpty(correo) || String.IsNullOrEmpty(codigoPostal) || String.IsNullOrEmpty(dni) || String.IsNullOrEmpty(numeroTarjeta))
                {
                    MessageBox.Show("Ingrese todos los campos.");
                }
                else
                {
                    if (contraseña == confirmarContraseña)
                    {
                        this.Hide();
                        Persona persona = new Persona(usuario, dni, contraseña, numeroTarjeta, direccion, correo, codigoPostal);
                        Cuenta cuenta = new Cuenta(persona, 0);
                        Banco.agregar(cuenta);
                        FormInicioSesion formInicio = new FormInicioSesion();
                        formInicio.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.");
                    }
                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en el formato ingresado. Descripción" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtRegistroUsuario_Enter(object sender, EventArgs e)
        {
            if (txtRegistroUsuario.Text == "Usuario")
            {
                txtRegistroUsuario.Text = "";
            }
        }

        private void txtRegistroCorreo_Enter(object sender, EventArgs e)
        {
            if (txtRegistroCorreo.Text == "Correo Electronico")
            {
                txtRegistroCorreo.Text = "";
            }
        }

        private void txtRegistroContraseña_Enter(object sender, EventArgs e)
        {
            if(txtRegistroContraseña.Text == "Contraseña")
            {
                txtRegistroContraseña.Text = "";
            }
        }

        private void txtRegistroDni_Enter(object sender, EventArgs e)
        {
            if (txtRegistroDni.Text == "DNI")
            {
                txtRegistroDni.Text = "";
            }
        }

        private void txtRegistroDireccion_Enter(object sender, EventArgs e)
        {
            if (txtRegistroDireccion.Text == "Direccion")
            {
                txtRegistroDireccion.Text = "";
            }
        }

        private void txtRegistroPostal_Enter(object sender, EventArgs e)
        {
            if (txtRegistroPostal.Text == "Codigo Postal")
            {
                txtRegistroPostal.Text = "";
            }
        }

        private void txtRegistroNumeroTarjeta_Enter(object sender, EventArgs e)
        {
            if (txtRegistroNumeroTarjeta.Text == "Numero Tarjeta")
            {
                txtRegistroNumeroTarjeta.Text = "";
            }
        }

        private void txtConfirmarContra_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContra.Text == "Confirmar Contraseña")
            {
                txtConfirmarContra.Text = "";
            }
        }

        private void buttonAtrasResgistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicioSesion formInicio = new FormInicioSesion();
            formInicio.ShowDialog();
            this.Close();
        }
    }
}

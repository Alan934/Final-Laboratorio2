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
    public partial class FormCuenta : Form
    {
        Cuenta cuenta;

        public FormCuenta(Cuenta cuenta)
        {
            InitializeComponent();
            this.cuenta = cuenta;
            labelCuentaUsuario.Text = cuenta.Persona.Usuario;
        }

        private void buttonCajaAhorro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("$" + cuenta.SaldoDisponible().ToString(), "Dinero Disponible");
        }

        private void buttonIngresarDinero_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOpciones formIngresar = new FormOpciones(2, cuenta);
            formIngresar.ShowDialog();
            this.Close();
        }

        private void buttonRetirarDinero_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOpciones formRetirar = new FormOpciones(1, cuenta);
            formRetirar.ShowDialog();
            this.Close();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicioSesion formInicioSesion = new FormInicioSesion();
            formInicioSesion.ShowDialog();
            this.Close();
        }

        private void buttonPago_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOpciones formRetirar = new FormOpciones(3, cuenta);
            formRetirar.ShowDialog();
            this.Close();
        }
    }
}

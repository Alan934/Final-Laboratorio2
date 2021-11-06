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
    public partial class FormOpciones : Form
    {
        Cuenta cuenta;
        int opcion;

        public FormOpciones(int opcion, Cuenta cuenta)
        {
            InitializeComponent();
            this.opcion = opcion;
            this.cuenta = cuenta;
            if (opcion == 1)
            {
                labelOpciones.Text = "Ingrese Monto a retirar:";
            }
            if (opcion == 2)
            {
                labelOpciones.Text = "Ingrese Monto que desea ingresar:";
            }
            else if (opcion == 3)
            {
                labelOpciones.Text = "Ingrese el Monto a pagar:";//podemos agregar luz agua etc
            }
        }

        private void buttonAceptarIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtMontoOpciones.Text) > 0)
                {
                    this.Hide();
                    if (opcion == 1 || opcion == 3)
                    {
                        if (cuenta.Saldo >= Convert.ToDouble(txtMontoOpciones.Text))
                        {
                            cuenta.RetirarDinero(Convert.ToDouble(txtMontoOpciones.Text));
                        }
                        else
                        {
                            MessageBox.Show("No dispone de fondos suficientes.");
                        }
                    }
                    if (opcion == 2)
                    {
                        cuenta.AgregarDinero(Convert.ToDouble(txtMontoOpciones.Text));
                    }
                    FormCuenta formCuenta = new FormCuenta(cuenta);
                    formCuenta.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede ingresar numeros negarivos.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en el formato ingresado. Descripción" + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCuenta formCuenta = new FormCuenta(cuenta);
            formCuenta.ShowDialog();
            this.Close();
        }
        
    }
}

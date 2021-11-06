using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Laboratorio2
{
    public class Cuenta
    {
        Persona persona;
        double saldo;

        public Cuenta(Persona persona, double saldo)
        {
            this.persona = persona;
            this.saldo = saldo;
        }

        public Persona Persona { get => persona; set => persona = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public string AgregarDinero(double agregar)
        {
            if (agregar > 0)
            {
                saldo += agregar;
                return "Dinero agregado exitosamente.";
            }
            else
            {
                return "No puede ingresar valores negativos.";
            }
        }

        public string RetirarDinero(double saldo)
        {
            if (saldo > 0)
            {
                if (saldo > this.saldo)
                {
                    return "Fondos Insuficientes";
                }
                else
                {
                    this.saldo -= saldo;
                    return "Retiro exitoso.";
                }
            }
            else
            {
                return "No puede ingresar valores negativos.";
            }
        }

        public double SaldoDisponible()
        {
            return saldo;
        }



    }
}

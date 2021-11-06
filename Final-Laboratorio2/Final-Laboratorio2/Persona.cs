using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Laboratorio2
{
    public class Persona
    {
         string usuario;
         string dni;
         string contraseña;
         string numeroTarjeta;
         string direccion;
         string correo;
         string codigopostal;

        public Persona(string usuario, string dni, string contraseña, string numeroTarjeta, string direccion, string correo, string codigopostal)
        {
            this.usuario = usuario;
            this.dni = dni;
            this.contraseña = contraseña;
            this.numeroTarjeta = numeroTarjeta;
            this.direccion = direccion;
            this.correo = correo;
            this.codigopostal = codigopostal;
        }

        public string Usuario { get => usuario; set => usuario = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string NumeroTarjeta { get => numeroTarjeta; set => numeroTarjeta = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Codigopostal { get => codigopostal; set => codigopostal = value; }
        
        public static Cuenta Validar(string usuario, string contraseña)
        {
            foreach (var cuenta in Banco.cuent)
            {
                if (cuenta.Persona.usuario == usuario && cuenta.Persona.contraseña == contraseña)
                {
                    return cuenta;
                }
            }
            return null;
        }




    }
}

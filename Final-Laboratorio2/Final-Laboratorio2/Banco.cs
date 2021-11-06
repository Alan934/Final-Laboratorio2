using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Laboratorio2
{
    class Banco
    {
        public static List<Cuenta> cuent = new List<Cuenta>();

        public static void agregar(Cuenta cuenta)
        {
            cuent.Add(cuenta);
        }
    }
}

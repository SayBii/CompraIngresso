using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraIngresso.Controller
{
    internal class Ingresso
    {
        public int Calcular(int valor, int quantidade)
        {
            valor = valor * quantidade;
            return valor;
        }
    }
}

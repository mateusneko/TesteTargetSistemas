using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTargetSistemas.Atividades
{
    internal class Fibonacci
    {
        public bool PertenceASequencia(int numero)
        {
            int a = 0, b = 1, c = 0;
            if (numero == 0 || numero == 1)
                return true;

            while (c < numero)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c == numero;
        }
    }
}

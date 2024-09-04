using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTargetSistemas.Atividades
{
    internal class SomaLoop
    {
        public static int CalcularSoma(int indice)
        {
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k++;
                soma += k;
            }
            return soma;
        }
    }
}

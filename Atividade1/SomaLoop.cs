using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testes
{
    public class Indice
    {
        public int CalcularSoma(int indice){
            int soma = 0;
            int k = 0;

            while(k < indice){
                k++;
                soma += k;
            }

            return soma;
        }
    }
}
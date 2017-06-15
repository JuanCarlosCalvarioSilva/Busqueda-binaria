using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_binaria
{
    class busquedaBinaria
    {
        public int contador=0;
        public int buscar(int numeroBucar, int[] vector, int tam)
        {
            int Li = 0;
            int mitad = tam / 2;
            int lS = tam;         

            return buscar(numeroBucar, vector, Li, mitad, lS);
        }

        private int buscar(int numeroBucar, int[] vector, int li, int mitad, int lS)
        {
            //contador++;
            if (li > lS)
                return -1;
            else
            {
                if (numeroBucar == vector[mitad])
                {
                    contador += 1;
                    return mitad;
                }
                else
                {
                    contador += 1;
                    if (numeroBucar < vector[mitad])
                        return buscar(numeroBucar, vector, li, (int)((li + mitad - 1) / 2), (mitad - 1));
                    else
                        return buscar(numeroBucar, vector, (mitad + 1), (int)((lS + mitad + 1) / 2), lS);
                }
            }          
        }       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_binaria
{
    class vector
    {
        public int[] _v;
        private Random numAleatorio = new Random();       

        public vector()
        {
            _v = new int[10]; ///500
        }

        public void llenar()
        {
            for (int i = 0; i < _v.Length; i++)
                _v[i] = numAleatorio.Next(0, 11); //10001
        }
    }
}

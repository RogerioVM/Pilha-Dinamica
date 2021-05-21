using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaComoLista2
{
    class Caixinha
    {
        private int elemento;
        private Caixinha proximo;

        public void setElemento(int elemento)
        {
            this.elemento = elemento;
        }

        public int getElemento()
        {
            return elemento;
        }

        public void setProximo(Caixinha proximo)
        {
            this.proximo = proximo;
        }

        public Caixinha getProximo()
        {
            return proximo;
        }
    }
}

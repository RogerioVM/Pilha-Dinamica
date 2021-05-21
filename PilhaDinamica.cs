using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaComoLista2
{
    class PilhaDinamica
    {
        Caixinha topo;

        public PilhaDinamica()
        {
            topo = null;
        }

        public void Inserir(int elemento)
        {
            Caixinha novo = new Caixinha();
            novo.setElemento(elemento);
            novo.setProximo(topo);

            topo = novo;
        }

        public int Remover()
        {
            int elem = topo.getElemento();
            topo = topo.getProximo();
            return elem;
        }

        public bool isEmpty()
        {
            return (topo == null);
        }
    }
}

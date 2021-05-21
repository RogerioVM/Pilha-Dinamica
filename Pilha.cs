using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaComoLista2
{
    class Pilha
    {
        private int[] valores;
        private int topo;

        public Pilha()
        {
            valores = new int[10];
            topo = -1;
        }

        public void Inserir(int elememto)
        {
            topo++;
            valores[topo] = elememto;
        }

        public int Remover()
        {
            int elem = valores[topo];
            topo--;
            return elem;
        }

        public bool isEmpty()
        {
            return (topo == -1);
        }

        public bool isFull()
        {
            return (topo == 9);
        }
    }
}

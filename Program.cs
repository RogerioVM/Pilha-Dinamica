using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaComoLista2
{
    class Program
    {
        static void Main(string[] args)
        {
            PilhaDinamica pilha = new PilhaDinamica();
            int numero = 172;
            int valor;

            while(numero != 0)
            {
                valor = numero % 2;
                pilha.Inserir(valor);
                numero = numero / 2;
            }

            while (!pilha.isEmpty())
            {
                int el = pilha.Remover();
                Console.WriteLine("Elemento da pliha dinamica removido: " + el);
            }


            Console.ReadLine();
        }
    }
}

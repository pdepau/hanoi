using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
      
     
        private int top;
        public int Size { get; set; }

        public int Top { get; set; }

        public List<Disco> Elementos { get; set; }

        /* TODO: Implementar métodos */
        public Pila()
        {
            Size = 0;
            Top = 0;
            Elementos = new List<Disco>();
        }
        public Pila(int s)
        {
            Size = s;
            Elementos = new List<Disco>();
            for (int i = 0; i < s; i++)
            {
                Elementos.Add(new Disco(s - i));
            }
            Top = Elementos[Elementos.Count - 1].Valor;
        }
        public void push(Disco d)
        {
            Elementos.Add(d);
            Size++;
            Top = d.Valor;
        }

        public Disco pop()
        {
            return null;
        }                

        public bool isEmpty()
        {
            return true;
        }

    }
}

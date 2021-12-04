using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA2_01
{
    class Tren
    {
        string destino;
        Vagon inicio, final;
        public Tren siguiente;

        public Tren (string destino)
        {
            this.destino = destino;
            inicio = final = null;
            siguiente = null;
        }

        public string Destino
        {
            get { return destino; }
        }

        public void Insertar(Vagon nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            { 
                final.siguiente = nuevo;
            final = nuevo;
            }
        }

        public void Mostrar()
        {
            if (inicio != null)
            {
                Vagon actual = inicio;
                while (actual != null)
                {
                    Console.WriteLine("\n Tren Destino: {0} ", destino);
                    actual.Mostrar();
                    actual.MostrarVagon();
                    actual = actual.siguiente;
                }
            }
            else 
            { 
                Console.WriteLine("\n El trean está Vacio...");
            }
        }

        public Vagon Buscar(int n)
        {
            Vagon actual = inicio;
            while (actual != null)
            {
                if (actual.Codigo == n)
                { 
                    return actual;
                    actual = actual.siguiente;
                }
            }
            return null;
        }


    }
}

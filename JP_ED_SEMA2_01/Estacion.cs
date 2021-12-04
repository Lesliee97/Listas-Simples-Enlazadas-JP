using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA2_01
{
    class Estacion
    {
        Tren inicio, final;

        public Estacion()
        {
            inicio = final = null;
        }

        public void Insertar(Tren nuevo)
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
                Tren actual = inicio;
                while (actual != null)
                {
                    actual.Mostrar();
                    actual = actual.siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n La ESTACIÓN Está Vació.... ");
            }
        }

        public Tren Buscar(String n)
        {
            Tren actual = inicio;
            while (actual != null)
            {
                if (actual.Destino == n)
                { 
                    return actual;
                    actual = actual.siguiente;
                }
            }
            return null;
        }

    }
}

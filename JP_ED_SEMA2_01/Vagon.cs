using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA2_01
{
    class Vagon
    {
        int codigo;
        Persona inicio, final;
        public Vagon siguiente;

        public Vagon(int codigo)
        {
            this.codigo = codigo;
            inicio = final = null;
            siguiente = null;
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public void Insertar(Persona nuevo)
        {
            if(inicio == null)
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
            if(inicio !=null)
            {
                Persona actual = inicio;
                while(actual !=null)
                {
                    actual.Mostrar();
                    actual = actual.siguiente;
                }
            }
            else
            {
                Console.WriteLine("\n El Vagón {0} Está Vació.... ", codigo);
            }
        }

        public void MostrarVagon()
        {
            Console.Write("N° Vagon: {0} \n", codigo);
        }

        public Persona Buscar(int n)
        {
            Persona actual = inicio;
            while (actual != null)
            {
                if (actual.Boleto == n)
                    return actual;
                 actual = actual.siguiente;
            }
            return null;
        }

        public void Eliminar(int n)
        {
            if (inicio != null)
            {
                Persona actual, padre;
                padre = BuscarPadre(n);
                if (padre == final)
                {
                    Console.WriteLine("\n Pasajero No Encontrado...");
                }
                if (padre == null)
                {
                    actual = inicio;
                    inicio = inicio.siguiente;
                    padre = inicio;
                }
                else
                {
                    actual = padre.siguiente;
                    padre.siguiente = actual.siguiente;
                }
                actual = null;
                if (padre == null || padre.siguiente == null)
                    final = padre;
                Console.WriteLine("Pasajero Bajado del Vagón...");
            }
            else
                Console.WriteLine("\n No Existe Ningún Pasajero...");
        }

        private Persona BuscarPadre(int n)
        {
            Persona padre, actual;
            actual = inicio;
            padre = null;

            while (actual != null)
            {
                if (actual.Boleto == n)
                    break;
                padre = actual;
                actual = actual.siguiente; // ->
            }
            return padre;
        }


        

    }
}

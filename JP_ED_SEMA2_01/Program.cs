using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            short op;
            int bol = 0;
            Estacion e = new Estacion();
            Tren t; Vagon v; Persona p;
            do
            {
                Console.WriteLine("\nESTACION DE TREN\n ");
                Console.WriteLine("1. Ingresar Pasajero");
                Console.WriteLine("2. Mostrar Todos Los Pasajeros");
                Console.WriteLine("3. Buscar Pasajero");
                Console.WriteLine("4. Bajar Pasajero");
                Console.WriteLine("5. Salir");
                Console.Write("Ingrese Opción: ");
                op = short.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("\nIngrese Destino Del Viaje: ");
                        string dv = Console.ReadLine();
                        t = e.Buscar(dv);
                        if (t == null)
                        {
                            Console.Write("\nTren Inexistente Con Este Destino...\nSe Creara Nuevo Destino - {0}\n", dv);
                            t = new Tren(dv);
                            e.Insertar(t);
                        }
                        Console.Write("\nIngrese Número De Vagon: ");
                        int nv = int.Parse(Console.ReadLine());
                        v = t.Buscar(nv);
                        if (v == null)
                        {
                            v = new Vagon(nv);
                            t.Insertar(v);
                        }
                        Console.Write("Ingrese Nombre: ");
                        string n = Console.ReadLine();
                        Console.Write("Ingrese Sexo: ");
                        string s = Console.ReadLine();
                        p = new Persona(bol, n, s);
                        v.Insertar(p);
                        bol++;
                        break;
                    case 2:
                        e.Mostrar();
                        break;
                    case 3:
                        Console.Write("\nIngrese Destino Del Tren: ");
                        string d = Console.ReadLine();
                        t = e.Buscar(d);
                        if (t != null)
                        {
                            Console.Write("Ingrese Codigo de Vagón: ");
                            int c = int.Parse(Console.ReadLine());
                            v = t.Buscar(c);
                            if (v != null)
                            {
                                Console.Write("Ingrese N° De Boleto: ");
                                int b = int.Parse(Console.ReadLine());
                                p = v.Buscar(b);
                                if (p != null)
                                {
                                    Console.Write("\n");
                                    p.Mostrar();
                                }
                                else
                                  { 
                                    Console.Write("\nPasajero No Existe...\n");
                                  }
                            }
                            else
                              { 
                                Console.Write("\nVagón No Existe...\n");
                              }
                        }
                        else
                          { 
                            Console.Write("\nTren No Existe...\n");
                          }
                        break;
                    case 4:
                        Console.Write("Ingrese Destino De Tren Para Bajar: ");
                        d = Console.ReadLine();
                        t = e.Buscar(d);
                        if (t != null)
                        {
                            Console.Write("Ingrese Codigo de Vagón: ");
                            int c = int.Parse(Console.ReadLine());
                            v = t.Buscar(c);
                            if (v != null)
                            {
                                Console.Write("Ingrese N° De Boleto:");
                                int b = int.Parse(Console.ReadLine());
                                p = v.Buscar(b);
                                if (p != null)
                                {
                                    Console.Write("\n");
                                    v.Eliminar(b);
                                }
                                else
                                    { 
                                    Console.Write("\nPasajero No Existe...\n");
                                    }
                            }
                            else
                              { 
                                Console.Write("\nVagón No Existe...\n");
                              }
                        }
                        else
                            { 
                            Console.Write("\nTren No Existe...\n");
                            }
                        break;
                    case 5:
                        Console.WriteLine("\nFin del Programa...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("\nOpción No Valida...");
                        break;
                }

            } while (op != 5);
        }
    }
}

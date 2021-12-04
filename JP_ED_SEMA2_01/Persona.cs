using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JP_ED_SEMA2_01
{
    class Persona
    {
        int boleto;
        string nombre, sexo;
        public Persona siguiente;

        public Persona(int boleto, string nombre, string sexo)
        {
            this.boleto = boleto;
            this.nombre = nombre;
            this.sexo = sexo;
            siguiente = null;
        }

        public int Boleto
        {
            get { return boleto; }
        }

        public string Nombre
        {
            get { return nombre; }
        }
        public string Sexo
        {
            get { return sexo; }
        }

        public void Mostrar()
        {
            Console.Write("Boleto: {0} | Nombre: {1} | Sexo: {2} \n", boleto, nombre, sexo);
        }
    }
}

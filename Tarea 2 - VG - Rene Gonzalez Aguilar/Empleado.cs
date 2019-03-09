using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2___VG___Rene_Gonzalez_Aguilar
{
    class Empleado
    {
        protected string nombre { get; set; }
        protected string puesto { get; set; }
        protected string nivel_de_ingles { get; set; }
        protected string dias_disponibles { get; set; }
        protected string horas_disponibles { get; set; }
        public Empleado(string nombre, string puesto, string nivel_de_ingles, string dias_disponibles, string horas_disponibles)
        {
            this.nombre = nombre;
            this.puesto = puesto;
            this.nivel_de_ingles = nivel_de_ingles;
            this.dias_disponibles = dias_disponibles;
            this.horas_disponibles = horas_disponibles;
        }
        public void Registro_VG_Studios(int cantidad, Empleado[] empleados)
        {
            for (int x = 0; x < empleados.Length; x++) 
            {
                Console.WriteLine("Nombre del empleado:"+ (x+1));
                empleados[x].nombre = Console.ReadLine();
                Console.WriteLine("Puesto a tomar:" + (x + 1));
                empleados[x].puesto = Console.ReadLine();
                Console.WriteLine("Nivel de ingles que actualmente posee:" + (x + 1));
                empleados[x].nivel_de_ingles = Console.ReadLine();
                Console.WriteLine("Dias disponibles (Poner la primera letra {Miercoles = Mi}):" + (x + 1));
                empleados[x].dias_disponibles = Console.ReadLine();
                Console.WriteLine("Horario de disponibilidad (En caso de tener variaciones por dia, separelos con un guion):" + (x + 1));
                empleados[x].horas_disponibles = Console.ReadLine();
            }
        }
        public void Revision()
        {
            for (int x = 0; x <= registro; x++)
            {
                Console.WriteLine(empleados[registro]);
                Console.WriteLine("-------------------");
            }
        }

    }
}

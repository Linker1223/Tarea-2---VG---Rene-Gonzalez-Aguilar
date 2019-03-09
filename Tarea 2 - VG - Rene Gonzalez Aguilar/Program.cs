using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2___VG___Rene_Gonzalez_Aguilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas personas desea registrar en el sistema?");
            int registro = Convert.ToInt32(Console.ReadLine());
            Empleado[] empleados = new Empleado[registro];

            

            Revision();
            Console.ReadLine();

        }
    }
}

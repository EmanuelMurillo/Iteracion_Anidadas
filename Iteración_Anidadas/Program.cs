using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteración_Anidadas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int i; //Variable que se encarga del bucle exterior
            int j; //Variable que se encarga del bucle interior/anidado
            int resultado; //Guardar el valor de la multiplicación

            for(i=1; i<=10; i++) //Bucle exterior/Externo
            {
                Console.WriteLine("Tabla de multiplicar del {0}: ", i); //Muestra la tabla actual

                for(j=1; j<=10; j++)
                {
                    resultado = (i * j);

                    Console.WriteLine("{0} * {1} = {2}", i, j, resultado);
                }
            }

            Console.ReadKey();
        }
    }
}

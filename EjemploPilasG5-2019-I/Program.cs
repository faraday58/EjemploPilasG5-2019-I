using System;
using System.Collections.Generic;

namespace EjemploPilasG5_2019_I
{
    class Program
    {
        static void Main()
        {
            Stack<string> pilacomida = new Stack<string>();

            pilacomida.Push("Enchiladas");
            pilacomida.Push("Guajolota");
            pilacomida.Push("Pozole");
            pilacomida.Push("Mole Poblano");
            pilacomida.Push("Tacos dorados");
            pilacomida.Push("Barbacoa");

            int countaux = pilacomida.Count;

            for(int i=0; i < countaux; i++)
            {
                Console.WriteLine("¿Qué desea ordenar joven: {0}", pilacomida.Pop());
            }

        }
    }
}

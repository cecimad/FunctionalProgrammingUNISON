using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class _Predicate
    {
        public static void Run()
          => PruebaFunc((x,y) => x > 100 && y== "Hola", 110,"Holfa");

        public static void Prueba(Predicate<int> predicado, int numero) 
        => System.Console.WriteLine(predicado(numero));

        public static void PruebaFunc(Func<int,string,bool> predicado, int numero,string palabra)
         => System.Console.WriteLine(predicado(numero,palabra));


    }
}
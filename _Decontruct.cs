using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalProgramming
{


    public class Test
    {
        public static void Run()
        {
         

            var (x, y) = new Coordenadas();

            var (a,b,z) = new Coordenadas();

            System.Console.WriteLine( $"{a} {b} {z} {x} {y} ");
        }

    }
    public class Coordenadas
    {
        public int X = 1, Y = 2;

        public void Deconstruct(out int x, out int y)
        {
            x = X; y = Y;
        }

        public void Deconstruct(out int x, out int y, out int  z)
        {
            x = X; y = Y; z =1;
        }

    }
}
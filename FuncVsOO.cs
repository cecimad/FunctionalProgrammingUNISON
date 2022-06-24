using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class FuncVsOO
    {
        public static void Test()
        {
            var nombres = new List<string>() { "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Pedro", "Luis", "Juan", "Carlos", "Jesus", "Yael" };
            var cronometro = Stopwatch.StartNew();
            cronometro.Start();
            System.Console.WriteLine(EncontrarNombre(nombres, "Yael"));
            cronometro.Stop();
            System.Console.WriteLine("OO");
            System.Console.WriteLine(cronometro.Elapsed);

            cronometro.Restart();
            System.Console.WriteLine(EncontrarNombreFunc(nombres, "Yael"));
            cronometro.Stop();
            System.Console.WriteLine("Funcional");
            System.Console.WriteLine(cronometro.Elapsed);

             cronometro.Restart();
            System.Console.WriteLine(EncontrarNombreDelegate(nombres,x => x.Any( y => y == "Yaelaaa" || y == "Yael" )));
            cronometro.Stop();
            System.Console.WriteLine("Funcional2");
            System.Console.WriteLine(cronometro.Elapsed);

        }

        static bool EncontrarNombreDelegate(List<string> nombres, Func<List<string>, bool> evaluacion)
        => evaluacion(nombres);
        static Func<List<string>, string, bool> EncontrarNombreFunc = (x, y) => x.Any(s => s == y);

        public static bool EncontrarNombre(List<string> nombres, string nombreBuscar)
        {

            foreach (var nombre in nombres)
            {

                if (nombre == nombreBuscar)
                {

                    return true;
                }
            }
            return false;
        }

    }
}
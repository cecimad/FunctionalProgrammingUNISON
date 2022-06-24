using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class _Func
    {
        ///aassseeerttggfdsdfg

        public static void Test()
        {

            var cronometro = Stopwatch.StartNew();
            cronometro.Start();
            System.Console.WriteLine(PrimerNoRepetidoClassic("asdfghgfdsa"));

            cronometro.Stop();
            System.Console.WriteLine("OO");
            System.Console.WriteLine(cronometro.Elapsed);

            cronometro.Restart();
        
            System.Console.WriteLine(GetNoRepetidoFunc("asdfghgfdsa"));

            cronometro.Stop();
            System.Console.WriteLine("Func");
            System.Console.WriteLine(cronometro.Elapsed);

        }


        public static Func<string, char> GetNoRepetidoFunc = (s) => s.ToCharArray().GroupBy(x => x)
                                                                             .Where(x => x.Count() == 1)
                                                                             .Select(x => x.Key).FirstOrDefault();

                                                                             
        public static char PrimerNoRepetidoClassic(string palabra)
        {
            int i, j;
            bool isRepeated = false;
            char[] chars = palabra.ToCharArray();

            for (i = 0; i < chars.Length; i++)
            {
                isRepeated = false;
                for (j = 0; j < chars.Length; j++)
                {

                    if ((i != j) && (chars[i] == chars[j]))
                    {
                        isRepeated = true;
                        break;

                    }

                }
                if (isRepeated == false)
                {
                    return chars[i];
                }


            }
            return '_';

        }


    }
}
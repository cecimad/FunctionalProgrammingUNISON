using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class _Actions
    {
        public static void Run()
        {
            var funTuple = new Func<double, double, (double suma, double multiplicacion)>((x, y) => (x + y, x * y));

            /*  (double suma, double multiplicacion) = SumarYMultiplicar(3, 6);
              System.Console.WriteLine($"Suma = {suma} Multiplicacion = {multiplicacion}");*/

              var personas = Persona();

              personas.Agregar("Alfonso");
              personas.Agregar("Ana");
              personas.Agregar("Aracely");
              personas.Agregar("Tulio");
              personas.Agregar("Dalia");
              personas.Agregar("Jesus");
              personas.Agregar("Yael");

              personas.Consultar();
              personas.Eliminar("Yael");

              personas.Consultar();

              System.Console.WriteLine(personas.Cuenta());

        }

        Tuple<double, double> SumarYMultiplicar(double a, double b)
        {
            return Tuple.Create(sumar(a, b), a * b);
        }

        double sumar(double a, double b) => a + b;


        static (Action<string> Agregar, Action<string> Eliminar, Action Consultar, Func<int> Cuenta) Persona()
        {

            List<string> datos = new List<string>();
            Action Consultar = () => datos.ForEach(x => System.Console.WriteLine(x));
            Action<string> Agregar = s => datos.Add(s);
            Action<string> Eliminar = x => datos.Remove(x);
            Func<int> Cuenta = () => datos.Count();

            return (Agregar, Eliminar, Consultar, Cuenta);

         }

        static (double suma, double multiplicacion) SumarYMultiplicarNew(double a, double b)
                => (a + b, a * b);





    }
}
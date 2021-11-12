using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static string pregunta()
        {
            Console.WriteLine("Que desea? dolares o euros?");
            string opcion = Console.ReadLine();
            return opcion;
        }
        public static double euroDolar(int dinero)
        {
            double total = 0;
            total = dinero * 1.15;
            return total;
        }
        public static double dolarEuro(int dinero)
        {
            double total = 0;
            total = dinero * 0.87;
            return total;
        }
        static void Main(string[] args)
        {
            string opcion = pregunta();
            Console.WriteLine("Cuanto dinero quiere cambiar?");
            int dinero = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case "dolar":
                    double dolares = euroDolar(dinero);
                    Console.WriteLine(dolares);
                    break;
                case "euro":
                    double euros = dolarEuro(dinero);
                    Console.WriteLine(euros);
                    break;
            }
            Console.ReadLine();
        }
    }
}

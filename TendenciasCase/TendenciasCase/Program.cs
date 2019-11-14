using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TendenciasCase
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            while (x)
            {
                Console.Clear();
                Console.WriteLine("Escriba un Texto o -1 para Salir: ");
                string mensaje = Console.ReadLine();
                Console.WriteLine();
                if (mensaje.Equals("-1"))
                {
                    Console.WriteLine("Pase Buenas Noches :DDDD!!!!");
                    Console.ReadKey();
                    x = false;
                    return;
                }
                else
                {
                    Console.WriteLine("Su Texto en Mayuscula es: ");
                    Console.WriteLine(StringToUpper(mensaje));

                    Console.WriteLine(".");
                    Console.ReadKey();
                }

            }

            //string mensajeUpper = mensaje.ToUpper();

            //Console.WriteLine(mensajeUpper);

            //Console.ReadKey();
        }

        public static string StringToUpper (string mensaje)
        {
            return mensaje.ToUpper();
        }
    }
}

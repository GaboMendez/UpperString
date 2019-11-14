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
            Console.WriteLine("Escriba un texto: ");
            string mensaje = Console.ReadLine();

            string mensajeUpper = mensaje.ToUpper();

            Console.WriteLine(mensajeUpper);

            Console.ReadKey();
        }
    }
}

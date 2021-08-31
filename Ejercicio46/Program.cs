using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio46
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            var suma = 0;
            do
            {
				Console.WriteLine("Ingrese un nùmero:");
				var numeroIngresado = Convert.ToInt32(Console.ReadLine());
				suma += numeroIngresado;
				cantidad++;
            } while (suma<=60);

			Console.WriteLine($"Se ingresaron {cantidad} de nùmeros");
			Console.WriteLine($"La suma de los mismos es {suma}");
			Console.ReadLine();
		}
    }
}

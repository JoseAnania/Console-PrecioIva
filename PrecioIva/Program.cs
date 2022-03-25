using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecioIva
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio;
            double iva;
            Console.WriteLine("Ingrese el precio neto: ");
            precio = Convert.ToDouble(Console.ReadLine());
            iva = (precio * 1.21);
            Console.WriteLine("Precio con IVA: $" + iva);
            Console.Read();
        }
    }
}

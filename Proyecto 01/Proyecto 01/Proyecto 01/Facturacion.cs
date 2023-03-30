using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    internal class Facturacion
    {
        public void facturar()
        {
            Console.Clear();
            int hola = 0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("AAD");
                    hola = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
            while (hola != 1);
        }
    }
}

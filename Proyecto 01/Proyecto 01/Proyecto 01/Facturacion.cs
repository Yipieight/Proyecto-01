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

            double[,] precios = new double[5, 2]
            {
                {001,1.10},
                {002,5.10},
                {003,7.30},
                {004,32.50},
                {005,17.95}
            };
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("001 Pan frances Q");
                    Console.WriteLine("002 Libra de azucar Q");
                    Console.WriteLine("003 Caja de galletas Q");
                    Console.WriteLine("001 Pan frances Q");
                    h = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
            while ();
        }
    }
}

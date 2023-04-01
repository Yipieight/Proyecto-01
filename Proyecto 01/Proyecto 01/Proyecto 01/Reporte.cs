using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    internal class Reporte
    {
        
        public void reporte()
        {
            Console.Clear();
            if (Facturacion.contar == 0)
            {
                Console.WriteLine("No tienes facturas...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Total de facturas son: " + Facturacion.contar +"\n");
                Console.WriteLine("Total de productos vendidos: " + Facturacion.totalproducto +"\n");
                Console.WriteLine("--------------------Total de produtos--------------------\n");
                Console.WriteLine(Facturacion.productofac[0]);
                Console.WriteLine(Facturacion.productofac[1]);
                Console.WriteLine(Facturacion.productofac[2]);
                Console.WriteLine(Facturacion.productofac[3]);
                Console.WriteLine(Facturacion.productofac[4]);
                Console.WriteLine("---------------------------------------------------------\n");
                Console.ReadKey();
            }
        }
    }
}

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
            if (Facturacion.contar == 0)
            {
                Console.WriteLine("No tienes facturas...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Total de facturas son: " + Facturacion.contar);
                Console.ReadKey();
            }
        }
    }
}

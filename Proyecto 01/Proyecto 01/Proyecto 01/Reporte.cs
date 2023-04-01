using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    internal class Reporte
    {
        public int totaldefacturas()
        {
            int contar;
            Facturacion factor = new Facturacion();
            contar = factor.contar;
            return contar; 
        }
        public void reporte()
        {
            Reporte reporte = new Reporte();
            if (totaldefacturas() == 0)
            {
                Console.WriteLine("No tienes facturas...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Total de facturas son: " + totaldefacturas());
                Console.ReadKey();
            }
        }
    }
}

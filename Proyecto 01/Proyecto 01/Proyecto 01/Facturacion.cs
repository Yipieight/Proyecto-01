using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_01
{
    internal class Facturacion
    {
        public string nit = "";
        public string nombrecliente = "";
        public string email = "";
        public string sino;

        public string preguntarsino()
        {
            bool repetir = false;
            while (repetir != true)
            {
                Console.WriteLine("¿Desea ingresar más cantidades a este producto? si/no");
                sino = Console.ReadLine();
                if (sino != "si" && sino != "no")
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar si o no....");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    repetir = true;
                }
            }
            return sino;
        }
        public void facturar()
        {
            Facturacion metodos = new Facturacion();
            Console.Clear();
            string opcion = "";
            bool repetir = false;
            double[] precios = new double[5] { 1.10, 5.00, 7.00, 32.50, 17.95 };
            string[] codigos = new string[5] { "001", "002", "003", "004", "005"};
            string[] productos = new string[5] { "Pan frances", "Libra azucar", "Caja de galletas", "Caja de granola", "Litro de juego de naranja" };
            while(repetir != true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese su nombre");
                    nombrecliente = Console.ReadLine();
                    if (nombrecliente.Any(char.IsDigit) || nombrecliente == "")
                    {
                        throw new Exception("Debe ingresar un texto, vuelva a colocar todo los datos...");
                    }
                    Console.WriteLine("Ingrese un e-mail");
                    email = Console.ReadLine();
                    if (email.Any(char.IsDigit) || email == "")
                    {
                        throw new Exception("Debe ingresar un texto, vuelva a colocar todo los datos...");
                    }
                    Console.WriteLine("Ingrese un nit");
                    nit = Console.ReadLine();
                    if (nit.Any(char.IsLetter) || nit == "")
                    {
                        throw new Exception("Debe ingresar numeros, vuelva a colocar todo los datos...");
                    }
                    repetir = true;
                }
                catch(Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }            
            }
            do
            {
                Console.Clear();
                Console.WriteLine("¿Que producto desea agregar? \n");
                Console.WriteLine($"{codigos[0]}.\t {productos[0]} Q{precios[0]}");
                Console.WriteLine($"{codigos[1]}.\t {productos[1]} Q{precios[1]}");
                Console.WriteLine($"{codigos[2]}.\t {productos[2]} Q{precios[2]}");
                Console.WriteLine($"{codigos[3]}.\t {productos[3]} Q{precios[3]}");
                Console.WriteLine($"{codigos[4]}.\t {productos[4]} Q{precios[4]} \n");
                opcion = Console.ReadLine();
                if (opcion.Length != 3 || int.Parse(opcion) > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar el codigo completo incluyendo los 0...");
                    Console.ReadKey();
                }
                switch (opcion)
                {
                    case "001":
                        break;
                    case "002":
                        break;
                    case "003":
                        break;
                    case "004":
                        break;
                    case "005":
                        break;
                }
            }

            while (metodos.preguntarsino() == "si");
        }
    }
}

using System;
using System.Linq;

namespace Proyecto_01
{
    internal class Facturacion
    {
        public int contarprod = 0;
        public string nit = "";
        public string nombrecliente = "";
        public string email = "";
        public string sino;
        public double suma = 0;
        public string[] productofac = new string[5];

        public void imprimirfactura(string nit, string nombrecliente, double suma, string[] productofac,string email)
        {
            Console.WriteLine("--------PublicMart--------");
            Console.WriteLine("Fecha de la factura: " + (DateTime.Now.ToString("dd/MM/yyyy")));
            Console.WriteLine("Número de factura: " + nit);
            Console.WriteLine("Nombre del cliente: " + nombrecliente + "\n");
            Console.WriteLine(productofac[0]);
            Console.WriteLine(productofac[1]);
            Console.WriteLine(productofac[2]);
            Console.WriteLine(productofac[3]);
            Console.WriteLine(productofac[4]);
            Console.WriteLine("Una copia de la factura se enviará al correo: " + email);
            Console.ReadKey();
        }
        public string preguntarsino()
        {

            bool repetir = false;
            while (repetir != true)
            {
                Console.WriteLine("¿Desea ingresar más producto? si/no");
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
            bool repetir = false;
            int cantidad;
            double[] precios = new double[5] { 1.10, 5.00, 7.30, 32.50, 17.95 };
            string[] codigos = new string[5] { "001", "002", "003", "004", "005" };
            string[] productos = new string[5] { "Pan frances", "Libra azucar", "Caja de galletas", "Caja de granola", "Litro de juego de naranja" };
            while (repetir != true)
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
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
            int[] sumacantidad = new int[5];
            int contar = 0;
            do
            {
                string opcion = "";
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
                        Console.WriteLine("Cuanta cantidad necesita para: " + productos[0]);
                        cantidad = int.Parse(Console.ReadLine());
                        suma = cantidad * precios[0] + suma;
                        suma = Math.Round(suma, 2);
                        sumacantidad[0] += cantidad;
                        productofac[contar] = "" + productos[0] + " cantidad: " + sumacantidad[0] + " precio: Q" + precios[0];
                        break;
                    case "002":
                        Console.WriteLine("Cuanta cantidad necesita para: " + productos[1]);
                        cantidad = int.Parse(Console.ReadLine());
                        suma = cantidad * precios[1] + suma;
                        suma = Math.Round(suma, 2);
                        sumacantidad[1] += cantidad;
                        productofac[contar] = "" + productos[1] + " cantidad: " + sumacantidad[1] + " precio: Q" + precios[1];
                        break;
                    case "003":
                        Console.WriteLine("Cuanta cantidad necesita para: " + productos[2]);
                        cantidad = int.Parse(Console.ReadLine());
                        suma = cantidad * precios[2] + suma;
                        suma = Math.Round(suma, 2);
                        sumacantidad[2] += cantidad;
                        productofac[contar] = "" + productos[2] + " cantidad: " + sumacantidad[2] + " precio: Q" + precios[2];

                        break;
                    case "004":
                        Console.WriteLine("Cuanta cantidad necesita para: " + productos[3]);
                        cantidad = int.Parse(Console.ReadLine());
                        suma = cantidad * precios[3] + suma;
                        suma = Math.Round(suma, 2);
                        sumacantidad[3] += cantidad;
                        productofac[contar] = "" + productos[3] + " cantidad: " + sumacantidad[3] + " precio: Q" + precios[3];

                        break;
                    case "005":
                        Console.WriteLine("Cuanta cantidad necesita para: " + productos[4]);
                        cantidad = int.Parse(Console.ReadLine());
                        suma = cantidad * precios[4] + suma;
                        suma = Math.Round(suma, 2);
                        sumacantidad[4] += cantidad;
                        productofac[contar] = "" + productos[4] + " cantidad: " + sumacantidad[4] + " precio: Q" + precios[4];
                        break;
                }
                contar++;
            }
            while (metodos.preguntarsino() == "si");

            try
            {
                int opcion = 0;
                Console.WriteLine("Seleccione su método de pago:");
                Console.WriteLine("1. Efectivo");
                Console.WriteLine("2. Tarjeta de crédito");
                Console.Write("Ingrese el número de su opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        int puntos = 0;

                        if (this.suma > 10.00 && this.suma <= 50.00)
                        {
                            puntos = (int)suma / 10;
                            Console.WriteLine("Estos son los puntos obtenidos por usar Tarjeta de credito como metodo de pago: " + puntos);
                            Console.ReadKey();

                        }
                        else if (this.suma > 50 && suma <= 150)
                        {
                            puntos = ((int)suma / 10) * 2;
                            Console.WriteLine("Estos son los puntos obtenidos por usar Tarjeta de credito como metodo de pago: " + puntos);
                            Console.ReadKey();

                        }
                        else if (suma > 150)
                        {
                            puntos = ((int)suma / 15) * 3;
                            Console.WriteLine("Estos son los puntos obtenidos por usar Tarjeta de credito como metodo de pago: " + puntos);
                            Console.ReadKey();
                        }
                        break;

                }
                metodos.imprimirfactura(nit, nombrecliente, suma, productofac, email);
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}

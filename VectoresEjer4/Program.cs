using System;

namespace VectoresEjer4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10

            
            int cantidadVendida;
            int nroArticulo;

            int[] totalCantidadVendida = new int[15];

            for (int x = 0; x < 15; x++)
            {
                totalCantidadVendida[x] = 0;
            }

            Console.WriteLine("Ingrese el nro de Articulo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nro de venta");
            cantidadVendida = int.Parse(Console.ReadLine());

            while (nroArticulo !=0)
            {
                Console.WriteLine("Ingrese el nro de Articulo: ");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nro de venta");
                cantidadVendida = int.Parse(Console.ReadLine());
            }
            int maxCantidad = totalCantidadVendida[0];
            int nroMaximo = 1;
            for (int x = 0; x < 15; x++)
            {
                if (totalCantidadVendida[x] > maxCantidad)
                {
                    maxCantidad = totalCantidadVendida;
                    nroArticulo = x + 1;
                }
            }
            Console.WriteLine("El producto mas vendido es: " + nroArticulo + " con la cantidad de: " + maxCantidad);

            for (int x = 0; x < 15; x++)   
            {
                if(totalCantidadVendida[x] == 0)
                Console.WriteLine("El producto que no registro venta es: " + (x + 1));
            }

            Console.WriteLine("La cantidad de venta del articulo 10 son : " + totalCantidadVendida[9]);
        }
    }
}

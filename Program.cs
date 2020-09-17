using System;


namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            string valuem = "";
            float PrecioU = 1000;
            float PrecioSDesc;
            float precioDescuento = 0;
            int carrito = 0;
            String YN = "";
            do
            {
                Console.WriteLine("MENÚ PRINCIPAL");
                Console.WriteLine(" ");
                Console.WriteLine("1- Añadir camisa al carrito");
                Console.WriteLine("2- Eliminar camisa del carrito");
                Console.WriteLine("3- Salir");
                valuem = Console.ReadLine();
                menu = Convert.ToInt32(valuem);

                if(menu == 1)
                {
                    carrito = carrito + 1;
                }

                if(menu == 2)
                {
                    carrito = carrito -1;
                }
                if(menu == 3)
                {
                    Console.WriteLine("¿Está seguro que desea salir ? S / N”. Si presiona “S” debe cerrar el programa.Si presiona “N” debe ingresar nuevamente a la pantalla principal.");
                    YN = Console.ReadLine();
                    if(YN == "y")
                    {
                        break;
                    }

                }


                PrecioSDesc = PrecioU * carrito;
                if (carrito >= 3 && carrito <= 5)
                {
                    precioDescuento = PrecioSDesc - PrecioSDesc * 0.1f;

                }
                if(carrito >= 5)
                {
                    precioDescuento = PrecioSDesc - PrecioSDesc * 0.2f;
                }


                Console.WriteLine("----------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Cantidad de camisas en el carrito: {0}", carrito);
                Console.WriteLine("Precio Unitario: {0}", PrecioU);
                Console.WriteLine("Precio final sin descuento: {0}", PrecioSDesc);
                Console.WriteLine("Precio final con descuento: {0}", precioDescuento);


            } while (menu != 3);


        }
    }
}

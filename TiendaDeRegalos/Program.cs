using TiendaDeRegalos.Clases;

namespace TiendaDeRegalos
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Tienda tienda = new Tienda();
                bool salir = false;

                while (!salir)
                {
                    Console.WriteLine("\n--- Menú Principal ---");
                    Console.WriteLine("1. Agregar Producto");
                    Console.WriteLine("2. Eliminar Producto");
                    Console.WriteLine("3. Actualizar Producto");
                    Console.WriteLine("4. Ver Inventario");
                    Console.WriteLine("5. Realizar Compra");
                    Console.WriteLine("6. Ver Historial");
                    Console.WriteLine("7. Salir");
                    Console.Write("Selecciona una opción: ");
                    int opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            AgregarProducto(tienda);
                            break;
                        case 2:
                            EliminarProducto(tienda);
                            break;
                        case 3:
                            ActualizarProducto(tienda);
                            break;
                        case 4:
                            tienda.MostrarInventario();
                            break;
                        case 5:
                            RealizarCompra(tienda);
                            break;
                        case 6:
                            tienda.VerHistorial();
                            break;
                        case 7:
                            salir = true;
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }

            static void AgregarProducto(Tienda tienda)
            {
                Console.Write("Nombre del Producto: ");
                string nombre = Console.ReadLine();
                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());
                Console.Write("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                tienda.AgregarProducto(nombre, precio, cantidad);
            }

            static void EliminarProducto(Tienda tienda)
            {
                Console.Write("Nombre del Producto a eliminar: ");
                string nombre = Console.ReadLine();
                tienda.EliminarProducto(nombre);
            }

            static void ActualizarProducto(Tienda tienda)
            {
                Console.Write("Nombre del Producto a actualizar: ");
                string nombre = Console.ReadLine();
                Console.Write("Nueva Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                tienda.ActualizarProducto(nombre, cantidad);
            }

            static void RealizarCompra(Tienda tienda)
            {
                Console.Write("Nombre del Producto a comprar: ");
                string nombre = Console.ReadLine();
                Console.Write("Cantidad: ");
                int cantidad = int.Parse(Console.ReadLine());

                tienda.RealizarCompra(nombre, cantidad);
            }
        }
    }

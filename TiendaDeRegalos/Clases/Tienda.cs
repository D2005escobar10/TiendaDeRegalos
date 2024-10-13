using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeRegalos.Clases
{
    internal class Tienda
    {
        private List<Producto> inventario = new List<Producto>();
        private List<string> historial = new List<string>();

        public void AgregarProducto(string nombre, decimal precio, int cantidad)
        {
            inventario.Add(new Producto(nombre, precio, cantidad));
            Console.WriteLine("El Producto se agrego de forma correcta");
        }

        public void EliminarProducto(string nombre)
        {
            Producto Producto = inventario.Find(p => p.Nombre == nombre);
            if (Producto != null)
            {
                inventario.Remove(Producto);
                Console.WriteLine("Producto Eliminado Con Exito");
            }
            else
            {
                Console.WriteLine("El producto no fue encontrado");
            }
        }

        public void ActualizarProducto(string nombre, int nuevaCantidad)
        {
            Producto producto = inventario.Find(p => p.Nombre == nombre);
            if (producto != null)
            {
                producto.Cantidad = nuevaCantidad;
                Console.WriteLine("El Producto se actualizo con exito");
            }
            else
            {
                Console.WriteLine("El Producto no fue encontrado");
            }
        }

        public void MostrarInventario()
        {
            Console.WriteLine("\nInventario");
            foreach (var producto in inventario)
            {
                Console.WriteLine($"{producto.Nombre} - precio: {producto.Precio} - Cantidad: {producto.Cantidad}");
            }
        }

        public void RealizarCompra(string nombre, int cantidad)
        {
            Producto producto = inventario.Find(p => p.Nombre == nombre);
            if (producto != null && producto.Cantidad >= cantidad)
            {
                producto.Cantidad -= cantidad;
                decimal total = producto.Precio * cantidad;
                historial.Add($"Compra: {cantidad} X {nombre} - Total {total:C}");
                Console.WriteLine($"Compra realizada por {total:Q.}");
            }
            else
            {
                Console.WriteLine("No existe suficiente stock o el producto no esta en existencia");
            }
        }

        public void VerHistorial()
        {
            Console.WriteLine("\nHistorial De Las Transacciones:");
            if (historial.Count == 0)
            {
                Console.WriteLine("Aún no se han realizado transacciones.");
            }
            else
            {
                foreach (var transaccion in historial)
                {
                    Console.WriteLine(transaccion);
                }
            }
        }
    }
}


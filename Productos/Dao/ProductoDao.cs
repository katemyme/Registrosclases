using Productos.Modelos;
using System;


namespace Productos.Dao
{
    public class ProductoDao
    {
        private static int TAM = 5;
        private Producto[] carrito = new Producto[TAM];
        private int pos = 0;
        public void Agregar(Producto prod)
        {
            if (pos < TAM)
            {
                carrito[pos++] = prod;

            }
            else Console.WriteLine("NO SE PUEDE AGREGAR MAS PRODUCTO");
        }

        public Producto[] Vercarrito()

        {
            return carrito;
        }





        
        
    }
}

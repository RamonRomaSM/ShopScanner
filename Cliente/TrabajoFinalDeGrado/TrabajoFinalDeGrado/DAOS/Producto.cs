using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalDeGrado.DAOS
{
    public class Producto
    {
        public string idproductos { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string supermercado { get; set; }
        public string oferta { get; set; }
        public string url { get; set; }
        public string imagen { get; set; }

        public int cantidad { get; set; }//Para que el carrito se re ordene

        public Producto() { 
        
            cantidad = 0;
        }
        public void copiar(Producto producto)
        {
            this.nombre = producto.nombre;
            this.idproductos = producto.idproductos;
            this.precio = producto.precio;
            this.supermercado = producto.supermercado;
            this.oferta = producto.oferta;
            this.url = producto.url;
            this.imagen = producto.imagen;
            this.cantidad = producto.cantidad;
        }
        

      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        
            cantidad = 1;
        }
        public Producto(string json)
        {
            var arr = json.Split(":");
            cantidad = 1;
           
            this.nombre = arr[3].Split('"')[1];
            this.precio = Double.Parse(arr[4].Split('"')[1].Replace(".",","));
            this.imagen = json.Split('"')[29];
            this.url = json.Split('"')[25];
            this.supermercado = arr[5].Split('"')[1];
            this.idproductos = arr[2].Split('"')[1];
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
        // override object.Equals
        public override bool Equals(object obj)
        { 

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            try 
            { 
                Producto producto = (Producto) obj;
                if(producto.idproductos == this.idproductos) { return true; }
                else { return false; }
            } 
            catch 
            {
                return false;
            }
        }

        public string getJson() {
            string resp= " { idProducto : " + idproductos+ " , nombre : " + nombre+ ", supermercado : " + supermercado+ ", precio : " + precio+ ", imagen : " + imagen+ ", url : " + url+ " , cantidad : "+cantidad+ "  }";
            //string resp = idproductos+" ç "+nombre+" ç "+supermercado+" ç "+precio+" ç "+imagen+" ç "+url;
            return resp;
        }
      
    }
}

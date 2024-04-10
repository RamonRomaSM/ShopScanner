using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalDeGrado.DAOS
{
    class Producto
    {
        public string idproductos { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public string supermercado { get; set; }
        public string oferta { get; set; }
        public string url { get; set; }
        public string imagen { get; set; }

        public Producto() { 
        
        
        }
    }
}

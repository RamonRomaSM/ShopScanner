using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalDeGrado.DAOS
{
    public class Lista
    {
        public ObservableCollection<Producto> productos { get; set; }
        public string nombre { get; set; }
        public string autor { get; set; }
        public double precio { get; set; }


        public Lista(string nombre,string autor, ObservableCollection<Producto> productos) 
        { 
            this.nombre = nombre;
            this.autor = autor;
            this.productos = productos;
            this.precio = calculaPrecio();
        }
        public string getNombre() { return nombre; }
        public string getAutor() { return autor; }

        private double calculaPrecio()
        {
            double resp = 0;
            foreach (Producto p in productos)
            {
                resp += p.precio;
            }
            return resp;
        }
       
    }
}

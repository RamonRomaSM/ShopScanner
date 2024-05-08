using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TrabajoFinalDeGrado.DAOS
{
    public class Lista
    {
        public ObservableCollection<Producto> productos { get; set; }
        public string nombre { get; set; }
        public string autor { get; set; }
        public double precio { get; set; }
        public int numeroProductos { get; set; }

        public Lista(string nombre,string autor, ObservableCollection<Producto> productos) 
        { 
            this.nombre = nombre;
            this.autor = autor;
            this.productos = new ObservableCollection<Producto>();

            foreach (Producto producto in productos)
            {
                this.productos.Add(producto);
            }

            calculaPrecio();
        }
        public string getNombre() { return nombre; }
        public string getAutor() { return autor; }

        public void calculaPrecio()
        {
            numeroProductos = 0;
            precio = 0;
            foreach (Producto p in productos)
            {
                precio += p.precio*p.cantidad;
                numeroProductos += p.cantidad;
            }
        }
       
       
    }
}

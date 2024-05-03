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
        private string autor;

        public Lista(string nombre,string autor, ObservableCollection<Producto> productos) 
        { 
            this.nombre = nombre;
            this.autor = autor;
            this.productos = productos;
        }
        public string getNombre() { return nombre; }
        public string getAutor() { return autor; }
        //public ArrayList getProductos() {  return productos; }
    }
}

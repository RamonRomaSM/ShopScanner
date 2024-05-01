using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalDeGrado.DAOS
{
    public class Lista
    {
        private ArrayList productos;
        public string nombre { get; set; }
        private string autor;

        public Lista(string nombre,string autor, ArrayList productos) 
        { 
            this.nombre = nombre;
            this.autor = autor;
            this.productos = productos;
        }
        public string getNombre() { return nombre; }
        public string getAutor() { return autor; }
        public ArrayList getProductos() {  return productos; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalDeGrado.DAOS
{
    public class Usuario
    {
        //esta clase refleja la sesion actual, cada cambio que se haga en las listas/carrito etc
        //debe hacerse desde el fragment correspondiente 
        private string nombre {  get; }
        private ArrayList listas { get; set; }
        private ArrayList carrito{ get; set; } //al guardar el carrito en el usuario, podemos hacerlo persistente

        public Usuario(string nombre, ArrayList listas, ArrayList carrito) { 
            this.nombre = nombre;
            this.listas = listas;
            this.carrito = carrito;
        }
        
        public ArrayList getListas() { return listas; }
        public string getNombre() {  return nombre; }
        public ArrayList getCarrito() { return carrito; }



    
    }
}

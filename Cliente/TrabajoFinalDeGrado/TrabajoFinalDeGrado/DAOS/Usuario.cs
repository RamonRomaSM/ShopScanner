using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Lista> listas { get; set; }
        private ArrayList carrito{ get; set; } //al guardar el carrito en el usuario, podemos hacerlo persistente,
                                               //si voy a hacerlo persistente, poner boton de vaciar carrito 
                                               //meterlo en un observable collection y que en la pestaña de carrito se vea en tajetas como en productos
                                               
        public Usuario(string nombre, ObservableCollection<Lista> listas, ArrayList carrito) { 
            this.nombre = nombre;
            this.listas = listas;
            this.carrito = carrito;
        }
        
        public ObservableCollection<Lista> getListas() { return listas; }
        public string getNombre() {  return nombre; }
        public ArrayList getCarrito() { return carrito; }



    
    }
}

using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Windows;

namespace TrabajoFinalDeGrado.DAOS
{
    public class Usuario
    {
         
        public string nombre {  get; }
        private ObservableCollection<Lista> listas { get; set; }
        private ObservableCollection<Producto> carrito{ get; set; } //al guardar el carrito en el usuario, podemos hacerlo persistente,
                                                                    //si voy a hacerlo persistente, poner boton de vaciar carrito 
        public string idUsuario="";

        public Usuario(string nombre, ObservableCollection<Lista> listas)
        {
            this.nombre = nombre;
            this.listas = listas;
            this.carrito = new ObservableCollection<Producto>();
        }
        public Usuario(string datos, bool tieneListas)
        {
            if(tieneListas) {
                var arr = datos.Split('"');
                for (int i = 1; i < arr[2].Length - 1; i++)
                {
                    this.idUsuario += arr[2][i];
                }
                this.nombre = arr[5];
                this.listas = new ObservableCollection<Lista>();
                this.carrito = new ObservableCollection<Producto>();
            }
            else {
                var arr = datos.Split('"');
                this.nombre = arr[5];
                for(int i = 1; i < arr[2].Length-1; i++) 
                {
                    this.idUsuario += arr[2][i];
                }
                this.listas = new ObservableCollection<Lista>();
                this.carrito = new ObservableCollection<Producto>();
            }
           
        }

        public ObservableCollection<Lista> getListas() { return listas; }
        public string getNombre() {  return nombre; }

        internal ObservableCollection<Producto> getCarrito()
        {
           return carrito;
        }
        internal void setCarrito(ObservableCollection<Producto> b)
        {
            carrito = b;
        }
        public void addLista(Lista lista)
        {
            
            listas.Add(lista);
        }
        public void removeLista(Lista lista)
        {
           
            listas.Remove(lista);
        }
    }
}

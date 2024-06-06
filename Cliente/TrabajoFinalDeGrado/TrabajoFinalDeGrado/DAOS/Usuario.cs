using System.Collections.ObjectModel;

namespace TrabajoFinalDeGrado.DAOS
{
    public class Usuario
    {
         
        public string nombre {  get; }
        private ObservableCollection<Lista> listas { get; set; }
        private ObservableCollection<Producto> carrito{ get; set; } //al guardar el carrito en el usuario, podemos hacerlo persistente,
                                                                    //si voy a hacerlo persistente, poner boton de vaciar carrito 
        
        public Usuario(string nombre, ObservableCollection<Lista> listas)
        {
            this.nombre = nombre;
            this.listas = listas;
            this.carrito = new ObservableCollection<Producto>();
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
            //TODO: acc a la bdd
            listas.Add(lista);
        }
        public void removeLista(Lista lista)
        {
            //TODO: acc a la bdd
            listas.Remove(lista);
        }
    }
}

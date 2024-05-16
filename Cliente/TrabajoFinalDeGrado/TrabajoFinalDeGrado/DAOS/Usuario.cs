using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using TrabajoFinalDeGrado.Toasts;

namespace TrabajoFinalDeGrado.DAOS
{
    public class Usuario
    {
        //esta clase refleja la sesion actual, cada cambio que se haga en las listas/carrito etc
        //debe hacerse desde el fragment correspondiente 
        public string nombre {  get; }
        private ObservableCollection<Lista> listas { get; set; }
        private ObservableCollection<Producto> carrito{ get; set; } //al guardar el carrito en el usuario, podemos hacerlo persistente,
                                                                    //si voy a hacerlo persistente, poner boton de vaciar carrito 
                                                                    //meterlo en un observable collection y que en la pestaña de carrito se vea en tajetas como en productos

        Toast men;
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
        public void mensaje(string msg) {
            if (men != null) { men.Close(); }
            

            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            double xin = desktopWorkingArea.Right - 270;
            double y = desktopWorkingArea.Bottom - 90;
            //men.Left = x - men.Width; men.Top = y - men.Height;// - height para que se coloque en la esquina de abajo
            men = new Toast(msg,(int)xin, (int)(xin+270));
            men.Top = y - men.Height;
            men.Show();
           
           
        }
    }
}

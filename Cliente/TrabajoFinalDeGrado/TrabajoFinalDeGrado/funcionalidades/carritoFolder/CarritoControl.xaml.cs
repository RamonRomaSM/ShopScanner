using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrabajoFinalDeGrado.DAOS;

namespace TrabajoFinalDeGrado.funcionalidades.carritoFolder
{
    /// <summary>
    /// Lógica de interacción para CarritoControl.xaml
    /// </summary>
    public partial class CarritoControl : UserControl
    {
        private Usuario sesionAct;
        ObservableCollection<Producto> Carrito;
        public CarritoControl(Usuario u)
        {
            InitializeComponent();
            this.sesionAct = u;
            Carrito = sesionAct.getCarrito();
            ListViewCarrito.ItemsSource =Carrito;
        }


       

        private void abrir_url(object sender, MouseButtonEventArgs e)
        {

            TextBlock a = (TextBlock)sender;
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = a.Text,
                UseShellExecute = true
            });
        }
        private void ListViewProducts_PreviewMouseWheel(object sender, MouseWheelEventArgs e) //para desviar los eventos del mousewheel que captura el listView al ScrollerView
        {
            if (!e.Handled)
            {
                e.Handled = true;
                var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
                eventArg.RoutedEvent = UIElement.MouseWheelEvent;
                eventArg.Source = sender;
                var parent = ((Control)sender).Parent as UIElement;
                parent.RaiseEvent(eventArg);
            }
        }
        private void bin(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;
            Carrito.Remove(p);
        }
        private void add(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;
            p.cantidad++;
            ObservableCollection <Producto> products = new ObservableCollection<Producto>();

            foreach (Producto item in Carrito)
            {
                products.Add(item);
            }
           
            foreach (Producto item in products)
            {
                Carrito.RemoveAt(0);
                Carrito.Add(item);
               
            }
        }
        
        private void substract(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;
            p.cantidad--;
            if(p.cantidad == 0) { Carrito.Remove(p); }
            ObservableCollection<Producto> products = new ObservableCollection<Producto>();

            foreach (Producto item in Carrito)
            {
                products.Add(item);
            }

            foreach (Producto item in products)
            {
                Carrito.RemoveAt(0);
                Carrito.Add(item);

            }

        }
        private ObservableCollection<Producto> reOrdenaCarrito(ObservableCollection<Producto> l, Producto p)
        {

            ObservableCollection<Producto> resp = l;
            if (!resp.Contains(p))
            {
                p.cantidad = 1;
                resp.Add(p);
            }
            else { p.cantidad++; }

            return resp;
        }

    }
}

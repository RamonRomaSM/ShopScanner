using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TrabajoFinalDeGrado.DAOS;

namespace TrabajoFinalDeGrado.funcionalidades.perfilFolder
{
    public partial class ListaWindow : Window
    {

       
        bool textoCambiado = false;
        Usuario sesionact;
        Lista listaOriginal;//referencia de la lista que me pasan
        ObservableCollection<Producto> listaNueva; // copia de la lista que me copian
        string nombre;//es el nombre de la lista que me pasan 
        mainFragment padre;
        public ListaWindow(Usuario u, Lista l,mainFragment p)
        {
            System.Console.WriteLine("aaa");
            InitializeComponent();
            this.sesionact = u;
            this.listaOriginal = l;
            padre = p;
            txtNombreLista.Text = l.nombre;
            this.nombre = l.nombre;

            listaNueva = new ObservableCollection<Producto>();
            foreach (Producto pr in l.productos) 
            { 
                listaNueva.Add(pr);
            }

            ListViewCarrito.ItemsSource = listaNueva;// esta tiene que ser la listaNueva (copiar original antes de ponerla como source)
        }

        private void moverWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        private void salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void minimizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
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

        private void add(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;
            p.cantidad++;
            ObservableCollection<Producto> products = new ObservableCollection<Producto>();

            foreach (Producto item in listaNueva)
            {
                products.Add(item);
            }

            foreach (Producto item in products)
            {
                listaNueva.RemoveAt(0);
                listaNueva.Add(item);

            }
        }

        private void substract(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;
            p.cantidad--;
            if (p.cantidad == 0) { listaNueva.Remove(p); }
            ObservableCollection<Producto> products = new ObservableCollection<Producto>();

            foreach (Producto item in listaNueva)
            {
                products.Add(item);
            }

            foreach (Producto item in products)
            {
                listaNueva.RemoveAt(0);
                listaNueva.Add(item);
            }
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
        private void bin(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;
            listaNueva.Remove(p);
        }
        private void addListaBtn_Click(object sender, RoutedEventArgs e)
        {
            listaOriginal.productos = listaNueva;
            if (textoCambiado) { listaOriginal.nombre = txtNombreLista.Text; }
            listaOriginal.calculaPrecio();
            padre.contenedorFragments.Content = new PerfilControl(sesionact, padre);
            Sesion.mensaje("Cambios en "+nombre+" guardados");
            this.Close();
        }


        private void txtNombreLista_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (txtNombreLista.Text.Equals(""))
            {
                txtNombreLista.Text = nombre;
                textoCambiado = false;
            }
            else { textoCambiado = true; }
        }
        private void txtNombreLista_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtNombreLista.Text = "";
        }
    }
}

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

        /*
         *  
         *  Cada vez que salgo de la lista (guardandola) tengo que crear un nuevo
         *  perfilFragment
         *  
         *  cuando guardo igualo la lista y el nombre, si salgo con la 'x' no gualdo nada
         *  
         *  
         *  
         *  ------------------------------------------------------------------------------
         *                                      TFG                                      
         *  ------------------------------------------------------------------------------
         *  
         *  Empieza la memoria
         *  En la presentacion llevar un video, si me veo confiado les dejo la app
         *  (la prioridad es tener una api, la seguridad ya se verá)
         *  
         *  
         *  ------------------------------------------------------------------------------
         *                                     VERANO
         *  ------------------------------------------------------------------------------
         *  
         *  caminos en verano:
         *      Ciberseguridad (el curso)
         *      Web (pillar un framework(angular, react, vue), despliegue, sistemas de monetizacion, diseño de ui)
         *      Embeded systems?: (raspi,breadboards,arduino)
         *      Kotlin (desarrollo movil puro, mejorar la de booking, usar alguna api para alguna app diferente(real state, weather app))
         *      
         *      Proyectos personales:
         *          App de facturas con javaFX
         *          JARVIS
         *          Lo de new pipe con juan
         *          ...
         *          
         *      Mantenimientos:
         *          Rehacer el supercole (y documentacion)
         *          Discord bot (documentacion y revision del codigo)
         *          Documentacion de booking y del tfg
         *          
         *          
         *      
         */
        bool textoCambiado = false;
        Usuario sesionact;
        ObservableCollection<Producto> listaOriginal;//referencia de la lista que me pasan
        ObservableCollection<Producto> listaNueva; // copia de la lista que me copian
        string nombre;//es el nombre de la lista que me pasan 
        public ListaWindow(Usuario u, Lista l)
        {
            System.Console.WriteLine("aaa");
            InitializeComponent();
            this.sesionact = u;
            this.listaOriginal = l.productos;

            txtNombreLista.Text = l.nombre;
            this.nombre = l.nombre;

            listaNueva = new ObservableCollection<Producto>();
            foreach (Producto p in l.productos) 
            { 
                listaNueva.Add(p);
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
            //TODO: el toast de que se han guardado los cambios
            /*
            if (!txtNombreLista.Equals("") && lista.Count > 0 && textoCambiado)
            {
                MessageBox.Show("Guardado");
                Lista nueva = new Lista(txtNombreLista.Text, sesionact.nombre, lista);

                sesionact.addLista(nueva);

                textoCambiado = false;
                txtNombreLista.Text = "Escribe el nombre de tu nueva lista";
                lista.Clear();       
            }
            */
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

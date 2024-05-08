using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using TrabajoFinalDeGrado.DAOS;

namespace TrabajoFinalDeGrado.funcionalidades.perfilFolder
{
    /// <summary>
    /// Lógica de interacción para ListaWindow.xaml
    /// </summary>
    public partial class ListaWindow : Window
    {
        bool textoCambiado = false;
        Usuario sesionact;
        
        ObservableCollection<Producto> lista; 
        string nombre;//lo sacas de la lista
        

        //Falta hacer un boton de guardar en plan bientxtNombreLista.
        public ListaWindow(Usuario u, Lista l)
        {
            InitializeComponent();
            this.sesionact = u;
            this.lista = l.productos;
            txtNombreLista.Text = l.nombre;
            this.nombre = l.nombre;
            ListViewCarrito.ItemsSource = lista;
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
            /*
            Producto p = ((Button)sender).Tag as Producto;
            p.cantidad++;
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
            */
        }

        private void substract(object sender, RoutedEventArgs e)
        {
            /*
            Producto p = ((Button)sender).Tag as Producto;
            p.cantidad--;
            if (p.cantidad == 0) { Carrito.Remove(p); }
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
            */
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
            /*
            Producto p = ((Button)sender).Tag as Producto;
            Carrito.Remove(p);
            */
        }


        private void addListaBtn_Click(object sender, RoutedEventArgs e)
        {/*
            if (!txtNombreLista.Equals("") && Carrito.Count > 0 && textoCambiado)
            {
                MessageBox.Show("Guardado");
                Lista nueva = new Lista(txtNombreLista.Text, sesionAct.nombre, Carrito);

                sesionAct.addLista(nueva);

                textoCambiado = false;
                txtNombreLista.Text = "Escribe el nombre de tu nueva lista";
                Carrito.Clear();
                
            }*/
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

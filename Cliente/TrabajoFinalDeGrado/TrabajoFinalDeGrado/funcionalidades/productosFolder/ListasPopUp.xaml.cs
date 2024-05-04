using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TrabajoFinalDeGrado.DAOS;

namespace TrabajoFinalDeGrado.funcionalidades.productosFolder
{
    /// <summary>
    /// Lógica de interacción para ListasPopUp.xaml
    /// </summary>
    public partial class ListasPopUp : Window
    {
        ObservableCollection<Lista> Listas;
        Producto act;
        public ListasPopUp(ObservableCollection<Lista> listas, Producto act)
        {

            this.Listas = listas;
            this.act = act;
            InitializeComponent();
            this.contenedorListas.ItemsSource = Listas;
           
        }

       
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            Button a = (Button)sender;
            Lista l = ((Button)sender).Tag as Lista;  
            l.productos = reOrdenaCarrito(l.productos, act);
            l.calculaPrecio();
            MessageBox.Show("Añadido a " + l.nombre);//To do, que el mensaje sea mas bonito y menos invasivo
            this.Close();
        }

        private void cerrar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!this.IsKeyboardFocused && !IsMouseOver) { this.Close(); }
        }
        private ObservableCollection<Producto> reOrdenaCarrito(ObservableCollection<Producto> l, Producto p)
        {

            ObservableCollection<Producto> resp = l;
            if (!resp.Contains(p))
            {
                p.cantidad ++;
                resp.Add(p);
            }
            else { p.cantidad++; }

            return resp;
        }


    }
        
}

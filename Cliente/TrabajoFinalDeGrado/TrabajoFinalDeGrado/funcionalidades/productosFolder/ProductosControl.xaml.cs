using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace TrabajoFinalDeGrado.funcionalidades.productosFolder
{
    /// <summary>
    /// Lógica de interacción para ProductosControl.xaml
    /// </summary>
    public partial class ProductosControl : UserControl
    {
        ObservableCollection<Producto> Products;
        int i = 0;
        public ProductosControl()
        {
            InitializeComponent();
            Products = new ObservableCollection<Producto>();
            Producto a = new Producto();
            Producto b = new Producto();
            Producto c = new Producto();
            Producto d = new Producto();


            a.nombre = "a";
            b.nombre = "b";
            c.nombre = "c";
            d.nombre = "d";

            Products.Add(a);
            Products.Add(b);
            Products.Add(c);
            Products.Add(d);
            Products.Add(c);
            Products.Add(d);

            ListViewProducts.ItemsSource = Products;
        }
        private void OnScrollChanged(object sender, ScrollChangedEventArgs e)
        { //pide nuevos items
            var scrollViewer = MyScroller;
            if (scrollViewer.VerticalOffset == scrollViewer.ScrollableHeight)
            {

                Producto a = new Producto();
                Producto b = new Producto();



                a.nombre = "a" + i;
                b.nombre = "b" + i;

                i++;
                Products.Add(a);
                Products.Add(b);
                Products.Add(a);
                Products.Add(b);
                Products.Add(a);
                Products.Add(b);

            }


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
    }
}

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
        private Usuario sesionAct;
        private ObservableCollection<Producto> Products;
        private int i = 0;
        
        public ProductosControl(Usuario u)
        {
           
            InitializeComponent();
            this.sesionAct = u;
            this.Products = new ObservableCollection<Producto>();
            ListViewProducts.ItemsSource = Products;
            OnScrollChanged(null, null);
        }


        //Pide nuevos items
        private void OnScrollChanged(object sender, ScrollChangedEventArgs e)
        { 
            
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

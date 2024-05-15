using System;
using System.Collections;
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
                Producto c = new Producto();

                a.nombre = "12 Mini croissants de mantequilla";
                b.nombre = "ALCAMPO CULTIVAMOS LO BUENO Champiñón laminado  Bandeja de 250 g.";
                c.nombre = " c";

                a.imagen = "https://prod-mercadona.imgix.net/images/55dfb0de5a832d479c76f2e25c653d4b.jpg?fit=crop&h=300&w=300";
                b.imagen = "https://www.compraonline.alcampo.es/images-v3/37ea0506-72ec-4543-93c8-a77bb916ec12/1c889628-8a63-4af8-85bd-a0783a89fe5b/300x300.jpg";

                a.url = "https://tienda.mercadona.es/product/84629/12-mini-croissants-mantequilla-bolsa";
                b.url = "https://www.compraonline.alcampo.es/products/ALCAMPO-CULTIVAMOS-LO-BUENO-Champiñón-laminado--Bandeja-de-250-g./57687";

                a.precio = 10;
                b.precio = 20;
                c.precio = 30;

                a.supermercado = "Mercadona";
                b.supermercado = "Alcampo";
                c.supermercado = "Alcampo";

                a.idproductos = "prod a";
                b.idproductos = "prod b";
                c.idproductos = "prod c";

                i++;
                Products.Add(a);
                Products.Add(b);
                Products.Add(c);
                Products.Add(a);
                Products.Add(b);
                Products.Add(c);

            }
        }
        
        private ObservableCollection<Producto> reOrdenaCarrito(ObservableCollection<Producto> l, Producto p)
        {
            Producto copiap = new Producto();
            copiap.copiar(p);

            ObservableCollection<Producto> resp = l;
            
            copiap.cantidad = 1;
            resp.Add(copiap);

            resp = refactoriza(resp,copiap);
            return resp;
        }
        public ObservableCollection<Producto> refactoriza(ObservableCollection<Producto> l,Producto p) { 
            int c = 0;
            Producto copiap = new Producto();   
            copiap.copiar(p);
            ObservableCollection<Producto> lcopy = new ObservableCollection<Producto>();

            foreach (Producto item in l)
            {
                if (item.Equals(p)) { c+=item.cantidad; }

            }
            foreach (Producto item in l)
            {
                if (!item.Equals(p)) { lcopy.Add(item); }
            }
           
            copiap.cantidad = c;
            lcopy.Add(copiap);
            return lcopy;
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

        private void abrir_url(object sender, MouseButtonEventArgs e)
        {

            TextBlock a = (TextBlock)sender;
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = a.Text,
                UseShellExecute = true
            });
        }

        private void addCarritobtn_Click(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;

            ObservableCollection<Producto> b = sesionAct.getCarrito();
            sesionAct.setCarrito(reOrdenaCarrito(b, p));
            sesionAct.mensaje("Añadido al carrito");
        }


        private void addListaBtn_Click(object sender, RoutedEventArgs e)
        {
            //TODO: que me saque un ventana emergente (con los colores de la app) con un stackpannel de las listas
            // https://www.youtube.com/watch?v=KSNjJ9Glky4
            Producto p = ((Button)sender).Tag as Producto;
            ListasPopUp popup = new ListasPopUp(sesionAct.getListas(),p,sesionAct);
           
            
            //para que se coloque en el cursor
            System.Windows.Point position = Mouse.GetPosition(this);
            System.Windows.Point screenPosition = this.PointToScreen(position);
            double x = screenPosition.X;
            double y = screenPosition.Y;

            popup.Show();
            popup.Left = x - popup.Width; popup.Top = y-popup.Height;// - height para que se coloque en la esquina de abajo
        }


    }
}

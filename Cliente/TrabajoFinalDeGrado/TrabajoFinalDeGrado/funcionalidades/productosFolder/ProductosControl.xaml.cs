using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TrabajoFinalDeGrado.DAOS;
using Yaapii.Http.Requests;
using Yaapii.Http.Wires.AspNetCore;
using Yaapii.Http.Wires;
using Yaapii.Http.Parts.Bodies;
using Antlr4.Runtime.Misc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Yaapii.JSON;
using System.Collections.Generic;
using System.Text.Json;
using System;

namespace TrabajoFinalDeGrado.funcionalidades.productosFolder
{
    public partial class ProductosControl : UserControl
    {
        private Usuario sesionAct;
        private ObservableCollection<Producto> Products;
        private int pagina = 0;
        private bool textoCambiado = false;
        public ProductosControl(Usuario u)
        {
           
            InitializeComponent();
            this.sesionAct = u;
            this.Products = new ObservableCollection<Producto>();
            ListViewProducts.ItemsSource = Products;
            OnScrollChanged(null, null);
        }

        //Pide nuevos items a la api
        private void OnScrollChanged(object sender, ScrollChangedEventArgs e)
        { 
            
            var scrollViewer = MyScroller;
            if (scrollViewer.VerticalOffset == scrollViewer.ScrollableHeight)
            {
                pideNuevos();
              
                pagina++;
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
            Sesion.mensaje("Añadido al carrito");
        }
        private void addListaBtn_Click(object sender, RoutedEventArgs e)
        {
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
        //---------------Relacionado con la barra de busqueda----------------------
        private void txtNombreLista_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (txtHint.Text.Equals(""))
            {
                txtHint.Text = "Escribe lo que quieras buscar";
                textoCambiado = false;
            }
            else { textoCambiado = true; }
        }
        private void txtNombreLista_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtHint.Text = "";
        }
        private void pideNuevos() {
           
            var response =
                new AspNetCoreWire(
                    new AspNetCoreClients()
                        ).Response(
                            new Get("https://my-first-express-api.vercel.app/getPagina/"+pagina+"/"+txtHint.Text+"")
            );
            string json = new TextBody.Of(response).AsString();

            var arr=json.Split("{");    
            for(int i = 2; i<arr.Length; i++) { 
                Producto p = new Producto(arr[i]);
                Products.Add(p);
            }

        }
        private void buscar(object sender, RoutedEventArgs e) 
        {
            pagina = 0;
            MyScroller.ScrollToTop();
            Products.Clear();
            pideNuevos();
        }
    }
}



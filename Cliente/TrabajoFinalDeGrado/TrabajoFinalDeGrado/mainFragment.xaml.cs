using System;
using System.Collections.Generic;
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
using TrabajoFinalDeGrado.funcionalidades.carritoFolder;
using TrabajoFinalDeGrado.funcionalidades.perfilFolder;
using TrabajoFinalDeGrado.funcionalidades.productosFolder;

namespace TrabajoFinalDeGrado
{
    /// <summary>
    /// Lógica de interacción para mainFragment.xaml
    /// </summary>
    public partial class mainFragment : UserControl
    {
        //este fragment al crearse ha de inicializar todos los Controls con los dastos del usuario
        private MainWindow padre;
        private ProductosControl productosControl;
        private CarritoControl  carritoControl;
        private PerfilControl perfilControl;


        public mainFragment(MainWindow padre)
        {
            InitializeComponent();
            this.padre = padre;
            this.productosControl = new ProductosControl();
            this.perfilControl = new PerfilControl();
            this.carritoControl = new CarritoControl();

            contenedorFragments.Content = productosControl;
        }
        private void salir2(object sender, RoutedEventArgs e)
        {
            var window = Window.GetWindow(this);
            window.Close();
        }
        private void cerrar_sesion(object sender, RoutedEventArgs e)
        {
            padre.deslogear();
        }
        private void productos(object sender, RoutedEventArgs e) 
        {
            contenedorFragments.Content = productosControl;
        }
        private void carrito(object sender, RoutedEventArgs e) 
        {
            contenedorFragments.Content = carritoControl;
        }
        private void perfil(object sender, RoutedEventArgs e) 
        {
            contenedorFragments.Content = perfilControl;
        }
    }
}

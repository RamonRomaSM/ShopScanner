using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using TrabajoFinalDeGrado.autenth;

namespace TrabajoFinalDeGrado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // acuerdate que cuando haces el login, el server te manda los datos de tu cuenta (tus listas de la compra) y estas se guardan en una variable
        // (usuarioAct), cuando cierras sesion, hay quedestruir esta variable (volverla null)
       
        public MainWindow()
        {

            InitializeComponent();
            mainContenedor.Content = new loginFragmentxaml(this);
        }
        private void moverWindow(object sender, MouseButtonEventArgs e)

        {

            this.DragMove();

        }

        private void salir(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
        private void maximizar(object sender, RoutedEventArgs e)
        {

            if (WindowState != WindowState.Maximized)
            {
                WindowState = WindowState.Maximized;

            }
            else {
                WindowState = WindowState.Normal;

            }
        }
        private void minimizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
             
        }

        public void logear(){
            this.mainContenedor.Content = new mainFragment(this);
        }
        public void deslogear()
        {
            this.mainContenedor.Content = new loginFragmentxaml(this);
        }
        
    }
   


}

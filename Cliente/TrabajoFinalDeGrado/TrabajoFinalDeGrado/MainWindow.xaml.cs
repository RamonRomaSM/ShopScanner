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

namespace TrabajoFinalDeGrado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            InitializeComponent();
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
            WindowState=WindowState.Minimized;

        }
    }
   


}

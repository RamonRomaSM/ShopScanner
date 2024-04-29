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
using System.Windows.Shapes;

namespace TrabajoFinalDeGrado.funcionalidades.productosFolder
{
    /// <summary>
    /// Lógica de interacción para ListasPopUp.xaml
    /// </summary>
    public partial class ListasPopUp : Window
    {
        public ListasPopUp()
        {
            InitializeComponent();
            Point mousePositionInApp = Mouse.GetPosition(Application.Current.MainWindow);
            Point mousePositionInScreenCoordinates =
            Application.Current.MainWindow.PointToScreen(mousePositionInApp);
        }

        private void Window_LostFocus(object sender, RoutedEventArgs e)
        {
            try { this.Close(); } catch { }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("aa");
        }
    }
        
}

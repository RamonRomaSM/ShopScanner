using System;
using System.Collections.Generic;
using System.Linq;
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

       
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show ("aa");
            this.Close();
        }


        private void Window_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!this.IsKeyboardFocused) { this.Close(); }
        }

        
    }
        
}

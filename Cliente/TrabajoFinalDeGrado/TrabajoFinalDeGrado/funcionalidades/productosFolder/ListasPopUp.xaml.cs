using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TrabajoFinalDeGrado.DAOS;

namespace TrabajoFinalDeGrado.funcionalidades.productosFolder
{
    /// <summary>
    /// Lógica de interacción para ListasPopUp.xaml
    /// </summary>
    public partial class ListasPopUp : Window
    {
        ObservableCollection<Lista> Listas;
        public ListasPopUp(ObservableCollection<Lista> listas)
        {

            this.Listas = listas;
            InitializeComponent();
            
            this.contenedorListas.ItemsSource = Listas;
           
        }

       
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button a = (Button)sender;
            MessageBox.Show("Añadido a "+a.Content);
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

       
       
    }
        
}

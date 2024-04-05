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

namespace TrabajoFinalDeGrado.autenth
{
    /// <summary>
    /// Lógica de interacción para loginFragmentxaml.xaml
    /// </summary>
    public partial class loginFragmentxaml : UserControl
    {
        MainWindow padre;
        public loginFragmentxaml(MainWindow padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void aceptar(object sender, RoutedEventArgs e)
        {
            padre.logear();
        }
    }
}

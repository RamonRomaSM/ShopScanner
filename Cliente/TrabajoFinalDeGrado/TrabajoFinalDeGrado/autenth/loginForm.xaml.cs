using System;
using System.Collections;
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

namespace TrabajoFinalDeGrado.autenth
{
    /// <summary>
    /// Lógica de interacción para loginForm.xaml
    /// </summary>
    public partial class loginForm : UserControl
    {
        MainWindow padre;
        public loginForm(MainWindow padre)
        {
            this.padre = padre;
            InitializeComponent();
        }

        private void aceptar(object sender, RoutedEventArgs e)
        {
            Usuario u = verifica(nombre.Text, pasw.Password);

            padre.logear(u);
        }
        //retorna el usuario, si no lo encuentra devuelve null
        public Usuario verifica(string nombre, string pasw)
        {
            //TODO: preguntar a la bdd

            Usuario u = new Usuario("Ramon",new ObservableCollection<Lista>());

            return u;
        }

    }
}

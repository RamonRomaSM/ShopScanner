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
        bool quien = true;
        MainWindow padre;
        public loginFragmentxaml(MainWindow padre)
        {
            InitializeComponent();
            this.padre = padre;
            formContainer.Content = new loginForm(padre);
        }

        
        private void logearse(object sender, RoutedEventArgs e)
        {
            loginBtn.BorderBrush = System.Windows.Media.Brushes.DodgerBlue;
            registarrseBtn.BorderBrush = System.Windows.Media.Brushes.Transparent;
            quien = true;
            formContainer.Content = new loginForm(padre);
        }
        private void registrarse(object sender, RoutedEventArgs e)
        {
            loginBtn.BorderBrush = System.Windows.Media.Brushes.Transparent;           
            registarrseBtn.BorderBrush = System.Windows.Media.Brushes.DodgerBlue;
            quien = false;
            formContainer.Content = new registerForm(padre);
        }




        private void loginBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            loginBtn.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#646D77");
        }

        private void loginBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            if (quien)
            {
                loginBtn.BorderBrush = System.Windows.Media.Brushes.DodgerBlue;
                registarrseBtn.BorderBrush = System.Windows.Media.Brushes.Transparent;
            }
            else {
                loginBtn.BorderBrush = System.Windows.Media.Brushes.Transparent;
                registarrseBtn.BorderBrush = System.Windows.Media.Brushes.DodgerBlue;
            }
        }

        private void registarrseBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            registarrseBtn.BorderBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#646D77");
        }

        private void registarrseBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            if (quien)
            {
                loginBtn.BorderBrush = System.Windows.Media.Brushes.DodgerBlue;
                registarrseBtn.BorderBrush = System.Windows.Media.Brushes.Transparent;
            }
            else
            {
                loginBtn.BorderBrush = System.Windows.Media.Brushes.Transparent;
                registarrseBtn.BorderBrush = System.Windows.Media.Brushes.DodgerBlue;
            }
        }
       





    }
    
}

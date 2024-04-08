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
    /// Lógica de interacción para registerForm.xaml
    /// </summary>
    public partial class registerForm : UserControl
    {
        MainWindow padre;
        public registerForm(MainWindow padre)
        {
            this.padre = padre;
            InitializeComponent();
        }

        private void registrar(object sender, RoutedEventArgs e)
        {   if (nombre.Text == "") 
            {
                feedbacklbl.Foreground = new SolidColorBrush(Colors.Red);
                feedbacklbl.Text = "Nombre invalido";
            }
            if (passw1.Password == passw2.Password)
            {
                if (passw1.Password == "") 
                {
                    feedbacklbl.Foreground = new SolidColorBrush(Colors.Red);
                    feedbacklbl.Text = "Contraseña invalida";
                }
                else if (padre.registrarse(passw1.Password, nombre.Text))
                {
                    feedbacklbl.Foreground = new SolidColorBrush(Colors.Green);
                    feedbacklbl.Text = "Usuario creado correctamente";
                    passw1.Password = "";
                    passw2.Password = "";
                    nombre.Text = "";

                }
                else 
                {
                    feedbacklbl.Foreground = new SolidColorBrush(Colors.Red);
                    feedbacklbl.Text = "Nombre en uso";
                }
            }
            else 
            {
                feedbacklbl.Foreground = new SolidColorBrush(Colors.Red);
                feedbacklbl.Text = "Las contraseñas no coinciden";
            }
        }
    }
}

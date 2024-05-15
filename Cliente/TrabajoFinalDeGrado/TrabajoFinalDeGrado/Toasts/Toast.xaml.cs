using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TrabajoFinalDeGrado.Toasts
{
    /// <summary>
    /// Lógica de interacción para Toast.xaml
    /// </summary>
    public partial class Toast : Window
    {
        private string mensaje;
        private DispatcherTimer timer;
        public Toast(string mensaje)
        {
            
            InitializeComponent();
            this.mensaje = mensaje;
            msg.Text = mensaje;
            Loaded += MainWindow_Loaded;
            
        }
        public void posicion() {
            //WindowStartupLocation="Manual"
            
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Crear un nuevo DispatcherTimer
            timer = new DispatcherTimer();
            // Establecer el intervalo del temporizador en 4 segundos
            timer.Interval = TimeSpan.FromSeconds(3);
            // Suscribirse al evento Tick del temporizador
            timer.Tick += Timer_Tick;
            // Iniciar el temporizador
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Detener el temporizador
            timer.Stop();
            // Cerrar la ventana
            this.Close();
        }
    }
}

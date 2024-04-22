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
using TrabajoFinalDeGrado.DAOS;

namespace TrabajoFinalDeGrado.funcionalidades.carritoFolder
{
    /// <summary>
    /// Lógica de interacción para CarritoControl.xaml
    /// </summary>
    public partial class CarritoControl : UserControl
    {
        private Usuario sesionAct;
        public CarritoControl(Usuario u)
        {
            this.sesionAct = u;
            InitializeComponent();
        }
    }
}

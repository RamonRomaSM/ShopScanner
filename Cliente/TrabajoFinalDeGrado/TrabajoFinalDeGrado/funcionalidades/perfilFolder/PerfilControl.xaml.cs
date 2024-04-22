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

namespace TrabajoFinalDeGrado.funcionalidades.perfilFolder
{
    /// <summary>
    /// Lógica de interacción para PerfilControl.xaml
    /// </summary>
    public partial class PerfilControl : UserControl
    {
        private Usuario sesionAct;
        private ObservableCollection<Lista> listas;
        public PerfilControl(Usuario u)
        {

            InitializeComponent();
            this.sesionAct = u;
            this.listas = new ObservableCollection<Lista>();

            ArrayList d = sesionAct.getListas();
            foreach (Lista l in d)
            {
                listas.Add(l);
            }
            ListViewProducts.ItemsSource = listas;
        }
    }
}

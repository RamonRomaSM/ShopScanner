using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoFinalDeGrado.Toasts;

namespace TrabajoFinalDeGrado.DAOS
{
    public class Sesion
    {
        //no ahce falta instanciar nada en principio
        public static Usuario usuarioAct {  get; set; }
        public static ObservableCollection<Producto> carrito {  get; set; }
        private static Toast men;


        public static void mensaje(string msg)
        {
            if (men != null) { men.Close(); }

            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            double xin = desktopWorkingArea.Right - 270;
            double y = desktopWorkingArea.Bottom - 90;
            //men.Left = x - men.Width; men.Top = y - men.Height;// - height para que se coloque en la esquina de abajo
            men = new Toast(msg, (int)xin, (int)(xin + 270));
            men.Top = y - men.Height;
            men.Show();
        }
        public static void addLista(Lista lista)
        {
            usuarioAct.addLista(lista);
        }
        public static void removeLista(Lista lista)
        {
            usuarioAct.removeLista(lista);
        }
    }
}

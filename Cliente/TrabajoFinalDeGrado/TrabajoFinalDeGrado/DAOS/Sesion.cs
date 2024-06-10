using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TrabajoFinalDeGrado.Toasts;
using Yaapii.Http.Parts.Bodies;
using Yaapii.Http.Requests;
using Yaapii.Http.Wires.AspNetCore;
using Yaapii.Http.Wires;
using System.Reflection.Metadata.Ecma335;

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
        public static void guardaJsonListas() {

            /*
             [{nombreLista : nombre , productos[{},{},{},{}]},{nombreLista : nombre , productos[{},{},{},{}]}]
             */
            string json = "elimina";
           
            if (usuarioAct.getListas().Count > 0) { 
                json = "[";
                ObservableCollection<Lista> listas = usuarioAct.getListas();
                for (int i = 0; i < listas.Count; i++) {

                    Lista act = listas[i];
                    json += "{ nombre_lista : " + act.nombre + " , productos : [";
                    ObservableCollection<Producto> prods = act.productos;
                    foreach (Producto prod in prods)
                    {
                        json += prod.getJson();
                        if (i != listas.Count - 1) { json += ","; }
                    }
                    json += "]}";
                }
                json += "]";
            }
            var re =
            new AspNetCoreWire(
            new AspNetCoreClients()
                ).Response(
                    new Get("https://my-first-express-api.vercel.app/nueva/" + usuarioAct.idUsuario + "/datos?datos=" + json
                    )
            );

        }
        public static void guarda(ObservableCollection<Lista> listas) { 
        
        }
        public static ObservableCollection<Lista> recoje() { 
        
            return null;
        }

    }
}

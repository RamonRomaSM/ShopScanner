using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using TrabajoFinalDeGrado.DAOS;
using Yaapii.Http.Parts.Bodies;
using Yaapii.Http.Requests;
using Yaapii.Http.Wires.AspNetCore;
using Yaapii.Http.Wires;
using System.Windows.Media;
using Yaapii.Atoms.Time;
using Newtonsoft.Json.Linq;

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
            if (nombre.Text != "" && pasw.Password != "")
            {
                Usuario u = verifica(nombre.Text, pasw.Password);
                if (u != null)
                {
                    padre.logear(u);
                }
                else
                {
                    feedbacklbl.Foreground = new SolidColorBrush(Colors.Red);
                    feedbacklbl.Text = "Usuario no encontrado";
                }
            }
        }
        //retorna el usuario, si no lo encuentra devuelve null
        public Usuario verifica(string nombre, string passw)
        {

            var response =
               new AspNetCoreWire(
                   new AspNetCoreClients()
                       ).Response(
                           new Get("https://my-first-express-api.vercel.app/login/nombre/"+nombre+"/passw/"+passw)
            );
            string json = new TextBody.Of(response).AsString();

            if (json == "resp:false") {

                return null;
            }
            else
            {
                //TODO: preguntar a la bdd

                var temp = json.Split("listas");
               
                if (temp.Length > 2)
                { //tiene listas
                    var arr = json.Split("{");//temp
                    string datos = arr[2];
                    Usuario u = new Usuario(datos, true);
                    return u;
                }
                else { //no tiene
                    var arr = json.Split("{");
                    string datos  = arr[2];
                    Usuario u = new Usuario(datos,false);
                    return u;
                }
            }
         
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
using TrabajoFinalDeGrado.autenth;
using TrabajoFinalDeGrado.DAOS;
using Yaapii.Http.Parts.Bodies;
using Yaapii.Http.Requests;
using Yaapii.Http.Wires.AspNetCore;
using Yaapii.Http.Wires;

namespace TrabajoFinalDeGrado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            
            InitializeComponent();
            mainContenedor.Content = new loginFragmentxaml(this);
        }
        private void moverWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void salir(object sender, RoutedEventArgs e)
        {
            try { Sesion.guardaJsonListas(); } catch(Exception) { }
           
            this.Close();
        }
        
        private void minimizar(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        // METODOS ACC A BDD (que despues de las validaciones, usa los metodos del objeto que accede a la bdd)
        public void logear(Usuario u){
            if (u != null)
            {

                this.mainContenedor.Content = new mainFragment(this, u);
            }
        }
        public void deslogear()
        {
            this.mainContenedor.Content = new loginFragmentxaml(this);
        }
        public Boolean registrarse(string passw, string nombre) {

            var response =
               new AspNetCoreWire(
                   new AspNetCoreClients()
                       ).Response(
                           new Get("https://my-first-express-api.vercel.app/register/nombre/"+nombre+"/passw/"+passw)
           );
            string json = new TextBody.Of(response).AsString().Split(":")[1];
            if (json == "false") { return false; }
            
            return true;
        }
        


    }
   


}

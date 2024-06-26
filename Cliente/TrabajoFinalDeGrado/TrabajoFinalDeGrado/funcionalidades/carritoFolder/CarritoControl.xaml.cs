﻿using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TrabajoFinalDeGrado.DAOS;
using Yaapii.Http.Parts.Bodies;
using Yaapii.Http.Requests;
using Yaapii.Http.Wires.AspNetCore;
using Yaapii.Http.Wires;
using Yaapii.JSON;
using System.Collections.Generic;
using System;
using Yaapii.Http.Responses;

namespace TrabajoFinalDeGrado.funcionalidades.carritoFolder
{
    public partial class CarritoControl : UserControl
    {
        private Usuario sesionAct;
        ObservableCollection<Producto> Carrito;
        bool textoCambiado = false;
        public CarritoControl(Usuario u)
        {
            InitializeComponent();
            this.sesionAct = u;
            Carrito = sesionAct.getCarrito();
            ListViewCarrito.ItemsSource =Carrito;
        }

        private void abrir_url(object sender, MouseButtonEventArgs e)
        {

            TextBlock a = (TextBlock)sender;
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = a.Text,
                UseShellExecute = true
            });
        }
        private void ListViewProducts_PreviewMouseWheel(object sender, MouseWheelEventArgs e) //para desviar los eventos del mousewheel que captura el listView al ScrollerView
        {
            if (!e.Handled)
            {
                e.Handled = true;
                var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
                eventArg.RoutedEvent = UIElement.MouseWheelEvent;
                eventArg.Source = sender;
                var parent = ((Control)sender).Parent as UIElement;
                parent.RaiseEvent(eventArg);
            }
        }
        private void bin(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;
            Carrito.Remove(p);
        }
        private void add(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;
            p.cantidad++;
            ObservableCollection <Producto> products = new ObservableCollection<Producto>();

            foreach (Producto item in Carrito)
            {
                products.Add(item);
            }
           
            foreach (Producto item in products)
            {
                Carrito.RemoveAt(0);
                Carrito.Add(item);          
            }
        }
        
        private void substract(object sender, RoutedEventArgs e)
        {
            Producto p = ((Button)sender).Tag as Producto;
            p.cantidad--;
            if(p.cantidad == 0) { Carrito.Remove(p); }
            ObservableCollection<Producto> products = new ObservableCollection<Producto>();

            foreach (Producto item in Carrito)
            {
                products.Add(item);
            }

            foreach (Producto item in products)
            {
                Carrito.RemoveAt(0);
                Carrito.Add(item);
            }
        }

        private ObservableCollection<Producto> reOrdenaCarrito(ObservableCollection<Producto> l, Producto p)
        {
            ObservableCollection<Producto> resp = l;
            if (!resp.Contains(p))
            {
                p.cantidad = 1;
                resp.Add(p);
            }
            else { p.cantidad++; }
            return resp;
        }

      
        private void txtNombreLista_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (txtNombreLista.Text.Equals(""))
            {
                txtNombreLista.Text = "Escribe el nombre de tu nueva lista";
                textoCambiado = false;
            }
            else { textoCambiado = true; }
        }

        private void txtNombreLista_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtNombreLista.Text = "";
        }

        private void addListaBtn_Click(object sender, RoutedEventArgs e)
        {
           if(!txtNombreLista.Equals("")&&Carrito.Count>0&&textoCambiado) { 
                Sesion.mensaje("lista creada");

                Lista nueva = new Lista(txtNombreLista.Text, sesionAct.nombre, Carrito);
                Sesion.addLista(nueva);
                textoCambiado = false;
                txtNombreLista.Text = "Escribe el nombre de tu nueva lista";
                Carrito.Clear();
            }
        }
    }
}

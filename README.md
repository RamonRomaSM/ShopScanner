# TFG



## Web Scraping
Para obtener los datos de la base de datos.


Tecnologías utilizadas:
+ Selenium

## Bases de datos
https://www.quora.com/Can-we-use-two-databases-in-one-project#:~:text=Yes%2C%20it's%20possible%20to%20use,needs%20within%20the%20same%20application.

  Tablas MySql:

  + Productos (Pid, nombre, precio, imagen, supermercado, oderta?)
  + Usuarios (Uid, nombre, contraseña)

  Mongo DB:
  + Listas de la compra

  Ejemplo:

      {
      "Uid": 7,
      "nombreLista": "Mi compra semanal",
      "Productos": {"Pid":1 ,"Pid":2, "Pid":3}
      }

## Cliente de la aplicacion
Tecnologías utilizadas:
+ WPF

Funcionalidades:

+ Productos:

  + Barra de busqueda
  + Filtrar por precio (ascendente/descendente)
  + Filtrar por tienda
  + Filtrar por ofertas
  + Rango de precios
  

  
+ Mi cesta
+ Perfil
+ Ajustes



## Que se va a usar

+ Scrapy
+ WPF
+ MySql 

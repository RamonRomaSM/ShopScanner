 # TFG



## Web Scraping
Para obtener los datos de la base de datos.


### Tecnologías utilizadas:
+ Selenium

## Bases de datos
https://www.quora.com/Can-we-use-two-databases-in-one-project#:~:text=Yes%2C%20it's%20possible%20to%20use,needs%20within%20the%20same%20application.

Es mas intuitivo y facil guardar las listas de la compra en formato json / a la hora de pedir los productos lo encontre mas intuitivo co SQL

  + ### Tablas MySql:

    + Productos (Pid, nombre, precio, imagen, supermercado, URL, oderta?)
    + Usuarios (Uid, nombre, contraseña)

  + ### Mongo DB:
    + Listas de la compra

      Ejemplo:
    
          {
          "Uid": 7,
          "nombreLista": "Mi compra semanal",
          "Productos": {"Pid":1 ,"Pid":2, "Pid":3}
          }

## Cliente de la aplicacion
### Tecnologías utilizadas:
+ WPF

### Funcionalidades:

+ ### Productos:

+ Barra de busqueda
  
  #### Items
  
  + Añadir
  + Visitar Pagina

  #### Barra lateral

  + Filtrar por precio (ascendente/descendente)
  + Filtrar por tienda
  + Filtrar por ofertas
  + Rango de precios
  

  
+ ### Mi cesta

   + Guardar lista como
   + Eliminar producto
   + Vaciar cesta
  
+ ### Perfil
  
  Apareceran tus listas de la compra y en cada una tendras las opciones de:

  + Sacar el pdf
  + Eliminar lista

 ## Servidor intermedio (capa de negocio)

Un programa en java que:

+ escucha por ejemplo el puerto 8080 
+ establece cnexion cifrada 
+ verifica y realiza las peticiones

Asi el cliente NO tieneconexion directa con mi BDD (mas seguro)     
https://stackoverflow.com/questions/14824491/can-i-communicate-between-java-and-c-sharp-using-just-sockets
https://es.wikipedia.org/wiki/Arquitectura_multicapa

Esta capa recibe las peticiones, pide datos y manda datos

Esta capa recive la url de las imagenes y le manda al cliente los bytes de la imagen




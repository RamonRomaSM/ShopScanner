 # TFG



## Web Scraping
Para obtener los datos de la base de datos.


### Tecnologías utilizadas:
+ Selenium

## Bases de datos
https://www.quora.com/Can-we-use-two-databases-in-one-project#:~:text=Yes%2C%20it's%20possible%20to%20use,needs%20within%20the%20same%20application.

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

 ## Servidor intermediario

Un programa en java que:

+ escucha por ejemplo el puerto 8080 
+ establece cnexion cifrada 
+ verifica y realiza las peticiones

Asi el cliente NO tieneconexion directa con mi BDD (mas seguro)     
https://stackoverflow.com/questions/14824491/can-i-communicate-between-java-and-c-sharp-using-just-sockets
https://refactoring.guru/es/design-patterns/proxy


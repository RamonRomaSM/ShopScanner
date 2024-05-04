# Falta:


## Para el jueves:	
  + tener los framents planteados
  + tener una version compilada del cliente
  + tener el script de python con lo del fichero
  + tarjeta con productos mock
  + tarjeta las listas mock (que se pueda desplegar, al lado de los productos + , - y eliminar (papelera))

## Diseño Tarjetas:
  + Productos: foto, nombre, precio, añadir al carrito, añadir a lista
  + Listas: de normal el nombre, precio total y una flechita o indicador para desplegar

    + Desplegada:	nombre producto, precio(precio * n), boton de + y -; ademas clasificar por supermercado
  + En cesta mostrarlo como si fuera una lista


## UI:
+ fragents (Mi carrito, mi perfil) 
+ las tarjetas (En las tarjetas  de productos, boton de añador al carrito y boton de añadir a lista ya esixtente (desplegable para seleciconar la lista?))
+ animaciones 
+ Barra de busqueda (y desplegable de filtros) <-- cuando tenga acceso a la bdd (asi puedo ir testeando el filtro, ordenar por precio en a bdd) 
  
## Logica UI:
+ Carrito:
+ Cargar items en el carrito desde una lista de la compra
+ añadir items al carro
+ guardar carrito (o sobreescribir)
+ Barra de busqueda (y logica de filtros)
+ Ver tus listas de la compra en el perfil

## Script python
+ Cargar desde un fichero la psw y el usuario de la bdd

## API

spring tiene forma de mandar correos

https://spring.io/guides/tutorials/rest

sesiones de spring?

https://docs.spring.io/spring-session/reference/guides/java-rest.html

seguridad en la api:

https://www.baeldung.com/spring-boot-api-key-secret (como asegurar la conexion   cliente-server)

ver lo de OW

lombook para pasar a jsons 

Mas contenido:

https://www.jetbrains.com/help/idea/your-first-spring-application.html#what-next

## Seguridad:
Creacion de claves:

Un par de keys
Mandas la cpub al server, y este te contesta ok (y lo guarda en una bdd)

Establecer conexion:

Mandar los datos encript y esperar ok + clave de sesion (para encriptar los mensajes actuales) + token de sesion (el token va al final de las peticiones, ara asegurarse de que eres tu el que hace las peticiones)

(Igual podria, cada vez que te conectas, que se te renueve el par de claves)

-------------------------------------------------

Que queda:
UI:

listas: nombre /n prods /precio

	ver(y editar) / eliminar

Cesta:	imagen papelera

mucho texto en productos

API:
	api

Python:
	parametrizar la conexion

Extra:
	diseño de los scrollbars
	Popups en vez de messageboxes
	lo del pdf con python y desde la api (asi puedo llamarlo desde el pc o el movil)
	app movil
	





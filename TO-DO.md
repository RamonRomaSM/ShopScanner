# Falta:

## UI:
+ Pop up de la lista
+ Notificaciones pero bien
+ Barra de busqueda (y desplegable de filtros) <-- cuando tenga acceso a la bdd (asi puedo ir testeando el filtro, ordenar por precio en a bdd) 

  
## Logica UI:
+ Barra de busqueda (y logica de filtros)
+ Ver tus listas de la compra en el perfil

## Script python
+ Cargar parametros desde un fichero 

## API

+ Hostear con railway
+ spring tiene forma de mandar correos

  (https://spring.io/guides/tutorials/rest)

  (https://docs.spring.io/spring-session/reference/guides/java-rest.html)

## Seguridad:
Creacion de claves:

Un par de keys
Mandas la cpub al server, y este te contesta ok (y lo guarda en una bdd)

Establecer conexion:

Mandar los datos encript y esperar ok + clave de sesion (para encriptar los mensajes actuales) + token de sesion (el token va al final de las peticiones, ara asegurarse de que eres tu el que hace las peticiones)

(Igual podria, cada vez que te conectas, que se te renueve el par de claves)

-------------------------------------------------



